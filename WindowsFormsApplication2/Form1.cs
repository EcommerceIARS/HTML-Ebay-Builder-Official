using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class eBayHTMLBuilder : Form
    {
        private FileStream oFile;
        private StreamWriter oFileStream;
        private String sTitle;
        private String sFolderPath;
        private String sWebPath;
        private String googleAPIKey = "AIzaSyCfZ3iSlDmSwhgtEdcsbzBpHx - FZwwvRJI";

        public eBayHTMLBuilder()
        {
            
            InitializeComponent();
            this.Text = "eBay HTML Builder v1";

            formHTML.Text = "form HTML";
            LHTMLTitle.Text = "Title";

            LProductGoodness.Text = "Type";
            cProductGoodness.Items.Add("Good");
            cProductGoodness.Items.Add("Better");
            cProductGoodness.Items.Add("Best");

            LDescriptionBox.Text = "Description";

            LManufactor.Text = "Manufacturer";
            LModel.Text = "Model #";

            LLeaseAmount.Text = "Lease Amount:";
            tbLeaseAmount.Enabled = false;
            LLeaseAmount.Enabled = false;

            cbDiscountedUnit.Text = "Discounted Unit";
            cbHasLeasing.Text = "Lease This Item";
            cbHasShipping.Text = "Big Equipment";

            cbHasWarranty.Text = "Does this Item Have Warranty";

            cbPartsWarranty.Text = "Parts and Labor Warranty";
            cbPartsWarranty.Enabled = false;
            tbPartsWarranty.Enabled = false;
            LPartsYears.Text = "Years";
            LPartsYears.Enabled = false;

            cbCompressorWarranty.Text = "Compressor Warranty";
            cbCompressorWarranty.Enabled = false;
            tbCompressorWarranty.Enabled = false;
            LCompYears.Text = "Years";
            LCompYears.Enabled = false;

            tbLiftRes.Enabled = false;
            LLiftRes.Text = "LiftGate/Residental Fee";
            LLiftRes.Enabled = false;

            cbSalesFloor.Text = "Sales Floor";
            cbSalesFloor.Enabled = false;
            cbSND.Text = "Scratch and Dent";
            cbSND.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sTitle = tbHTMLTitle.Text;
            sFolderPath = tbManufactor.Text + @"\" + tbModel.Text + @"\" + tbModel.Text + @".html";
            sWebPath = tbManufactor.Text + @"/" + tbModel.Text + @"/" + tbModel.Text;

            if (File.Exists(@"D:\Data\Shared\Ecommerce\WebData" + sFolderPath))
            {
                File.Delete(@"D:\Data\Shared\Ecommerce\WebData" + sFolderPath);
            }
            if (Directory.Exists(@"D:\Data\Shared\Ecommerce\WebData" + tbManufactor.Text + @"\" + tbModel.Text))
            {
                oFile = File.Create(@"D:\Data\Shared\Ecommerce\WebData" + sFolderPath);
                oFile.Close();
            }
            else
            {
                Directory.CreateDirectory(@"D:\Data\Shared\Ecommerce\WebData" + tbManufactor.Text + @"\" + tbModel.Text);
                oFile = File.Create(@"D:\Data\Shared\Ecommerce\WebData" + sFolderPath);
                oFile.Close();
            }
            oFileStream = new StreamWriter(oFile.Name);

            makeTXT();

            Process.Start("Notepad.exe", oFile.Name);
        }

        private void makeTXT()
        {
            oFileStream.WriteLine(@"<style>");
            oFileStream.WriteLine(@".divisionTitle{");
            oFileStream.WriteLine(@"bacground-color: black;");
            oFileStream.WriteLine(@"width: 900px;");
            oFileStream.WriteLine(@"height: 285px;");
            oFileStream.WriteLine(@"text-align: center;");
            oFileStream.WriteLine("font-family: \"Arial Black\"");
            oFileStream.WriteLine(@"font-size: 30px;");
            oFileStream.WriteLine(@"color: Navy;       }");

            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@".Picture{
float:left;
font-family: ""Arial Black"";
text - align: center;
 width: 167px;
height: 528px;
}");

        oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@".footer{
text-align: center;
float:left;
width: 900px;
height: 150px;
background-color: white;
}");

            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@".Description{
float:left;
width: 800px;
font - size: 18;
 background - color: snow;
}");

            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@"</style>");

            oFileStream.WriteLine(@"<!-- Icesystems graphic header with link-->
<!-- item details-->
<div class=""divisionTitle"">
<a href=""http://stores.ebay.com/Ice-and-Refrigeration-Systems""><img alt=""Ice &amp; Refrigeration Systems, LLC"" src=""http://iceandrefrigerationsystems.com/ebay/logo-ebay.jpg"" border =""0"" width = ""900""></a>");

            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(tbHTMLTitle.Text);

            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@"</div>");

            oFileStream.WriteLine(@"");
            oFileStream.WriteLine(@"");
            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@"<div class=""Picture"">");
            oFileStream.WriteLine(@"<img src=""https://a094914241160d8d42f3b1713dd0e1c3ab90a99f-www.googledrive.com/host/0ByMHVEFCTiK3fjJZQnhRaW1Uay1rcHNZaktSR09EYnFZa1ozWE5jQ2t0NExEVkpVNDIyQlE/" + sWebPath + @".jpg"" alt=" + tbHTMLTitle.Text + "></img>");

            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@"<img src=""https://a094914241160d8d42f3b1713dd0e1c3ab90a99f-www.googledrive.com/host/0ByMHVEFCTiK3fjJZQnhRaW1Uay1rcHNZaktSR09EYnFZa1ozWE5jQ2t0NExEVkpVNDIyQlE/logo%20and%20watermark/shipping2.JPG"" alt=""Title Here""></img>");

            oFileStream.WriteLine(@"</div");

            oFileStream.WriteLine(@"");
            oFileStream.WriteLine(@"");

            oFileStream.WriteLine(@"<div class=""Description"">
<br>
<ul>");

            if (cbDiscountedUnit.Checked)
            {
                oFileStream.WriteLine(@"<li>Model: " + tbModel.Text + @" **Discounted Model**</li>");
                oFileStream.WriteLine(@"<li>Tested by a Certified Licensed Technician and runs great</li>");

                if (cbSalesFloor.Checked)
                {
                    oFileStream.WriteLine(@"<li>New Out of Box, Has No Damage</li>");
                }
                else if (cbSND.Checked)
                {
                    oFileStream.WriteLine(@"<li>New Out of Box, Has Minor Scratch and Dings</li>");
                }
            }
            else
            {
                oFileStream.WriteLine(@"<li>Model: " + tbModel.Text + @"</li>");
            }
            
            foreach (String sline in tbListBox.Lines)
            {
                if (sline != "")
                oFileStream.WriteLine(@"<li>" + sline + @"</li>");
            }

            

            if (cbHasShipping.Checked)
            {
                oFileStream.WriteLine(@"<li><b>Free Shipping is to a Commercial Address, Add $" + tbLiftRes.Text + @" for Residental Delivery, Add $" + tbLiftRes.Text + @" for Lift Gate Services</b>");
                oFileStream.WriteLine(@"<br><font size=""2"">*FREE SHIPPING IS ONLY AVAILABLE IN THE 48 CONTIGUOUS STATES<br></font></li>");
            }

            if (cbHasWarranty.Checked)
            {
                oFileStream.WriteLine(@"<li><b>");
                if (cbPartsWarranty.Checked)
                {
                    oFileStream.WriteLine( tbPartsWarranty.Text + @"YEAR(S) ALL PARTS AND LABOR");
                    if (cbCompressorWarranty.Checked)
                    {
                        oFileStream.WriteLine( @"/");
                    }
                }
                if (cbCompressorWarranty.Checked)
                {
                    oFileStream.WriteLine(tbCompressorWarranty.Text + @"YEAR(S) COMPRESSOR ");
                }
                oFileStream.WriteLine(@"WARRANTY</b><br> for full warranty details please call customer support at 817-888-3056</li>");
            }

            oFileStream.WriteLine(@"<br></ul>");

            if (cbHasLeasing.Checked)
            {
                oFileStream.WriteLine(@"<!--  LEASE Amount!! -->");
                oFileStream.WriteLine(@"<div style=""text-indent:140px""> **Lease this product for <span style=""color:red; font-size:22"" >" + tbLeaseAmount.Text + @" </span> a month**<p> </div>");
            }

            oFileStream.WriteLine(@"");
            oFileStream.WriteLine(@"</div>");

            oFileStream.WriteLine(@"<div class=""footer"">
<table align=""center"">
	<tr>
		<td>
			<img src=""http://iceandrefrigerationsystems.com/ebay/images/" + cProductGoodness.Text + @".png"" width=""150"" height=""150"">
		</td>
		<td>
			<font size=""5"" color=""#002cfd"">LOWEST PRICE GUARANTEE <br></font>
			<font size=""5"" color=""#fb0034""><strong>ASK ABOUT NEW, USED AND LEASE PRODUCTS</strong></font><br>
		</td>
	</tr>
</table>
</div>
");

            oFileStream.Close();


        }

        private void cbHasLeasing_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHasLeasing.Checked)
            {
                tbLeaseAmount.Enabled = true;
                LLeaseAmount.Enabled = true;
            }
            else
            {
                tbLeaseAmount.Enabled = false;
                LLeaseAmount.Enabled = false;
            }
        }

        private void cbHasWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHasWarranty.Checked)
            {
                cbPartsWarranty.Enabled = true;
                cbCompressorWarranty.Enabled = true;
                
            }
            else
            {
                cbPartsWarranty.Enabled = false;
                cbCompressorWarranty.Enabled = false;
                cbCompressorWarranty.Checked = false;
                cbPartsWarranty.Checked = false;
            }
        }

        private void cbCompressorWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCompressorWarranty.Checked & cbCompressorWarranty.Enabled)
            {
                LCompYears.Enabled = true;
                tbCompressorWarranty.Enabled = true;
            }
            else
            {
                LCompYears.Enabled = false;
                tbCompressorWarranty.Enabled = false;
            }
        }

        private void cbPartsWaaranty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPartsWarranty.Checked & cbPartsWarranty.Enabled)
            {
                LPartsYears.Enabled = true;
                tbPartsWarranty.Enabled = true;
            }
            else
            {
                LPartsYears.Enabled = false;
                tbPartsWarranty.Enabled = false;
            }
        }

        private void cbHasShipping_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHasShipping.Checked)
            {
                LLiftRes.Enabled = true;
                tbLiftRes.Enabled = true;
            }
            else
            {
                LLiftRes.Enabled = false;
                tbLiftRes.Enabled = false;
            }
        }

        private void cbDiscountedUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDiscountedUnit.Checked)
            {
                cbSND.Enabled = true;
                cbSalesFloor.Enabled = true;
            }
            else
            {
                cbSalesFloor.Checked = false;
                cbSND.Checked = false;
                cbSND.Enabled = false;
                cbSalesFloor.Enabled = false;
                
            }
        }

        private void cbSalesFloor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSalesFloor.Checked)
            {
                cbSND.Enabled = false;
            }
            else
            {
                cbSND.Enabled = true;
            }
        }

        private void cbSND_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSND.Checked)
            {
                cbSalesFloor.Enabled = false;
            }
            else
            {
                cbSalesFloor.Enabled = true;
            }
        }
    }
}
