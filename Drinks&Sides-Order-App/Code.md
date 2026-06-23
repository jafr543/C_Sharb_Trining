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
    public partial class DrinksForm : Form
    {
        public DrinksForm()
        {
            InitializeComponent();
        }
        
        int CalculateDrinksPrice()
        {
            int drinksCount = 0;
            int drinksPrice = 0;

            if(chCo.Checked)
            {
                drinksPrice+= Convert.ToInt16(chCo.Tag);
                drinksCount++;
            }

            if(chDC.Checked)
            {
                drinksPrice+= Convert.ToInt16(chDC.Tag);
                drinksCount++;
            }

            if(chOJ.Checked)
            {
                drinksPrice += Convert.ToInt16(chOJ.Tag);
                drinksCount++;
            }

            if(chWt.Checked)
            {
                drinksPrice += Convert.ToInt16(chWt.Tag);
                drinksCount++;
            }

            if (rdSm.Checked)
            {
                return drinksPrice += (Convert.ToInt16(rdSm.Tag) * drinksCount);
            }

            if (rdMe.Checked)
            {
                return drinksPrice += (Convert.ToInt16(rdMe.Tag) * drinksCount);
            }

            if (rdLg.Checked)
            {
                return drinksPrice += (Convert.ToInt16(rdLg.Tag) * drinksCount);
            }

            return drinksPrice;
        }

        int CalculateSidesPrice()
        {
            int sidesPrice = 0;

            if(chFF.Checked)
            {
                sidesPrice+= Convert.ToInt16(chFF.Tag);
            }

            if(chOR.Checked)
            {
                sidesPrice+= Convert.ToInt16(chOR.Tag);
            }

            if(chMS.Checked)
            {
                sidesPrice+= Convert.ToInt16(chMS.Tag);
            }

            if(chGB.Checked)
            {
                sidesPrice+= Convert.ToInt16(chGB.Tag);
            }
            return sidesPrice;
        }
        
        int CalculateTotalPrice()
        {
            return (Convert.ToInt16(NUDdrinks.Value) * CalculateDrinksPrice()) + (Convert.ToInt16(NUDsides.Value) * CalculateSidesPrice());
        }

        void PrintTotalPrice()
        {
            laPrice.Text = "$" + CalculateTotalPrice();
        }

        void ResetForm()
        {
            chCo.Checked = false;
            chDC.Checked = false;
            chOJ.Checked = false;
            chWt.Checked = false;

            rdSm.Checked = true;

            chFF.Checked = false;
            chOR.Checked = false;
            chMS.Checked = false;
            chGB.Checked = false;
            NUDdrinks.Value = 1;
            NUDsides.Value = 1;
        }

        bool ChecktheOrder()
        {
            if(CalculateTotalPrice() == 0)
            {
                return true;
            }

            return false;
        }
        private void DrinksCheckChanged(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void DrinkSizeCheckedChanged(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void SidesCheckedChanged(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void Drinks_Sides_NUD_ValueChanged(object sender, EventArgs e)
        {
            PrintTotalPrice();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btAddtoCart_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are Sure", "Confrit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(Result == DialogResult.OK)
            {
                if(ChecktheOrder())
                {
                    MessageBox.Show("You Can Not Order Nothing!", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Order Added Successfully", "Order Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void DrinksForm_Load(object sender, EventArgs e)
        {
            chCo.Checked = true;
            chFF.Checked = true;
            PrintTotalPrice();
        }

        private void btReset_MouseEnter(object sender, EventArgs e)
        {
            btReset.ForeColor = Color.White;
        }

        private void btReset_MouseLeave(object sender, EventArgs e)
        {
            btReset.ForeColor = Color.MediumSlateBlue;
        }

        private void btAddtoCart_MouseEnter(object sender, EventArgs e)
        {
            btAddtoCart.ForeColor = Color.White;
        }

        private void btAddtoCart_MouseLeave(object sender, EventArgs e)
        {
            btAddtoCart.ForeColor = Color.MediumSlateBlue;
        }
    }
}
