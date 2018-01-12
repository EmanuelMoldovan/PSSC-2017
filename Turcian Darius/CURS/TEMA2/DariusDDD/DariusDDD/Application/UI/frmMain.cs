using System.Windows.Forms;
using DariusDDD.Domain.Enums;
using DariusDDD.Domain.Models;
using DariusDDD.Domain.Repositories;
using DariusDDD.Domain.Repositories.Interfaces;
using DariusDDD.Domain.Services;

namespace DariusDDD.Application.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private bool _employer;

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            _employer = false;
            //var conetext = new Entities();
        }
    }
}
