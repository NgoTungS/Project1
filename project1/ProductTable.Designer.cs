
namespace project1
{
    partial class ProductTable
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.intro = new System.Windows.Forms.Label();
            this.ProductBox = new System.Windows.Forms.ListView();
            this.qrcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.base_unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.qrcode_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(568, 60);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(227, 288);
            this.resultBox.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(570, 354);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(215, 67);
            this.LogOutBtn.TabIndex = 1;
            this.LogOutBtn.Text = "Đăng xuất";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tạo hóa đơn bán";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tạo Hóa đơn nhập";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // intro
            // 
            this.intro.AutoSize = true;
            this.intro.Location = new System.Drawing.Point(12, 12);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(27, 13);
            this.intro.TabIndex = 4;
            this.intro.Text = "intro";
            // 
            // ProductBox
            // 
            this.ProductBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qrcode,
            this.name,
            this.price,
            this.base_unit,
            this.category,
            this.description,
            this.quantity});
            this.ProductBox.HideSelection = false;
            this.ProductBox.Location = new System.Drawing.Point(14, 60);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(550, 288);
            this.ProductBox.TabIndex = 5;
            this.ProductBox.UseCompatibleStateImageBehavior = false;
            this.ProductBox.View = System.Windows.Forms.View.Details;
            this.ProductBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductBox_MouseDown);
            // 
            // qrcode
            // 
            this.qrcode.Text = "QR code";
            this.qrcode.Width = 69;
            // 
            // name
            // 
            this.name.Text = "Tên sản phẩm";
            this.name.Width = 105;
            // 
            // price
            // 
            this.price.Text = "Giá tiền";
            this.price.Width = 88;
            // 
            // base_unit
            // 
            this.base_unit.Text = "Đơn vị";
            // 
            // category
            // 
            this.category.Text = "Loại thực phẩm";
            this.category.Width = 101;
            // 
            // description
            // 
            this.description.Text = "Mô tả";
            // 
            // quantity
            // 
            this.quantity.Text = "Số lượng";
            this.quantity.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "QR code";
            // 
            // qrcode_input
            // 
            this.qrcode_input.Location = new System.Drawing.Point(282, 12);
            this.qrcode_input.Name = "qrcode_input";
            this.qrcode_input.Size = new System.Drawing.Size(261, 20);
            this.qrcode_input.TabIndex = 7;
            this.qrcode_input.TextChanged += new System.EventHandler(this.qrcode_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách sản phẩm";
            // 
            // ProductTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qrcode_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.resultBox);
            this.Name = "ProductTable";
            this.Text = "ProductTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.ListView ProductBox;
        private System.Windows.Forms.ColumnHeader qrcode;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader base_unit;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qrcode_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}