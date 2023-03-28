using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsyncAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int op1, op2;
            op1 = Convert.ToInt32(txtOperand1.Text);
            op2 = Convert.ToInt32(txtOperand2.Text);
            CallSumOfOneToNAsync(op1,op2);
            lblResult.Text = "Please wait...";
        }

        private async void CallSumOfOneToNAsync(int min,int max)
        {
            var result = await SumOfOneToNAsync(min,max);
            lblResult.Text = result;
        }

        private Task<string> SumOfOneToNAsync(int min, int max)
        {
            return Task.Factory.StartNew(() => SumOfOnetoN(min,max));
        }

        private string SumOfOnetoN(int min, int max)
        {
            Thread.Sleep(5000);

            int sum = 0;

            for(int i = min; i <= max; i++)
            {
                sum += i;
            }

            return $"Sum of numbers between {min} and {max}: {sum}";
        }
    }
}
