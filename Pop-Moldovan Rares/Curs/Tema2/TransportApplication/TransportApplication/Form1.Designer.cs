namespace TransportApplication
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAngajat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.Window;
            this.btnClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(23, 26);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(145, 37);
            this.btnClient.TabIndex = 5;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click_1);
            // 
            // btnAngajat
            // 
            this.btnAngajat.BackColor = System.Drawing.SystemColors.Window;
            this.btnAngajat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngajat.Location = new System.Drawing.Point(217, 26);
            this.btnAngajat.Name = "btnAngajat";
            this.btnAngajat.Size = new System.Drawing.Size(145, 37);
            this.btnAngajat.TabIndex = 6;
            this.btnAngajat.Text = "Angajat";
            this.btnAngajat.UseVisualStyleBackColor = false;
            this.btnAngajat.Click += new System.EventHandler(this.btnAngajat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(392, 89);
            this.Controls.Add(this.btnAngajat);
            this.Controls.Add(this.btnClient);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Aplicatie Transport Autocar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAngajat;
    }
}

