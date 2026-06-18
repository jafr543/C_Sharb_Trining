using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class BurgarForm : Form
    {
        public BurgarForm()
        {
            InitializeComponent();
        }

        int CalculateTypePrice()
        {
            if(rbBeef.Checked)
            {
                return Convert.ToInt16(rbBeef.Tag);
            }
            
            if(rbCh.Checked)
            {
                return Convert.ToInt16(rbCh.Tag);
            }

            if(rbMuBu.Checked)
            {
                return Convert.ToInt16(rbMuBu.Tag);
            }

            return 0;
        }

        int CalculateSizePrice()
        {
            if (rbSin.Checked)
            {
                return Convert.ToInt16(rbSin.Tag);
            }

            if (rbDou.Checked)
            {
                return Convert.ToInt16(rbDou.Tag);
            }

            if (rbTr.Checked)
            {
                return Convert.ToInt16(rbTr.Tag);
            }

            return 0;
        }

        int CalculateToppingsPrice()
        {
            int Price = 0;

            if (chCh.Checked)
            {
                Price += Convert.ToInt16(chCh.Tag);
            }

            if(chBa.Checked)
            {
                Price += Convert.ToInt16(chBa.Tag);
            }

            if(chPi.Checked)
            {
                Price += Convert.ToInt16(chPi.Tag);
            }

            if(chSp.Checked)
            {
                Price += Convert.ToInt16(chSp.Tag);
            }

            return Price;
        }

        int CalculateTotalPrice()
        {
            int TotalPrice = CalculateTypePrice() + CalculateSizePrice() + CalculateToppingsPrice();
            return Convert.ToInt16(Qn.Value) * TotalPrice;
        }

        void PrintTotalPrice()
        {
            
               laTotalPrice.Text = "$" + CalculateTotalPrice();
             
        }

        void ResetButtons()
        {
            rbBeef.Checked = true;
            rbSin.Checked = true;


            chCh.Checked = false;
            chBa.Checked = false;
            chPi.Checked = false;
            chSp.Checked = false;

            Qn.Value = 1;

            PrintTotalPrice();
        }

        private void Type_Change(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void SizeChange(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void ToppingsChange(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

         private void Qn_ValueChanged(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void BurgarForm_Load(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void btReset_Click(object sender, EventArgs e)
        { 
            ResetButtons();
        }

        private void btAddtoTheCart_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Are You Sure", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(Result == DialogResult.OK)
            {
                MessageBox.Show("Your Order Added Successfully","Order Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            ResetButtons();
        }

        private void btAddtoTheCart_MouseEnter(object sender, EventArgs e)
        {
            btAddtoTheCart.ForeColor = Color.White;  
        }

        private void btAddtoTheCart_MouseLeave(object sender, EventArgs e)
        {
            btAddtoTheCart.ForeColor = Color.DarkOrange;
        }

        private void btReset_MouseEnter(object sender, EventArgs e)
        {
            btReset.ForeColor = Color.White;
        }

        private void btReset_MouseLeave(object sender, EventArgs e)
        {
            btReset.ForeColor = Color.DarkOrange;
        }
    }
}
