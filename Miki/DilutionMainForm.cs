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
    public partial class DilutionMainForm : Form
    {
        public DilutionMainForm()
        {
            InitializeComponent();
            this.Focus();
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

            double m1 = ParseM(m1_tmp);
            double m2 = ParseM(m2_tmp);
            double v1 = ParseV(v1_tmp, v1unit);
            double v2 = ParseV(v2_tmp, v2unit);

            double result;

            switch (comboBox1.SelectedItem)
            {
                case "M1":
                    result = (m2 * v2) / v1; // (m2 * v2) / v1
                    textBox1.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " M";
                    break;
                case "M2":
                    result = (m1 * v1) / v2; // (m1 * v1) / v2
                    textBox1.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " M";
                    break;
                case "V1":
                    result = (m2 * v2) / m1; // (m2 * v2) / m1
                    textBox1.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " mL";
                    break;
                case "V2":
                    result = (m1 * v1) / m2; // (m1 * v1) / m2 
                    textBox1.Text = decimal.Round((decimal)result, 2).ToString("0.00") + " mL";
                    break;
                default:
                    MessageBox.Show("Choose a valid unknown.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                    break;
            }
        }

        private static double ParseM(string M) => string.IsNullOrWhiteSpace(M) ? 0 : Convert.ToDouble(M);

        private static double ParseV(string V, string unit)
        {
            double v = string.IsNullOrWhiteSpace(V) ? 0 : Convert.ToDouble(V);
            switch (unit)
            {
                case "L":
                    double result = v * 1000;
                    return result;
                case "mL":
                    return v;
                default:
                    return 0;
            }
        }
        private static void ValidateNumber(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }

        private void InitialConcentrationTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e);
        }

        private void InitialVolumeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e);
        }

        private void FinalConcentrationTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e);
        }

        private void FinalVolumeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e);
        }
    }
}