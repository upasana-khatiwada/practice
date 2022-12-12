using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_main
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
            DashBoard LoginForm = new DashBoard();
            LoginForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
            products productPage = new products();
            productPage.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
            LowStock lowstockPage = new LowStock();
            lowstockPage.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
           AllTransactions transactionPage = new AllTransactions();
            transactionPage.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the first form 
            Setting settingPage = new Setting();
            settingPage.ShowDialog();

        }
    }
}
