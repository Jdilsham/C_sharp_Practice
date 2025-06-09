using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            string language = "";

            if (radioMale.Checked) {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }

            if (radioEnglish.Checked)
            {
                language = "English";
            }
            else if (radioSinhala.Checked)
            {
                language = "Sinhala";
            }
            else if(radioTamil.Checked)
            {
                language = "Tamil";
            }

            label1.Text = $"Your gender is {gender} and language is {language}.";

        }

        private void englishradio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
