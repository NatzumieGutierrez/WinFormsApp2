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

        private double total_amount = 0;
        private int qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;
        private double total_qty = 0;



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
            itemnametxtbox.Text = name1lbl.Text;
            pricetextbox.Text = "45";




        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;


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

            name1lbl.Text = "MCFLOAT";
            name2lbl.Text = "MCFLURRY";
            name3lbl.Text = "SUNDAE";
            name4lbl.Text = "APPLE PIE";
            name5lbl.Text = "BFAST A";
            name6lbl.Text = "BIGMAC";
            name7lbl.Text = "2pc CHX";
            name8lbl.Text = "2pc PANCAKE";
            name9lbl.Text = "MC MUFFIN";
            name10lbl.Text = "PANCAKE MEAL";
            name11lbl.Text = "6pc BUCKET";
            name12lbl.Text = "8pc BUCKET";
            name13lbl.Text = "2pc MEAL";
            name14lbl.Text = "PALABOK";
            name15lbl.Text = "1pc CHICKEN";
            name16lbl.Text = "FAM MEAL";
            name17lbl.Text = "SUPER MEAL";
            name18lbl.Text = "BURGER STEAK";
            name19lbl.Text = "SPAG CHX";
            name20lbl.Text = "FAM MEAL 2";


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            Senior.Checked = false;
            Employee.Checked = false;
            nodisc.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //Senior CITIZEN radio button
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            Senior.Checked = false;
            Employee.Checked = false;
            nodisc.Checked = false;



        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Employee_CheckedChanged(object sender, EventArgs e)
        {
            //EMPLOYEE DISC radio button
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            Senior.Checked = false;
            Employee.Checked = false;
            nodisc.Checked = false;

        }

        private void nodisc_CheckedChanged(object sender, EventArgs e)
        {
            //NO DISCOUNT radio button
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            Senior.Checked = false;
            Employee.Checked = false;
            nodisc.Checked = false;
        }

        private void itemnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {

        }

        private void exitbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newbttn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            cashrenderedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = "70";

            itemnametxtbox.Text = name3lbl.Text;
            pricetextbox.Text = "60";

            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = "32";

            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = "45";

            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = "45";

            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = "95";

            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = "240";

            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = "35";

            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = "105";

            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = "645";

            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = "845";

            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = "175";

            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = "145";

            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = "70";

            itemnametxtbox.Text = name16lbl.Text;
            pricetextbox.Text = "257.50";

            itemnametxtbox.Text = name17lbl.Text;
            pricetextbox.Text = "250.30";

            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = "99.9";

            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = "140.70";

            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = "257.50";
        }

        private void calculate_Click_1(object sender, EventArgs e)
        {
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);

            qty_total += qty;
            discount_totalgiven += discounted_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            qty_totaltxtbox.Text = qty_total.ToString();
            discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");
            discounted_totaltxtbox.Text = discounted_total.ToString("n");
        }

        private void qty_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name3lbl.Text;
            pricetextbox.Text = "60";


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = "32";


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = "45";


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = "45";


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = "95";


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = "240";


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = "35";


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = "105";


        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = "645";


        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = "845";


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = "175";


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = "145";


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = "70";


        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {


            itemnametxtbox.Text = name17lbl.Text;
            pricetextbox.Text = "250.30";


        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = "99.9";


        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = "140.70";


        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {


            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = "257.50";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = "140.70";

            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = "257.50";
        }

        private void cashrenderedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}