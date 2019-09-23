using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KARSAVOTOMASYON
{
    public partial class duyuruGoruntule : Form
    {
        public duyuruGoruntule()
        {
            InitializeComponent();
        }

        private void duyuruGoruntule_Load(object sender, EventArgs e)
        {
            duyuruWeb.ScriptErrorsSuppressed = true;
            duyuruWeb.Navigate(AnaForm.duyuruUrl);

        }
    }
}
