namespace PSSC
{
    partial class XmlToHtml
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_xml = new System.Windows.Forms.TextBox();
            this.txt_xsl = new System.Windows.Forms.TextBox();
            this.txt_html = new System.Windows.Forms.TextBox();
            this.btn_xml_select = new System.Windows.Forms.Button();
            this.btn_xsl_select = new System.Windows.Forms.Button();
            this.btn_html_select = new System.Windows.Forms.Button();
            this.btn_transform = new System.Windows.Forms.Button();
            this._select_path = new System.Windows.Forms.OpenFileDialog();
            this.btn_generate_xsl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xsl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Html";
            // 
            // txt_xml
            // 
            this.txt_xml.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_xml.Location = new System.Drawing.Point(55, 19);
            this.txt_xml.Name = "txt_xml";
            this.txt_xml.Size = new System.Drawing.Size(216, 20);
            this.txt_xml.TabIndex = 3;
            // 
            // txt_xsl
            // 
            this.txt_xsl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_xsl.Location = new System.Drawing.Point(55, 48);
            this.txt_xsl.Name = "txt_xsl";
            this.txt_xsl.Size = new System.Drawing.Size(216, 20);
            this.txt_xsl.TabIndex = 4;
            // 
            // txt_html
            // 
            this.txt_html.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_html.Location = new System.Drawing.Point(55, 76);
            this.txt_html.Name = "txt_html";
            this.txt_html.Size = new System.Drawing.Size(216, 20);
            this.txt_html.TabIndex = 5;
            // 
            // btn_xml_select
            // 
            this.btn_xml_select.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_xml_select.Location = new System.Drawing.Point(277, 17);
            this.btn_xml_select.Name = "btn_xml_select";
            this.btn_xml_select.Size = new System.Drawing.Size(75, 23);
            this.btn_xml_select.TabIndex = 6;
            this.btn_xml_select.Text = "Select";
            this.btn_xml_select.UseVisualStyleBackColor = false;
            this.btn_xml_select.Click += new System.EventHandler(this.btn_xml_select_Click);
            // 
            // btn_xsl_select
            // 
            this.btn_xsl_select.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_xsl_select.Location = new System.Drawing.Point(277, 46);
            this.btn_xsl_select.Name = "btn_xsl_select";
            this.btn_xsl_select.Size = new System.Drawing.Size(75, 23);
            this.btn_xsl_select.TabIndex = 7;
            this.btn_xsl_select.Text = "Select";
            this.btn_xsl_select.UseVisualStyleBackColor = false;
            this.btn_xsl_select.Click += new System.EventHandler(this.btn_xsl_select_Click);
            // 
            // btn_html_select
            // 
            this.btn_html_select.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_html_select.Location = new System.Drawing.Point(277, 74);
            this.btn_html_select.Name = "btn_html_select";
            this.btn_html_select.Size = new System.Drawing.Size(75, 23);
            this.btn_html_select.TabIndex = 8;
            this.btn_html_select.Text = "Select";
            this.btn_html_select.UseVisualStyleBackColor = false;
            this.btn_html_select.Click += new System.EventHandler(this.btn_html_select_Click);
            // 
            // btn_transform
            // 
            this.btn_transform.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_transform.Location = new System.Drawing.Point(196, 102);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(156, 25);
            this.btn_transform.TabIndex = 9;
            this.btn_transform.Text = "Transform";
            this.btn_transform.UseVisualStyleBackColor = false;
            this.btn_transform.Click += new System.EventHandler(this.btn_transform_Click);
            // 
            // btn_generate_xsl
            // 
            this.btn_generate_xsl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_generate_xsl.Location = new System.Drawing.Point(55, 103);
            this.btn_generate_xsl.Name = "btn_generate_xsl";
            this.btn_generate_xsl.Size = new System.Drawing.Size(135, 23);
            this.btn_generate_xsl.TabIndex = 10;
            this.btn_generate_xsl.Text = "Generate Xsl";
            this.btn_generate_xsl.UseVisualStyleBackColor = false;
            this.btn_generate_xsl.Click += new System.EventHandler(this.btn_generate_xsl_Click);
            // 
            // XmlToHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(365, 141);
            this.Controls.Add(this.btn_generate_xsl);
            this.Controls.Add(this.btn_transform);
            this.Controls.Add(this.btn_html_select);
            this.Controls.Add(this.btn_xsl_select);
            this.Controls.Add(this.btn_xml_select);
            this.Controls.Add(this.txt_html);
            this.Controls.Add(this.txt_xsl);
            this.Controls.Add(this.txt_xml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XmlToHtml";
            this.Text = "XmlToHtml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_xml;
        private System.Windows.Forms.TextBox txt_xsl;
        private System.Windows.Forms.TextBox txt_html;
        private System.Windows.Forms.Button btn_xml_select;
        private System.Windows.Forms.Button btn_xsl_select;
        private System.Windows.Forms.Button btn_html_select;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.OpenFileDialog _select_path;
        private System.Windows.Forms.Button btn_generate_xsl;
    }
}