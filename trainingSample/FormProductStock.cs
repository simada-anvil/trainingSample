using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingSample.model;

namespace trainingSample
{
    public partial class FormProductStock : Form
    {
        #region 定数
        /// <summary>
        /// 編集モード 登録:1 更新:2
        /// </summary>
        private enum EDIT_MODE
        {
            add = 1 // 追加
            , update = 2 // 更新
        }
        #endregion

        #region メンバー
        /// <summary>
        /// 編集モード デフォルト 登録
        /// </summary>
        private EDIT_MODE editMode = EDIT_MODE.add;

        /// <summary>
        /// 更新行のNo.
        /// </summary>
        private int updateNo = 0;

        /// <summary>
        /// 在庫情報一覧の中のデータ
        /// BindingList<T>を使用しているのはグリッドへの即時反映を実現する為。
        /// ※ただのList<T>だと即時反映されない。
        /// </summary>
        private BindingList<ProductStock> productStocks = new BindingList<ProductStock>();

        #endregion

        #region イベント
        /// <summary>
        /// コンストラクタ(自動)
        /// </summary>
        public FormProductStock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームの起動イベント
        ///  フォームが表示された際に真っ先に
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProductStock_Load(object sender, EventArgs e)
        {
            // ================================================
            // フォームが表示された際に真っ先に呼び出されるイベントメソッド
            // ================================================

            // 主に画面の初回起動時にやっておきたいことを記述する。

            // 　この画面の場合は、グリッドに在庫情報一覧を紐づけることを真っ先にやっておきたい。
            this.grdProduct.DataSource = productStocks;

            //  あと念の為、編集フォームの初期状態化。
            this.clearForm();
            
        }

        /// <summary>
        /// 登録/更新ボタン
        ///     動作は編集モードにより切り替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // ================================================
                // 入力チェック 
                // チェックエラー時は以下の処理を行わない。
                // ================================================
                if (!inputCheck()) return;

                // ================================================
                // 編集モードにより登録か、更新かを判断する。
                // ================================================
                if (this.editMode == EDIT_MODE.add) { 
                    // 登録
                    this.add();
                }
                else if(this.editMode == EDIT_MODE.update)
                {
                    // 更新
                    this.update();
                }

                // ================================================
                // 登録/更新完了後フォームをデフォルトに戻す。
                // ================================================
                clearForm();
            }catch(Exception ex) { 
                Debug.Print("エラーがでました。たぶんバグです。" + ex.StackTrace);
            }


        }

        /// <summary>
        /// ダブルクリックした行の更新モードに切り替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                // RowIndexは行以外を選択した場合0以下の値が返ってくるので、それらが返ってきたら抜ける。
                if (e.RowIndex < 0) return;

                // ================================================
                // グリッドから選択行の在庫情報を取得
                //     グリッドからNoを取得。
                // ================================================
                int stockNo = (int)this.grdProduct.Rows[e.RowIndex].Cells[0].Value;

                // ================================================
                //      Noから在庫情報を検索してその行を取得する。
                // ================================================
                ProductStock row = getRow(stockNo);

                // Noに一致する在庫情報がない場合はNullが返ってくる。
                if (row == null) return;

                // ================================================
                // 検索した在庫情報を画面に表示する。
                // ================================================
                this.txtProductCode.Text = row.productCode;
                this.txtProductName.Text = row.productName;
                this.txtPrice.Text = row.price.ToString();
                this.txtQuantity.Text = row.quantity.ToString();

                // ================================================
                // 編集モードを更新に切り替え
                // ================================================
                //      編集行のNoを保持
                this.updateNo = stockNo;
                //      編集モードを更新に変更
                this.editMode = EDIT_MODE.update;

                // ================================================
                // あとついでに登録ボタン⇒更新ボタンに切り替え
                // ================================================
                // 切り替わった事が分かりやすいように赤フォントにしておく。
                btnUpdate.Text = "更新";
                btnUpdate.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Debug.Print("エラーがでました。たぶんバグです。" + ex.StackTrace);
            }

        }

        #endregion

        #region メソッド


        /// <summary>
        /// 登録
        /// </summary>
        private void add()
        {

            // 新規登録行のインスタンス化
            ProductStock newStock = new ProductStock();
            // ================================================
            // Noの自動採番
            // ================================================
            int maxNo = getMaxNo();     // 1.ProductStocks内のNo最大値を取得する。
            int newNo = maxNo + 1;                 // 2.取得した最大値 + 1＝新規採番値を計算する。

            // ================================================
            // 入力値から在庫情報を作成する。
            // ================================================
            newStock.no = newNo;                                // No
            newStock.productCode = this.txtProductCode.Text;    // 商品コード
            newStock.productName = this.txtProductName.Text;    // 商品名

            // ※単価、数量は文字列項目のため数値変換が必要
            newStock.price = int.Parse(this.txtPrice.Text);　　 // 単価 
            newStock.quantity = int.Parse(this.txtQuantity.Text); // 数量
           
            // 金額 = 単価 * 数量
            newStock.summary = newStock.price * newStock.quantity;

            // 現在時刻 = 現在のPC時刻を取得
            newStock.addDate = DateTime.Now.ToString("yyyy/MM/dd");

            // ================================================
            // 作成した在庫情報を在庫情報一覧に追加する。
            // ================================================
            this.productStocks.Add(newStock);


        }

        /// <summary>
        /// 更新
        /// </summary>
        private void update()
        {
            // ================================================
            // 更新対象行を検索し、取得する。
            // ================================================
            ProductStock updateStock = getRow(this.updateNo);

            // Noに一致する在庫情報がない場合はNullが返ってくる。
            if (updateStock == null) return;

            // ================================================
            // 入力値の各値を更新
            // ================================================
            // 既にある行を更新するので、Noの採番は不要。
            updateStock.productCode = this.txtProductCode.Text;    // 商品コード
            updateStock.productName = this.txtProductName.Text;    // 商品名

            // ※単価、数量は文字列項目のため数値変換が必要
            updateStock.price = int.Parse(this.txtPrice.Text);　　 // 単価 
            updateStock.quantity = int.Parse(this.txtQuantity.Text); // 数量

            // 金額 = 単価 * 数量
            updateStock.summary = updateStock.price * updateStock.quantity;

            // 登録日付の更新も不要

            // ================================================
            // グリッドの表示更新　※行追加は反映されるが、行のデータ更新は即時で表示反映されないっぽい
            // ================================================
            this.grdProduct.Refresh();

        }

        /// <summary>
        /// 登録／更新後の編集フォームのクリア処理
        /// 　編集フォームを初期状態に戻す。
        /// </summary>
        private void clearForm()
        {
            // ================================================
            // 登録 / 更新処理の完了後 
            // ================================================
            this.txtProductCode.Text = String.Empty;
            this.txtProductName.Text = String.Empty;
            this.txtPrice.Text = String.Empty;
            this.txtQuantity.Text = String.Empty;
            this.editMode = EDIT_MODE.add;

            // ================================================
            // 編集モードを初期状態＝登録に戻す。
            // ================================================
            btnUpdate.Text = "登録";
            btnUpdate.ForeColor = Color.Black;


        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private Boolean inputCheck()
        {
            // 文字数チェックは割愛（maxlenghで吸収
            // 半角チェックも割愛（IMEモードで吸収

            // ================================================
            //  ・商品コード
            // ================================================
            //      必須
            if (String.IsNullOrEmpty(this.txtProductCode.Text))
            {
                MessageBox.Show("商品コードは必須です。");
                return false;
            }


            // ================================================
            //  ・商品名     
            // ================================================
            //      必須
            if (String.IsNullOrEmpty(this.txtProductName.Text))
            {
                MessageBox.Show("商品名は必須です。");
                return false;
            }

            // ================================================
            //  ・単価
            // ================================================
            //      必須
            if (String.IsNullOrEmpty(this.txtPrice.Text))
            {
                MessageBox.Show("単価は必須です。");
                return false;
            }

            //      数値
            double price;
            if (!double.TryParse(this.txtPrice.Text, out price))
            {
                MessageBox.Show("単価は数値で入力してください。");
                return false;
            }

            //      0以上
            if (price <= 0)
            {
                MessageBox.Show("単価は0以上で入力してください。");
                return false;
            }

            // ================================================
            //  ・数量
            // ================================================
            //      必須
            if (String.IsNullOrEmpty(this.txtQuantity.Text))
            {
                MessageBox.Show("数量は必須です。");
                return false;
            }

            //      数値
            double quantity;
            if (!double.TryParse(this.txtQuantity.Text, out quantity))
            {
                MessageBox.Show("数量は数値で入力してください。");
                return false;
            }

            //      0以上
            if (quantity <= 0)
            {
                MessageBox.Show("数量は0以上で入力してください。");
                return false;
            }

            return true;
        }



        #endregion


        /// <summary>
        /// Noの最大値を取得(自動採番用)
        /// </summary>
        /// <returns></returns>
        private int getMaxNo()
        {
            int maxNo = 0;

            // リストの各行のNo.を参照し、最大の物を取得する。
            foreach(ProductStock stock in productStocks)
            {
                // その時点のmaxNoより参照行のNoの方が大きい場合は
                if( maxNo < stock.no)
                {
                    // maxNoを置き換え、これを繰り返す事で最大値を取得できる。
                    maxNo = stock.no;
                }
            }

            return maxNo;
        }

        /// <summary>
        /// Noで在庫情報を検索
        ///     ただし、Noが一致する行がない場合は容赦無くNullを返す。
        ///     受け取り側でちゃんとNull対処すること。
        /// </summary>
        /// <param name="no">編集行のNo.</param>
        /// <returns>引数のNoに一致する在庫情報 ※一致する物がない場合はNull</returns>
        private ProductStock getRow(int no)
        {

            ProductStock result = null;

            // noが一致する在庫情報を検索する
            //      在庫情報の一覧の
            foreach(ProductStock row in this.productStocks)
            {
                // noが一致するものを取得する。
                if(row.no == no) { 
                    result = row;
                    break;
                }
            }

            // Nullだったときログとメッセージを出してあげてる。
            if (result == null)
            {
                Debug.Print("選択行がリスト上に存在しない。たぶんバグ");
                MessageBox.Show("選択行がデータ上に存在しません。");
            }

            // 戻り値
            return result;
        }

    }
}
