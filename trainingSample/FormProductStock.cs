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
        #region メンバー

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


        }

        /// <summary>
        /// 登録/更新ボタン
        ///     動作は編集モードにより切り替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 登録
            this.add();
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
        /// Noの最大値を取得(自動採番用)
        /// </summary>
        /// <returns></returns>
        private int getMaxNo()
        {
            int maxNo = 0;

            // リストの各行のNo.を参照し、最大の物を取得する。
            foreach (ProductStock stock in productStocks)
            {
                // その時点のmaxNoより参照行のNoの方が大きい場合は
                if (maxNo < stock.no)
                {
                    // maxNoを置き換え、これを繰り返す事で最大値を取得できる。
                    maxNo = stock.no;
                }
            }

            return maxNo;
        }

        #endregion


    }
}
