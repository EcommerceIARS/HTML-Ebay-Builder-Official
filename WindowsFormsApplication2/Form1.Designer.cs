namespace WindowsFormsApplication2
{
    partial class eBayHTMLBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formHTML = new System.Windows.Forms.Button();
            this.tbHTMLTitle = new System.Windows.Forms.TextBox();
            this.LHTMLTitle = new System.Windows.Forms.Label();
            this.cProductGoodness = new System.Windows.Forms.ComboBox();
            this.LProductGoodness = new System.Windows.Forms.Label();
            this.tbListBox = new System.Windows.Forms.TextBox();
            this.LDescriptionBox = new System.Windows.Forms.Label();
            this.tbManufactor = new System.Windows.Forms.TextBox();
            this.LManufactor = new System.Windows.Forms.Label();
            this.cbHasLeasing = new System.Windows.Forms.CheckBox();
            this.cbHasWarranty = new System.Windows.Forms.CheckBox();
            this.cbHasShipping = new System.Windows.Forms.CheckBox();
            this.cbDiscountedUnit = new System.Windows.Forms.CheckBox();
            this.LModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbLeaseAmount = new System.Windows.Forms.TextBox();
            this.LLeaseAmount = new System.Windows.Forms.Label();
            this.cbCompressorWarranty = new System.Windows.Forms.CheckBox();
            this.tbCompressorWarranty = new System.Windows.Forms.TextBox();
            this.LCompYears = new System.Windows.Forms.Label();
            this.LPartsYears = new System.Windows.Forms.Label();
            this.tbPartsWarranty = new System.Windows.Forms.TextBox();
            this.cbPartsWarranty = new System.Windows.Forms.CheckBox();
            this.tbLiftRes = new System.Windows.Forms.TextBox();
            this.LLiftRes = new System.Windows.Forms.Label();
            this.cbSalesFloor = new System.Windows.Forms.CheckBox();
            this.cbSND = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // formHTML
            // 
            this.formHTML.Location = new System.Drawing.Point(447, 566);
            this.formHTML.Name = "formHTML";
            this.formHTML.Size = new System.Drawing.Size(193, 54);
            this.formHTML.TabIndex = 0;
            this.formHTML.Text = "button1";
            this.formHTML.UseVisualStyleBackColor = true;
            this.formHTML.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbHTMLTitle
            // 
            this.tbHTMLTitle.Location = new System.Drawing.Point(28, 48);
            this.tbHTMLTitle.Name = "tbHTMLTitle";
            this.tbHTMLTitle.Size = new System.Drawing.Size(508, 20);
            this.tbHTMLTitle.TabIndex = 1;
            // 
            // LHTMLTitle
            // 
            this.LHTMLTitle.AutoSize = true;
            this.LHTMLTitle.Location = new System.Drawing.Point(25, 21);
            this.LHTMLTitle.Name = "LHTMLTitle";
            this.LHTMLTitle.Size = new System.Drawing.Size(35, 13);
            this.LHTMLTitle.TabIndex = 2;
            this.LHTMLTitle.Text = "label1";
            // 
            // cProductGoodness
            // 
            this.cProductGoodness.FormattingEnabled = true;
            this.cProductGoodness.Location = new System.Drawing.Point(371, 512);
            this.cProductGoodness.Name = "cProductGoodness";
            this.cProductGoodness.Size = new System.Drawing.Size(165, 21);
            this.cProductGoodness.TabIndex = 3;
            // 
            // LProductGoodness
            // 
            this.LProductGoodness.AutoSize = true;
            this.LProductGoodness.Location = new System.Drawing.Point(309, 515);
            this.LProductGoodness.Name = "LProductGoodness";
            this.LProductGoodness.Size = new System.Drawing.Size(35, 13);
            this.LProductGoodness.TabIndex = 4;
            this.LProductGoodness.Text = "label1";
            // 
            // tbListBox
            // 
            this.tbListBox.Location = new System.Drawing.Point(28, 121);
            this.tbListBox.Multiline = true;
            this.tbListBox.Name = "tbListBox";
            this.tbListBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbListBox.Size = new System.Drawing.Size(508, 361);
            this.tbListBox.TabIndex = 2;
            // 
            // LDescriptionBox
            // 
            this.LDescriptionBox.AutoSize = true;
            this.LDescriptionBox.Location = new System.Drawing.Point(25, 92);
            this.LDescriptionBox.Name = "LDescriptionBox";
            this.LDescriptionBox.Size = new System.Drawing.Size(35, 13);
            this.LDescriptionBox.TabIndex = 6;
            this.LDescriptionBox.Text = "label1";
            // 
            // tbManufactor
            // 
            this.tbManufactor.Location = new System.Drawing.Point(122, 540);
            this.tbManufactor.Name = "tbManufactor";
            this.tbManufactor.Size = new System.Drawing.Size(97, 20);
            this.tbManufactor.TabIndex = 3;
            // 
            // LManufactor
            // 
            this.LManufactor.AutoSize = true;
            this.LManufactor.Location = new System.Drawing.Point(41, 543);
            this.LManufactor.Name = "LManufactor";
            this.LManufactor.Size = new System.Drawing.Size(35, 13);
            this.LManufactor.TabIndex = 8;
            this.LManufactor.Text = "label1";
            // 
            // cbHasLeasing
            // 
            this.cbHasLeasing.AutoSize = true;
            this.cbHasLeasing.Location = new System.Drawing.Point(572, 111);
            this.cbHasLeasing.Name = "cbHasLeasing";
            this.cbHasLeasing.Size = new System.Drawing.Size(80, 17);
            this.cbHasLeasing.TabIndex = 6;
            this.cbHasLeasing.Text = "checkBox1";
            this.cbHasLeasing.UseVisualStyleBackColor = true;
            this.cbHasLeasing.CheckedChanged += new System.EventHandler(this.cbHasLeasing_CheckedChanged);
            // 
            // cbHasWarranty
            // 
            this.cbHasWarranty.AutoSize = true;
            this.cbHasWarranty.Location = new System.Drawing.Point(572, 212);
            this.cbHasWarranty.Name = "cbHasWarranty";
            this.cbHasWarranty.Size = new System.Drawing.Size(80, 17);
            this.cbHasWarranty.TabIndex = 7;
            this.cbHasWarranty.Text = "checkBox1";
            this.cbHasWarranty.UseVisualStyleBackColor = true;
            this.cbHasWarranty.CheckedChanged += new System.EventHandler(this.cbHasWarranty_CheckedChanged);
            // 
            // cbHasShipping
            // 
            this.cbHasShipping.AutoSize = true;
            this.cbHasShipping.Location = new System.Drawing.Point(572, 370);
            this.cbHasShipping.Name = "cbHasShipping";
            this.cbHasShipping.Size = new System.Drawing.Size(80, 17);
            this.cbHasShipping.TabIndex = 8;
            this.cbHasShipping.Text = "checkBox1";
            this.cbHasShipping.UseVisualStyleBackColor = true;
            this.cbHasShipping.CheckedChanged += new System.EventHandler(this.cbHasShipping_CheckedChanged);
            // 
            // cbDiscountedUnit
            // 
            this.cbDiscountedUnit.AutoSize = true;
            this.cbDiscountedUnit.Location = new System.Drawing.Point(572, 51);
            this.cbDiscountedUnit.Name = "cbDiscountedUnit";
            this.cbDiscountedUnit.Size = new System.Drawing.Size(80, 17);
            this.cbDiscountedUnit.TabIndex = 5;
            this.cbDiscountedUnit.Text = "checkBox1";
            this.cbDiscountedUnit.UseVisualStyleBackColor = true;
            this.cbDiscountedUnit.CheckedChanged += new System.EventHandler(this.cbDiscountedUnit_CheckedChanged);
            // 
            // LModel
            // 
            this.LModel.AutoSize = true;
            this.LModel.Location = new System.Drawing.Point(42, 587);
            this.LModel.Name = "LModel";
            this.LModel.Size = new System.Drawing.Size(35, 13);
            this.LModel.TabIndex = 14;
            this.LModel.Text = "label1";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(122, 584);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(97, 20);
            this.tbModel.TabIndex = 4;
            // 
            // tbLeaseAmount
            // 
            this.tbLeaseAmount.Location = new System.Drawing.Point(671, 144);
            this.tbLeaseAmount.Name = "tbLeaseAmount";
            this.tbLeaseAmount.Size = new System.Drawing.Size(163, 20);
            this.tbLeaseAmount.TabIndex = 15;
            // 
            // LLeaseAmount
            // 
            this.LLeaseAmount.AutoSize = true;
            this.LLeaseAmount.Location = new System.Drawing.Point(580, 147);
            this.LLeaseAmount.Name = "LLeaseAmount";
            this.LLeaseAmount.Size = new System.Drawing.Size(35, 13);
            this.LLeaseAmount.TabIndex = 16;
            this.LLeaseAmount.Text = "label1";
            // 
            // cbCompressorWarranty
            // 
            this.cbCompressorWarranty.AutoSize = true;
            this.cbCompressorWarranty.Location = new System.Drawing.Point(618, 240);
            this.cbCompressorWarranty.Name = "cbCompressorWarranty";
            this.cbCompressorWarranty.Size = new System.Drawing.Size(80, 17);
            this.cbCompressorWarranty.TabIndex = 17;
            this.cbCompressorWarranty.Text = "checkBox1";
            this.cbCompressorWarranty.UseVisualStyleBackColor = true;
            this.cbCompressorWarranty.CheckedChanged += new System.EventHandler(this.cbCompressorWarranty_CheckedChanged);
            // 
            // tbCompressorWarranty
            // 
            this.tbCompressorWarranty.Location = new System.Drawing.Point(659, 263);
            this.tbCompressorWarranty.Name = "tbCompressorWarranty";
            this.tbCompressorWarranty.Size = new System.Drawing.Size(73, 20);
            this.tbCompressorWarranty.TabIndex = 18;
            // 
            // LCompYears
            // 
            this.LCompYears.AutoSize = true;
            this.LCompYears.Location = new System.Drawing.Point(738, 266);
            this.LCompYears.Name = "LCompYears";
            this.LCompYears.Size = new System.Drawing.Size(35, 13);
            this.LCompYears.TabIndex = 19;
            this.LCompYears.Text = "label1";
            // 
            // LPartsYears
            // 
            this.LPartsYears.AutoSize = true;
            this.LPartsYears.Location = new System.Drawing.Point(738, 327);
            this.LPartsYears.Name = "LPartsYears";
            this.LPartsYears.Size = new System.Drawing.Size(35, 13);
            this.LPartsYears.TabIndex = 22;
            this.LPartsYears.Text = "label1";
            // 
            // tbPartsWarranty
            // 
            this.tbPartsWarranty.Location = new System.Drawing.Point(659, 324);
            this.tbPartsWarranty.Name = "tbPartsWarranty";
            this.tbPartsWarranty.Size = new System.Drawing.Size(73, 20);
            this.tbPartsWarranty.TabIndex = 21;
            // 
            // cbPartsWarranty
            // 
            this.cbPartsWarranty.AutoSize = true;
            this.cbPartsWarranty.Location = new System.Drawing.Point(618, 301);
            this.cbPartsWarranty.Name = "cbPartsWarranty";
            this.cbPartsWarranty.Size = new System.Drawing.Size(80, 17);
            this.cbPartsWarranty.TabIndex = 20;
            this.cbPartsWarranty.Text = "checkBox1";
            this.cbPartsWarranty.UseVisualStyleBackColor = true;
            this.cbPartsWarranty.CheckedChanged += new System.EventHandler(this.cbPartsWaaranty_CheckedChanged);
            // 
            // tbLiftRes
            // 
            this.tbLiftRes.Location = new System.Drawing.Point(618, 393);
            this.tbLiftRes.Name = "tbLiftRes";
            this.tbLiftRes.Size = new System.Drawing.Size(73, 20);
            this.tbLiftRes.TabIndex = 23;
            // 
            // LLiftRes
            // 
            this.LLiftRes.AutoSize = true;
            this.LLiftRes.Location = new System.Drawing.Point(697, 396);
            this.LLiftRes.Name = "LLiftRes";
            this.LLiftRes.Size = new System.Drawing.Size(35, 13);
            this.LLiftRes.TabIndex = 24;
            this.LLiftRes.Text = "label1";
            // 
            // cbSalesFloor
            // 
            this.cbSalesFloor.AutoSize = true;
            this.cbSalesFloor.Location = new System.Drawing.Point(618, 74);
            this.cbSalesFloor.Name = "cbSalesFloor";
            this.cbSalesFloor.Size = new System.Drawing.Size(80, 17);
            this.cbSalesFloor.TabIndex = 25;
            this.cbSalesFloor.Text = "checkBox1";
            this.cbSalesFloor.UseVisualStyleBackColor = true;
            this.cbSalesFloor.CheckedChanged += new System.EventHandler(this.cbSalesFloor_CheckedChanged);
            // 
            // cbSND
            // 
            this.cbSND.AutoSize = true;
            this.cbSND.Location = new System.Drawing.Point(723, 74);
            this.cbSND.Name = "cbSND";
            this.cbSND.Size = new System.Drawing.Size(80, 17);
            this.cbSND.TabIndex = 26;
            this.cbSND.Text = "checkBox1";
            this.cbSND.UseVisualStyleBackColor = true;
            this.cbSND.CheckedChanged += new System.EventHandler(this.cbSND_CheckedChanged);
            // 
            // eBayHTMLBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 643);
            this.Controls.Add(this.cbSND);
            this.Controls.Add(this.cbSalesFloor);
            this.Controls.Add(this.LLiftRes);
            this.Controls.Add(this.tbLiftRes);
            this.Controls.Add(this.LPartsYears);
            this.Controls.Add(this.tbPartsWarranty);
            this.Controls.Add(this.cbPartsWarranty);
            this.Controls.Add(this.LCompYears);
            this.Controls.Add(this.tbCompressorWarranty);
            this.Controls.Add(this.cbCompressorWarranty);
            this.Controls.Add(this.LLeaseAmount);
            this.Controls.Add(this.tbLeaseAmount);
            this.Controls.Add(this.LModel);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.cbDiscountedUnit);
            this.Controls.Add(this.cbHasShipping);
            this.Controls.Add(this.cbHasWarranty);
            this.Controls.Add(this.cbHasLeasing);
            this.Controls.Add(this.LManufactor);
            this.Controls.Add(this.tbManufactor);
            this.Controls.Add(this.LDescriptionBox);
            this.Controls.Add(this.tbListBox);
            this.Controls.Add(this.LProductGoodness);
            this.Controls.Add(this.cProductGoodness);
            this.Controls.Add(this.LHTMLTitle);
            this.Controls.Add(this.tbHTMLTitle);
            this.Controls.Add(this.formHTML);
            this.Name = "eBayHTMLBuilder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formHTML;
        private System.Windows.Forms.TextBox tbHTMLTitle;
        private System.Windows.Forms.Label LHTMLTitle;
        private System.Windows.Forms.ComboBox cProductGoodness;
        private System.Windows.Forms.Label LProductGoodness;
        private System.Windows.Forms.TextBox tbListBox;
        private System.Windows.Forms.Label LDescriptionBox;
        private System.Windows.Forms.TextBox tbManufactor;
        private System.Windows.Forms.Label LManufactor;
        private System.Windows.Forms.CheckBox cbHasLeasing;
        private System.Windows.Forms.CheckBox cbHasWarranty;
        private System.Windows.Forms.CheckBox cbHasShipping;
        private System.Windows.Forms.CheckBox cbDiscountedUnit;
        private System.Windows.Forms.Label LModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbLeaseAmount;
        private System.Windows.Forms.Label LLeaseAmount;
        private System.Windows.Forms.CheckBox cbCompressorWarranty;
        private System.Windows.Forms.TextBox tbCompressorWarranty;
        private System.Windows.Forms.Label LCompYears;
        private System.Windows.Forms.Label LPartsYears;
        private System.Windows.Forms.TextBox tbPartsWarranty;
        private System.Windows.Forms.CheckBox cbPartsWarranty;
        private System.Windows.Forms.TextBox tbLiftRes;
        private System.Windows.Forms.Label LLiftRes;
        private System.Windows.Forms.CheckBox cbSalesFloor;
        private System.Windows.Forms.CheckBox cbSND;
    }
}

