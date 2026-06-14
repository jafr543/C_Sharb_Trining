using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int CalculatePizzaTypePrice()
        {
            if(rBBeef.Checked)
             return Convert.ToInt16(rBBeef.Tag);
            
            if (rBCh.Checked)
                return Convert.ToInt16(rBCh.Tag);

            if(rBVe.Checked)
                return Convert.ToInt16(rBVe.Tag);

            if(rBPe.Checked)
                return Convert.ToInt16(rBPe.Tag);

            if(rBMa.Checked)
                return Convert.ToInt16(rBMa.Tag);

            return 0;
        }

        int CalculateSizePrice()
        {
            
            if (rBSmall.Checked)
            {
                return Convert.ToInt32(rBSmall.Tag);
            }

            if(rBMedium.Checked)
            {
                return Convert.ToInt16(rBMedium.Tag);
            }

            if(rBLarge.Checked)
            {
                return Convert.ToInt16(rBLarge.Tag);
            }

            return 0;
        }

        int CalculateCurstPrice()
        { 

            if (rBThin.Checked)
            {
                return 0;
            }

            if(rBThink.Checked)
            {
                return Convert.ToInt16(rBThink.Tag);
            }

            return 0;
        }

        int CalculateToppingsPrice()
        {
            int Price = 0;
            if (cBEx.Checked)
            {
                Price += Convert.ToInt16(cBEx.Tag);
            }

            if (cBMu.Checked)
            {
                Price += Convert.ToInt16(cBMu.Tag);
            }

            if (cBTo.Checked)
            {
                Price += Convert.ToInt16(cBTo.Tag);
            }

            if (cBOn.Checked)
            {
                Price += Convert.ToInt16(cBOn.Tag);
            }

            if (cBOl.Checked)
            {
                Price += Convert.ToInt16(cBOl.Tag);
            }

            if (cBGr.Checked)
            {
                Price += Convert.ToInt16(cBGr.Tag);
            }

            return Price;
        }

        int CalculateTotalPrice()
        {
           return CalculateSizePrice() + CalculateCurstPrice() + CalculateToppingsPrice() + CalculatePizzaTypePrice();
        }

        void PrintTotalPrice()
        {
            laTotalPrice.Text = "$" + CalculateTotalPrice();
        }

        void SelectedPizzaType()
        {
            if (rBBeef.Checked)
            {
             laPizzaType.Text = rBBeef.Text;
                return;
            }
              

            if (rBCh.Checked)
            {
             laPizzaType.Text = rBCh.Text;
            return;
            }
                
            if (rBVe.Checked)
            {
               laPizzaType.Text = rBVe.Text;
               return;
            }
                

            if (rBPe.Checked)
            {
                laPizzaType.Text =  rBPe.Text;
                return;
            }
                

            if (rBMa.Checked)
            {
                laPizzaType.Text =  rBMa.Text;
                return;
            }
                
        }

        void SelectedSize()
        {
            

            if (rBSmall.Checked)
            {
                laSelectedSize.Text = rBSmall.Text;
                return;
            }

            if(rBMedium.Checked)
            {
                laSelectedSize.Text = rBMedium.Text;
                return;
            }

            if(rBLarge.Checked)
            {
                laSelectedSize.Text = rBLarge.Text;
                return;
            }
        }

        void SelectedCurst()
        {

            if (rBThin.Checked)
            {
                laSelectedCurst.Text = rBThin.Text;
                return;
            }
            if(rBThink.Checked) 
            {
                laSelectedCurst.Text = rBThink.Text;
                return;
            }
        }

        void SelectedToppings()
        {
            string sToppings = "";
            
            if(cBEx.Checked)
            {
                sToppings = cBEx.Text + " ,";
            }

            if (cBMu.Checked)
            {
                sToppings += cBMu.Text + " ,";
            }

            if (cBTo.Checked)
            {
                sToppings += cBTo.Text + " ,";
            }

            if (cBOn.Checked)
            {
                sToppings += cBOn.Text + " ,";
            }

            if (cBOl.Checked)
            {
                sToppings += cBOl.Text + " ,";
            }

            if (cBGr.Checked)
            {
                sToppings += cBGr.Text + " ,";
            }

            laSelectedToppings.Text = sToppings.TrimEnd(',',' ');
        }

        void SelectedWhereToEat()
        {
            if(rBEatin.Checked)
            {
                laSelectedPleasofEat.Text = rBEatin.Text;
            }
            else
            {
                laSelectedPleasofEat.Text = rBEatOut.Text;
            }
        }

        void TurnoffButtenes()
        {
            plSize.Enabled = false;
            plCurst.Enabled = false;
            plToppings.Enabled = false;
            plWheretoEat.Enabled = false;
            bOrder.Enabled = false;
            plPizzaType.Enabled = false;
        }

        void TurnonButtenes()
        {
            plSize.Enabled = true;
            plCurst.Enabled = true;
            plToppings.Enabled = true;
            plWheretoEat.Enabled = true;
            bOrder.Enabled = true;
            plPizzaType.Enabled = true;

            cBEx.Checked = false;
            cBMu.Checked = false;
            cBTo.Checked = false;
            cBOn.Checked = false;
            cBOl.Checked = false;
            cBGr.Checked = false;

            rBSmall.Checked = true;
            rBThin.Checked = true;
            rBEatin.Checked = true;
            rBBeef.Checked = true;

            laSelectedToppings.Text = "no Toppings";

            PrintTotalPrice();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectedPizzaType();
            SelectedSize();
            SelectedCurst();
            SelectedWhereToEat();
            PrintTotalPrice();
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            SelectedToppings();
            PrintTotalPrice();
        }

        private void rBWhereToEat_CheckedChanged(object sender, EventArgs e)
        {
            SelectedWhereToEat();
        }

        private void rBSize_CheckedChanged(object sender, EventArgs e)
        {
            SelectedSize();
            PrintTotalPrice();
        }

        private void CrustTypeChanged(object sender, EventArgs e)
        {
            SelectedCurst();
            PrintTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult Result =  MessageBox.Show("you Sure?","Confirmation",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(Result == DialogResult.OK)
            {
                MessageBox.Show("Order Add Successfully", "Order Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                TurnoffButtenes();
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            TurnonButtenes();
        }

        private void bReset_MouseEnter(object sender, EventArgs e)
        {
            bOrder.BackColor = Color.Transparent;
            bReset.BackColor = Color.Transparent;
        }

        private void TypeChenge(object sender, EventArgs e)
        {
            SelectedPizzaType();
            PrintTotalPrice();
        }
    }
}
