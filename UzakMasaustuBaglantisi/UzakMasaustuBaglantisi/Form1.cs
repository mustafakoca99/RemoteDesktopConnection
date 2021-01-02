using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzakMasaustuBaglantisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnconnect_Click(object sender, EventArgs e)
        {
            axMsTscAxNotSafeForScripting1.Server = textBox1.Text;
            axMsTscAxNotSafeForScripting1.UserName = textBox2.Text;
            IMsTscNonScriptable guvenlik = (IMsTscNonScriptable)axMsTscAxNotSafeForScripting1.GetOcx();
            guvenlik.ClearTextPassword = textBox3.Text;
            axMsTscAxNotSafeForScripting1.Connect();
            
        }

        private void Btndisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                axMsTscAxNotSafeForScripting1.Disconnect();
            }
            catch (Exception)
            {
                MessageBox.Show("Zaten bağlı değil!");
             //   throw;
            }
            
        }
    }
}
