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
    public partial class etkinlikGoruntule : Form
    {
        public etkinlikGoruntule()
        {
            InitializeComponent();
        }

        private void etkinlikGoruntule_Load(object sender, EventArgs e)
        {
            
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(AnaForm.adres);
        }
    }
}
