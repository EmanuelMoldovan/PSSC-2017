namespace PSSC
{
    partial class CheckOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_waiter = new System.Windows.Forms.ComboBox();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_check_orders = new System.Windows.Forms.Button();
            this.btn_import_data = new System.Windows.Forms.Button();
            this._xml_import = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Waiter";
            // 
            // cmb_waiter
            // 
            this.cmb_waiter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cmb_waiter.FormattingEnabled = true;
            this.cmb_waiter.Items.AddRange(new object[] {
            "Remus Jurj",
            "John Doe",
            "Jane Doe"});
            this.cmb_waiter.Location = new System.Drawing.Point(76, 14);
            this.cmb_waiter.Name = "cmb_waiter";
            this.cmb_waiter.Size = new System.Drawing.Size(121, 21);
            this.cmb_waiter.TabIndex = 3;
            // 
            // dgv_orders
            // 
            this.dgv_orders.AllowUserToAddRows = false;
            this.dgv_orders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.dgv_orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orders.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_No,
            this.table_column,
            this.order_column,
            this.amount_column});
            this.dgv_orders.EnableHeadersVisualStyles = false;
            this.dgv_orders.Location = new System.Drawing.Point(25, 44);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.dgv_orders.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_orders.Size = new System.Drawing.Size(455, 309);
            this.dgv_orders.TabIndex = 4;
            // 
            // Order_No
            // 
            this.Order_No.HeaderText = "Order No";
            this.Order_No.Name = "Order_No";
            this.Order_No.ReadOnly = true;
            this.Order_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // table_column
            // 
            this.table_column.HeaderText = "Table";
            this.table_column.Name = "table_column";
            this.table_column.ReadOnly = true;
            this.table_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // order_column
            // 
            this.order_column.HeaderText = "Order";
            this.order_column.Name = "order_column";
            this.order_column.ReadOnly = true;
            this.order_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // amount_column
            // 
            this.amount_column.HeaderText = "Amount";
            this.amount_column.Name = "amount_column";
            this.amount_column.ReadOnly = true;
            this.amount_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_check_orders
            // 
            this.btn_check_orders.BackColor = System.Drawing.Color.Brown;
            this.btn_check_orders.Enabled = false;
            this.btn_check_orders.Location = new System.Drawing.Point(218, 14);
            this.btn_check_orders.Name = "btn_check_orders";
            this.btn_check_orders.Size = new System.Drawing.Size(99, 23);
            this.btn_check_orders.TabIndex = 5;
            this.btn_check_orders.Text = "View";
            this.btn_check_orders.UseVisualStyleBackColor = false;
            this.btn_check_orders.Click += new System.EventHandler(this.btn_check_orders_Click);
            // 
            // btn_import_data
            // 
            this.btn_import_data.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_import_data.Location = new System.Drawing.Point(381, 14);
            this.btn_import_data.Name = "btn_import_data";
            this.btn_import_data.Size = new System.Drawing.Size(99, 23);
            this.btn_import_data.TabIndex = 6;
            this.btn_import_data.Text = "Import Data";
            this.btn_import_data.UseVisualStyleBackColor = false;
            this.btn_import_data.Click += new System.EventHandler(this.btn_import_data_Click);
            // 
            // _xml_import
            // 
            this._xml_import.FileName = "Select Xml";
            // 
            // CheckOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(503, 365);
            this.Controls.Add(this.btn_import_data);
            this.Controls.Add(this.btn_check_orders);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.cmb_waiter);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckOrders";
            this.Text = "CheckOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_waiter;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Button btn_check_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_column;
        private System.Windows.Forms.Button btn_import_data;
        private System.Windows.Forms.OpenFileDialog _xml_import;
    }
}