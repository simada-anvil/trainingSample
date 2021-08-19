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

        public ProductStock()
        {

        }

        /// <summary>
        /// No.
        /// </summary>
        public int no { get; set; }

        /// <summary>
        /// 商品コード
        /// </summary>
        public string productCode { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// 単価
        /// </summary>
        public int price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public int summary { get; set; }

        /// <summary>
        /// 登録日付
        /// </summary>
        public string addDate { get; set; }

    }
}
