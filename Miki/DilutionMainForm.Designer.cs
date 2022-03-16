#region MIT License
// Copyright (c) 2022 Glenn Alon
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

namespace Miki
{
    partial class DilutionMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InitialConcentrationCbox = new System.Windows.Forms.ComboBox();
            this.InitialConcentrationTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InitialVolumeCbox = new System.Windows.Forms.ComboBox();
            this.InitialVolumeTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FinalVolumeCbox = new System.Windows.Forms.ComboBox();
            this.FinalVolumeTxt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FinalConcentrationCbox = new System.Windows.Forms.ComboBox();
            this.FinalConcentrationTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InitialConcentrationCbox);
            this.groupBox1.Controls.Add(this.InitialConcentrationTxt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concentration (Initial)";
            // 
            // InitialConcentrationCbox
            // 
            this.InitialConcentrationCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialConcentrationCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitialConcentrationCbox.FormattingEnabled = true;
            this.InitialConcentrationCbox.Items.AddRange(new object[] {
            "M"});
            this.InitialConcentrationCbox.Location = new System.Drawing.Point(178, 24);
            this.InitialConcentrationCbox.Name = "InitialConcentrationCbox";
            this.InitialConcentrationCbox.Size = new System.Drawing.Size(67, 26);
            this.InitialConcentrationCbox.TabIndex = 1;
            // 
            // InitialConcentrationTxt
            // 
            this.InitialConcentrationTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InitialConcentrationTxt.Location = new System.Drawing.Point(6, 25);
            this.InitialConcentrationTxt.Name = "InitialConcentrationTxt";
            this.InitialConcentrationTxt.Size = new System.Drawing.Size(166, 26);
            this.InitialConcentrationTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InitialVolumeCbox);
            this.groupBox2.Controls.Add(this.InitialVolumeTxt);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(15, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume (Initial)";
            // 
            // InitialVolumeCbox
            // 
            this.InitialVolumeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialVolumeCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitialVolumeCbox.FormattingEnabled = true;
            this.InitialVolumeCbox.Items.AddRange(new object[] {
            "mL",
            "L"});
            this.InitialVolumeCbox.Location = new System.Drawing.Point(178, 25);
            this.InitialVolumeCbox.Name = "InitialVolumeCbox";
            this.InitialVolumeCbox.Size = new System.Drawing.Size(67, 26);
            this.InitialVolumeCbox.TabIndex = 1;
            // 
            // InitialVolumeTxt
            // 
            this.InitialVolumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InitialVolumeTxt.Location = new System.Drawing.Point(6, 25);
            this.InitialVolumeTxt.Name = "InitialVolumeTxt";
            this.InitialVolumeTxt.Size = new System.Drawing.Size(166, 26);
            this.InitialVolumeTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FinalVolumeCbox);
            this.groupBox3.Controls.Add(this.FinalVolumeTxt);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 57);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Volume (Final)";
            // 
            // FinalVolumeCbox
            // 
            this.FinalVolumeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinalVolumeCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalVolumeCbox.FormattingEnabled = true;
            this.FinalVolumeCbox.Items.AddRange(new object[] {
            "mL",
            "L"});
            this.FinalVolumeCbox.Location = new System.Drawing.Point(178, 25);
            this.FinalVolumeCbox.Name = "FinalVolumeCbox";
            this.FinalVolumeCbox.Size = new System.Drawing.Size(67, 26);
            this.FinalVolumeCbox.TabIndex = 1;
            // 
            // FinalVolumeTxt
            // 
            this.FinalVolumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalVolumeTxt.Location = new System.Drawing.Point(6, 25);
            this.FinalVolumeTxt.Name = "FinalVolumeTxt";
            this.FinalVolumeTxt.Size = new System.Drawing.Size(166, 26);
            this.FinalVolumeTxt.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FinalConcentrationCbox);
            this.groupBox4.Controls.Add(this.FinalConcentrationTxt);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(15, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 57);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Concentration (Final)";
            // 
            // FinalConcentrationCbox
            // 
            this.FinalConcentrationCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinalConcentrationCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalConcentrationCbox.FormattingEnabled = true;
            this.FinalConcentrationCbox.Items.AddRange(new object[] {
            "M"});
            this.FinalConcentrationCbox.Location = new System.Drawing.Point(178, 25);
            this.FinalConcentrationCbox.Name = "FinalConcentrationCbox";
            this.FinalConcentrationCbox.Size = new System.Drawing.Size(67, 26);
            this.FinalConcentrationCbox.TabIndex = 1;
            // 
            // FinalConcentrationTxt
            // 
            this.FinalConcentrationTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalConcentrationTxt.Location = new System.Drawing.Point(6, 25);
            this.FinalConcentrationTxt.Name = "FinalConcentrationTxt";
            this.FinalConcentrationTxt.Size = new System.Drawing.Size(166, 26);
            this.FinalConcentrationTxt.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(9, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 66);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(238, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find the";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M1",
            "V1",
            "M2",
            "V2"});
            this.comboBox1.Location = new System.Drawing.Point(93, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(166, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DilutionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DilutionMainForm";
            this.Text = "Dilution Solution";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox InitialConcentrationCbox;
        private TextBox InitialConcentrationTxt;
        private GroupBox groupBox2;
        private ComboBox InitialVolumeCbox;
        private TextBox InitialVolumeTxt;
        private GroupBox groupBox3;
        private ComboBox FinalVolumeCbox;
        private TextBox FinalVolumeTxt;
        private GroupBox groupBox4;
        private ComboBox FinalConcentrationCbox;
        private TextBox FinalConcentrationTxt;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}