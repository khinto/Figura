using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int gverdi1, gverdi2, gverdi3, perim_kvadratis, perim_mart, perim_sam;
            double  fartobi, fartobi_kvadratis, fartobi_sam, fartobi_mart;
            gverdi1 = int.Parse(textBox1.Text);
            gverdi2 = int.Parse(textBox2.Text);
            gverdi3 = int.Parse(textBox3.Text);
            


            Figura martkutxedi = new Figura(gverdi1, gverdi2);
            Figura kvadrati = new Figura(gverdi1);
            
            Figura samkutxedi = new Figura(gverdi1, gverdi2, gverdi3);

            perim_kvadratis = kvadrati.Perimetri();
            perim_sam = samkutxedi.Perimetri();
            perim_mart = martkutxedi.Perimetri();
            fartobi_kvadratis = kvadrati.Fartobi();
            fartobi_sam = samkutxedi.Fartobi();
            fartobi_mart = martkutxedi.Fartobi();


            label1.Text = "კვადრატის პერიმეტრი " + perim_kvadratis.ToString() + " კვადრატის ფართობი  " + fartobi_kvadratis.ToString();

            label2.Text = "სამკუთხედის პერიმეტრი " + perim_sam.ToString() + " სამკუთხედის ფართობი " + fartobi_sam.ToString();

            label3.Text = "მართკუთხედის პერიმეტრი " + perim_mart.ToString()  +" მართკუთხედის ფართობი " + fartobi_mart.ToString();












        }
    }
}
