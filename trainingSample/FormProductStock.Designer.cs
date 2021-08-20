
namespace trainingSample
{
    partial class FormProductStock
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.ldlProductCode = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.ldlProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.AllowUserToAddRows = false;
            this.grdProduct.AllowUserToDeleteRows = false;
            this.grdProduct.AllowUserToResizeColumns = false;
            this.grdProduct.AllowUserToResizeRows = false;
            this.grdProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProduct.ColumnHeadersHeight = 31;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.productCode,
            this.productName,
            this.price,
            this.quantity,
            this.summary,
            this.addDate});
            this.grdProduct.Location = new System.Drawing.Point(12, 152);
            this.grdProduct.Name = "grdProduct";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProduct.RowHeadersWidth = 92;
            this.grdProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grdProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grdProduct.RowTemplate.Height = 30;
            this.grdProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProduct.Size = new System.Drawing.Size(865, 438);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellDoubleClick);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "No.";
            this.no.MinimumWidth = 11;
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // productCode
            // 
            this.productCode.DataPropertyName = "productCode";
            this.productCode.HeaderText = "商品コード";
            this.productCode.MinimumWidth = 11;
            this.productCode.Name = "productCode";
            this.productCode.Width = 130;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "商品名";
            this.productName.MinimumWidth = 11;
            this.productName.Name = "productName";
            this.productName.Width = 140;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "単価";
            this.price.MinimumWidth = 11;
            this.price.Name = "price";
            this.price.Width = 225;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "数量";
            this.quantity.MinimumWidth = 11;
            this.quantity.Name = "quantity";
            this.quantity.Width = 225;
            // 
            // summary
            // 
            this.summary.DataPropertyName = "summary";
            this.summary.HeaderText = "金額";
            this.summary.MinimumWidth = 11;
            this.summary.Name = "summary";
            this.summary.Width = 225;
            // 
            // addDate
            // 
            this.addDate.DataPropertyName = "addDate";
            this.addDate.HeaderText = "登録日付";
            this.addDate.MinimumWidth = 11;
            this.addDate.Name = "addDate";
            this.addDate.ReadOnly = true;
            this.addDate.Width = 150;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtProductCode.Location = new System.Drawing.Point(130, 62);
            this.txtProductCode.MaxLength = 9;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(124, 31);
            this.txtProductCode.TabIndex = 1;
            // 
            // ldlProductCode
            // 
            this.ldlProductCode.AutoSize = true;
            this.ldlProductCode.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ldlProductCode.Location = new System.Drawing.Point(32, 66);
            this.ldlProductCode.Name = "ldlProductCode";
            this.ldlProductCode.Size = new System.Drawing.Size(90, 24);
            this.ldlProductCode.TabIndex = 2;
            this.ldlProductCode.Text = "商品コード";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPrice.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPrice.Location = new System.Drawing.Point(448, 62);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 31);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(390, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "単価";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuantity.Location = new System.Drawing.Point(390, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(42, 24);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "数量";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtQuantity.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtQuantity.Location = new System.Drawing.Point(448, 105);
            this.txtQuantity.MaxLength = 3;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(164, 31);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ldlProductName
            // 
            this.ldlProductName.AutoSize = true;
            this.ldlProductName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ldlProductName.Location = new System.Drawing.Point(32, 107);
            this.ldlProductName.Name = "ldlProductName";
            this.ldlProductName.Size = new System.Drawing.Size(58, 24);
            this.ldlProductName.TabIndex = 6;
            this.ldlProductName.Text = "商品名";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtProductName.Location = new System.Drawing.Point(130, 105);
            this.txtProductName.MaxLength = 10;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(241, 31);
            this.txtProductName.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdate.Location = new System.Drawing.Point(778, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "登録";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(778, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "出力";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("メイリオ", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFormTitle.Location = new System.Drawing.Point(8, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(180, 41);
            this.lblFormTitle.TabIndex = 11;
            this.lblFormTitle.Text = "在庫管理画面";
            // 
            // FormProductStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.ldlProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.ldlProductCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.grdProduct);
            this.Name = "FormProductStock";
            this.Text = "在庫管理";
            this.Load += new System.EventHandler(this.FormProductStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label ldlProductCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label ldlProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDate;
    }
}

