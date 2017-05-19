using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            while(result ==DialogResult.Yes)
            {
               result= MessageBox.Show("続けますか？", "確認",
                   MessageBoxButtons.YesNo);
                System.Threading.Thread.Sleep(1000);
            }
            MessageBox.Show("WHILEループを終了しました", "情報");
        }
    }
}
