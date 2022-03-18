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
    partial class MagneticFluxForm
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AngleCbox = new System.Windows.Forms.ComboBox();
            this.AngleTxt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AreaCbox = new System.Windows.Forms.ComboBox();
            this.AreaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MagneticFieldCbox = new System.Windows.Forms.ComboBox();
            this.MagneticFieldTxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ResultsTxt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateBtn.Location = new System.Drawing.Point(192, 238);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 29);
            this.CalculateBtn.TabIndex = 16;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AngleCbox);
            this.groupBox2.Controls.Add(this.AngleTxt);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 57);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angle (ϕ)";
            // 
            // AngleCbox
            // 
            this.AngleCbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AngleCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AngleCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AngleCbox.FormattingEnabled = true;
            this.AngleCbox.Items.AddRange(new object[] {
            "°"});
            this.AngleCbox.Location = new System.Drawing.Point(178, 25);
            this.AngleCbox.Name = "AngleCbox";
            this.AngleCbox.Size = new System.Drawing.Size(67, 26);
            this.AngleCbox.TabIndex = 1;
            // 
            // AngleTxt
            // 
            this.AngleTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AngleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AngleTxt.Location = new System.Drawing.Point(6, 25);
            this.AngleTxt.Name = "AngleTxt";
            this.AngleTxt.Size = new System.Drawing.Size(166, 26);
            this.AngleTxt.TabIndex = 0;
            this.AngleTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AngleTxt_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AreaCbox);
            this.groupBox4.Controls.Add(this.AreaTxt);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(14, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 57);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Area (A)";
            // 
            // AreaCbox
            // 
            this.AreaCbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AreaCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreaCbox.FormattingEnabled = true;
            this.AreaCbox.Items.AddRange(new object[] {
            "m²"});
            this.AreaCbox.Location = new System.Drawing.Point(178, 25);
            this.AreaCbox.Name = "AreaCbox";
            this.AreaCbox.Size = new System.Drawing.Size(67, 26);
            this.AreaCbox.TabIndex = 1;
            // 
            // AreaTxt
            // 
            this.AreaTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AreaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreaTxt.Location = new System.Drawing.Point(6, 25);
            this.AreaTxt.Name = "AreaTxt";
            this.AreaTxt.Size = new System.Drawing.Size(166, 26);
            this.AreaTxt.TabIndex = 0;
            this.AreaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AreaTxt_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MagneticFieldCbox);
            this.groupBox1.Controls.Add(this.MagneticFieldTxt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magnetic Field (B)";
            // 
            // MagneticFieldCbox
            // 
            this.MagneticFieldCbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MagneticFieldCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MagneticFieldCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MagneticFieldCbox.FormattingEnabled = true;
            this.MagneticFieldCbox.Items.AddRange(new object[] {
            "T"});
            this.MagneticFieldCbox.Location = new System.Drawing.Point(178, 25);
            this.MagneticFieldCbox.Name = "MagneticFieldCbox";
            this.MagneticFieldCbox.Size = new System.Drawing.Size(67, 26);
            this.MagneticFieldCbox.TabIndex = 1;
            // 
            // MagneticFieldTxt
            // 
            this.MagneticFieldTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MagneticFieldTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MagneticFieldTxt.Location = new System.Drawing.Point(6, 25);
            this.MagneticFieldTxt.Name = "MagneticFieldTxt";
            this.MagneticFieldTxt.Size = new System.Drawing.Size(166, 26);
            this.MagneticFieldTxt.TabIndex = 0;
            this.MagneticFieldTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MagneticFieldTxt_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ResultsTxt);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(9, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 66);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results";
            // 
            // ResultsTxt
            // 
            this.ResultsTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsTxt.Location = new System.Drawing.Point(4, 25);
            this.ResultsTxt.Name = "ResultsTxt";
            this.ResultsTxt.ReadOnly = true;
            this.ResultsTxt.Size = new System.Drawing.Size(247, 26);
            this.ResultsTxt.TabIndex = 2;
            // 
            // MagneticFluxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MagneticFluxForm";
            this.Text = "MagneticFlux";
            this.Load += new System.EventHandler(this.MagneticFluxForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CalculateBtn;
        private GroupBox groupBox2;
        private ComboBox AngleCbox;
        private TextBox AngleTxt;
        private GroupBox groupBox4;
        private ComboBox AreaCbox;
        private TextBox AreaTxt;
        private GroupBox groupBox1;
        private ComboBox MagneticFieldCbox;
        private TextBox MagneticFieldTxt;
        private GroupBox groupBox5;
        private TextBox ResultsTxt;
    }
}