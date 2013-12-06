namespace Bookstore
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgSales = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1002, 342);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // cboItems
            // 
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(12, 11);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(201, 21);
            this.cboItems.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddToCart.Location = new System.Drawing.Point(247, 12);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(67, 48);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(122, 20);
            this.txtQty.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(525, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amt Due";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(528, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amt Paid";
            this.label3.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(627, 11);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 9;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(627, 52);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(100, 20);
            this.txtPaid.TabIndex = 10;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(920, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.txtFinish_Click);
            // 
            // dvgSales
            // 
            this.dvgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Price,
            this.Qty,
            this.ExitPrice});
            this.dvgSales.Location = new System.Drawing.Point(12, 171);
            this.dvgSales.Name = "dvgSales";
            this.dvgSales.Size = new System.Drawing.Size(442, 150);
            this.dvgSales.TabIndex = 13;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // ExitPrice
            // 
            this.ExitPrice.HeaderText = "ExitPrice";
            this.ExitPrice.Name = "ExitPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(528, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(627, 106);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 342);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgSales);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.cboItems);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvgSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChange;
    }
}

