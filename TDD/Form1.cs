using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD
{
    public partial class Savings : Form
    {
        public Savings()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var prin = double.Parse(tbPrincipal.Text);
                var rate = double.Parse(tbRate.Text);
                var time = Int32.Parse(tbTime.Text);
                var amount = SimpleInterest(prin, rate, time);
                tbAmount.Text = amount.ToString();
            }
            catch (Exception exception)
            {
                tbAmount.Text = "Something went wrong";
            }

        }

        public double SimpleInterest(double principal, double rate, int time)
        {
            var amount = principal + (principal * rate * time / 100);
            return amount;
        }
    }
}
