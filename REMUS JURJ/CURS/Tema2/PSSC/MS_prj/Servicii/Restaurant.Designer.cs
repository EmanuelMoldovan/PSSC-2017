namespace PSSC
{
    partial class Restaurant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_waiter = new System.Windows.Forms.ComboBox();
            this.cmb_table = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_food = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_drinks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_x_food = new System.Windows.Forms.TextBox();
            this.txt_x_drinks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add_food = new System.Windows.Forms.Button();
            this.btn_add_drinks = new System.Windows.Forms.Button();
            this.btn_send_order = new System.Windows.Forms.Button();
            this.btn_clear_order = new System.Windows.Forms.Button();
            this.dgv_food = new System.Windows.Forms.DataGridView();
            this.food_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_amount_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_drinks = new System.Windows.Forms.DataGridView();
            this.drinks_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinks_amount_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_export_orders = new System.Windows.Forms.Button();
            this._xml_export = new System.Windows.Forms.OpenFileDialog();
            this.btn_view_orders = new System.Windows.Forms.Button();
            this.btn_html_transform = new System.Windows.Forms.Button();
            this.btn_reset_orders = new System.Windows.Forms.Button();
            this.log_box = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drinks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_waiter
            // 
            this.cmb_waiter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cmb_waiter.FormattingEnabled = true;
            this.cmb_waiter.Items.AddRange(new object[] {
            "Remus Jurj",
            "John Doe",
            "Jane Doe"});
            this.cmb_waiter.Location = new System.Drawing.Point(64, 28);
            this.cmb_waiter.Name = "cmb_waiter";
            this.cmb_waiter.Size = new System.Drawing.Size(247, 21);
            this.cmb_waiter.TabIndex = 0;
            // 
            // cmb_table
            // 
            this.cmb_table.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cmb_table.FormattingEnabled = true;
            this.cmb_table.Items.AddRange(new object[] {
            "Table no. 1",
            "Table no. 2",
            "Table no. 3",
            "Table no. 4",
            "Table no. 5",
            "Table no. 6",
            "Table no. 7",
            "Table no. 8",
            "Table no. 9",
            "Table no. 10"});
            this.cmb_table.Location = new System.Drawing.Point(400, 28);
            this.cmb_table.Name = "cmb_table";
            this.cmb_table.Size = new System.Drawing.Size(248, 21);
            this.cmb_table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Waiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(360, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table";
            // 
            // cmb_food
            // 
            this.cmb_food.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cmb_food.FormattingEnabled = true;
            this.cmb_food.Items.AddRange(new object[] {
            "Green salad",
            "Beetroot salad",
            "Sweet potato and quinoa salad",
            "Avocado, tomato and mango salad",
            "Pasta with seeds and orange",
            "Tofu and cashew cream pasta",
            "Four cheese pasta",
            "Pasta with eggplant",
            "Pasta with broccoli and pesto",
            "Coconut candies",
            "Raw Green Cakes",
            "Brownies",
            "Melon ice cream",
            "Matcha ice cream"});
            this.cmb_food.Location = new System.Drawing.Point(64, 71);
            this.cmb_food.Name = "cmb_food";
            this.cmb_food.Size = new System.Drawing.Size(195, 21);
            this.cmb_food.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Food";
            // 
            // cmb_drinks
            // 
            this.cmb_drinks.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cmb_drinks.FormattingEnabled = true;
            this.cmb_drinks.Items.AddRange(new object[] {
            "Apple Basic",
            "Double Apple",
            "Fresh mixt",
            "Ginger Zinger",
            "Grapefruit Basic",
            "Joint Aid",
            "Minty C",
            "Sweet C",
            "Apple Pie Smoothie",
            "Turmeric Tonic",
            "Green Goddess",
            "Mango-Pistachio Lassi",
            "Green Smoothie",
            "Super Berries Smoothie",
            "Banana Smoothie",
            "Apple Ginger"});
            this.cmb_drinks.Location = new System.Drawing.Point(400, 71);
            this.cmb_drinks.Name = "cmb_drinks";
            this.cmb_drinks.Size = new System.Drawing.Size(196, 21);
            this.cmb_drinks.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.PowderBlue;
            this.label4.Location = new System.Drawing.Point(357, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Drinks";
            // 
            // txt_x_food
            // 
            this.txt_x_food.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_x_food.Location = new System.Drawing.Point(285, 72);
            this.txt_x_food.Name = "txt_x_food";
            this.txt_x_food.Size = new System.Drawing.Size(26, 20);
            this.txt_x_food.TabIndex = 8;
            this.txt_x_food.Text = "1";
            // 
            // txt_x_drinks
            // 
            this.txt_x_drinks.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_x_drinks.Location = new System.Drawing.Point(622, 71);
            this.txt_x_drinks.Name = "txt_x_drinks";
            this.txt_x_drinks.Size = new System.Drawing.Size(26, 20);
            this.txt_x_drinks.TabIndex = 9;
            this.txt_x_drinks.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.PowderBlue;
            this.label5.Location = new System.Drawing.Point(265, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.PowderBlue;
            this.label6.Location = new System.Drawing.Point(602, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            // 
            // btn_add_food
            // 
            this.btn_add_food.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_add_food.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_food.Location = new System.Drawing.Point(21, 99);
            this.btn_add_food.Name = "btn_add_food";
            this.btn_add_food.Size = new System.Drawing.Size(75, 23);
            this.btn_add_food.TabIndex = 14;
            this.btn_add_food.Text = "Add";
            this.btn_add_food.UseVisualStyleBackColor = false;
            this.btn_add_food.Click += new System.EventHandler(this.btn_add_food_Click);
            // 
            // btn_add_drinks
            // 
            this.btn_add_drinks.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_add_drinks.Location = new System.Drawing.Point(358, 99);
            this.btn_add_drinks.Name = "btn_add_drinks";
            this.btn_add_drinks.Size = new System.Drawing.Size(75, 23);
            this.btn_add_drinks.TabIndex = 15;
            this.btn_add_drinks.Text = "Add";
            this.btn_add_drinks.UseVisualStyleBackColor = false;
            this.btn_add_drinks.Click += new System.EventHandler(this.btn_add_drinks_Click);
            // 
            // btn_send_order
            // 
            this.btn_send_order.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_send_order.Location = new System.Drawing.Point(176, 291);
            this.btn_send_order.Name = "btn_send_order";
            this.btn_send_order.Size = new System.Drawing.Size(141, 30);
            this.btn_send_order.TabIndex = 16;
            this.btn_send_order.Text = "Send Order";
            this.btn_send_order.UseVisualStyleBackColor = false;
            this.btn_send_order.Click += new System.EventHandler(this.btn_send_order_Click);
            // 
            // btn_clear_order
            // 
            this.btn_clear_order.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_clear_order.Location = new System.Drawing.Point(21, 290);
            this.btn_clear_order.Name = "btn_clear_order";
            this.btn_clear_order.Size = new System.Drawing.Size(141, 30);
            this.btn_clear_order.TabIndex = 17;
            this.btn_clear_order.Text = "Clear Order";
            this.btn_clear_order.UseVisualStyleBackColor = false;
            this.btn_clear_order.Click += new System.EventHandler(this.btn_clear_order_Click);
            // 
            // dgv_food
            // 
            this.dgv_food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_food.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food_column,
            this.food_amount_column});
            this.dgv_food.EnableHeadersVisualStyles = false;
            this.dgv_food.Location = new System.Drawing.Point(21, 129);
            this.dgv_food.Name = "dgv_food";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_food.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgv_food.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_food.Size = new System.Drawing.Size(290, 145);
            this.dgv_food.TabIndex = 18;
            // 
            // food_column
            // 
            this.food_column.HeaderText = "Food";
            this.food_column.Name = "food_column";
            this.food_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // food_amount_column
            // 
            this.food_amount_column.HeaderText = "Food Amount";
            this.food_amount_column.Name = "food_amount_column";
            this.food_amount_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_drinks
            // 
            this.dgv_drinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drinks.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_drinks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_drinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinks_column,
            this.drinks_amount_column});
            this.dgv_drinks.EnableHeadersVisualStyles = false;
            this.dgv_drinks.Location = new System.Drawing.Point(358, 129);
            this.dgv_drinks.Name = "dgv_drinks";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_drinks.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.dgv_drinks.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_drinks.Size = new System.Drawing.Size(290, 145);
            this.dgv_drinks.TabIndex = 19;
            // 
            // drinks_column
            // 
            this.drinks_column.HeaderText = "Drinks";
            this.drinks_column.Name = "drinks_column";
            this.drinks_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // drinks_amount_column
            // 
            this.drinks_amount_column.HeaderText = "Drinks Amount";
            this.drinks_amount_column.Name = "drinks_amount_column";
            this.drinks_amount_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_export_orders
            // 
            this.btn_export_orders.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_export_orders.Location = new System.Drawing.Point(176, 362);
            this.btn_export_orders.Name = "btn_export_orders";
            this.btn_export_orders.Size = new System.Drawing.Size(141, 30);
            this.btn_export_orders.TabIndex = 20;
            this.btn_export_orders.Text = "Export Orders";
            this.btn_export_orders.UseVisualStyleBackColor = false;
            this.btn_export_orders.Click += new System.EventHandler(this.btn_export_orders_Click);
            // 
            // _xml_export
            // 
            this._xml_export.CheckFileExists = false;
            this._xml_export.CheckPathExists = false;
            this._xml_export.FileName = "restaurant.xml";
            // 
            // btn_view_orders
            // 
            this.btn_view_orders.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_view_orders.Location = new System.Drawing.Point(176, 327);
            this.btn_view_orders.Name = "btn_view_orders";
            this.btn_view_orders.Size = new System.Drawing.Size(141, 30);
            this.btn_view_orders.TabIndex = 21;
            this.btn_view_orders.Text = "View Orders";
            this.btn_view_orders.UseVisualStyleBackColor = false;
            this.btn_view_orders.Click += new System.EventHandler(this.btn_view_orders_Click);
            // 
            // btn_html_transform
            // 
            this.btn_html_transform.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_html_transform.Location = new System.Drawing.Point(21, 362);
            this.btn_html_transform.Name = "btn_html_transform";
            this.btn_html_transform.Size = new System.Drawing.Size(141, 30);
            this.btn_html_transform.TabIndex = 22;
            this.btn_html_transform.Text = "Xml To HTML";
            this.btn_html_transform.UseVisualStyleBackColor = false;
            this.btn_html_transform.Click += new System.EventHandler(this.btn_html_transform_Click);
            // 
            // btn_reset_orders
            // 
            this.btn_reset_orders.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_reset_orders.Location = new System.Drawing.Point(21, 326);
            this.btn_reset_orders.Name = "btn_reset_orders";
            this.btn_reset_orders.Size = new System.Drawing.Size(141, 30);
            this.btn_reset_orders.TabIndex = 23;
            this.btn_reset_orders.Text = "Reset All Orders";
            this.btn_reset_orders.UseVisualStyleBackColor = false;
            this.btn_reset_orders.Click += new System.EventHandler(this.btn_reset_orders_Click);
            // 
            // log_box
            // 
            this.log_box.BackColor = System.Drawing.Color.MediumAquamarine;
            this.log_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_box.FormattingEnabled = true;
            this.log_box.ItemHeight = 15;
            this.log_box.Location = new System.Drawing.Point(358, 283);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(288, 109);
            this.log_box.TabIndex = 24;
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(670, 406);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.btn_reset_orders);
            this.Controls.Add(this.btn_html_transform);
            this.Controls.Add(this.btn_view_orders);
            this.Controls.Add(this.btn_export_orders);
            this.Controls.Add(this.dgv_drinks);
            this.Controls.Add(this.dgv_food);
            this.Controls.Add(this.btn_clear_order);
            this.Controls.Add(this.btn_send_order);
            this.Controls.Add(this.btn_add_drinks);
            this.Controls.Add(this.btn_add_food);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_x_drinks);
            this.Controls.Add(this.txt_x_food);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_drinks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_food);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_table);
            this.Controls.Add(this.cmb_waiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Restaurant";
            this.Text = "Restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add_food;
        private System.Windows.Forms.Button btn_add_drinks;
        private System.Windows.Forms.Button btn_send_order;
        private System.Windows.Forms.Button btn_clear_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_amount_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinks_amount_column;
        private System.Windows.Forms.Button btn_export_orders;
        private System.Windows.Forms.OpenFileDialog _xml_export;
        private System.Windows.Forms.Button btn_view_orders;
        public System.Windows.Forms.DataGridView dgv_food;
        public System.Windows.Forms.ComboBox cmb_waiter;
        public System.Windows.Forms.ComboBox cmb_table;
        public System.Windows.Forms.ComboBox cmb_food;
        public System.Windows.Forms.ComboBox cmb_drinks;
        public System.Windows.Forms.TextBox txt_x_food;
        public System.Windows.Forms.TextBox txt_x_drinks;
        public System.Windows.Forms.DataGridView dgv_drinks;
        private System.Windows.Forms.Button btn_html_transform;
        private System.Windows.Forms.Button btn_reset_orders;
        private System.Windows.Forms.ListBox log_box;
    }
}

