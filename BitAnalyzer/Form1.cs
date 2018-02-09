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
    enum BitOperation
	{
	    LOGICAL_OPERATION,
        SHIFT_OPERATION,
        UNKNOWN_OPERATION
	};

    public partial class Form1 : Form
    {
        private bool IsHexChangeIsLastEdit = true;
        private BitOperation LastOperationSet = BitOperation.UNKNOWN_OPERATION;
        
        public Form1()
        {
            InitializeComponent();
            InitializeBitMap();
            
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
            try
            {
                Label Bit = sender as Label;
                Byte BitNumber = Byte.Parse(Bit.Name.Substring(("Bit").Length));
                Byte NibbleValue;
                int NibbleIndex = BitNumber / 4;
                UInt64 HexValue = 0;

                NibbleValue = Byte.Parse(Nibble[NibbleIndex].Text, System.Globalization.NumberStyles.HexNumber);

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

                foreach (var Cont in this.PanelBits.Controls.OfType<TextBox>())
                {
                    HexValue += UInt64.Parse(Cont.Text, System.Globalization.NumberStyles.HexNumber) <<
                            (Byte.Parse(Cont.Name.Substring(("Nibble").Length)) * 4);
                }

                tbHexValue.Text = HexValue.ToString("X16");
                tbDecimalPosValue.Text = HexValue.ToString();
                tbDecimalNegValue.Text = ((Int64)UInt64.Parse(tbDecimalPosValue.Text)).ToString();
                tbOctalValue.Text = ToOctal(Convert.ToUInt64(tbDecimalPosValue.Text));
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
                        UInt64 NumberOfBytes = UInt64.Parse(TextBoxSetting.Text, style);
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
                        MessageBox.Show(ex.Message);
                        if (ex.Message.Contains("or too small for a UInt64"))
                        {
                            MessageBox.Show("Value is out of 64Bit range.", "Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                tbHexValue.Text = (0).ToString("X16");
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
                Target = tbDecimalPosValue;
                targetStyle = "0";
            }
            else
            {
                Source = tbDecimalPosValue;
                sourceStyle = System.Globalization.NumberStyles.Integer;
                Target = tbHexValue;
                targetStyle = "X16";
            }
            /*Convert value from hex(decimal) to decimal(hex)*/
            Target.Text = UInt64.Parse(Source.Text, sourceStyle).ToString(targetStyle);
            tbOctalValue.Text = ToOctal(Convert.ToUInt64(tbDecimalPosValue.Text));
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
            tbDecimalNegValue.Text = ((Int64)UInt64.Parse(tbDecimalPosValue.Text)).ToString();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (true == IsHexChangeIsLastEdit)
            {
                tbHexValue.Text = (~UInt64.Parse(tbHexValue.Text, System.Globalization.NumberStyles.HexNumber)).ToString("X16");
            }
            else
            {
                tbDecimalPosValue.Text = (~UInt64.Parse(tbDecimalPosValue.Text, System.Globalization.NumberStyles.HexNumber)).ToString(); 
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
            /*reset all fields to 0s*/
            foreach (var PanelControl in this.PanelBits.Controls)
            {
                switch (PanelControl.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        ((TextBox)PanelControl).Text = (value == "1") ? "F" : value;
                        break;
                    case "System.Windows.Forms.Label":
                        if (true == ((Label)PanelControl).Name.StartsWith("Bit"))
                        {
                            ((Label)PanelControl).Text = value;
                        }
                        break;
                    default:
                        break;
                }
            }

            tbDecimalPosValue.Text = (value == "1") ? UInt64.MaxValue.ToString() : value;
            Object obj = new Object();
            EventArgs arg = new EventArgs();
            btnApply_Click(obj, arg);
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            tbOutputLogical.Text = 
            (
                UInt64.Parse(tbHexValue.Text, System.Globalization.NumberStyles.HexNumber) |
                UInt64.Parse(tbInputLogical.Text, System.Globalization.NumberStyles.HexNumber)
            ).ToString("X16");
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            tbOutputLogical.Text =
            (
                UInt64.Parse(tbHexValue.Text, System.Globalization.NumberStyles.HexNumber) &
                UInt64.Parse(tbInputLogical.Text, System.Globalization.NumberStyles.HexNumber)
            ).ToString("X16");
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            tbOutputLogical.Text =
            (
                UInt64.Parse(tbHexValue.Text, System.Globalization.NumberStyles.HexNumber) ^
                UInt64.Parse(tbInputLogical.Text, System.Globalization.NumberStyles.HexNumber)
            ).ToString("X16");
        }

        private void btnShiftX_Click(object sender, EventArgs e)
        {
            Button ShiftBtn = sender as Button;
            int PlaceToShift = int.Parse(tbShiftValue.Text);
            UInt64 Value;

            if (0 == UInt64.Parse(tbOutputShift.Text, System.Globalization.NumberStyles.HexNumber))
            {
                /*Get initial value*/
                tbOutputShift.Text = tbHexValue.Text;
            }

            Value = UInt64.Parse(tbOutputShift.Text, System.Globalization.NumberStyles.HexNumber);
            
            if (ShiftBtn.Name.Equals("btnShiftRight"))
            {
                Value >>= PlaceToShift;
            }
            else if(ShiftBtn.Name.Equals("btnShiftLeft"))
            {
                Value <<= PlaceToShift;
            }
            tbOutputShift.Text = Value.ToString("X16");
        }

        private void tbMoveToResult_Click(object sender, EventArgs e)
        {
            switch (LastOperationSet)
            {
                case BitOperation.LOGICAL_OPERATION:
                    tbHexValue.Text = tbOutputLogical.Text;
                    break;
                case BitOperation.SHIFT_OPERATION:
                    tbHexValue.Text = tbOutputShift.Text;
                    break;
                case BitOperation.UNKNOWN_OPERATION:
                    break;
            }
            Object obj = new Object();
            EventArgs arg = new EventArgs();
            btnApply_Click(obj, arg);
        }

        private void tbOutputLogical_TextChanged(object sender, EventArgs e)
        {
            LastOperationSet = BitOperation.LOGICAL_OPERATION;
        }

        private void tbOutputShift_TextChanged(object sender, EventArgs e)
        {
            LastOperationSet = BitOperation.SHIFT_OPERATION;
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
            tbInputLogical.Text = (0).ToString("X16");
            tbOutputLogical.Text = (0).ToString("X16");
            tbInputShift.Text = (0).ToString("X16");
            tbOutputShift.Text = (0).ToString("X16");
            tbShiftValue.Text = "0";
            LastOperationSet = BitOperation.UNKNOWN_OPERATION;
        }
    }
}
