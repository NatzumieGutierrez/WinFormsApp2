using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Activity2_Load(object sender, EventArgs e)
        {



            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\MCFLOAT.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\MCFLURRY.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\HOT FUDGE SUNDAE.png");
            pictureBox4.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\APPLE PIE.png");
            pictureBox5.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\BFAST A.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\BFAST B.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\BFAST MEAL B.png");
            pictureBox8.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\PANCAKE VALUE MEAL A.png");
            pictureBox9.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\CHK MEAL 2.png");
            pictureBox10.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\BIGMAC.png");
            pictureBox11.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\CHK MEAL A.png");
            pictureBox12.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\DBL PALABOK MEAL.png");
            pictureBox13.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\DBL VAL MEAL A.png");
            pictureBox14.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\FAMCOMBO MEAL A.png");
            pictureBox15.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\FAMCOMBO MEAL B.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\FRND MEAL A.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\PSTA MEAL 101.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\LNCH VAL MEAL 1.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\LUNCH VALUE MEAL B.png");
            pictureBox20.Image = Image.FromFile("C:\\Users\\C203-03.C203-03\\Pictures\\PIC\\FRND MEAL A.png");




        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SENIOR CITIZEN radio button:
                int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discounted_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            regularButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

            with DISC. CARD radio button:



        }
    }
}
