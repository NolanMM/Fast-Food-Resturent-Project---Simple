using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Resturent_Project
{
    public partial class Form1 : Form
    {
        const double Price_BottleWater = 1.9;
        const double Price_CheeseSandwich = 2.3;
        const double Price_ChickenSandwich = 2.4;
        const double Price_ChocolateMilkShake = 2.1;
        const double Price_ChocolateMuffin = 2.3;
        const double Price_Coffee = 1.5;
        const double Price_Cola = 1.3;
        const double Price_FishSandwich = 2.9;
        const double Price_Chicken = 4.5;
        const double Price_Fries = 1.1;
        const double Price_ChickenBurger = 2.5;
        const double Price_HashBrown = 1.0;
        const double Price_OnionRings = 0.56;
        const double Price_Orange = 1.2;
        const double Price_PancakesSyrup = 1.2;
        const double Price_PineappleStick = 1.6;
        const double Price_Salad = 1.2;
        const double Price_Strawberry = 1.7;
        const double Price_ChickenSalad = 1.8;
        const double Price_Tea = 1.1;
        const double Price_ToastedBagel = 1.3;
        const double Price_VanillaCone = 1.7;
        const double Price_VanillaShake = 1.5;
        const double Tax_Rate = 3.9;

        double iTax, iSubTotal, iTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to Exit the Project", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
       if(iExit == DialogResult.Yes)
       {
           Application.Exit();
       }
        
        }

        //==================================RestTextBoxes()===============================

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Text = "0";
                        else
                            func(control.Controls);
                };
            func(Controls);
        }

        //==================================EnableTextBoxes()===============================

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //==================================RestCheckBoxes()===============================

        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.Items.Add("");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Master Card");
            cmbPaymentMethod.Items.Add("Visa Card");
            cmbPaymentMethod.Items.Add("Debit Card");

            EnableTextBoxes();
        }

        //==================================Fast Food===============================

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked == true )
            {
                txtFries.Text = "";
                txtFries.Focus();
                txtFries.Enabled = true;
            }

            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalad.Checked == true)
            {
                txtSalad.Text = "";
                txtSalad.Focus();
                txtSalad.Enabled = true;
            }

            else
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void chkChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenBurger.Checked == true)
            {
                txtChickenBurger.Text = "";
                txtChickenBurger.Focus();
                txtChickenBurger.Enabled = true;
            }

            else
            {
                txtChickenBurger.Enabled = false;
                txtChickenBurger.Text = "0";
            }
        }

        private void chkonionRings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkonionRings.Checked == true)
            {
                txtOnionRings.Text = "";
                txtOnionRings.Focus();
                txtOnionRings.Enabled = true;
            }

            else
            {
                txtOnionRings.Enabled = false;
                txtOnionRings.Text = "0";
            }
        }

        private void chkChickenSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenSalad.Checked == true)
            {
                txtChickenSalad.Text = "";
                txtChickenSalad.Focus();
                txtChickenSalad.Enabled = true;
            }

            else
            {
                txtChickenSalad.Enabled = false;
                txtChickenSalad.Text = "0";
            }
        }

        private void chkFishSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFishSandwich.Checked == true)
            {
                txtFishSandwich.Text = "";
                txtFishSandwich.Focus();
                txtFishSandwich.Enabled = true;
            }

            else
            {
                txtFishSandwich.Enabled = false;
                txtFishSandwich.Text = "0";
            }
        }

        private void chkCheeseSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseSandwich.Checked == true)
            {
                txtCheeseSandwich.Text = "";
                txtCheeseSandwich.Focus();
                txtCheeseSandwich.Enabled = true;
            }

            else
            {
                txtCheeseSandwich.Enabled = false;
                txtCheeseSandwich.Text = "0";
            }
        }

        private void chkChickenSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenSandwich.Checked == true)
            {
                txtChickenSandwich.Text = "";
                txtChickenSandwich.Focus();
                txtChickenSandwich.Enabled = true;
            }

            else
            {
                txtChickenSandwich.Enabled = false;
                txtChickenSandwich.Text = "0";
            }
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked == true)
            {
                txtChicken.Text = "";
                txtChicken.Focus();
                txtChicken.Enabled = true;
            }

            else
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }

            //==================================Desserts===============================
        }

        private void chkHashBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHashBrown.Checked == true)
            {
                txtHashBrown.Text = "";
                txtHashBrown.Focus();
                txtHashBrown.Enabled = true;
            }

            else
            {
                txtHashBrown.Enabled = false;
                txtHashBrown.Text = "0";
            }
        }

        private void chkToastedBagel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToastedBagel.Checked == true)
            {
                txtToastedBagel.Text = "";
                txtToastedBagel.Focus();
                txtToastedBagel.Enabled = true;
            }

            else
            {
                txtToastedBagel.Enabled = false;
                txtToastedBagel.Text = "0";
            }
        }

        private void chkPineappleStick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPineappleStick.Checked == true)
            {
                txtPineappleStick.Text = "";
                txtPineappleStick.Focus();
                txtPineappleStick.Enabled = true;
            }

            else
            {
                txtPineappleStick.Enabled = false;
                txtPineappleStick.Text = "0";
            }
        }

        private void chkChocolateMuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolateMuffin.Checked == true)
            {
                txtChocolateMuffin.Text = "";
                txtChocolateMuffin.Focus();
                txtChocolateMuffin.Enabled = true;
            }

            else
            {
                txtChocolateMuffin.Enabled = false;
                txtChocolateMuffin.Text = "0";
            }
        }

        private void chkPancakesSyrup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPancakesSyrup.Checked == true)
            {
                txtPancakesSyrup.Text = "";
                txtPancakesSyrup.Focus();
                txtPancakesSyrup.Enabled = true;
            }

            else
            {
                txtPancakesSyrup.Enabled = false;
                txtPancakesSyrup.Text = "0";
            }
        }

        //==================================Drinks===============================

        private void chkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTea.Checked == true)
            {
                txtTea.Text = "";
                txtTea.Focus();
                txtTea.Enabled = true;
            }

            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked == true)
            {
                txtCola.Text = "";
                txtCola.Focus();
                txtCola.Enabled = true;
            }

            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                txtCoffee.Text = "";
                txtCoffee.Focus();
                txtCoffee.Enabled = true;
            }

            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void chkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrange.Checked == true)
            {
                txtOrange.Text = "";
                txtOrange.Focus();
                txtOrange.Enabled = true;
            }

            else
            {
                txtOrange.Enabled = false;
                txtOrange.Text = "0";
            }
        }

        private void chkBottleWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBottleWater.Checked == true)
            {
                txtBottleWater.Text = "";
                txtBottleWater.Focus();
                txtBottleWater.Enabled = true;
            }

            else
            {
                txtBottleWater.Enabled = false;
                txtBottleWater.Text = "0";
            }
        }

        //==================================Shakes===============================

        private void chkVanillaCone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVanillaCone.Checked == true)
            {
                txtVanillaCone.Text = "";
                txtVanillaCone.Focus();
                txtVanillaCone.Enabled = true;
            }

            else
            {
                txtVanillaCone.Enabled = false;
                txtVanillaCone.Text = "0";
            }
        }

        private void chkVanillaShake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVanillaShake.Checked == true)
            {
                txtVanillaShake.Text = "";
                txtVanillaShake.Focus();
                txtVanillaShake.Enabled = true;
            }

            else
            {
                txtVanillaShake.Enabled = false;
                txtVanillaShake.Text = "0";
            }
        }

        private void chkStarwberryShake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStarwberryShake.Checked == true)
            {
                txtStarwberryShake.Text = "";
                txtStarwberryShake.Focus();
                txtStarwberryShake.Enabled = true;
            }

            else
            {
                txtStarwberryShake.Enabled = false;
                txtStarwberryShake.Text = "0";
            }
        }

        private void chkChocolateMilkShake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolateMilkShake.Checked == true)
            {
                txtChocolateMilkShake.Text = "";
                txtChocolateMilkShake.Focus();
                txtChocolateMilkShake.Enabled = true;
            }

            else
            {
                txtChocolateMilkShake.Enabled = false;
                txtChocolateMilkShake.Text = "0";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //==================================Cash===============================

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(cmbPaymentMethod.Text == "Cash")
          {
              txtPaymentMethod.Enabled = true;
              txtPaymentMethod.Text = "";
              txtPaymentMethod.Focus();

          }

            else
          {
              txtPaymentMethod.Enabled = false;
              txtPaymentMethod.Text = "0";
          }

          //==================================Master Card===============================

          if (cmbPaymentMethod.Text == "Master Card")
          {
              txtPaymentMethod.Enabled = true;
              txtPaymentMethod.Text = "";
              txtPaymentMethod.Focus();

          }

          else
          {
              txtPaymentMethod.Enabled = false;
              txtPaymentMethod.Text = "0";
          }

          //==================================Visa Card===============================

          if (cmbPaymentMethod.Text == "Visa Card")
          {
              txtPaymentMethod.Enabled = true;
              txtPaymentMethod.Text = "";
              txtPaymentMethod.Focus();

          }

          else
          {
              txtPaymentMethod.Enabled = false;
              txtPaymentMethod.Text = "0";
          }

          //==================================Debit Card===============================

          if (cmbPaymentMethod.Text == "Debit Card")
          {
              txtPaymentMethod.Enabled = true;
              txtPaymentMethod.Text = "";
              txtPaymentMethod.Focus();

          }

          else
          {
              txtPaymentMethod.Enabled = false;
              txtPaymentMethod.Text = "0";
          }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[23];
            itemcost[0] = Convert.ToDouble(txtFries.Text) * Price_Fries;
            itemcost[1] = Convert.ToDouble(txtSalad.Text) * Price_Salad;
            itemcost[2] = Convert.ToDouble(txtChickenBurger.Text) * Price_ChickenBurger;
            itemcost[3] = Convert.ToDouble(txtOnionRings.Text) * Price_OnionRings;
            itemcost[4] = Convert.ToDouble(txtChickenSalad.Text) * Price_ChickenSalad;
            itemcost[5] = Convert.ToDouble(txtFishSandwich.Text) * Price_FishSandwich;
            itemcost[6] = Convert.ToDouble(txtCheeseSandwich.Text) * Price_CheeseSandwich;
            itemcost[7] = Convert.ToDouble(txtChickenSandwich.Text) * Price_ChickenSandwich;
            itemcost[8] = Convert.ToDouble(txtChicken.Text) * Price_Chicken;
            itemcost[9] = Convert.ToDouble(txtHashBrown.Text) * Price_HashBrown;
            itemcost[10] = Convert.ToDouble(txtToastedBagel.Text) * Price_ToastedBagel;
            itemcost[11] = Convert.ToDouble(txtPineappleStick.Text) * Price_PineappleStick;
            itemcost[12] = Convert.ToDouble(txtChocolateMuffin.Text) * Price_ChocolateMuffin;
            itemcost[13] = Convert.ToDouble(txtPancakesSyrup.Text) * Price_PancakesSyrup;
            itemcost[14] = Convert.ToDouble(txtTea.Text) * Price_Tea;
            itemcost[15] = Convert.ToDouble(txtCola.Text) * Price_Cola;
            itemcost[16] = Convert.ToDouble(txtCoffee.Text) * Price_Coffee;
            itemcost[17] = Convert.ToDouble(txtOrange.Text) * Price_Orange;
            itemcost[18] = Convert.ToDouble(txtBottleWater.Text) * Price_BottleWater;
            itemcost[19] = Convert.ToDouble(txtVanillaCone.Text) * Price_VanillaCone;
            itemcost[20] = Convert.ToDouble(txtVanillaShake.Text) * Price_VanillaShake;
            itemcost[21] = Convert.ToDouble(txtStarwberryShake.Text) * Price_Strawberry;
            itemcost[22] = Convert.ToDouble(txtChocolateMilkShake.Text) * Price_ChocolateMilkShake;

            double cost, ichange;

            if(cmbPaymentMethod.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                    itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] +
                    itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] +
                    itemcost[19] + itemcost[20] + itemcost[21] + itemcost[22];

                lblSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lblTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lblTotal.Text = Convert.ToString(iTotal);

                ichange = Convert.ToDouble(txtPaymentMethod.Text);
                cost = ichange - (iTax + iTotal);
                lblChange.Text = Convert.ToString(cost);

                lblChange.Text = String.Format("{0:C}", cost);
            lblTax.Text = String.Format("{0:C}", iTax);
        lblSubTotal.Text = String.Format("{0:C}", iSubTotal);
                lblTotal.Text = String.Format("{0:C}", iTotal);
            }

            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                    itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] +
                    itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] +
                    itemcost[19] + itemcost[20] + itemcost[21] + itemcost[22];

                lblSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lblTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lblTotal.Text = Convert.ToString(iTotal);

                
                lblTax.Text = String.Format("{0:C}", iTax);
                lblSubTotal.Text = String.Format("{0:C}", iSubTotal);
                lblTotal.Text = String.Format("{0:C}", iTotal);
            }
            

        }

        
    }
}
