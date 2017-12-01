namespace ConsignatieUI
{
    partial class Consignatie
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FurnizoriListbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consignatie Magazin";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.HorizontalScrollbar = true;
            this.itemsListbox.ItemHeight = 18;
            this.itemsListbox.Location = new System.Drawing.Point(15, 78);
            this.itemsListbox.Margin = new System.Windows.Forms.Padding(4);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(298, 130);
            this.itemsListbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obiecte pe stoc";
            // 
            // purchaseItem
            // 
            this.purchaseItem.Location = new System.Drawing.Point(320, 123);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(142, 51);
            this.purchaseItem.TabIndex = 3;
            this.purchaseItem.Text = "Add To Cart ->";
            this.purchaseItem.UseVisualStyleBackColor = true;
            this.purchaseItem.Click += new System.EventHandler(this.purchaseItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cos Obiecte Cumparate";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.HorizontalScrollbar = true;
            this.shoppingCartListbox.ItemHeight = 18;
            this.shoppingCartListbox.Location = new System.Drawing.Point(469, 78);
            this.shoppingCartListbox.Margin = new System.Windows.Forms.Padding(4);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(254, 130);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(605, 215);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(118, 49);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Furnizori";
            // 
            // FurnizoriListbox
            // 
            this.FurnizoriListbox.FormattingEnabled = true;
            this.FurnizoriListbox.ItemHeight = 18;
            this.FurnizoriListbox.Location = new System.Drawing.Point(15, 297);
            this.FurnizoriListbox.Margin = new System.Windows.Forms.Padding(4);
            this.FurnizoriListbox.Name = "FurnizoriListbox";
            this.FurnizoriListbox.Size = new System.Drawing.Size(298, 130);
            this.FurnizoriListbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Profit Depozit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Location = new System.Drawing.Point(578, 275);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(42, 18);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // Consignatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 441);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FurnizoriListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.purchaseItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consignatie";
            this.Text = "Consignatie Magazin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button purchaseItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox FurnizoriListbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

