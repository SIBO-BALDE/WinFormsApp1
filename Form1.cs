using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {


        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        //FunctionPointerAttributes pour mes buttons
        private void txtValeur_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Bouton 1 cliqu� !");
            txtValue.Text = txtValue.Text + 1;

        }
        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 2;
            //txtValue.Text += "1";
            //MessageBox.Show("Bouton 2 cliqu� !");
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 3;
            //txtValue.Text += "1";
            //MessageBox.Show("Bouton 3 cliqu� !");
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 4;
            //MessageBox.Show("Bouton 4 cliqu� !");

        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 5;
            //MessageBox.Show("Bouton 5 cliqu� !");

        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 6;
            //MessageBox.Show("Bouton 6 cliqu� !");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 7;
            //MessageBox.Show("Bouton 7 cliqu� !");

        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 8;
            //MessageBox.Show("Bouton 8 cliqu� !");

        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 9;
            //MessageBox.Show("Bouton 9 cliqu� !");

        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + 0;
            //MessageBox.Show("Bouton 0 cliqu� !");
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = "";
            //MessageBox.Show("Bouton c cliqu� !");

        }
        //soustraction button
        int opera;
        float valeur1;
        float valeur2;
        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            opera = 1;
            string a = txtValue.Text;
            float.TryParse(a, out valeur1);
            txtValue.Text = "";

        }


        //Function egale somme
        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            if (opera == 1)
            {
                string b = txtValue.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 - valeur2;
                txtValue.Text = ("" + a);


            }
            if (opera == 2)
            {
                string b = txtValue.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 + valeur2;
                txtValue.Text = ("" + a);


            }
            if (opera == 3)
            {
                string b = txtValue.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 * valeur2;
                txtValue.Text = ("" + a);


            }

            if (opera == 4)
            {
                string b = txtValue.Text;
                float.TryParse(b, out valeur2);
                float a = valeur1 / valeur2;
                txtValue.Text = ("" + a);


            }
        }
        //Function Plus addition operation
        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            opera = 2;
            string a = txtValue.Text;
            float.TryParse(a, out valeur1);
            txtValue.Text = "";

        }
        //funtion multiplication
        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Bouton * cliqu� !");
            opera = 3;
            string a = txtValue.Text;
            float.TryParse(a, out valeur1);
            txtValue.Text = "";


        }
        //FUNTION POUR DIVISION

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            opera = 4;
            string a = txtValue.Text;
            float.TryParse(a, out valeur1);
            txtValue.Text = "";

        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            txtValue.Text = txtValue.Text + ",";

        }
    }
}
