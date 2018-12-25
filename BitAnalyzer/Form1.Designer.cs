namespace BitAnalyzer
{
    partial class Form1
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

        private void InitializeBitMap()
        {
            this.Bit = new System.Windows.Forms.Label[64];
            this.Nibble = new System.Windows.Forms.TextBox[16];

            this.Nibble[15] = new System.Windows.Forms.TextBox();
            this.Nibble[14] = new System.Windows.Forms.TextBox();
            this.Nibble[13] = new System.Windows.Forms.TextBox();
            this.Nibble[12] = new System.Windows.Forms.TextBox();
            this.Nibble[11] = new System.Windows.Forms.TextBox();
            this.Nibble[10] = new System.Windows.Forms.TextBox();
            this.Nibble[9] = new System.Windows.Forms.TextBox();
            this.Nibble[8] = new System.Windows.Forms.TextBox();
            this.Nibble[7] = new System.Windows.Forms.TextBox();
            this.Nibble[6] = new System.Windows.Forms.TextBox();
            this.Nibble[5] = new System.Windows.Forms.TextBox();
            this.Nibble[4] = new System.Windows.Forms.TextBox();
            this.Nibble[3] = new System.Windows.Forms.TextBox();
            this.Nibble[2] = new System.Windows.Forms.TextBox();
            this.Nibble[1] = new System.Windows.Forms.TextBox();
            this.Nibble[0] = new System.Windows.Forms.TextBox();
            this.Bit[63] = new System.Windows.Forms.Label();
            this.Bit[62] = new System.Windows.Forms.Label();
            this.Bit[61] = new System.Windows.Forms.Label();
            this.Bit[60] = new System.Windows.Forms.Label();
            this.Bit[59] = new System.Windows.Forms.Label();
            this.Bit[58] = new System.Windows.Forms.Label();
            this.Bit[57] = new System.Windows.Forms.Label();
            this.Bit[56] = new System.Windows.Forms.Label();
            this.Bit[55] = new System.Windows.Forms.Label();
            this.Bit[54] = new System.Windows.Forms.Label();
            this.Bit[53] = new System.Windows.Forms.Label();
            this.Bit[52] = new System.Windows.Forms.Label();
            this.Bit[51] = new System.Windows.Forms.Label();
            this.Bit[50] = new System.Windows.Forms.Label();
            this.Bit[49] = new System.Windows.Forms.Label();
            this.Bit[48] = new System.Windows.Forms.Label();
            this.Bit[47] = new System.Windows.Forms.Label();
            this.Bit[46] = new System.Windows.Forms.Label();
            this.Bit[45] = new System.Windows.Forms.Label();
            this.Bit[44] = new System.Windows.Forms.Label();
            this.Bit[43] = new System.Windows.Forms.Label();
            this.Bit[42] = new System.Windows.Forms.Label();
            this.Bit[41] = new System.Windows.Forms.Label();
            this.Bit[40] = new System.Windows.Forms.Label();
            this.Bit[39] = new System.Windows.Forms.Label();
            this.Bit[38] = new System.Windows.Forms.Label();
            this.Bit[37] = new System.Windows.Forms.Label();
            this.Bit[36] = new System.Windows.Forms.Label();
            this.Bit[35] = new System.Windows.Forms.Label();
            this.Bit[34] = new System.Windows.Forms.Label();
            this.Bit[33] = new System.Windows.Forms.Label();
            this.Bit[32] = new System.Windows.Forms.Label();
            this.Bit[31] = new System.Windows.Forms.Label();
            this.Bit[30] = new System.Windows.Forms.Label();
            this.Bit[29] = new System.Windows.Forms.Label();
            this.Bit[28] = new System.Windows.Forms.Label();
            this.Bit[27] = new System.Windows.Forms.Label();
            this.Bit[26] = new System.Windows.Forms.Label();
            this.Bit[25] = new System.Windows.Forms.Label();
            this.Bit[24] = new System.Windows.Forms.Label();
            this.Bit[23] = new System.Windows.Forms.Label();
            this.Bit[22] = new System.Windows.Forms.Label();
            this.Bit[21] = new System.Windows.Forms.Label();
            this.Bit[20] = new System.Windows.Forms.Label();
            this.Bit[19] = new System.Windows.Forms.Label();
            this.Bit[18] = new System.Windows.Forms.Label();
            this.Bit[17] = new System.Windows.Forms.Label();
            this.Bit[16] = new System.Windows.Forms.Label();
            this.Bit[15] = new System.Windows.Forms.Label();
            this.Bit[14] = new System.Windows.Forms.Label();
            this.Bit[13] = new System.Windows.Forms.Label();
            this.Bit[12] = new System.Windows.Forms.Label();
            this.Bit[11] = new System.Windows.Forms.Label();
            this.Bit[10] = new System.Windows.Forms.Label();
            this.Bit[9] = new System.Windows.Forms.Label();
            this.Bit[8] = new System.Windows.Forms.Label();
            this.Bit[7] = new System.Windows.Forms.Label();
            this.Bit[6] = new System.Windows.Forms.Label();
            this.Bit[5] = new System.Windows.Forms.Label();
            this.Bit[4] = new System.Windows.Forms.Label();
            this.Bit[3] = new System.Windows.Forms.Label();
            this.Bit[2] = new System.Windows.Forms.Label();
            this.Bit[1] = new System.Windows.Forms.Label();
            this.Bit[0] = new System.Windows.Forms.Label();

            this.PanelBits.Controls.Add(this.Nibble[15]);
            this.PanelBits.Controls.Add(this.Nibble[14]);
            this.PanelBits.Controls.Add(this.Nibble[13]);
            this.PanelBits.Controls.Add(this.Nibble[12]);
            this.PanelBits.Controls.Add(this.Nibble[11]);
            this.PanelBits.Controls.Add(this.Nibble[10]);
            this.PanelBits.Controls.Add(this.Nibble[9]);
            this.PanelBits.Controls.Add(this.Nibble[8]);
            this.PanelBits.Controls.Add(this.Nibble[7]);
            this.PanelBits.Controls.Add(this.Nibble[6]);
            this.PanelBits.Controls.Add(this.Nibble[5]);
            this.PanelBits.Controls.Add(this.Nibble[4]);
            this.PanelBits.Controls.Add(this.Nibble[3]);
            this.PanelBits.Controls.Add(this.Nibble[2]);
            this.PanelBits.Controls.Add(this.Nibble[1]);
            this.PanelBits.Controls.Add(this.Nibble[0]);

            this.PanelBits.Controls.Add(this.Bit[63]);
            this.PanelBits.Controls.Add(this.Bit[62]);
            this.PanelBits.Controls.Add(this.Bit[61]);
            this.PanelBits.Controls.Add(this.Bit[60]);
            this.PanelBits.Controls.Add(this.Bit[59]);
            this.PanelBits.Controls.Add(this.Bit[58]);
            this.PanelBits.Controls.Add(this.Bit[57]);
            this.PanelBits.Controls.Add(this.Bit[56]);
            this.PanelBits.Controls.Add(this.Bit[55]);
            this.PanelBits.Controls.Add(this.Bit[54]);
            this.PanelBits.Controls.Add(this.Bit[53]);
            this.PanelBits.Controls.Add(this.Bit[52]);
            this.PanelBits.Controls.Add(this.Bit[51]);
            this.PanelBits.Controls.Add(this.Bit[50]);
            this.PanelBits.Controls.Add(this.Bit[49]);
            this.PanelBits.Controls.Add(this.Bit[48]);
            this.PanelBits.Controls.Add(this.Bit[47]);
            this.PanelBits.Controls.Add(this.Bit[46]);
            this.PanelBits.Controls.Add(this.Bit[45]);
            this.PanelBits.Controls.Add(this.Bit[44]);
            this.PanelBits.Controls.Add(this.Bit[43]);
            this.PanelBits.Controls.Add(this.Bit[42]);
            this.PanelBits.Controls.Add(this.Bit[41]);
            this.PanelBits.Controls.Add(this.Bit[40]);
            this.PanelBits.Controls.Add(this.Bit[39]);
            this.PanelBits.Controls.Add(this.Bit[38]);
            this.PanelBits.Controls.Add(this.Bit[37]);
            this.PanelBits.Controls.Add(this.Bit[36]);
            this.PanelBits.Controls.Add(this.Bit[35]);
            this.PanelBits.Controls.Add(this.Bit[34]);
            this.PanelBits.Controls.Add(this.Bit[33]);
            this.PanelBits.Controls.Add(this.Bit[32]);
            this.PanelBits.Controls.Add(this.Bit[31]);
            this.PanelBits.Controls.Add(this.Bit[30]);
            this.PanelBits.Controls.Add(this.Bit[29]);
            this.PanelBits.Controls.Add(this.Bit[28]);
            this.PanelBits.Controls.Add(this.Bit[27]);
            this.PanelBits.Controls.Add(this.Bit[26]);
            this.PanelBits.Controls.Add(this.Bit[25]);
            this.PanelBits.Controls.Add(this.Bit[24]);
            this.PanelBits.Controls.Add(this.Bit[23]);
            this.PanelBits.Controls.Add(this.Bit[22]);
            this.PanelBits.Controls.Add(this.Bit[21]);
            this.PanelBits.Controls.Add(this.Bit[20]);
            this.PanelBits.Controls.Add(this.Bit[19]);
            this.PanelBits.Controls.Add(this.Bit[18]);
            this.PanelBits.Controls.Add(this.Bit[17]);
            this.PanelBits.Controls.Add(this.Bit[16]);
            this.PanelBits.Controls.Add(this.Bit[15]);
            this.PanelBits.Controls.Add(this.Bit[14]);
            this.PanelBits.Controls.Add(this.Bit[13]);
            this.PanelBits.Controls.Add(this.Bit[12]);
            this.PanelBits.Controls.Add(this.Bit[11]);
            this.PanelBits.Controls.Add(this.Bit[10]);
            this.PanelBits.Controls.Add(this.Bit[9]);
            this.PanelBits.Controls.Add(this.Bit[8]);
            this.PanelBits.Controls.Add(this.Bit[7]);
            this.PanelBits.Controls.Add(this.Bit[6]);
            this.PanelBits.Controls.Add(this.Bit[5]);
            this.PanelBits.Controls.Add(this.Bit[4]);
            this.PanelBits.Controls.Add(this.Bit[3]);
            this.PanelBits.Controls.Add(this.Bit[2]);
            this.PanelBits.Controls.Add(this.Bit[1]);
            this.PanelBits.Controls.Add(this.Bit[0]);
            // 
            // Nibble15
            // 
            this.Nibble[15].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[15].Location = new System.Drawing.Point(4, 34);
            this.Nibble[15].Multiline = true;
            this.Nibble[15].Name = "Nibble15";
            this.Nibble[15].Size = new System.Drawing.Size(77, 21);
            this.Nibble[15].TabIndex = 157;
            this.Nibble[15].TabStop = false;
            this.Nibble[15].Text = "0";
            this.Nibble[15].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble14
            // 
            this.Nibble[14].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[14].Location = new System.Drawing.Point(84, 34);
            this.Nibble[14].Multiline = true;
            this.Nibble[14].Name = "Nibble14";
            this.Nibble[14].Size = new System.Drawing.Size(77, 21);
            this.Nibble[14].TabIndex = 156;
            this.Nibble[14].TabStop = false;
            this.Nibble[14].Text = "0";
            this.Nibble[14].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble13
            // 
            this.Nibble[13].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[13].Location = new System.Drawing.Point(165, 34);
            this.Nibble[13].Multiline = true;
            this.Nibble[13].Name = "Nibble13";
            this.Nibble[13].Size = new System.Drawing.Size(77, 21);
            this.Nibble[13].TabIndex = 155;
            this.Nibble[13].TabStop = false;
            this.Nibble[13].Text = "0";
            this.Nibble[13].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble12
            // 
            this.Nibble[12].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[12].Location = new System.Drawing.Point(246, 34);
            this.Nibble[12].Multiline = true;
            this.Nibble[12].Name = "Nibble12";
            this.Nibble[12].Size = new System.Drawing.Size(77, 21);
            this.Nibble[12].TabIndex = 154;
            this.Nibble[12].TabStop = false;
            this.Nibble[12].Text = "0";
            this.Nibble[12].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble11
            // 
            this.Nibble[11].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[11].Location = new System.Drawing.Point(328, 34);
            this.Nibble[11].Multiline = true;
            this.Nibble[11].Name = "Nibble11";
            this.Nibble[11].Size = new System.Drawing.Size(77, 21);
            this.Nibble[11].TabIndex = 153;
            this.Nibble[11].TabStop = false;
            this.Nibble[11].Text = "0";
            this.Nibble[11].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble10
            // 
            this.Nibble[10].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[10].Location = new System.Drawing.Point(408, 34);
            this.Nibble[10].Multiline = true;
            this.Nibble[10].Name = "Nibble10";
            this.Nibble[10].Size = new System.Drawing.Size(77, 21);
            this.Nibble[10].TabIndex = 152;
            this.Nibble[10].TabStop = false;
            this.Nibble[10].Text = "0";
            this.Nibble[10].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble09
            // 
            this.Nibble[09].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[09].Location = new System.Drawing.Point(492, 34);
            this.Nibble[09].Multiline = true;
            this.Nibble[09].Name = "Nibble09";
            this.Nibble[09].Size = new System.Drawing.Size(77, 21);
            this.Nibble[09].TabIndex = 151;
            this.Nibble[09].TabStop = false;
            this.Nibble[09].Text = "0";
            this.Nibble[09].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble08
            // 
            this.Nibble[08].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[08].Location = new System.Drawing.Point(572, 34);
            this.Nibble[08].Multiline = true;
            this.Nibble[08].Name = "Nibble08";
            this.Nibble[08].Size = new System.Drawing.Size(77, 21);
            this.Nibble[08].TabIndex = 150;
            this.Nibble[08].TabStop = false;
            this.Nibble[08].Text = "0";
            this.Nibble[08].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble07
            // 
            this.Nibble[07].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[07].Location = new System.Drawing.Point(3, 91);
            this.Nibble[07].Multiline = true;
            this.Nibble[07].Name = "Nibble07";
            this.Nibble[07].Size = new System.Drawing.Size(77, 21);
            this.Nibble[07].TabIndex = 149;
            this.Nibble[07].TabStop = false;
            this.Nibble[07].Text = "0";
            this.Nibble[07].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble06
            // 
            this.Nibble[06].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[06].Location = new System.Drawing.Point(83, 91);
            this.Nibble[06].Multiline = true;
            this.Nibble[06].Name = "Nibble06";
            this.Nibble[06].Size = new System.Drawing.Size(77, 21);
            this.Nibble[06].TabIndex = 148;
            this.Nibble[06].TabStop = false;
            this.Nibble[06].Text = "0";
            this.Nibble[06].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble05
            // 
            this.Nibble[05].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[05].Location = new System.Drawing.Point(164, 91);
            this.Nibble[05].Multiline = true;
            this.Nibble[05].Name = "Nibble05";
            this.Nibble[05].Size = new System.Drawing.Size(77, 21);
            this.Nibble[05].TabIndex = 147;
            this.Nibble[05].TabStop = false;
            this.Nibble[05].Text = "0";
            this.Nibble[05].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble04
            // 
            this.Nibble[04].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[04].Location = new System.Drawing.Point(245, 91);
            this.Nibble[04].Multiline = true;
            this.Nibble[04].Name = "Nibble04";
            this.Nibble[04].Size = new System.Drawing.Size(77, 21);
            this.Nibble[04].TabIndex = 146;
            this.Nibble[04].TabStop = false;
            this.Nibble[04].Text = "0";
            this.Nibble[04].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble03
            // 
            this.Nibble[03].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[03].Location = new System.Drawing.Point(327, 91);
            this.Nibble[03].Multiline = true;
            this.Nibble[03].Name = "Nibble03";
            this.Nibble[03].Size = new System.Drawing.Size(77, 21);
            this.Nibble[03].TabIndex = 145;
            this.Nibble[03].TabStop = false;
            this.Nibble[03].Text = "0";
            this.Nibble[03].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble02
            // 
            this.Nibble[02].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[02].Location = new System.Drawing.Point(407, 91);
            this.Nibble[02].Multiline = true;
            this.Nibble[02].Name = "Nibble02";
            this.Nibble[02].Size = new System.Drawing.Size(77, 21);
            this.Nibble[02].TabIndex = 144;
            this.Nibble[02].TabStop = false;
            this.Nibble[02].Text = "0";
            this.Nibble[02].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble01
            // 
            this.Nibble[01].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[01].Location = new System.Drawing.Point(491, 91);
            this.Nibble[01].Multiline = true;
            this.Nibble[01].Name = "Nibble01";
            this.Nibble[01].Size = new System.Drawing.Size(77, 21);
            this.Nibble[01].TabIndex = 143;
            this.Nibble[01].TabStop = false;
            this.Nibble[01].Text = "0";
            this.Nibble[01].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nibble00
            // 
            this.Nibble[00].BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nibble[00].Location = new System.Drawing.Point(571, 91);
            this.Nibble[00].Multiline = true;
            this.Nibble[00].Name = "Nibble00";
            this.Nibble[00].Size = new System.Drawing.Size(77, 21);
            this.Nibble[00].TabIndex = 142;
            this.Nibble[00].TabStop = false;
            this.Nibble[00].Text = "0";
            this.Nibble[00].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            


            // 
            // Bit63
            // 
            this.Bit[63].AutoSize = true;
            this.Bit[63].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[63].Location = new System.Drawing.Point(4, 13);
            this.Bit[63].Name = "Bit63";
            this.Bit[63].Size = new System.Drawing.Size(20, 21);
            this.Bit[63].TabIndex = 131;
            this.Bit[63].Text = "0";
            // 
            // Bit62
            // 
            this.Bit[62].AutoSize = true;
            this.Bit[62].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[62].Location = new System.Drawing.Point(23, 13);
            this.Bit[62].Name = "Bit62";
            this.Bit[62].Size = new System.Drawing.Size(20, 21);
            this.Bit[62].TabIndex = 130;
            this.Bit[62].Text = "0";
            // 
            // Bit61
            // 
            this.Bit[61].AutoSize = true;
            this.Bit[61].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[61].Location = new System.Drawing.Point(42, 13);
            this.Bit[61].Name = "Bit61";
            this.Bit[61].Size = new System.Drawing.Size(20, 21);
            this.Bit[61].TabIndex = 129;
            this.Bit[61].Text = "0";
            // 
            // Bit60
            // 
            this.Bit[60].AutoSize = true;
            this.Bit[60].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[60].Location = new System.Drawing.Point(60, 13);
            this.Bit[60].Name = "Bit60";
            this.Bit[60].Size = new System.Drawing.Size(20, 21);
            this.Bit[60].TabIndex = 128;
            this.Bit[60].Text = "0";
            // 
            // Bit59
            // 
            this.Bit[59].AutoSize = true;
            this.Bit[59].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[59].Location = new System.Drawing.Point(84, 13);
            this.Bit[59].Name = "Bit59";
            this.Bit[59].Size = new System.Drawing.Size(20, 21);
            this.Bit[59].TabIndex = 126;
            this.Bit[59].Text = "0";
            // 
            // Bit58
            // 
            this.Bit[58].AutoSize = true;
            this.Bit[58].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[58].Location = new System.Drawing.Point(103, 13);
            this.Bit[58].Name = "Bit58";
            this.Bit[58].Size = new System.Drawing.Size(20, 21);
            this.Bit[58].TabIndex = 125;
            this.Bit[58].Text = "0";
            // 
            // Bit57
            // 
            this.Bit[57].AutoSize = true;
            this.Bit[57].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[57].Location = new System.Drawing.Point(122, 13);
            this.Bit[57].Name = "Bit57";
            this.Bit[57].Size = new System.Drawing.Size(20, 21);
            this.Bit[57].TabIndex = 124;
            this.Bit[57].Text = "0";
            // 
            // Bit56
            // 
            this.Bit[56].AutoSize = true;
            this.Bit[56].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[56].Location = new System.Drawing.Point(140, 13);
            this.Bit[56].Name = "Bit56";
            this.Bit[56].Size = new System.Drawing.Size(20, 21);
            this.Bit[56].TabIndex = 123;
            this.Bit[56].Text = "0";
            // 
            // Bit55
            // 
            this.Bit[55].AutoSize = true;
            this.Bit[55].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[55].Location = new System.Drawing.Point(166, 13);
            this.Bit[55].Name = "Bit55";
            this.Bit[55].Size = new System.Drawing.Size(20, 21);
            this.Bit[55].TabIndex = 121;
            this.Bit[55].Text = "0";
            // 
            // Bit54
            // 
            this.Bit[54].AutoSize = true;
            this.Bit[54].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[54].Location = new System.Drawing.Point(185, 13);
            this.Bit[54].Name = "Bit54";
            this.Bit[54].Size = new System.Drawing.Size(20, 21);
            this.Bit[54].TabIndex = 120;
            this.Bit[54].Text = "0";
            // 
            // Bit53
            // 
            this.Bit[53].AutoSize = true;
            this.Bit[53].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[53].Location = new System.Drawing.Point(204, 13);
            this.Bit[53].Name = "Bit53";
            this.Bit[53].Size = new System.Drawing.Size(20, 21);
            this.Bit[53].TabIndex = 119;
            this.Bit[53].Text = "0";
            // 
            // Bit52
            // 
            this.Bit[52].AutoSize = true;
            this.Bit[52].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[52].Location = new System.Drawing.Point(222, 13);
            this.Bit[52].Name = "Bit52";
            this.Bit[52].Size = new System.Drawing.Size(20, 21);
            this.Bit[52].TabIndex = 118;
            this.Bit[52].Text = "0";
            // 
            // Bit51
            // 
            this.Bit[51].AutoSize = true;
            this.Bit[51].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[51].Location = new System.Drawing.Point(246, 13);
            this.Bit[51].Name = "Bit51";
            this.Bit[51].Size = new System.Drawing.Size(20, 21);
            this.Bit[51].TabIndex = 116;
            this.Bit[51].Text = "0";
            // 
            // Bit50
            // 
            this.Bit[50].AutoSize = true;
            this.Bit[50].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[50].Location = new System.Drawing.Point(265, 13);
            this.Bit[50].Name = "Bit50";
            this.Bit[50].Size = new System.Drawing.Size(20, 21);
            this.Bit[50].TabIndex = 115;
            this.Bit[50].Text = "0";
            // 
            // Bit49
            // 
            this.Bit[49].AutoSize = true;
            this.Bit[49].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[49].Location = new System.Drawing.Point(284, 13);
            this.Bit[49].Name = "Bit49";
            this.Bit[49].Size = new System.Drawing.Size(20, 21);
            this.Bit[49].TabIndex = 114;
            this.Bit[49].Text = "0";
            // 
            // Bit48
            // 
            this.Bit[48].AutoSize = true;
            this.Bit[48].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[48].Location = new System.Drawing.Point(302, 13);
            this.Bit[48].Name = "Bit48";
            this.Bit[48].Size = new System.Drawing.Size(20, 21);
            this.Bit[48].TabIndex = 113;
            this.Bit[48].Text = "0";
            // 
            // Bit47
            // 
            this.Bit[47].AutoSize = true;
            this.Bit[47].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[47].Location = new System.Drawing.Point(329, 13);
            this.Bit[47].Name = "Bit47";
            this.Bit[47].Size = new System.Drawing.Size(20, 21);
            this.Bit[47].TabIndex = 111;
            this.Bit[47].Text = "0";
            // 
            // Bit46
            // 
            this.Bit[46].AutoSize = true;
            this.Bit[46].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[46].Location = new System.Drawing.Point(348, 13);
            this.Bit[46].Name = "Bit46";
            this.Bit[46].Size = new System.Drawing.Size(20, 21);
            this.Bit[46].TabIndex = 110;
            this.Bit[46].Text = "0";
            // 
            // Bit45
            // 
            this.Bit[45].AutoSize = true;
            this.Bit[45].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[45].Location = new System.Drawing.Point(367, 13);
            this.Bit[45].Name = "Bit45";
            this.Bit[45].Size = new System.Drawing.Size(20, 21);
            this.Bit[45].TabIndex = 109;
            this.Bit[45].Text = "0";
            // 
            // Bit44
            // 
            this.Bit[44].AutoSize = true;
            this.Bit[44].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[44].Location = new System.Drawing.Point(385, 13);
            this.Bit[44].Name = "Bit44";
            this.Bit[44].Size = new System.Drawing.Size(20, 21);
            this.Bit[44].TabIndex = 108;
            this.Bit[44].Text = "0";
            // 
            // Bit43
            // 
            this.Bit[43].AutoSize = true;
            this.Bit[43].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[43].Location = new System.Drawing.Point(409, 13);
            this.Bit[43].Name = "Bit43";
            this.Bit[43].Size = new System.Drawing.Size(20, 21);
            this.Bit[43].TabIndex = 106;
            this.Bit[43].Text = "0";
            // 
            // Bit42
            // 
            this.Bit[42].AutoSize = true;
            this.Bit[42].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[42].Location = new System.Drawing.Point(428, 13);
            this.Bit[42].Name = "Bit42";
            this.Bit[42].Size = new System.Drawing.Size(20, 21);
            this.Bit[42].TabIndex = 105;
            this.Bit[42].Text = "0";
            // 
            // Bit41
            // 
            this.Bit[41].AutoSize = true;
            this.Bit[41].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[41].Location = new System.Drawing.Point(447, 13);
            this.Bit[41].Name = "Bit41";
            this.Bit[41].Size = new System.Drawing.Size(20, 21);
            this.Bit[41].TabIndex = 104;
            this.Bit[41].Text = "0";
            // 
            // Bit40
            // 
            this.Bit[40].AutoSize = true;
            this.Bit[40].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[40].Location = new System.Drawing.Point(465, 13);
            this.Bit[40].Name = "Bit40";
            this.Bit[40].Size = new System.Drawing.Size(20, 21);
            this.Bit[40].TabIndex = 103;
            this.Bit[40].Text = "0";
            // 
            // Bit39
            // 
            this.Bit[39].AutoSize = true;
            this.Bit[39].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[39].Location = new System.Drawing.Point(493, 13);
            this.Bit[39].Name = "Bit39";
            this.Bit[39].Size = new System.Drawing.Size(20, 21);
            this.Bit[39].TabIndex = 101;
            this.Bit[39].Text = "0";
            // 
            // Bit38
            // 
            this.Bit[38].AutoSize = true;
            this.Bit[38].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[38].Location = new System.Drawing.Point(512, 13);
            this.Bit[38].Name = "Bit38";
            this.Bit[38].Size = new System.Drawing.Size(20, 21);
            this.Bit[38].TabIndex = 100;
            this.Bit[38].Text = "0";
            // 
            // Bit37
            // 
            this.Bit[37].AutoSize = true;
            this.Bit[37].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[37].Location = new System.Drawing.Point(531, 13);
            this.Bit[37].Name = "Bit37";
            this.Bit[37].Size = new System.Drawing.Size(20, 21);
            this.Bit[37].TabIndex = 99;
            this.Bit[37].Text = "0";
            // 
            // Bit36
            // 
            this.Bit[36].AutoSize = true;
            this.Bit[36].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[36].Location = new System.Drawing.Point(549, 13);
            this.Bit[36].Name = "Bit36";
            this.Bit[36].Size = new System.Drawing.Size(20, 21);
            this.Bit[36].TabIndex = 98;
            this.Bit[36].Text = "0";
            // 
            // Bit35
            // 
            this.Bit[35].AutoSize = true;
            this.Bit[35].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[35].Location = new System.Drawing.Point(572, 13);
            this.Bit[35].Name = "Bit35";
            this.Bit[35].Size = new System.Drawing.Size(20, 21);
            this.Bit[35].TabIndex = 96;
            this.Bit[35].Text = "0";
            // 
            // Bit34
            // 
            this.Bit[34].AutoSize = true;
            this.Bit[34].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[34].Location = new System.Drawing.Point(591, 13);
            this.Bit[34].Name = "Bit34";
            this.Bit[34].Size = new System.Drawing.Size(20, 21);
            this.Bit[34].TabIndex = 95;
            this.Bit[34].Text = "0";
            // 
            // Bit33
            // 
            this.Bit[33].AutoSize = true;
            this.Bit[33].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[33].Location = new System.Drawing.Point(610, 13);
            this.Bit[33].Name = "Bit33";
            this.Bit[33].Size = new System.Drawing.Size(20, 21);
            this.Bit[33].TabIndex = 94;
            this.Bit[33].Text = "0";
            // 
            // Bit32
            // 
            this.Bit[32].AutoSize = true;
            this.Bit[32].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[32].Location = new System.Drawing.Point(628, 13);
            this.Bit[32].Name = "Bit32";
            this.Bit[32].Size = new System.Drawing.Size(20, 21);
            this.Bit[32].TabIndex = 93;
            this.Bit[32].Text = "0";
            // 
            // Bit31
            // 
            this.Bit[31].AutoSize = true;
            this.Bit[31].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[31].Location = new System.Drawing.Point(3, 70);
            this.Bit[31].Name = "Bit31";
            this.Bit[31].Size = new System.Drawing.Size(20, 21);
            this.Bit[31].TabIndex = 83;
            this.Bit[31].Text = "0";
            // 
            // Bit30
            // 
            this.Bit[30].AutoSize = true;
            this.Bit[30].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[30].Location = new System.Drawing.Point(22, 70);
            this.Bit[30].Name = "Bit30";
            this.Bit[30].Size = new System.Drawing.Size(20, 21);
            this.Bit[30].TabIndex = 82;
            this.Bit[30].Text = "0";
            // 
            // Bit29
            // 
            this.Bit[29].AutoSize = true;
            this.Bit[29].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[29].Location = new System.Drawing.Point(41, 70);
            this.Bit[29].Name = "Bit29";
            this.Bit[29].Size = new System.Drawing.Size(20, 21);
            this.Bit[29].TabIndex = 81;
            this.Bit[29].Text = "0";
            // 
            // Bit28
            // 
            this.Bit[28].AutoSize = true;
            this.Bit[28].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[28].Location = new System.Drawing.Point(59, 70);
            this.Bit[28].Name = "Bit28";
            this.Bit[28].Size = new System.Drawing.Size(20, 21);
            this.Bit[28].TabIndex = 80;
            this.Bit[28].Text = "0";
            // 
            // Bit27
            // 
            this.Bit[27].AutoSize = true;
            this.Bit[27].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[27].Location = new System.Drawing.Point(83, 70);
            this.Bit[27].Name = "Bit27";
            this.Bit[27].Size = new System.Drawing.Size(20, 21);
            this.Bit[27].TabIndex = 78;
            this.Bit[27].Text = "0";
            // 
            // Bit26
            // 
            this.Bit[26].AutoSize = true;
            this.Bit[26].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[26].Location = new System.Drawing.Point(102, 70);
            this.Bit[26].Name = "Bit26";
            this.Bit[26].Size = new System.Drawing.Size(20, 21);
            this.Bit[26].TabIndex = 77;
            this.Bit[26].Text = "0";
            // 
            // Bit25
            // 
            this.Bit[25].AutoSize = true;
            this.Bit[25].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[25].Location = new System.Drawing.Point(121, 70);
            this.Bit[25].Name = "Bit25";
            this.Bit[25].Size = new System.Drawing.Size(20, 21);
            this.Bit[25].TabIndex = 76;
            this.Bit[25].Text = "0";
            // 
            // Bit24
            // 
            this.Bit[24].AutoSize = true;
            this.Bit[24].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[24].Location = new System.Drawing.Point(139, 70);
            this.Bit[24].Name = "Bit24";
            this.Bit[24].Size = new System.Drawing.Size(20, 21);
            this.Bit[24].TabIndex = 75;
            this.Bit[24].Text = "0";
            // 
            // Bit23
            // 
            this.Bit[23].AutoSize = true;
            this.Bit[23].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[23].Location = new System.Drawing.Point(165, 70);
            this.Bit[23].Name = "Bit23";
            this.Bit[23].Size = new System.Drawing.Size(20, 21);
            this.Bit[23].TabIndex = 73;
            this.Bit[23].Text = "0";
            // 
            // Bit22
            // 
            this.Bit[22].AutoSize = true;
            this.Bit[22].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[22].Location = new System.Drawing.Point(184, 70);
            this.Bit[22].Name = "Bit22";
            this.Bit[22].Size = new System.Drawing.Size(20, 21);
            this.Bit[22].TabIndex = 72;
            this.Bit[22].Text = "0";
            // 
            // Bit21
            // 
            this.Bit[21].AutoSize = true;
            this.Bit[21].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[21].Location = new System.Drawing.Point(203, 70);
            this.Bit[21].Name = "Bit21";
            this.Bit[21].Size = new System.Drawing.Size(20, 21);
            this.Bit[21].TabIndex = 71;
            this.Bit[21].Text = "0";
            // 
            // Bit20
            // 
            this.Bit[20].AutoSize = true;
            this.Bit[20].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[20].Location = new System.Drawing.Point(221, 70);
            this.Bit[20].Name = "Bit20";
            this.Bit[20].Size = new System.Drawing.Size(20, 21);
            this.Bit[20].TabIndex = 70;
            this.Bit[20].Text = "0";
            // 
            // Bit19
            // 
            this.Bit[19].AutoSize = true;
            this.Bit[19].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[19].Location = new System.Drawing.Point(245, 70);
            this.Bit[19].Name = "Bit19";
            this.Bit[19].Size = new System.Drawing.Size(20, 21);
            this.Bit[19].TabIndex = 68;
            this.Bit[19].Text = "0";
            // 
            // Bit18
            // 
            this.Bit[18].AutoSize = true;
            this.Bit[18].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[18].Location = new System.Drawing.Point(264, 70);
            this.Bit[18].Name = "Bit18";
            this.Bit[18].Size = new System.Drawing.Size(20, 21);
            this.Bit[18].TabIndex = 67;
            this.Bit[18].Text = "0";
            // 
            // Bit17
            // 
            this.Bit[17].AutoSize = true;
            this.Bit[17].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[17].Location = new System.Drawing.Point(283, 70);
            this.Bit[17].Name = "Bit17";
            this.Bit[17].Size = new System.Drawing.Size(20, 21);
            this.Bit[17].TabIndex = 66;
            this.Bit[17].Text = "0";
            // 
            // Bit16
            // 
            this.Bit[16].AutoSize = true;
            this.Bit[16].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[16].Location = new System.Drawing.Point(301, 70);
            this.Bit[16].Name = "Bit16";
            this.Bit[16].Size = new System.Drawing.Size(20, 21);
            this.Bit[16].TabIndex = 65;
            this.Bit[16].Text = "0";
            // 
            // Bit15
            // 
            this.Bit[15].AutoSize = true;
            this.Bit[15].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[15].Location = new System.Drawing.Point(328, 70);
            this.Bit[15].Name = "Bit15";
            this.Bit[15].Size = new System.Drawing.Size(20, 21);
            this.Bit[15].TabIndex = 63;
            this.Bit[15].Text = "0";
            // 
            // Bit14
            // 
            this.Bit[14].AutoSize = true;
            this.Bit[14].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[14].Location = new System.Drawing.Point(347, 70);
            this.Bit[14].Name = "Bit14";
            this.Bit[14].Size = new System.Drawing.Size(20, 21);
            this.Bit[14].TabIndex = 62;
            this.Bit[14].Text = "0";
            // 
            // Bit13
            // 
            this.Bit[13].AutoSize = true;
            this.Bit[13].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[13].Location = new System.Drawing.Point(366, 70);
            this.Bit[13].Name = "Bit13";
            this.Bit[13].Size = new System.Drawing.Size(20, 21);
            this.Bit[13].TabIndex = 61;
            this.Bit[13].Text = "0";
            // 
            // Bit12
            // 
            this.Bit[12].AutoSize = true;
            this.Bit[12].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[12].Location = new System.Drawing.Point(384, 70);
            this.Bit[12].Name = "Bit12";
            this.Bit[12].Size = new System.Drawing.Size(20, 21);
            this.Bit[12].TabIndex = 60;
            this.Bit[12].Text = "0";
            // 
            // Bit11
            // 
            this.Bit[11].AutoSize = true;
            this.Bit[11].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[11].Location = new System.Drawing.Point(408, 70);
            this.Bit[11].Name = "Bit11";
            this.Bit[11].Size = new System.Drawing.Size(20, 21);
            this.Bit[11].TabIndex = 58;
            this.Bit[11].Text = "0";
            // 
            // Bit10
            // 
            this.Bit[10].AutoSize = true;
            this.Bit[10].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[10].Location = new System.Drawing.Point(427, 70);
            this.Bit[10].Name = "Bit10";
            this.Bit[10].Size = new System.Drawing.Size(20, 21);
            this.Bit[10].TabIndex = 57;
            this.Bit[10].Text = "0";
            // 
            // Bit09
            // 
            this.Bit[09].AutoSize = true;
            this.Bit[09].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[09].Location = new System.Drawing.Point(446, 70);
            this.Bit[09].Name = "Bit09";
            this.Bit[09].Size = new System.Drawing.Size(20, 21);
            this.Bit[09].TabIndex = 56;
            this.Bit[09].Text = "0";
            // 
            // Bit08
            // 
            this.Bit[08].AutoSize = true;
            this.Bit[08].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[08].Location = new System.Drawing.Point(464, 70);
            this.Bit[08].Name = "Bit08";
            this.Bit[08].Size = new System.Drawing.Size(20, 21);
            this.Bit[08].TabIndex = 55;
            this.Bit[08].Text = "0";
            // 
            // Bit07
            // 
            this.Bit[07].AutoSize = true;
            this.Bit[07].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[07].Location = new System.Drawing.Point(492, 70);
            this.Bit[07].Name = "Bit07";
            this.Bit[07].Size = new System.Drawing.Size(20, 21);
            this.Bit[07].TabIndex = 53;
            this.Bit[07].Text = "0";
            // 
            // Bit06
            // 
            this.Bit[06].AutoSize = true;
            this.Bit[06].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[06].Location = new System.Drawing.Point(511, 70);
            this.Bit[06].Name = "Bit06";
            this.Bit[06].Size = new System.Drawing.Size(20, 21);
            this.Bit[06].TabIndex = 52;
            this.Bit[06].Text = "0";
            // 
            // Bit05
            // 
            this.Bit[05].AutoSize = true;
            this.Bit[05].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[05].Location = new System.Drawing.Point(530, 70);
            this.Bit[05].Name = "Bit05";
            this.Bit[05].Size = new System.Drawing.Size(20, 21);
            this.Bit[05].TabIndex = 51;
            this.Bit[05].Text = "0";
            // 
            // Bit04
            // 
            this.Bit[04].AutoSize = true;
            this.Bit[04].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[04].Location = new System.Drawing.Point(548, 70);
            this.Bit[04].Name = "Bit04";
            this.Bit[04].Size = new System.Drawing.Size(20, 21);
            this.Bit[04].TabIndex = 50;
            this.Bit[04].Text = "0";
            // 
            // Bit03
            // 
            this.Bit[03].AutoSize = true;
            this.Bit[03].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[03].Location = new System.Drawing.Point(571, 70);
            this.Bit[03].Name = "Bit03";
            this.Bit[03].Size = new System.Drawing.Size(20, 21);
            this.Bit[03].TabIndex = 48;
            this.Bit[03].Text = "0";
            // 
            // Bit02
            // 
            this.Bit[02].AutoSize = true;
            this.Bit[02].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[02].Location = new System.Drawing.Point(590, 70);
            this.Bit[02].Name = "Bit02";
            this.Bit[02].Size = new System.Drawing.Size(20, 21);
            this.Bit[02].TabIndex = 47;
            this.Bit[02].Text = "0";
            // 
            // Bit01
            // 
            this.Bit[01].AutoSize = true;
            this.Bit[01].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[01].Location = new System.Drawing.Point(609, 70);
            this.Bit[01].Name = "Bit01";
            this.Bit[01].Size = new System.Drawing.Size(20, 21);
            this.Bit[01].TabIndex = 46;
            this.Bit[01].Text = "0";
            // 
            // Bit[00]
            // 
            this.Bit[00].AutoSize = true;
            this.Bit[00].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bit[00].Location = new System.Drawing.Point(627, 70);
            this.Bit[00].Name = "Bit00";
            this.Bit[00].Size = new System.Drawing.Size(20, 21);
            this.Bit[00].TabIndex = 45;
            this.Bit[00].Text = "0";
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbDecimalPosValue = new System.Windows.Forms.TextBox();
            this.tbHexValue = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.lbl0x = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.tbOctalValue = new System.Windows.Forms.TextBox();
            this.btnInvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDecimalNegValue = new System.Windows.Forms.TextBox();
            this.btnSetAll = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbClear = new System.Windows.Forms.Button();
            this.tbMoveToResult = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbShiftValue = new System.Windows.Forms.TextBox();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInputMask = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblByte = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKByte = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMByte = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblGByte = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PanelBits = new System.Windows.Forms.Panel();
            this.rb32BitMode = new System.Windows.Forms.RadioButton();
            this.rb64BitMode = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PanelBits.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDecimalPosValue
            // 
            this.tbDecimalPosValue.Location = new System.Drawing.Point(114, 145);
            this.tbDecimalPosValue.Name = "tbDecimalPosValue";
            this.tbDecimalPosValue.Size = new System.Drawing.Size(207, 27);
            this.tbDecimalPosValue.TabIndex = 1;
            this.tbDecimalPosValue.TabStop = false;
            this.tbDecimalPosValue.Text = "0";
            this.tbDecimalPosValue.WordWrap = false;
            this.tbDecimalPosValue.TextChanged += new System.EventHandler(this.tbXValue_TextChanged);
            this.tbDecimalPosValue.Leave += new System.EventHandler(this.tbDecimalValue_Leave);
            // 
            // tbHexValue
            // 
            this.tbHexValue.Location = new System.Drawing.Point(402, 145);
            this.tbHexValue.MaxLength = 16;
            this.tbHexValue.Name = "tbHexValue";
            this.tbHexValue.Size = new System.Drawing.Size(207, 27);
            this.tbHexValue.TabIndex = 2;
            this.tbHexValue.TabStop = false;
            this.tbHexValue.Text = "0000000000000000";
            this.tbHexValue.WordWrap = false;
            this.tbHexValue.TextChanged += new System.EventHandler(this.tbXValue_TextChanged);
            this.tbHexValue.Leave += new System.EventHandler(this.tbHexValue_Leave);
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(327, 148);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(42, 19);
            this.lblHex.TabIndex = 3;
            this.lblHex.Text = "Hex:";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(8, 148);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(100, 19);
            this.lblDecimal.TabIndex = 4;
            this.lblDecimal.Text = "Decimal (+):";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(613, 145);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(55, 63);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnResetAll.Location = new System.Drawing.Point(8, 56);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(77, 30);
            this.btnResetAll.TabIndex = 6;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl0x
            // 
            this.lbl0x.AutoSize = true;
            this.lbl0x.Location = new System.Drawing.Point(375, 148);
            this.lbl0x.Name = "lbl0x";
            this.lbl0x.Size = new System.Drawing.Size(26, 19);
            this.lbl0x.TabIndex = 7;
            this.lbl0x.Text = "0x";
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(327, 181);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(51, 19);
            this.lblOctal.TabIndex = 9;
            this.lblOctal.Text = "Octal:";
            // 
            // tbOctalValue
            // 
            this.tbOctalValue.Location = new System.Drawing.Point(402, 181);
            this.tbOctalValue.Name = "tbOctalValue";
            this.tbOctalValue.ReadOnly = true;
            this.tbOctalValue.Size = new System.Drawing.Size(207, 27);
            this.tbOctalValue.TabIndex = 8;
            this.tbOctalValue.TabStop = false;
            this.tbOctalValue.Text = "0";
            this.tbOctalValue.WordWrap = false;
            // 
            // btnInvert
            // 
            this.btnInvert.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnInvert.Location = new System.Drawing.Point(8, 20);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(77, 30);
            this.btnInvert.TabIndex = 10;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Decimal (-):";
            // 
            // tbDecimalNegValue
            // 
            this.tbDecimalNegValue.Location = new System.Drawing.Point(114, 178);
            this.tbDecimalNegValue.Name = "tbDecimalNegValue";
            this.tbDecimalNegValue.ReadOnly = true;
            this.tbDecimalNegValue.Size = new System.Drawing.Size(207, 27);
            this.tbDecimalNegValue.TabIndex = 11;
            this.tbDecimalNegValue.TabStop = false;
            this.tbDecimalNegValue.Text = "0";
            this.tbDecimalNegValue.WordWrap = false;
            // 
            // btnSetAll
            // 
            this.btnSetAll.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSetAll.Location = new System.Drawing.Point(8, 92);
            this.btnSetAll.Name = "btnSetAll";
            this.btnSetAll.Size = new System.Drawing.Size(77, 30);
            this.btnSetAll.TabIndex = 13;
            this.btnSetAll.Text = "Set All";
            this.btnSetAll.UseVisualStyleBackColor = true;
            this.btnSetAll.Click += new System.EventHandler(this.btnSetAll_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnd.Location = new System.Drawing.Point(137, 56);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(42, 26);
            this.btnAnd.TabIndex = 17;
            this.btnAnd.Text = "&&";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOr
            // 
            this.btnOr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOr.Location = new System.Drawing.Point(89, 56);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(42, 26);
            this.btnOr.TabIndex = 16;
            this.btnOr.Text = "|";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnXor
            // 
            this.btnXor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXor.Location = new System.Drawing.Point(185, 56);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(42, 26);
            this.btnXor.TabIndex = 18;
            this.btnXor.Text = "^";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInvert);
            this.groupBox1.Controls.Add(this.btnResetAll);
            this.groupBox1.Controls.Add(this.btnSetAll);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 132);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbClear);
            this.groupBox2.Controls.Add(this.tbMoveToResult);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbShiftValue);
            this.groupBox2.Controls.Add(this.btnShiftRight);
            this.groupBox2.Controls.Add(this.btnShiftLeft);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbOutput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbInputMask);
            this.groupBox2.Controls.Add(this.btnXor);
            this.groupBox2.Controls.Add(this.btnOr);
            this.groupBox2.Controls.Add(this.btnAnd);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(114, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 132);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bitwise Operations";
            // 
            // tbClear
            // 
            this.tbClear.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.tbClear.Location = new System.Drawing.Point(337, 56);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(64, 26);
            this.tbClear.TabIndex = 27;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // tbMoveToResult
            // 
            this.tbMoveToResult.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.tbMoveToResult.Location = new System.Drawing.Point(263, 88);
            this.tbMoveToResult.Name = "tbMoveToResult";
            this.tbMoveToResult.Size = new System.Drawing.Size(138, 26);
            this.tbMoveToResult.TabIndex = 14;
            this.tbMoveToResult.Text = "Move OP to Result";
            this.tbMoveToResult.UseVisualStyleBackColor = true;
            this.tbMoveToResult.Click += new System.EventHandler(this.tbMoveToResult_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Shift value";
            // 
            // tbShiftValue
            // 
            this.tbShiftValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShiftValue.Location = new System.Drawing.Point(359, 23);
            this.tbShiftValue.MaxLength = 2;
            this.tbShiftValue.Name = "tbShiftValue";
            this.tbShiftValue.Size = new System.Drawing.Size(42, 27);
            this.tbShiftValue.TabIndex = 29;
            this.tbShiftValue.TabStop = false;
            this.tbShiftValue.Text = "0";
            this.tbShiftValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbShiftValue.WordWrap = false;
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftRight.Location = new System.Drawing.Point(281, 56);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(42, 26);
            this.btnShiftRight.TabIndex = 27;
            this.btnShiftRight.Text = ">>";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.btnShiftX_Click);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftLeft.Location = new System.Drawing.Point(233, 56);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(42, 26);
            this.btnShiftLeft.TabIndex = 28;
            this.btnShiftLeft.Text = "<<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.btnShiftX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "0x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Output";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(89, 88);
            this.tbOutput.MaxLength = 16;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(160, 27);
            this.tbOutput.TabIndex = 22;
            this.tbOutput.TabStop = false;
            this.tbOutput.Text = "0000000000000000";
            this.tbOutput.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "0x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mask";
            // 
            // tbInputMask
            // 
            this.tbInputMask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputMask.Location = new System.Drawing.Point(89, 23);
            this.tbInputMask.MaxLength = 16;
            this.tbInputMask.Name = "tbInputMask";
            this.tbInputMask.Size = new System.Drawing.Size(160, 27);
            this.tbInputMask.TabIndex = 19;
            this.tbInputMask.TabStop = false;
            this.tbInputMask.Text = "0000000000000000";
            this.tbInputMask.WordWrap = false;
            this.tbInputMask.TextChanged += new System.EventHandler(this.tbOperationInput_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblByte,
            this.toolStripStatusLabel2,
            this.lblKByte,
            this.toolStripStatusLabel1,
            this.lblMByte,
            this.toolStripStatusLabel3,
            this.lblGByte,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblByte
            // 
            this.lblByte.Name = "lblByte";
            this.lblByte.Size = new System.Drawing.Size(13, 17);
            this.lblByte.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel2.Text = "Byte |";
            // 
            // lblKByte
            // 
            this.lblKByte.Name = "lblKByte";
            this.lblKByte.Size = new System.Drawing.Size(13, 17);
            this.lblKByte.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "KByte |";
            // 
            // lblMByte
            // 
            this.lblMByte.Name = "lblMByte";
            this.lblMByte.Size = new System.Drawing.Size(13, 17);
            this.lblMByte.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel3.Text = "MByte |";
            // 
            // lblGByte
            // 
            this.lblGByte.Name = "lblGByte";
            this.lblGByte.Size = new System.Drawing.Size(13, 17);
            this.lblGByte.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel4.Text = "GByte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(635, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(473, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(303, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "16";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(141, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "24";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(489, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(325, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(162, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "23";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(0, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 92;
            this.label16.Text = "31";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Location = new System.Drawing.Point(630, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 133;
            this.label24.Text = "32";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label23.Location = new System.Drawing.Point(467, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 13);
            this.label23.TabIndex = 134;
            this.label23.Text = "40";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(304, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 135;
            this.label22.Text = "48";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.Location = new System.Drawing.Point(142, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 136;
            this.label21.Text = "56";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(490, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 137;
            this.label20.Text = "39";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(326, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 138;
            this.label19.Text = "47";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Location = new System.Drawing.Point(163, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 139;
            this.label18.Text = "55";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(1, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 140;
            this.label17.Text = "63";
            // 
            // PanelBits
            // 
            this.PanelBits.BackColor = System.Drawing.Color.White;
            this.PanelBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelBits.Controls.Add(this.label17);
            this.PanelBits.Controls.Add(this.label18);
            this.PanelBits.Controls.Add(this.label19);
            this.PanelBits.Controls.Add(this.label20);
            this.PanelBits.Controls.Add(this.label21);
            this.PanelBits.Controls.Add(this.label22);
            this.PanelBits.Controls.Add(this.label23);
            this.PanelBits.Controls.Add(this.label24);
            this.PanelBits.Controls.Add(this.label16);
            this.PanelBits.Controls.Add(this.label15);
            this.PanelBits.Controls.Add(this.label14);
            this.PanelBits.Controls.Add(this.label13);
            this.PanelBits.Controls.Add(this.label12);
            this.PanelBits.Controls.Add(this.label11);
            this.PanelBits.Controls.Add(this.label10);
            this.PanelBits.Controls.Add(this.label9);
            this.PanelBits.Location = new System.Drawing.Point(12, 13);
            this.PanelBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelBits.Name = "PanelBits";
            this.PanelBits.Size = new System.Drawing.Size(656, 117);
            this.PanelBits.TabIndex = 0;
            // 
            // rb32BitMode
            // 
            this.rb32BitMode.AutoSize = true;
            this.rb32BitMode.BackColor = System.Drawing.Color.Transparent;
            this.rb32BitMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb32BitMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb32BitMode.ForeColor = System.Drawing.Color.Red;
            this.rb32BitMode.Location = new System.Drawing.Point(1, 15);
            this.rb32BitMode.Name = "rb32BitMode";
            this.rb32BitMode.Size = new System.Drawing.Size(36, 23);
            this.rb32BitMode.TabIndex = 27;
            this.rb32BitMode.Text = "_";
            this.rb32BitMode.UseVisualStyleBackColor = false;
            this.rb32BitMode.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
            // 
            // rb64BitMode
            // 
            this.rb64BitMode.AutoSize = true;
            this.rb64BitMode.BackColor = System.Drawing.Color.Transparent;
            this.rb64BitMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb64BitMode.Checked = true;
            this.rb64BitMode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rb64BitMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb64BitMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb64BitMode.ForeColor = System.Drawing.Color.Red;
            this.rb64BitMode.Location = new System.Drawing.Point(63, 70);
            this.rb64BitMode.Name = "rb64BitMode";
            this.rb64BitMode.Size = new System.Drawing.Size(56, 23);
            this.rb64BitMode.TabIndex = 28;
            this.rb64BitMode.TabStop = true;
            this.rb64BitMode.Text = "___";
            this.rb64BitMode.UseVisualStyleBackColor = false;
            this.rb64BitMode.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rb32BitMode);
            this.panel1.Controls.Add(this.rb64BitMode);
            this.panel1.Location = new System.Drawing.Point(537, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 123);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 374);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDecimalNegValue);
            this.Controls.Add(this.lblOctal);
            this.Controls.Add(this.tbOctalValue);
            this.Controls.Add(this.lbl0x);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.tbHexValue);
            this.Controls.Add(this.tbDecimalPosValue);
            this.Controls.Add(this.PanelBits);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bit Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PanelBits.ResumeLayout(false);
            this.PanelBits.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label[] Bit;
        private System.Windows.Forms.TextBox[] Nibble;
        private System.Windows.Forms.TextBox tbDecimalPosValue;
        private System.Windows.Forms.TextBox tbHexValue;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Label lbl0x;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.TextBox tbOctalValue;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDecimalNegValue;
        private System.Windows.Forms.Button btnSetAll;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInputMask;
        private System.Windows.Forms.Button tbMoveToResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblByte;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblKByte;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblMByte;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblGByte;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbShiftValue;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel PanelBits;
        private System.Windows.Forms.RadioButton rb32BitMode;
        private System.Windows.Forms.RadioButton rb64BitMode;
        private System.Windows.Forms.Panel panel1;
    }
}

