using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class CashRegister : Form
    {
        
        double hyperlightprice = 350;
        double trigger7price = 400;
        double syncprice = 300;
        double chestpadprice = 150;
        double skatesprice = 250;
        double pantsprice = 200;
        double cleartapeprice = 3.25;
        double sticktapeprice = 2.00;
        double lacesprice = 5.00;
        int numofhyperlight = 0;
        int numoftrigger7 = 0;
        int numofsync = 0;
        int numofchestpad = 0;
        int numofskates = 0;
        int numofpants = 0;
        int numofcleartape = 0;
        int numofsticktape = 0;
        int numoflaces = 0;
        double hyperlighttotal = 0;
        double trigger7total = 0;
        double synctotal = 0;
        double chestpadtotal = 0;
        double skatestotal = 0;
        double pantstotal = 0;
        double cleartapetotal = 0;
        double sticktapetotal = 0;
        double lacestotal = 0;
        double sticktotal = 0;
        double geartotal = 0;
        double extrastotal = 0;
        double subtotal = 0;
        double totalprice = 0;
        double taxrate = 0.13;
        double taxamount = 0;
        double tenderedamount = 0;
        double totalchange = 0;
        public CashRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numofhyperlight = Convert.ToInt32(hyperlightnumInput.Text);
                numoftrigger7 = Convert.ToInt32(trigger7numInput.Text);
                numofsync = Convert.ToInt32(syncnumInput.Text);
                numofchestpad = Convert.ToInt32(hyperlightnumInput.Text);
                numofskates = Convert.ToInt32(trigger7numInput.Text);
                numofpants = Convert.ToInt32(syncnumInput.Text);
                numofcleartape = Convert.ToInt32(hyperlightnumInput.Text);
                numofsticktape = Convert.ToInt32(trigger7numInput.Text);
                numoflaces = Convert.ToInt32(syncnumInput.Text);

                sticksButton.Visible = false;
                gearButton.Visible = false;
                extrasButton.Visible = false;  

                hyperlighttotal = numofhyperlight * hyperlightprice;
                trigger7total = numoftrigger7 * trigger7price;
                synctotal = numofsync * syncprice;
                chestpadtotal = numofchestpad * chestpadprice;
                skatestotal = numofskates * skatesprice;
                pantstotal = numofpants * pantsprice;
                cleartapetotal = numofcleartape * cleartapeprice;
                sticktapetotal = numofsticktape * sticktapeprice;
                lacestotal = numoflaces * lacesprice;

                subtotal = hyperlighttotal + trigger7total + synctotal + chestpadtotal + skatestotal + pantstotal + cleartapetotal + sticktapetotal + lacestotal;
                taxamount = subtotal * taxrate;
                totalprice = subtotal + taxamount;
                

                subtotalpriceOutput.Text = $"{subtotal.ToString("C")}";
                taxamountOutput.Text = $"{taxamount.ToString("C")}";
                totalpriceOutput.Text = $"{totalprice.ToString("C")}";
               

            }

            catch
            {
                subtotalpriceLabel.Text = "ERROR";
                totalpriceLabel.Text = "";
                taxamountLabel.Text = "";
                taxamountOutput.Visible = false;
                totalpriceOutput.Visible = false;
                subtotalpriceOutput.Visible = false;

            }
          
            
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                

                tenderedamount = Convert.ToDouble(tenderedamountInput.Text);

                totalchange = tenderedamount - totalprice;

                totalchangeOutput.Text = $"{totalchange.ToString("C")}";

            }
            catch
            {
                changeamountLabel.Text = "ERROR";
            }


        }

        private void printreciptTotal_Click(object sender, EventArgs e)
        {
           
            reciptOutline.Visible = true;

            //reciptburgerInput.Text = $"x{numofburgers}@ {burgertotal.ToString("C")}";
            //reciptdrinkInput.Text = $"x{numofdrinks}@ {drinktotal.ToString("C")}";
            //reciptfriesInput.Text = $"x{numoffries}@ {friestotal.ToString("C")}";
            //reciptsubtotalInput.Text = $"{subtotal.ToString("C")}";
            //recipttaxInput.Text = $"{taxamount.ToString("C")}";
            //recipttotalInput.Text = $"{totalprice.ToString("C")}";
            //recipttenderedInput.Text = $"{tenderedamount.ToString("C")}";
            //reciptchangeInput.Text = $"{totalchange.ToString("C")}";

            



        }

        private void sticksButton_Click(object sender, EventArgs e)
        {
            hyperlightnumInput.Location = new Point(728, 123);
            trigger7numInput.Location = new Point(728, 281);
            syncnumInput.Location = new Point(728, 422);
            numofpantsInput.Location = new Point(728, 4220);
            numofskatesInput.Location = new Point(728, 2810);
            numofchestpadInput.Location = new Point(728, 1230);
            numofcleartapeInput.Location = new Point(728, 1230);
            numofsticktapeInput.Location = new Point(728, 2810);
            numoflacesInput.Location = new Point(728, 4220);
            
            item1priceLabel.Text = $"{hyperlightprice.ToString("C")}";
            item2priceLabel.Text = $"{trigger7price.ToString("C")}";
            item3priceLabel.Text = $"{syncprice.ToString("C")}";
            
            this.Size = new Size(816, 615);
            
            item1Label.Text = "HyperLight";
            item2Label.Text = "Trigger7";
            item3Label.Text = "Sync";
            numofitemsLabel1.Text = "# of these you want to purchase";
            numofitemsLabel2.Text = "# of these you want to purchase";
            numofitemsLabel3.Text = "# of these you want to purchase";


        }

        private void gearButton_Click(object sender, EventArgs e)
        {
            numofpantsInput.Location = new Point(728, 422);
            numofskatesInput.Location = new Point(728, 281);
            numofchestpadInput.Location = new Point(728, 123);
            hyperlightnumInput.Location = new Point(728, 1230);
            trigger7numInput.Location = new Point(728, 2810);
            syncnumInput.Location = new Point(728, 4220);
            numofcleartapeInput.Location = new Point(728, 1230);
            numofsticktapeInput.Location = new Point(728, 2810);
            numoflacesInput.Location = new Point(728, 4220);
            item1priceLabel.Text = $"{chestpadprice.ToString("C")}";
            item2priceLabel.Text = $"{skatesprice.ToString("C")}";
            item3priceLabel.Text = $"{pantsprice.ToString("C")}";
            this.Size = new Size(816, 615);
            item1Label.Text = "Chestpad";
            item2Label.Text = "Skates";
            item3Label.Text = "Pants";
            numofitemsLabel1.Text = "# of these you want to purchase";
            numofitemsLabel2.Text = "# of these you want to purchase";
            numofitemsLabel3.Text = "# of these you want to purchase";
        }

        private void extrasButton_Click(object sender, EventArgs e)
        {
            numofcleartapeInput.Location = new Point(728, 123);
            numofsticktapeInput.Location = new Point(728, 281);
            numoflacesInput.Location = new Point(728, 422);
            hyperlightnumInput.Location = new Point(728, 1230);
            trigger7numInput.Location = new Point(728, 2810);
            syncnumInput.Location = new Point(728, 4220);
            numofpantsInput.Location = new Point(728, 4220);
            numofskatesInput.Location = new Point(728, 2810);
            numofchestpadInput.Location = new Point(728, 1230);
            item2priceLabel.Text = $"{sticktapeprice.ToString("C")}";
            item1priceLabel.Text = $"{cleartapeprice.ToString("C")}";
            item3priceLabel.Text = $"{lacesprice.ToString("C")}";
            this.Size = new Size(816, 615);
            item1Label.Text = "Clear Tape";
            item2Label.Text = "Stick Tape";
            item3Label.Text = "Laces";
            numofitemsLabel1.Text = "# of these you want to purchase";
            numofitemsLabel2.Text = "# of these you want to purchase";
            numofitemsLabel3.Text = "# of these you want to purchase";
        }

     
    }
}
