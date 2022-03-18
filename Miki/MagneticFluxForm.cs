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
    public partial class MagneticFluxForm : Form
    {
        public MagneticFluxForm() => InitializeComponent();

        private void MagneticFluxForm_Load(object sender, EventArgs e)
        {
            MagneticFieldCbox.Text += "T";
            AngleCbox.Text += "°";
            AreaCbox.Text += "m²";
        }

        private void MagneticFieldTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, MagneticFieldTxt);
        }

        private void AngleTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, AngleTxt);
        }

        private void AreaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(sender, e, AreaTxt);
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            float T = ParseFloat(MagneticFieldTxt.Text);
            float angle = ParseFloat(AngleTxt.Text);
            float area = ParseFloat(AreaTxt.Text);
            float result = (float)((T * area) * MathF.Cos(angle * (MathF.PI/180.0F)));
            ResultsTxt.Text = decimal.Round((decimal)result, 2).ToString("0.00") + @" 𝑾𝒃";
        }
    }
}
