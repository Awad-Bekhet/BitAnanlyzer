using System;
using System.Globalization;
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
        private bool IsHexChangeIsLastEdit = true;
        private BlankScreen RunningIn32BitModeScreen = new BlankScreen();
        private String HexDisplayFormat = "X16";

        public Form1()
        {
            InitializeComponent();
            InitializeBitMap();

            RunningIn32BitModeScreen.Location = new System.Drawing.Point(2, 2);
            this.PanelBits.Controls.Add(RunningIn32BitModeScreen);
            RunningIn32BitModeScreen.BringToFront();
            RunningIn32BitModeScreen.Visible = false;

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
            /*Make 32Bit as default*/
            rb32BitMode.Checked = true;
        }

        private void BitX_Click(object sender, EventArgs e)
        {
            try
            {
                Label Bit = sender as Label;
                Byte BitNumber = Byte.Parse(Bit.Name.Substring(("Bit").Length));
                Byte NibbleValue;
                int NibbleIndex = BitNumber / 4;
                UInt64 HexValue = 0;

                NibbleValue = Byte.Parse(Nibble[NibbleIndex].Text, NumberStyles.HexNumber);

                if ("0" == Bit.Text)
                {
                    NibbleValue += Byte.Parse((1 << (BitNumber % 4)).ToString());
                    Bit.Text = "1";
                }
                else
                {
                    NibbleValue -= Byte.Parse((1 << (BitNumber % 4)).ToString());
                    Bit.Text = "0";
                }

                Nibble[NibbleIndex].Text = NibbleValue.ToString("X1");

                for (int counter = 0; counter < Nibble.Length; counter++)
                {
                    HexValue += UInt64.Parse(Nibble[counter].Text, NumberStyles.HexNumber) <<
                        (counter * 4);
                }

                if (true == RunningIn32BitModeScreen.Visible)
                {
                    HexValue <<= 32;
                    HexValue >>= 32;
                }

                tbHexValue.Text = HexValue.ToString(HexDisplayFormat);
                tbDecimalPosValue.Text = HexValue.ToString();
                if (true == RunningIn32BitModeScreen.Visible)
                {
                    tbDecimalNegValue.Text = ((Int32)UInt32.Parse(tbDecimalPosValue.Text)).ToString();
                    tbOctalValue.Text = ToOctal(Convert.ToUInt32(tbDecimalPosValue.Text));
                }
                else
                {
                    tbDecimalNegValue.Text = ((Int64)UInt64.Parse(tbDecimalPosValue.Text)).ToString();
                    tbOctalValue.Text = ToOctal(Convert.ToUInt64(tbDecimalPosValue.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Unhandled Exception");
            }
        }

        private void tbXValue_TextChanged(object sender, EventArgs e)
        {
            TextBox TextBoxSetting = sender as TextBox;
            String regexPattern = "";
            NumberStyles style;

            if (TextBoxSetting.Name == "tbHexValue")
            {
                this.IsHexChangeIsLastEdit = true;
                regexPattern = @"\A\b[0-9a-fA-F]+\b\Z";
                style = NumberStyles.HexNumber;
            }
            else
            {
                this.IsHexChangeIsLastEdit = false;
                regexPattern = @"\A\b[0-9]+\b\Z";
                style = NumberStyles.Integer;
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
                        object NumberOfBytes = 0;
                        if(true == RunningIn32BitModeScreen.Visible)
                        {
                            NumberOfBytes = UInt32.Parse(TextBoxSetting.Text, style);
                        }
                        else
                        {
                            NumberOfBytes = UInt64.Parse(TextBoxSetting.Text, style);
                        }
                        Decimal KByte       = Decimal.Parse(NumberOfBytes.ToString()) / 1024;
                        Decimal KByteRem    = Math.Truncate((KByte - Math.Truncate(KByte)) * 1000);
                        Decimal MByte       = KByte / 1024;
                        Decimal MByteRem    = Math.Truncate((MByte - Math.Truncate(MByte)) * 1000);
                        Decimal GByte       = MByte / 1024;
                        Decimal GByteRem    = Math.Truncate((GByte - Math.Truncate(GByte)) * 1000);

                        lblByte.Text = NumberOfBytes.ToString();
                        lblKByte.Text = Math.Truncate(KByte).ToString("0") + "." + KByteRem.ToString("000");
                        lblMByte.Text = Math.Truncate(MByte).ToString("0") + "." + MByteRem.ToString("000");
                        lblGByte.Text = Math.Truncate(GByte).ToString("0") + "." + GByteRem.ToString("000");
                    }
                    catch (OverflowException ex)
                    {
                        if (ex.Message.Contains("or too small for a UInt"))
                        {
                            MessageBox.Show("Value is out of range of selected mode (32/64).", "Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TrimLastDigit = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Unhandled Exception");
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
                tbHexValue.Text = (0).ToString(HexDisplayFormat);
            }
        }

        private void tbDecimalValue_Leave(object sender, EventArgs e)
        {
            if (true == String.IsNullOrEmpty(tbDecimalPosValue.Text))
            {
                tbDecimalPosValue.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetAllFieldsValue("0");
        }

        private void btnSetAll_Click(object sender, EventArgs e)
        {
            SetAllFieldsValue("1");
        }

        private void NibbleX_TextChanged(object sender, EventArgs e)
        {
            TextBox source = sender as TextBox;
            Byte sourceValue = Byte.Parse(source.Text, NumberStyles.HexNumber);
            Byte nibbleNumber = Byte.Parse(source.Name.Substring("Nibble".Length));
            /*Update bitfields relative to nibble number*/
            Bit[(nibbleNumber * 4) + 0].Text = ((sourceValue >> 0) & 0x1).ToString();
            Bit[(nibbleNumber * 4) + 1].Text = ((sourceValue >> 1) & 0x1).ToString();
            Bit[(nibbleNumber * 4) + 2].Text = ((sourceValue >> 2) & 0x1).ToString();
            Bit[(nibbleNumber * 4) + 3].Text = ((sourceValue >> 3) & 0x1).ToString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            NumberStyles sourceStyle;
            string targetStyle;
            TextBox Target;
            TextBox Source;
            if (true == IsHexChangeIsLastEdit)
            {
                Source = tbHexValue;
                sourceStyle = NumberStyles.HexNumber;
                Target = tbDecimalPosValue;
                targetStyle = "0";
            }
            else
            {
                Source = tbDecimalPosValue;
                sourceStyle = NumberStyles.Integer;
                Target = tbHexValue;
                targetStyle = HexDisplayFormat;
            }
            if (true == RunningIn32BitModeScreen.Visible)
            {
                /*Convert value from hex(decimal) to decimal(hex)*/
                Target.Text = UInt32.Parse(Source.Text, sourceStyle).ToString(targetStyle);
                tbOctalValue.Text = ToOctal(Convert.ToUInt32(tbDecimalPosValue.Text));
            }
            else
            {
                /*Convert value from hex(decimal) to decimal(hex)*/
                Target.Text = UInt64.Parse(Source.Text, sourceStyle).ToString(targetStyle);
                tbOctalValue.Text = ToOctal(Convert.ToUInt64(tbDecimalPosValue.Text));
            }
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
            if (true == RunningIn32BitModeScreen.Visible)
            {
                tbDecimalNegValue.Text = ((Int32)UInt32.Parse(tbDecimalPosValue.Text)).ToString();
            }
            else
            {
                tbDecimalNegValue.Text = ((Int64)UInt64.Parse(tbDecimalPosValue.Text)).ToString();
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (true == IsHexChangeIsLastEdit)
            {
                if (true == RunningIn32BitModeScreen.Visible)
                {
                    tbHexValue.Text = (~UInt32.Parse(tbHexValue.Text, NumberStyles.HexNumber)).ToString(HexDisplayFormat);
                }
                else
                {
                    tbHexValue.Text = (~UInt64.Parse(tbHexValue.Text, NumberStyles.HexNumber)).ToString(HexDisplayFormat);
                }
            }
            else
            {
                if (true == RunningIn32BitModeScreen.Visible)
                {
                    tbHexValue.Text = (~UInt32.Parse(tbHexValue.Text, NumberStyles.HexNumber)).ToString(HexDisplayFormat);
                }
                else
                {
                    tbHexValue.Text = (~UInt64.Parse(tbHexValue.Text, NumberStyles.HexNumber)).ToString(HexDisplayFormat);
                }
            }
            Object obj = new Object();
            EventArgs arg = new EventArgs();
            btnApply_Click(obj, arg);
        }

        private string ToOctal(UInt64 Number)
        {
            string RetString = null;
            while (Number != 0)
            {
                RetString += Number % 8;
                Number /= 8;
            }
            return (RetString == null) ? "0" : new String(RetString.ToCharArray().Reverse().ToArray());
        }

        private void SetAllFieldsValue(string value)
        {
            int NibblesCounter = (true == RunningIn32BitModeScreen.Visible) ? (Nibble.Length / 2) : Nibble.Length;
            int BitsCounter = (true == RunningIn32BitModeScreen.Visible) ? (Bit.Length / 2) : Bit.Length;

            for (int counter = 0; counter < NibblesCounter; counter++)
            {
                Nibble[counter].Text = (value == "1") ? "F" : value;
            }

            if (true == RunningIn32BitModeScreen.Visible)
            {
                tbDecimalPosValue.Text = (value == "1") ? UInt32.MaxValue.ToString() : value;
            }
            else
            {
                tbDecimalPosValue.Text = (value == "1") ? UInt64.MaxValue.ToString() : value;
            }

            Object obj = new Object();
            EventArgs arg = new EventArgs();
            btnApply_Click(obj, arg);
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            if (true == RunningIn32BitModeScreen.Visible)
            {
                tbOutput.Text =
                (
                    UInt32.Parse(tbHexValue.Text, NumberStyles.HexNumber) |
                    UInt32.Parse(tbInputMask.Text, NumberStyles.HexNumber)
                ).ToString(HexDisplayFormat);
            }
            else
            {
                tbOutput.Text =
                (
                    UInt64.Parse(tbHexValue.Text, NumberStyles.HexNumber) |
                    UInt64.Parse(tbInputMask.Text, NumberStyles.HexNumber)
                ).ToString(HexDisplayFormat);
            }
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            if (true == RunningIn32BitModeScreen.Visible)
            {
                tbOutput.Text =
                (
                    UInt32.Parse(tbHexValue.Text, NumberStyles.HexNumber) &
                    UInt32.Parse(tbInputMask.Text, NumberStyles.HexNumber)
                ).ToString(HexDisplayFormat);
            }
            else
            {
                tbOutput.Text =
                (
                    UInt64.Parse(tbHexValue.Text, NumberStyles.HexNumber) &
                    UInt64.Parse(tbInputMask.Text, NumberStyles.HexNumber)
                ).ToString(HexDisplayFormat);
            }
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            if (true == RunningIn32BitModeScreen.Visible)
            {
                tbOutput.Text =
                (
                    UInt32.Parse(tbHexValue.Text, NumberStyles.HexNumber) ^
                    UInt32.Parse(tbInputMask.Text, NumberStyles.HexNumber)
                ).ToString(HexDisplayFormat);
            }
            else
            {
                tbOutput.Text =
                (
                    UInt64.Parse(tbHexValue.Text, NumberStyles.HexNumber) ^
                    UInt64.Parse(tbInputMask.Text, NumberStyles.HexNumber)
                ).ToString(HexDisplayFormat);
            }
        }

        private void btnShiftX_Click(object sender, EventArgs e)
        {
            Button ShiftBtn = sender as Button;
            int PlaceToShift = int.Parse(tbShiftValue.Text);

            if (0 == UInt64.Parse(tbOutput.Text, NumberStyles.HexNumber))
            {
                /*Get initial value*/
                tbOutput.Text = tbHexValue.Text;
            }

            if (true == RunningIn32BitModeScreen.Visible)
            {
                UInt32 Value = UInt32.Parse(tbOutput.Text, NumberStyles.HexNumber);
                if (ShiftBtn.Name.Equals("btnShiftRight"))
                {
                    Value >>= PlaceToShift;
                }
                else if (ShiftBtn.Name.Equals("btnShiftLeft"))
                {
                    Value <<= PlaceToShift;
                }
                tbOutput.Text = Value.ToString(HexDisplayFormat);
            }
            else
            {
                UInt64 Value = UInt64.Parse(tbOutput.Text, NumberStyles.HexNumber);

                if (ShiftBtn.Name.Equals("btnShiftRight"))
                {
                    Value >>= PlaceToShift;
                }
                else if (ShiftBtn.Name.Equals("btnShiftLeft"))
                {
                    Value <<= PlaceToShift;
                }
                tbOutput.Text = Value.ToString(HexDisplayFormat);
            }
        }

        private void tbMoveToResult_Click(object sender, EventArgs e)
        {
            tbHexValue.Text = tbOutput.Text;
            Object obj = new Object();
            EventArgs arg = new EventArgs();
            btnApply_Click(obj, arg);
        }

        private void tbOperationInput_TextChanged(object sender, EventArgs e)
        {
            TextBox TextBoxInput = sender as TextBox;
            String regexPattern = @"\A\b[0-9a-fA-F]+\b\Z";
            if (false == String.IsNullOrEmpty(TextBoxInput.Text))
            {
                bool TrimLastDigit = false;
                if (false == System.Text.RegularExpressions.Regex.IsMatch(TextBoxInput.Text, regexPattern))
                {
                    MessageBox.Show("Only allowed characters could be used.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TrimLastDigit = true;
                }

                if (true == TrimLastDigit)
                {
                    TextBoxInput.Text = TextBoxInput.Text.Remove(TextBoxInput.Text.Length - 1);
                    TextBoxInput.SelectionStart = TextBoxInput.Text.Length;
                    TextBoxInput.SelectionLength = 0;
                }
            }
        }

        private void tbShiftValue_TextChanged(object sender, EventArgs e)
        {
            TextBox TextBoxInput = sender as TextBox;
            String regexPattern = @"\A\b[0-9]+\b\Z";
            if (false == String.IsNullOrEmpty(TextBoxInput.Text))
            {
                bool TrimLastDigit = false;
                if (false == System.Text.RegularExpressions.Regex.IsMatch(TextBoxInput.Text, regexPattern))
                {
                    MessageBox.Show("Only allowed characters could be used.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TrimLastDigit = true;
                }
                else
                {
                    if (int.Parse(TextBoxInput.Text) > 64)
                    {
                        MessageBox.Show("Value must be (<= 64).", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TrimLastDigit = true;
                    }
                }

                if (true == TrimLastDigit)
                {
                    TextBoxInput.Text = TextBoxInput.Text.Remove(TextBoxInput.Text.Length - 1);
                    TextBoxInput.SelectionStart = TextBoxInput.Text.Length;
                    TextBoxInput.SelectionLength = 0;
                }
            }
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            tbInputMask.Text = (0).ToString(HexDisplayFormat);
            tbOutput.Text = (0).ToString(HexDisplayFormat);
            //tbInputShift.Text = (0).ToString(HexDisplayFormat);
            //tbOutputShift.Text = (0).ToString(HexDisplayFormat);
            tbShiftValue.Text = "0";
        }

        private void rbMode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbMode = sender as RadioButton;
            if (true == rbMode.Checked)
            {
                switch (rbMode.Name)
                {
                    case "rb32BitMode":
                        RunningIn32BitModeScreen.Visible = true;
                        HexDisplayFormat = "X8";
                        tbHexValue.MaxLength = 8;
                        tbInputMask.MaxLength = 8;
                        tbOutput.MaxLength = 8;
                        break;
                    default:
                    case "rb64BitMode":
                        RunningIn32BitModeScreen.Visible = false;
                        HexDisplayFormat = "X16";
                        tbHexValue.MaxLength = 16;
                        tbInputMask.MaxLength = 16;
                        tbOutput.MaxLength = 16;
                        break;
                }

                tbHexValue.Text = 0.ToString(HexDisplayFormat);
                tbOutput.Text = 0.ToString(HexDisplayFormat);
                tbInputMask.Text = 0.ToString(HexDisplayFormat);

                SetAllFieldsValue("0");
            }
        }
    }
}
