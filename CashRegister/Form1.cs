using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CashRegister
{
    public partial class CashRegister : Form
    {
        SoundPlayer ding = new SoundPlayer(Properties.Resources.ding);
        SoundPlayer error = new SoundPlayer(Properties.Resources.error);
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

       

        private void sticksButton_Click(object sender, EventArgs e)
        {
            ding.Play();
           
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

            ding.Play();
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

            ding.Play();
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

        private void gobackButton_Click(object sender, EventArgs e)
        {
            errormessageLabel.Visible = false;
            errormessage2Label.Visible = false;
            gobackButton.Location = new Point(428, 4170);
        }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            ding.Play();
            numofhyperlight = Convert.ToInt32(hyperlightnumInput.Text);
            numoftrigger7 = Convert.ToInt32(trigger7numInput.Text);
            numofsync = Convert.ToInt32(syncnumInput.Text);
            numofchestpad = Convert.ToInt32(numofchestpadInput.Text);
            numofskates = Convert.ToInt32(numofskatesInput.Text);
            numofpants = Convert.ToInt32(numofpantsInput.Text);
            numofcleartape = Convert.ToInt32(numofcleartapeInput.Text);
            numofsticktape = Convert.ToInt32(numofsticktapeInput.Text);
            numoflaces = Convert.ToInt32(numoflacesInput.Text);


            hyperlightnumInput.Visible = false;
            trigger7numInput.Visible = false;
            syncnumInput.Visible = false;
            numofchestpadInput.Visible = false;
            numofskatesInput.Visible = false;
            numofpantsInput.Visible = false;
            numofcleartapeInput.Visible = false;
            numofsticktapeInput.Visible = false;
            numoflacesInput.Visible = false;
            item1Label.Visible = false;
            item2Label.Visible = false;
            item3Label.Visible = false;
            sticksButton.Visible = false;
            gearButton.Visible = false;
            extrasButton.Visible = false;
            item1priceLabel.Visible = false;
            item2priceLabel.Visible = false;
            item3priceLabel.Visible = false;
            numofitemsLabel1.Visible = false;
            numofitemsLabel2.Visible = false;
            numofitemsLabel3.Visible = false;

            reciptOutline.Visible = true;
            presubtotalOutput.Visible = true;
            subtotalpriceOutput.Visible = true;
            taxamountOutput.Visible = true;
            totalpriceOutput.Visible = true;
            tenderedamountInput.Visible = true;

            continueButton.Location = new Point(1000, 1000);
            printreciptButton.Location = new Point(122, 426);

            this.Size = new Size(900, 615);




            hyperlighttotal = numofhyperlight * hyperlightprice;
            trigger7total = numoftrigger7 * trigger7price;
            synctotal = numofsync * syncprice;
            chestpadtotal = numofchestpad * chestpadprice;
            skatestotal = numofskates * skatesprice;
            pantstotal = numofpants * pantsprice;
            cleartapetotal = numofcleartape * cleartapeprice;
            sticktapetotal = numofsticktape * sticktapeprice;
            lacestotal = numoflaces * lacesprice;
            sticktotal = hyperlighttotal + trigger7total + synctotal;
            geartotal = chestpadtotal + skatestotal + pantstotal;
            extrastotal = cleartapetotal + sticktapetotal + lacestotal;


            subtotal = hyperlighttotal + trigger7total + synctotal + chestpadtotal + skatestotal + pantstotal + cleartapetotal + sticktapetotal + lacestotal;
            taxamount = subtotal * taxrate;
            totalprice = subtotal + taxamount;




            presubtotalOutput.Text = $"Hyperlights : {numofhyperlight}";
            presubtotalOutput.Text += $"\nTrigger 7s : {numoftrigger7}";
            presubtotalOutput.Text += $"\nSyncs : {numofsync}";
            presubtotalOutput.Text += $"\nChestpads : {numofchestpad}";
            presubtotalOutput.Text += $"\nSkates : {numofskates}";
            presubtotalOutput.Text += $"\nPants : {numofpants}";
            presubtotalOutput.Text += $"\nClear tape : {numofcleartape}";
            presubtotalOutput.Text += $"\nStick tape : {numofsticktape}";
            presubtotalOutput.Text += $"\nLaces : {numoflaces}";
            presubtotalOutput.Text += $"\nSticks total : {sticktotal.ToString("C")}";
            presubtotalOutput.Text += $"\nGear total : {geartotal.ToString("C")}";
            presubtotalOutput.Text += $"\nExtras total : {extrastotal.ToString("C")}";
            presubtotalOutput.Text += $"\nSubtotal : {subtotal.ToString("C")}";
            presubtotalOutput.Text += $"\nTax total : {taxamount.ToString("C")}";
            presubtotalOutput.Text += $"\nTotal price : {totalprice.ToString("C")}";
            presubtotalOutput.Text += $"\nTendered :";



        }

        catch
        {
            errormessageLabel.Visible = true;
            errormessage2Label.Visible = true;
            errormessageLabel.BringToFront();
            errormessage2Label.BringToFront();
            gobackButton.BringToFront();
            gobackButton.Location = new Point(428, 417);


        }

    }

        private void printreciptButton_Click(object sender, EventArgs e)
        {
            try
            {

                tenderedamount = Convert.ToDouble(tenderedamountInput.Text);

                totalchange = tenderedamount - totalprice;

                recipttextOutput.Visible = true;
                recipttextOutput.BringToFront();

                recipttextOutput.Text = $"-------------------------------------------------------------";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n                   Hockey World INC";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n-------------------------------------------------------------";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Order Number 1001";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     September 5, 2008";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n-------------------------------------------------------------";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Hyperlights      x{numofhyperlight} @ {hyperlighttotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Trigger7           x{numoftrigger7} @ {trigger7total.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Syncs               x{numofsync} @ {synctotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Chestpad        x{numofchestpad} @ {chestpadtotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Skates            x{numofskates} @ {skatestotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Pants              x{numofpants} @ {pantstotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Clear tape       x{numofcleartape} @ {cleartapetotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Stick tape       x{numofsticktape} @ {sticktapetotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Laces              x{numoflaces} @ {lacestotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n-------------------------------------------------------------";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Subtotal                     {subtotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Tax                             {taxamount.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Total                           {totalprice.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n-------------------------------------------------------------";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Tendered                   {tenderedamount.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                recipttextOutput.Text += $"\n     Change                      {totalchange.ToString("C")}";
                Refresh();

                ding.Play();
               
                printreciptButton.Location = new Point(1000, 1000);

                neworderButton.Visible = true;
                neworderButton.Enabled = true;
                
                

                
            }
            catch
            {
                errormessageLabel.Visible = true;
                errormessage2Label.Visible = true;
                errormessageLabel.BringToFront();
                errormessage2Label.BringToFront();
                gobackButton.BringToFront();
                gobackButton.Location = new Point(428, 417);
            }



        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            hyperlighttotal = 0;
            trigger7total = 0;
            synctotal = 0;
            chestpadtotal = 0;
            skatestotal = 0;
            pantstotal = 0;
            cleartapetotal = 0;
            sticktapetotal = 0;
            lacestotal = 0;
            sticktotal = 0;
            geartotal = 0;
            extrastotal = 0;
            subtotal = 0;
            taxamount = 0;
            totalprice = 0;

            this.Size = new Size(476, 615);
            continueButton.Location = new Point(153, 415);

            recipttextOutput.Visible = false;
            reciptOutline.Visible = false;
            neworderButton.Visible = false;
            neworderButton.Enabled = false;
            presubtotalOutput.Visible = false;
            subtotalpriceOutput.Visible = false;
            taxamountOutput.Visible = false;
            totalpriceOutput.Visible = false;
            tenderedamountInput.Visible = false;
           
            hyperlightnumInput.Visible = true;
            trigger7numInput.Visible = true;
            syncnumInput.Visible = true;
            numofchestpadInput.Visible = true;
            numofskatesInput.Visible = true;
            numofpantsInput.Visible = true;
            numofcleartapeInput.Visible = true;
            numofsticktapeInput.Visible = true;
            numoflacesInput.Visible = true;
            item1Label.Visible = true;
            item2Label.Visible = true;
            item3Label.Visible = true;
            sticksButton.Visible = true;
            gearButton.Visible = true;
            extrasButton.Visible = true;
            item1priceLabel.Visible = true;
            item2priceLabel.Visible = true;
            item3priceLabel.Visible = true;
            numofitemsLabel1.Visible = true;
            numofitemsLabel2.Visible = true;
            numofitemsLabel3.Visible = true;

            syncnumInput.Text = "0";
            hyperlightnumInput.Text = "0";
            trigger7numInput.Text = "0";
            numofchestpadInput.Text = "0";
            numofskatesInput.Text = "0";
            numofpantsInput.Text = "0";
            numofcleartapeInput.Text = "0";
            numofsticktapeInput.Text = "0";
            numoflacesInput.Text = "0";
            tenderedamountInput.Text = "0";




        }
    }
}
