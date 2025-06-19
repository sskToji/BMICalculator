using System.Runtime.InteropServices;

namespace BMI_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string berekenBMI(float gewichtKG, float lengteM)
        {
            if (gewichtKG > 0 && lengteM > 0)
            {
                return (gewichtKG / (lengteM * lengteM)).ToString();
            }
            else
                return "Invalid Value";
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            bool box1 = float.TryParse(textBox1.Text.Replace(",", "."), out float weight);
            bool box2 = float.TryParse(textBox2.Text.Replace(",", "."), out float length);

            if (box1 && box2)
            {
                Result.Text = berekenBMI(weight, length);
            }
            if (box1 == false || box2 == false)
            {
                Result.Text = "Voer A.U.B. nummers in";
                if (box1 == false)
                {
                    textBox1.Text = string.Empty;
                    Result.Text += " Gewicht";
                }
                if (box2 == false)
                {
                    textBox2.Text = string.Empty;
                    Result.Text += " Lengte";
                }
            }


        }

        private void TextBoxChange(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text.Replace(",", "."), out float weight) && float.TryParse(textBox2.Text.Replace(",", "."), out float length))
            {
                Result.Text = berekenBMI(weight, length);
            }
            else
            {
                Result.Text = "Voer A.U.B. nummers in";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Result.Text = default;
            textBox1.Text = default;
            textBox2.Text = default;
        }
    }
}

