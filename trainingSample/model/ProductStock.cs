using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingSample.model
{
    /// <summary>
    /// 在庫情報
    /// </summary>
    class ProductStock
    {
        /// <summary>
        /// コンストラクタ
        ///    クラスのインスタンス化時に真っ先に動きメソッド
        ///    インスタンス化と同時に定義しておきたい情報がある場合はセットしておく。
        /// </summary>
        public ProductStock()
        {

        }

        /// <summary>
        /// No.
        /// </summary>
        private int _no = 0;

        /// <summary>
        /// 商品コード
        /// </summary>
        private string _productCode = string.Empty;

        /// <summary>
        /// 商品名
        /// </summary>
        private string _productName = string.Empty;

        /// <summary>
        /// 単価
        /// </summary>
        private int _price = 0;

        /// <summary>
        /// 数量
        /// </summary>
        private int _quantity = 0;

        /// <summary>
        /// 合計金額
        /// </summary>
        private int _summary = 0;

        /// <summary>
        /// 登録日付
        /// </summary>
        private string _addDate = string.Empty;



        /// <summary>
        /// No.
        /// </summary>
        public int no
        {
            get { return _no; }
            set { _no = value; }
        }

        /// <summary>
        /// 商品コード
        /// </summary>
        public string productCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }

        /// <summary>
        /// 商品名
        /// </summary>
        public string productName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        /// <summary>
        /// 単価
        /// </summary>
        public int price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        /// <summary>
        /// 金額
        /// </summary>
        public int summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        /// <summary>
        /// 登録日付
        /// </summary>
        public string addDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

    }
}
