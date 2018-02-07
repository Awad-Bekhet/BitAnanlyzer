using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitAnalyzer
{
    public partial class Form1 : Form
    {
        //const Byte NumberOfBits = 64;
        //const Byte BitsPerRow = 32;
        //private System.Windows.Forms.Label[] BitsArray = new Label[NumberOfBits];
        private bool IsHexChangeIsLastEdit = true;
        private const UInt64 Max64Bit = 18446744073709551615;
        private const UInt32 Max32Bit = 4294967295;

        public Form1()
        {
            InitializeComponent();
            /*
            int SizeW = (this.PanelBits.Width / BitsPerRow)  + 2; 
            int SizeH = (this.PanelBits.Height / 2) + 2; 

            int PosXB = this.PanelBits.Width - SizeW;
            int PosYB = this.PanelBits.Height - SizeH;

            int PosXH = this.PanelBits.Width - SizeW;
            int PosYH = this.PanelBits.Height - SizeH;

            Color[] BitsColors = { Color.Gainsboro, Color.Silver, Color.PeachPuff, Color.LightSalmon };
            int colorindex = -1;
            
            for (int Bitscounter = 0; Bitscounter < NumberOfBits; Bitscounter++)
            {
                BitsArray[Bitscounter] = new Label();

                BitsArray[Bitscounter].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                BitsArray[Bitscounter].Location = new System.Drawing.Point(PosXB, PosYB);
                BitsArray[Bitscounter].Size = new System.Drawing.Size(SizeW, SizeH);

                if (Bitscounter % 4 == 0)
                {
                    colorindex++;
                    if (colorindex == 4)
                    {
                        colorindex = 0;
                    }
                }
                BitsArray[Bitscounter].BackColor = BitsColors[colorindex];


                BitsArray[Bitscounter].AutoSize = false;
                BitsArray[Bitscounter].Name = "Bit" + Bitscounter.ToString("00");
                BitsArray[Bitscounter].Text = "0";
                BitsArray[Bitscounter].TextAlign = ContentAlignment.MiddleCenter;
                BitsArray[Bitscounter].TabStop = false;
                BitsArray[Bitscounter].BringToFront();
                BitsArray[Bitscounter].Click += new System.EventHandler(this.Bits_Click);

                this.PanelBits.Controls.Add(BitsArray[Bitscounter]);
                PosXB -= SizeW - 1;
                if (Bitscounter == 31)
                {
                    PosXB = this.PanelBits.Width - SizeW;
                    PosYB -= SizeH;
                }
            }
            */
            
            foreach (var PanelControl in this.PanelBits.Controls)
            {
                switch (PanelControl.GetType().ToString())
	            {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)PanelControl).Text = "0";
                        ((TextBox)PanelControl).Enabled = false;
                        ((TextBox)PanelControl).TextChanged += new System.EventHandler(this.NibbleX_TextChanged);
                        break;
                    case "System.Windows.Forms.Label":
                        if(true == ((Label)PanelControl).Name.StartsWith("Bit"))
                        {
                            ((Label)PanelControl).Text = "0";
                            ((Label)PanelControl).Click += new System.EventHandler(this.BitX_Click);
                        }
                        break;
		            default:
                        break;
	            }
            }
        }

        private void BitX_Click(object sender, EventArgs e)
        {
            Label labelSettings = sender as Label;
            TextBox NibbleCntrl = null;
            Byte BitNumber = Byte.Parse(labelSettings.Name.Substring(("Bit").Length));
            Byte NibbleValue;

            foreach (var Cont in this.PanelBits.Controls.OfType<TextBox>())
            {
                if ("Nibble" + (BitNumber / 4).ToString("00") == Cont.Name)
                {
                    NibbleCntrl = Cont;
                    break;
                }
            }
            
            NibbleValue = Byte.Parse(NibbleCntrl.Text, System.Globalization.NumberStyles.HexNumber);
            
            if("0" == labelSettings.Text)
            {
                NibbleValue += Byte.Parse((1 << (BitNumber % 4)).ToString());
                labelSettings.Text = "1";
            }
            else
            {
                NibbleValue -= Byte.Parse((1 << (BitNumber % 4)).ToString());
                labelSettings.Text = "0";
            }

            NibbleCntrl.Text = NibbleValue.ToString("X1");

            UInt64 HexValue = 0;

            foreach (var Cont in this.PanelBits.Controls.OfType<TextBox>())
            {
                HexValue += UInt64.Parse(Cont.Text, System.Globalization.NumberStyles.HexNumber) <<
                        (Byte.Parse(Cont.Name.Substring(("Nibble").Length)) * 4);
            }

            tbHexValue.Text = HexValue.ToString("X16");
            tbDecimalValue.Text = HexValue.ToString();
        }

        private void tbXValue_TextChanged(object sender, EventArgs e)
        {
            TextBox TextBoxSetting = sender as TextBox;
            String regexPattern = "";
            System.Globalization.NumberStyles style;
            if (TextBoxSetting.Name == "tbHexValue")
            {
                this.IsHexChangeIsLastEdit = true;
                regexPattern = @"\A\b[0-9a-fA-F]+\b\Z";
                style = System.Globalization.NumberStyles.HexNumber;
            }
            else
            {
                this.IsHexChangeIsLastEdit = false;
                regexPattern = @"\A\b[0-9]+\b\Z";
                style = System.Globalization.NumberStyles.Integer;
            }

            if (false == String.IsNullOrEmpty(TextBoxSetting.Text))
            {
                bool TrimLastDigit = false;
                if (false == System.Text.RegularExpressions.Regex.IsMatch(TextBoxSetting.Text, regexPattern))
                {
                    MessageBox.Show("Only allowed characters could be used.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TrimLastDigit = true;
                }
                else
                {
                    try
                    {
                        UInt64.Parse(TextBoxSetting.Text, style);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Value is out of 64Bit range.", "Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TrimLastDigit = true;
                    }
                }

                if (true == TrimLastDigit)
                {
                    TextBoxSetting.Text = TextBoxSetting.Text.Remove(TextBoxSetting.Text.Length - 1);
                    TextBoxSetting.SelectionStart = TextBoxSetting.Text.Length;
                    TextBoxSetting.SelectionLength = 0;
                }
            }
        }
        
        private void tbHexValue_Leave(object sender, EventArgs e)
        {
            if (true == String.IsNullOrEmpty(tbHexValue.Text))
            {
                tbHexValue.Text = (0).ToString("X16");
            }
        }

        private void tbDecimalValue_Leave(object sender, EventArgs e)
        {
            if (true == String.IsNullOrEmpty(tbDecimalValue.Text))
            {
                tbDecimalValue.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            /*reset all fields to 0s*/
            foreach (var PanelControl in this.PanelBits.Controls)
            {
                switch (PanelControl.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)PanelControl).Text = "0";
                        break;
                    case "System.Windows.Forms.Label":
                        if (true == ((Label)PanelControl).Name.StartsWith("Bit"))
                        {
                            ((Label)PanelControl).Text = "0";
                        }
                        break;
                    default:
                        break;
                }
            }
            tbHexValue.Text = (0).ToString("X16");
            tbDecimalValue.Text = "0";
        }

        private void NibbleX_TextChanged(object sender, EventArgs e)
        {
            TextBox source = sender as TextBox;
            Byte sourceValue = Byte.Parse(source.Text, System.Globalization.NumberStyles.HexNumber);
            Byte nibbleNumber = Byte.Parse(source.Name.Substring("Nibble".Length));
            /*Update bitfields relative to nibble number*/
            Bit[(nibbleNumber * 4) + 0].Text = ((sourceValue >> 0) & 0x1).ToString();
            Bit[(nibbleNumber * 4) + 1].Text = ((sourceValue >> 1) & 0x1).ToString();
            Bit[(nibbleNumber * 4) + 2].Text = ((sourceValue >> 2) & 0x1).ToString();
            Bit[(nibbleNumber * 4) + 3].Text = ((sourceValue >> 3) & 0x1).ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            System.Globalization.NumberStyles sourceStyle;
            string targetStyle;
            TextBox Target;
            TextBox Source;
            if (true == IsHexChangeIsLastEdit)
            {
                Source = tbHexValue;
                sourceStyle = System.Globalization.NumberStyles.HexNumber;
                Target = tbDecimalValue;
                targetStyle = "0";
            }
            else
            {
                Source = tbDecimalValue;
                sourceStyle = System.Globalization.NumberStyles.Integer;
                Target = tbHexValue;
                targetStyle = "X16";
            }
            /*Convert value from hex(decimal) to decimal(hex)*/
            Target.Text = UInt64.Parse(Source.Text, sourceStyle).ToString(targetStyle);
            MessageBox.Show(Convert.ToString(long.Parse(Source.Text, sourceStyle), 8).ToString());
            /*Clear all nibbles fields*/
            foreach (var Cont in this.PanelBits.Controls.OfType<TextBox>())
            {
                Cont.Text = "0";
            }
            /*Set all values*/
            for (int counter = 0; counter <= tbHexValue.Text.Length - 1; counter++)
            {
                Nibble[counter].Text = tbHexValue.Text.Substring((tbHexValue.Text.Length - counter - 1), 1);
            }
        }
    }
}
