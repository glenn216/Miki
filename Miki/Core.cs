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
    internal static class Core
    {
        internal static double ParseDouble(string x)
        {
            return string.IsNullOrWhiteSpace(x) ? 0 : Convert.ToDouble(x);
        }

        internal static float ParseFloat(string x)
        {
            return string.IsNullOrWhiteSpace(x) ? 0 : Convert.ToSingle(x);
        }

        internal static double ParseVolume(string V, string unit)
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

        internal static void ValidateNumber(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            switch (e.KeyChar)
            {
                case '-':
                    _ = textBox.Text + "-";
                    textBox.SelectionStart = textBox.Text.Length;
                    break;
                default:
                    if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) || ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1)) || ((e.KeyChar == '-') && (((TextBox)sender).Text.IndexOf('.') > -1)))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }
    }
}
