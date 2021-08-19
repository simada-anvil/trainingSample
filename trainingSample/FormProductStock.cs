using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            add = 1
            , update = 2
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
        /// フォームの起動時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProductStock_Load(object sender, EventArgs e)
        {
            this.grdProduct.DataSource = productStocks;

            
        }

        /// <summary>
        /// 登録/更新ボタン
        ///     動作は編集モードにより切り替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!inputCheck()) return;

            if (this.editMode == EDIT_MODE.add) { 
                this.add();
            }
            else if(this.editMode == EDIT_MODE.update)
            {
                this.update();
            }

            this.txtProductCode.Text = String.Empty;
            this.txtProductName.Text = String.Empty;
            this.txtPrice.Text = String.Empty;
            this.txtQuantity.Text = String.Empty;
            this.editMode = EDIT_MODE.add;

            btnUpdate.Text = "登録";
            btnUpdate.ForeColor = Color.Black;

        }

        /// <summary>
        /// ダブルクリックした行の更新モードに切り替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // RowIndexは行以外を選択した場合0以下の値が返ってくるので、それらが返ってきたら抜ける。
            if (e.RowIndex < 0) return;

            ProductStock row = (ProductStock)this.grdProduct.Rows[e.RowIndex].DataBoundItem;

            this.txtProductCode.Text = row.productCode;
            this.txtProductName.Text = row.productName;
            this.txtPrice.Text = row.price.ToString();
            this.txtQuantity.Text = row.quantity.ToString();

            this.updateNo = row.no;
            this.editMode = EDIT_MODE.update;

            btnUpdate.Text = "更新";
            btnUpdate.ForeColor = Color.Red;

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

            // Noの自動採番
            int maxNo = getMaxNo();     // 1.ProductStocks内のNo最大値を取得する。
            maxNo += 1;                 // 2.取得した最大値 + 1＝新規採番値を計算する。

            // ProductStockクラスを作成
            newStock.no = maxNo;                                // No
            newStock.productCode = this.txtProductCode.Text;    // 商品コード
            newStock.productName = this.txtProductName.Text;    // 商品名

            // ※単価、数量は文字列項目のため数値変換が必要
            newStock.price = int.Parse(this.txtPrice.Text);　　 // 単価 
            newStock.quantity = int.Parse(this.txtQuantity.Text); // 数量
           
            // 金額 = 単価 * 数量
            newStock.summary = newStock.price * newStock.quantity;

            // 現在時刻 = 現在のPC時刻を取得
            newStock.addDate = DateTime.Now.ToString("yyyy/MM/dd");


            this.productStocks.Add(newStock);


        }

        /// <summary>
        /// 更新
        /// </summary>
        private void update()
        {
            // 更新行のインスタンス化
            ProductStock newStock = getRow(this.updateNo);

            // 既にある行を更新するので、Noの採番は不要。

            // 入力値の各値を更新
            newStock.productCode = this.txtProductCode.Text;    // 商品コード
            newStock.productName = this.txtProductName.Text;    // 商品名

            // ※単価、数量は文字列項目のため数値変換が必要
            newStock.price = int.Parse(this.txtPrice.Text);　　 // 単価 
            newStock.quantity = int.Parse(this.txtQuantity.Text); // 数量

            // 金額 = 単価 * 数量
            newStock.summary = newStock.price * newStock.quantity;

            // 登録日付の更新も不要

            this.grdProduct.Refresh();

        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private Boolean inputCheck()
        {

            // 文字数チェックは割愛（maxlenghで吸収
            // 半角チェックも割愛（IMEモードで吸収

            //  ・商品コード
            //      必須
            if (String.IsNullOrEmpty(this.txtProductCode.Text))
            {
                MessageBox.Show("商品コードは必須です。");
                return false;
            }


            //  ・商品名     
            //      必須
            if (String.IsNullOrEmpty(this.txtProductName.Text))
            {
                MessageBox.Show("商品名は必須です。");
                return false;
            }


            //  ・単価
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
                MessageBox.Show("単価は必須です。");
                return false;
            }

            //      0以上
            if (price <= 0)
            {
                MessageBox.Show("単価は0以上で入力してください。");
                return false;
            }

            //  ・数量
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
                MessageBox.Show("数量は必須です。");
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
                // その時点のmaxNoより大きい場合は
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
        /// </summary>
        /// <param name="no">編集行のNo.</param>
        /// <returns></returns>
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

            // 戻り値
            return result;
        }

    }
}
