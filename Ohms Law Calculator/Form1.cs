using System.ComponentModel;

namespace Ohms_Law_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double voltin = 0;
        double amperein = 0;
        double wattin = 0;
        double ohmsin = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //Volt & Ampere
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double.TryParse(textBox1.Text, out voltin);
                double .TryParse(textBox2.Text, out amperein);  
                
                wattin = voltin * amperein;
                textBox3.Text = wattin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox3.Text = wattin.ToString("0.###");
                }

                ohmsin = voltin / amperein;
                textBox4.Text = ohmsin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox4.Text = ohmsin.ToString("0.###");
                }
            }
           
            //Volt & Watt
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                double.TryParse(textBox1.Text, out voltin);
                double.TryParse(textBox3.Text, out wattin);

                amperein = wattin / voltin; 
                textBox2.Text = amperein.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = amperein.ToString("0.###");
                }
          
                ohmsin = (voltin * voltin) / wattin;
                textBox4.Text = ohmsin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox4.Text = ohmsin.ToString("0.###");
                }
            }

            //Volt & Ohms
            if (textBox1.Text != "" && textBox4.Text != "")
            {
                double.TryParse(textBox1.Text, out voltin);
                double.TryParse(textBox4.Text, out ohmsin);

                amperein = voltin / ohmsin;
                textBox2.Text = amperein.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = amperein.ToString("0.###");
                }
              
                wattin = (voltin * voltin) / ohmsin;
                textBox3.Text = wattin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox3.Text = wattin.ToString("0.###");
                }
            }

            //Ampere & watt 
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                double.TryParse(textBox2.Text, out amperein);
                double.TryParse(textBox3.Text, out wattin);

                voltin = wattin / amperein;
                textBox1.Text = voltin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox1.Text = voltin.ToString("0.###");
                }
               
                ohmsin = wattin / (amperein * amperein);
                textBox4.Text = ohmsin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox4.Text = ohmsin.ToString("0.###");
                }
            }

            //Ampere & Ohms
            if (textBox2.Text != "" && textBox4.Text != "")
            {
                double.TryParse(textBox2.Text, out amperein);
                double.TryParse(textBox4.Text, out ohmsin);

                voltin = amperein * ohmsin; 
                textBox1.Text = voltin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox1.Text = voltin.ToString("0.###");
                }
               
                wattin = (amperein * amperein) * ohmsin;
                textBox3.Text = wattin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox3.Text = wattin.ToString("0.###");
                }
            }

            //Watt & Ohms
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                double.TryParse(textBox3.Text, out amperein);
                double.TryParse(textBox4.Text, out ohmsin);

                voltin = Math.Sqrt(wattin * ohmsin);
                textBox1.Text = voltin.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox1.Text = voltin.ToString("0.###");
                }
                
                amperein = Math.Sqrt(wattin / ohmsin);
                textBox2.Text = amperein.ToString();
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = amperein.ToString("0.###");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
