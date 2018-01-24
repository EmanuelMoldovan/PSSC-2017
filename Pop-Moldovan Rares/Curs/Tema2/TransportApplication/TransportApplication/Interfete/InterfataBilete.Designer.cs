namespace TransportApplication.Interfete
{
    partial class InterfataBilete
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumePasager = new System.Windows.Forms.TextBox();
            this.btnCautaRute = new System.Windows.Forms.Button();
            this.lblBilet = new System.Windows.Forms.Label();
            this.btnSaveBilet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nume Pasager";
            // 
            // tbNumePasager
            // 
            this.tbNumePasager.Location = new System.Drawing.Point(129, 8);
            this.tbNumePasager.Name = "tbNumePasager";
            this.tbNumePasager.Size = new System.Drawing.Size(213, 20);
            this.tbNumePasager.TabIndex = 7;
            // 
            // btnCautaRute
            // 
            this.btnCautaRute.BackColor = System.Drawing.SystemColors.Window;
            this.btnCautaRute.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaRute.Location = new System.Drawing.Point(15, 42);
            this.btnCautaRute.Name = "btnCautaRute";
            this.btnCautaRute.Size = new System.Drawing.Size(98, 53);
            this.btnCautaRute.TabIndex = 8;
            this.btnCautaRute.Text = "Adauga Numele";
            this.btnCautaRute.UseVisualStyleBackColor = false;
            this.btnCautaRute.Click += new System.EventHandler(this.btnCautaRute_Click);
            // 
            // lblBilet
            // 
            this.lblBilet.AutoSize = true;
            this.lblBilet.Location = new System.Drawing.Point(13, 115);
            this.lblBilet.Name = "lblBilet";
            this.lblBilet.Size = new System.Drawing.Size(0, 13);
            this.lblBilet.TabIndex = 9;
            // 
            // btnSaveBilet
            // 
            this.btnSaveBilet.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveBilet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBilet.Location = new System.Drawing.Point(244, 42);
            this.btnSaveBilet.Name = "btnSaveBilet";
            this.btnSaveBilet.Size = new System.Drawing.Size(98, 53);
            this.btnSaveBilet.TabIndex = 10;
            this.btnSaveBilet.Text = "Salvare Bilet";
            this.btnSaveBilet.UseVisualStyleBackColor = false;
            this.btnSaveBilet.Click += new System.EventHandler(this.btnSaveBilet_Click);
            // 
            // InterfataBilete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(354, 325);
            this.Controls.Add(this.btnSaveBilet);
            this.Controls.Add(this.lblBilet);
            this.Controls.Add(this.btnCautaRute);
            this.Controls.Add(this.tbNumePasager);
            this.Controls.Add(this.label2);
            this.Name = "InterfataBilete";
            this.Text = "InterfataBilete";
            this.Load += new System.EventHandler(this.InterfataBilete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumePasager;
        private System.Windows.Forms.Button btnCautaRute;
        private System.Windows.Forms.Label lblBilet;
        private System.Windows.Forms.Button btnSaveBilet;
    }
}