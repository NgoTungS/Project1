namespace project1
{
    partial class FormForStorage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.in_invoice_button = new System.Windows.Forms.Button();
            this.out_invoice_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.productBox = new System.Windows.Forms.ListView();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.qrcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.base_unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // in_invoice_button
            // 
            this.in_invoice_button.Location = new System.Drawing.Point(12, 12);
            this.in_invoice_button.Name = "in_invoice_button";
            this.in_invoice_button.Size = new System.Drawing.Size(180, 54);
            this.in_invoice_button.TabIndex = 0;
            this.in_invoice_button.Text = "Tạo hóa đơn nhập";
            this.in_invoice_button.UseVisualStyleBackColor = true;
            // 
            // out_invoice_button
            // 
            this.out_invoice_button.Location = new System.Drawing.Point(12, 99);
            this.out_invoice_button.Name = "out_invoice_button";
            this.out_invoice_button.Size = new System.Drawing.Size(180, 54);
            this.out_invoice_button.TabIndex = 1;
            this.out_invoice_button.Text = "Tạo hóa đơn bán";
            this.out_invoice_button.UseVisualStyleBackColor = true;
            // 
            // Logout_button
            // 
            this.Logout_button.Location = new System.Drawing.Point(12, 186);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(180, 54);
            this.Logout_button.TabIndex = 2;
            this.Logout_button.Text = "Đăng xuất";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // productBox
            // 
            this.productBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qrcode,
            this.name,
            this.price,
            this.base_unit,
            this.category,
            this.quantity});
            this.productBox.HideSelection = false;
            this.productBox.Location = new System.Drawing.Point(207, 12);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(492, 228);
            this.productBox.TabIndex = 3;
            this.productBox.UseCompatibleStateImageBehavior = false;
            this.productBox.View = System.Windows.Forms.View.Details;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(705, 13);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(146, 227);
            this.resultBox.TabIndex = 4;
            // 
            // qrcode
            // 
            this.qrcode.Text = "QR code";
            // 
            // name
            // 
            this.name.Text = "Tên sản phẩm";
            // 
            // price
            // 
            this.price.Text = "Giá tiền";
            // 
            // base_unit
            // 
            this.base_unit.Text = "Đơn vị";
            // 
            // category
            // 
            this.category.Text = "Loại thực phẩm";
            // 
            // quantity
            // 
            this.quantity.Text = "Số lượng";
            // 
            // FormForStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 260);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.out_invoice_button);
            this.Controls.Add(this.in_invoice_button);
            this.Name = "FormForStorage";
            this.Text = "FormForStorage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button in_invoice_button;
        private System.Windows.Forms.Button out_invoice_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.ListView productBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.ColumnHeader qrcode;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader base_unit;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader quantity;
    }
}