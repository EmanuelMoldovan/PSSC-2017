using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace PSSC
{
    public partial class XmlToHtml : Form
    {
        public XmlToHtml()
        {
            InitializeComponent();
        }

        private void btn_xml_select_Click(object sender, EventArgs e)
        {
            _select_path.Filter = "XML Files|*.xml";
            if (_select_path.ShowDialog() == DialogResult.OK)
            {
                Variables._xml_path = _select_path.FileName;
                txt_xml.Text = _select_path.FileName;
            }
        }

        private void btn_xsl_select_Click(object sender, EventArgs e)
        {
            _select_path.Filter = "XSL Files|*.xsl";
            if (_select_path.ShowDialog() == DialogResult.OK)
            {
                Variables._xsl_path = _select_path.FileName;
                txt_xsl.Text = _select_path.FileName;
            }
        }

        private void btn_html_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _select_folder = new FolderBrowserDialog();
            if(_select_folder.ShowDialog() == DialogResult.OK)
            {
                Variables._html_path = _select_folder.SelectedPath;
                txt_html.Text = _select_folder.SelectedPath;
            }
        }

        private void btn_transform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(Variables._xsl_path);
            xslt.Transform(Variables._xml_path, Variables._html_path+"\\restaurant.html");
            Process.Start(Variables._html_path + "\\restaurant.html");
        }

        private void btn_generate_xsl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _select_folder = new FolderBrowserDialog();
            if (_select_folder.ShowDialog() == DialogResult.OK)
            {               
                Variables._xsl_generate_path = _select_folder.SelectedPath;
                Variables._xsl_path = _select_folder.SelectedPath+"\\restaurant.xsl";
                GenerateXsl.Xsl_Generate(Variables._xsl_generate_path);
                txt_xsl.Text = Variables._xsl_path;
            }
            
        }
    }
}
