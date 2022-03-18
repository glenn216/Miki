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

using static Miki.Core;

namespace Miki
{
    public partial class SolutionDilutionForm : Form
    {
        public SolutionDilutionForm()
        {
            InitializeComponent();
        }

        private void SolutionDilutionForm_Load(object sender, EventArgs e)
        {
            InitialConcentrationCbox.Text += "M";
            InitialVolumeCbox.Text += "mL";
            FinalConcentrationCbox.Text += "M";
            FinalVolumeCbox.Text += "mL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m1_tmp = InitialConcentrationTxt.Text;
            string v1_tmp = InitialVolumeTxt.Text; 
            string m2_tmp = FinalConcentrationTxt.Text;
            string v2_tmp = FinalVolumeTxt.Text; 

            string v1unit = InitialVolumeCbox.Text;
            string v2unit = FinalVolumeCbox.Text;

            double m1 = ParseDouble(m1_tmp);
            double m2 = ParseDouble(m2_tmp); 

            double v1 = ParseVolume(v1_tmp, v1unit);
            double v2 = ParseVolume(v2_tmp, v2unit);

            double result;

            switch (comboBox1.SelectedItem)
            {
                case "M1":
                    result = (m2 * v2) / v1; // (m2 * v2) / v1
                    ResultsTxt.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " M";
                    break;
                case "M2":
                    result = (m1 * v1) / v2; // (m1 * v1) / v2
                    ResultsTxt.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " M";
                    break;
                case "V1":
                    result = (m2 * v2) / m1; // (m2 * v2) / m1
                    ResultsTxt.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " mL";
                    break;
                case "V2":
                    result = (m1 * v1) / m2; // (m1 * v1) / m2 
                    ResultsTxt.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " mL";
                    break;
                default:
                    MessageBox.Show("Choose a valid unknown.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                    break;
            }
        }

        private void InitialConcentrationTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, InitialConcentrationTxt);
        }

        private void InitialVolumeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, InitialVolumeTxt);
        }

        private void FinalConcentrationTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, FinalConcentrationTxt);
        }

        private void FinalVolumeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, FinalVolumeTxt);
        }
    }
}