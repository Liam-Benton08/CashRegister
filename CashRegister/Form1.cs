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

//Cash Register
//Liam Benton, April 12, 2024.
//This program will run as a online store, you will be able "purchase items" then be printed a recipt.

namespace CashRegister
{
    public partial class CashRegister : Form
    {
        //Set sounds
        SoundPlayer ding = new SoundPlayer(Properties.Resources.ding);
        SoundPlayer error = new SoundPlayer(Properties.Resources.error);
        
        //Set prices for every item
        double hyperlightPrice = 350;
        double trigger7Price = 400;
        double syncPrice = 300;
        double chestPadPrice = 150;
        double skatesPrice = 250;
        double pantsPrice = 200;
        double clearTapePrice = 3.25;
        double stickTapePrice = 2.00;
        double lacesPrice = 5.00;
        int numOfHyperlight = 0;
        int numOfTrigger7 = 0;
        int numOfSync = 0;
        int numOfChestPad = 0;
        int numOfSkates = 0;
        int numOfPants = 0;
        int numOfClearTape = 0;
        int numOfStickTape = 0;
        int numOfLaces = 0;
        double hyperlightTotal = 0;
        double trigger7Total = 0;
        double syncTotal = 0;
        double chestPadTotal = 0;
        double skatesTotal = 0;
        double pantsTotal = 0;
        double clearTapeTotal = 0;
        double stickTapeTotal = 0;
        double lacesTotal = 0;
        double stickTotal = 0;
        double gearTotal = 0;
        double extrasTotal = 0;
        double subtotal = 0;
        double totalPrice = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double tenderedAmount = 0;
        double totalChange = 0;
        public CashRegister()
        {
            InitializeComponent();
        }
        private void sticksButton_Click(object sender, EventArgs e)
        {

            //Move extras onto screen and Move everything else out
            ding.Play();
            hyperlightNumInput.Location = new Point(728, 123);
            trigger7NumInput.Location = new Point(728, 281);
            syncNumInput.Location = new Point(728, 422);
            numOfPantsInput.Location = new Point(728, 4220);
            numOfSkatesInput.Location = new Point(728, 2810);
            numOfChestPadInput.Location = new Point(728, 1230);
            numOfClearTapeInput.Location = new Point(728, 1230);
            numOfStickTapeInput.Location = new Point(728, 2810);
            numOfLacesInput.Location = new Point(728, 4220);

            //Show prices on screen
            item1PriceLabel.Text = $"{hyperlightPrice.ToString("C")}";
            item2PriceLabel.Text = $"{trigger7Price.ToString("C")}";
            item3PriceLabel.Text = $"{syncPrice.ToString("C")}";

            //Increase screen size
            this.Size = new Size(816, 615);

            //Put correct writing on screen
            item1Label.Text = "HyperLight";
            item2Label.Text = "Trigger7";
            item3Label.Text = "Sync";
            numOfItemsLabel1.Text = "# of these you want to purchase";
            numOfItemsLabel2.Text = "# of these you want to purchase";
            numOfItemsLabel3.Text = "# of these you want to purchase";
        }

        private void gearButton_Click(object sender, EventArgs e)
        {
            //Move extras onto screen and Move everything else out
            ding.Play();
            numOfPantsInput.Location = new Point(728, 422);
            numOfSkatesInput.Location = new Point(728, 281);
            numOfChestPadInput.Location = new Point(728, 123);
            hyperlightNumInput.Location = new Point(728, 1230);
            trigger7NumInput.Location = new Point(728, 2810);
            syncNumInput.Location = new Point(728, 4220);
            numOfClearTapeInput.Location = new Point(728, 1230);
            numOfStickTapeInput.Location = new Point(728, 2810);
            numOfLacesInput.Location = new Point(728, 4220);

            //Show prices on screen
            item1PriceLabel.Text = $"{chestPadPrice.ToString("C")}";
            item2PriceLabel.Text = $"{skatesPrice.ToString("C")}";
            item3PriceLabel.Text = $"{pantsPrice.ToString("C")}";

            //Increase screen size
            this.Size = new Size(816, 615);

            //Put correct writing on screen
            item1Label.Text = "Chestpad";
            item2Label.Text = "Skates";
            item3Label.Text = "Pants";
            numOfItemsLabel1.Text = "# of these you want to purchase";
            numOfItemsLabel2.Text = "# of these you want to purchase";
            numOfItemsLabel3.Text = "# of these you want to purchase";
        }

        private void extrasButton_Click(object sender, EventArgs e)
        {
            //Move extras onto screen and Move everything else out
            ding.Play();
            numOfClearTapeInput.Location = new Point(728, 123);
            numOfStickTapeInput.Location = new Point(728, 281);
            numOfLacesInput.Location = new Point(728, 422);
            hyperlightNumInput.Location = new Point(728, 1230);
            trigger7NumInput.Location = new Point(728, 2810);
            syncNumInput.Location = new Point(728, 4220);
            numOfPantsInput.Location = new Point(728, 4220);
            numOfSkatesInput.Location = new Point(728, 2810);
            numOfChestPadInput.Location = new Point(728, 1230);
            
            //Show prices on screen
            item2PriceLabel.Text = $"{stickTapePrice.ToString("C")}";
            item1PriceLabel.Text = $"{clearTapePrice.ToString("C")}";
            item3PriceLabel.Text = $"{lacesPrice.ToString("C")}";
            
            //Increase screen size
            this.Size = new Size(816, 615);
            
            //Put correct writing on screen
            item1Label.Text = "Clear Tape";
            item2Label.Text = "Stick Tape";
            item3Label.Text = "Laces";
            numOfItemsLabel1.Text = "# of these you want to purchase";
            numOfItemsLabel2.Text = "# of these you want to purchase";
            numOfItemsLabel3.Text = "# of these you want to purchase";
        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            //Make error message invisible
            errorMessageLabel.Visible = false;
            errorMessage2Label.Visible = false;
            goBackButton.Location = new Point(428, 4170);
        }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            //Converting text to numbers
            ding.Play();
            numOfHyperlight = Convert.ToInt32(hyperlightNumInput.Text);
            numOfTrigger7 = Convert.ToInt32(trigger7NumInput.Text);
            numOfSync = Convert.ToInt32(syncNumInput.Text);
            numOfChestPad = Convert.ToInt32(numOfChestPadInput.Text);
            numOfSkates = Convert.ToInt32(numOfSkatesInput.Text);
            numOfPants = Convert.ToInt32(numOfPantsInput.Text);
            numOfClearTape = Convert.ToInt32(numOfClearTapeInput.Text);
            numOfStickTape = Convert.ToInt32(numOfStickTapeInput.Text);
            numOfLaces = Convert.ToInt32(numOfLacesInput.Text);

            //Make everything invisible
            hyperlightNumInput.Visible = false;
            trigger7NumInput.Visible = false;
            syncNumInput.Visible = false;
            numOfChestPadInput.Visible = false;
            numOfSkatesInput.Visible = false;
            numOfPantsInput.Visible = false;
            numOfClearTapeInput.Visible = false;
            numOfStickTapeInput.Visible = false;
            numOfLacesInput.Visible = false;
            item1Label.Visible = false;
            item2Label.Visible = false;
            item3Label.Visible = false;
            sticksButton.Visible = false;
            gearButton.Visible = false;
            extrasButton.Visible = false;
            item1PriceLabel.Visible = false;
            item2PriceLabel.Visible = false;
            item3PriceLabel.Visible = false;
            numOfItemsLabel1.Visible = false;
            numOfItemsLabel2.Visible = false;
            numOfItemsLabel3.Visible = false;
            
            //Make everything visible
            reciptOutline.Visible = true;
            preSubtotalOutput.Visible = true;
            subtotalPriceOutput.Visible = true;
            taxAmountOutput.Visible = true;
            totalPriceOutput.Visible = true;
            tenderedAmountInput.Visible = true;
            
            //Move to new locations
            continueButton.Location = new Point(1000, 1000);
            printReciptButton.Location = new Point(122, 426);

            //Change background size
            this.Size = new Size(900, 615);

            //All the multiplications 
            hyperlightTotal = numOfHyperlight * hyperlightPrice;
            trigger7Total = numOfTrigger7 * trigger7Price;
            syncTotal = numOfSync * syncPrice;
            chestPadTotal = numOfChestPad * chestPadPrice;
            skatesTotal = numOfSkates * skatesPrice;
            pantsTotal = numOfPants * pantsPrice;
            clearTapeTotal = numOfClearTape * clearTapePrice;
            stickTapeTotal = numOfStickTape * stickTapePrice;
            lacesTotal = numOfLaces * lacesPrice;
            stickTotal = hyperlightTotal + trigger7Total + syncTotal;
            gearTotal = chestPadTotal + skatesTotal + pantsTotal;
            extrasTotal = clearTapeTotal + stickTapeTotal + lacesTotal;
            subtotal = hyperlightTotal + trigger7Total + syncTotal + chestPadTotal + skatesTotal + pantsTotal + clearTapeTotal + stickTapeTotal + lacesTotal;
            taxAmount = subtotal * taxRate;
            totalPrice = subtotal + taxAmount;

            //Write all of the presubtotal texts
            preSubtotalOutput.Text = $"Hyperlights  : {numOfHyperlight}";
            preSubtotalOutput.Text += $"\nTrigger 7s   : {numOfTrigger7}";
            preSubtotalOutput.Text += $"\nSyncs        : {numOfSync}";
            preSubtotalOutput.Text += $"\nChestpads    : {numOfChestPad}";
            preSubtotalOutput.Text += $"\nSkates       : {numOfSkates}";
            preSubtotalOutput.Text += $"\nPants        : {numOfPants}";
            preSubtotalOutput.Text += $"\nClear tape   : {numOfClearTape}";
            preSubtotalOutput.Text += $"\nStick tape   : {numOfStickTape}";
            preSubtotalOutput.Text += $"\nLaces        : {numOfLaces}";
            preSubtotalOutput.Text += $"\nSticks total : {stickTotal.ToString("C")}";
            preSubtotalOutput.Text += $"\nGear total   : {gearTotal.ToString("C")}";
            preSubtotalOutput.Text += $"\nExtras total : {extrasTotal.ToString("C")}";
            preSubtotalOutput.Text += $"\nSubtotal     : {subtotal.ToString("C")}";
            preSubtotalOutput.Text += $"\nTax total    : {taxAmount.ToString("C")}";
            preSubtotalOutput.Text += $"\nTotal price  : {totalPrice.ToString("C")}";
            preSubtotalOutput.Text += $"\nTendered     :";
        }

        catch
        {
            //Put error message on screen
            errorMessageLabel.Visible = true;
            errorMessage2Label.Visible = true;
            errorMessageLabel.BringToFront();
            errorMessage2Label.BringToFront();
            goBackButton.BringToFront();
            goBackButton.Location = new Point(428, 417);
        }
    }

        private void printreciptButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connvert change
                tenderedAmount = Convert.ToDouble(tenderedAmountInput.Text);

                //Another addition
                totalChange = tenderedAmount - totalPrice;

                //Bringing recipt to screen
                reciptTextOutput.Visible = true;
                reciptTextOutput.BringToFront();

                //Print the text for the recipt
                reciptTextOutput.Text = $"----------------------------------";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n         Hockey World INC";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n----------------------------------";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Order Number 1001";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   September 5, 2008";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n----------------------------------";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Hyperlights    x{numOfHyperlight} @ {hyperlightTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Trigger7       x{numOfTrigger7} @ {trigger7Total.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Syncs          x{numOfSync} @ {syncTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Chestpad       x{numOfChestPad} @ {chestPadTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Skates         x{numOfSkates} @ {skatesTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Pants          x{numOfPants} @ {pantsTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Clear tape     x{numOfClearTape} @ {clearTapeTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Stick tape     x{numOfStickTape} @ {stickTapeTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Laces          x{numOfLaces} @ {lacesTotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n----------------------------------";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Subtotal            {subtotal.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Tax                 {taxAmount.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Total               {totalPrice.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n----------------------------------";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Tendered            {tenderedAmount.ToString("C")}";
                Thread.Sleep(250);
                Refresh();
                reciptTextOutput.Text += $"\n   Change              {totalChange.ToString("C")}";
                Refresh();

                ding.Play();

                //Move print recipt button away
                printReciptButton.Location = new Point(1000, 1000);

                //Make a new order button
                newOrderButton.Visible = true;
                newOrderButton.Enabled = true;
            }
            catch
            {
                //If something goes wrong show error screen
                errorMessageLabel.Visible = true;
                errorMessage2Label.Visible = true;
                errorMessageLabel.BringToFront();
                errorMessage2Label.BringToFront();
                goBackButton.BringToFront();
                goBackButton.Location = new Point(428, 417);
            }
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            //Reset for new order
            hyperlightTotal = 0;
            trigger7Total = 0;
            syncTotal = 0;
            chestPadTotal = 0;
            skatesTotal = 0;
            pantsTotal = 0;
            clearTapeTotal = 0;
            stickTapeTotal = 0;
            lacesTotal = 0;
            stickTotal = 0;
            gearTotal = 0;
            extrasTotal = 0;
            subtotal = 0;
            taxAmount = 0;
            totalPrice = 0;
            syncNumInput.Text = "0";
            hyperlightNumInput.Text = "0";
            trigger7NumInput.Text = "0";
            numOfChestPadInput.Text = "0";
            numOfSkatesInput.Text = "0";
            numOfPantsInput.Text = "0";
            numOfClearTapeInput.Text = "0";
            numOfStickTapeInput.Text = "0";
            numOfLacesInput.Text = "0";
            tenderedAmountInput.Text = "0";

            this.Size = new Size(476, 615);
            continueButton.Location = new Point(153, 415);

            //Make end screen invisible
            reciptTextOutput.Visible = false;
            reciptOutline.Visible = false;
            newOrderButton.Visible = false;
            newOrderButton.Enabled = false;
            preSubtotalOutput.Visible = false;
            subtotalPriceOutput.Visible = false;
            taxAmountOutput.Visible = false;
            totalPriceOutput.Visible = false;
            tenderedAmountInput.Visible = false;
           
            //Bring back the first screen
            hyperlightNumInput.Visible = true;
            trigger7NumInput.Visible = true;
            syncNumInput.Visible = true;
            numOfChestPadInput.Visible = true;
            numOfSkatesInput.Visible = true;
            numOfPantsInput.Visible = true;
            numOfClearTapeInput.Visible = true;
            numOfStickTapeInput.Visible = true;
            numOfLacesInput.Visible = true;
            item1Label.Visible = true;
            item2Label.Visible = true;
            item3Label.Visible = true;
            sticksButton.Visible = true;
            gearButton.Visible = true;
            extrasButton.Visible = true;
            item1PriceLabel.Visible = true;
            item2PriceLabel.Visible = true;
            item3PriceLabel.Visible = true;
            numOfItemsLabel1.Visible = true;
            numOfItemsLabel2.Visible = true;
            numOfItemsLabel3.Visible = true;
        }
    }
}
