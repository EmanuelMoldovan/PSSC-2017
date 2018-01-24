namespace TransportApplication.Interfete
{
    partial class InterfataClient
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
            this.comboBoxOrase = new System.Windows.Forms.ComboBox();
            this.btnCautaRute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listTrasee = new System.Windows.Forms.ListBox();
            this.btnAfiseazaTot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destinatie:";
            // 
            // comboBoxOrase
            // 
            this.comboBoxOrase.FormattingEnabled = true;
            this.comboBoxOrase.Items.AddRange(new object[] {
            "Arad",
            "Oradea",
            "Timisoara",
            "Lugoj",
            "Alba-Iulia",
            "Turda",
            "Cluj",
            "Targu Mures",
            "Targu Jiu",
            "Iasi",
            "Bucuresti"});
            this.comboBoxOrase.Location = new System.Drawing.Point(269, 43);
            this.comboBoxOrase.Name = "comboBoxOrase";
            this.comboBoxOrase.Size = new System.Drawing.Size(140, 21);
            this.comboBoxOrase.TabIndex = 3;
            // 
            // btnCautaRute
            // 
            this.btnCautaRute.BackColor = System.Drawing.SystemColors.Window;
            this.btnCautaRute.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaRute.Location = new System.Drawing.Point(28, 90);
            this.btnCautaRute.Name = "btnCautaRute";
            this.btnCautaRute.Size = new System.Drawing.Size(140, 50);
            this.btnCautaRute.TabIndex = 4;
            this.btnCautaRute.Text = "Cauta Rute";
            this.btnCautaRute.UseVisualStyleBackColor = false;
            this.btnCautaRute.Click += new System.EventHandler(this.btnCautaRute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plecare:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arad",
            "Oradea",
            "Timisoara",
            "Lugoj",
            "Alba-Iulia",
            "Turda",
            "Cluj",
            "Targu Mures",
            "Targu Jiu",
            "Iasi",
            "Bucuresti"});
            this.comboBox1.Location = new System.Drawing.Point(28, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // listTrasee
            // 
            this.listTrasee.FormattingEnabled = true;
            this.listTrasee.Location = new System.Drawing.Point(28, 181);
            this.listTrasee.Name = "listTrasee";
            this.listTrasee.Size = new System.Drawing.Size(381, 160);
            this.listTrasee.TabIndex = 8;
            this.listTrasee.SelectedIndexChanged += new System.EventHandler(this.listTrasee_SelectedIndexChanged);
            // 
            // btnAfiseazaTot
            // 
            this.btnAfiseazaTot.BackColor = System.Drawing.SystemColors.Window;
            this.btnAfiseazaTot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseazaTot.Location = new System.Drawing.Point(269, 90);
            this.btnAfiseazaTot.Name = "btnAfiseazaTot";
            this.btnAfiseazaTot.Size = new System.Drawing.Size(140, 50);
            this.btnAfiseazaTot.TabIndex = 9;
            this.btnAfiseazaTot.Text = "Afiseaza toate rutele";
            this.btnAfiseazaTot.UseVisualStyleBackColor = false;
            this.btnAfiseazaTot.Click += new System.EventHandler(this.btnAfiseazaTot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // InterfataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(440, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAfiseazaTot);
            this.Controls.Add(this.listTrasee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCautaRute);
            this.Controls.Add(this.comboBoxOrase);
            this.Controls.Add(this.label1);
            this.Name = "InterfataClient";
            this.Text = "InterfataClient";
            this.Load += new System.EventHandler(this.InterfataClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrase;
        private System.Windows.Forms.Button btnCautaRute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listTrasee;
        private System.Windows.Forms.Button btnAfiseazaTot;
        private System.Windows.Forms.Label label4;
    }
}