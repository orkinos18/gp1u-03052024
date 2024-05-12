using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp1uö03052024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SORU: Aşağıdaki form görüntüsünü oluşturarak, ÇAlışma departmanına göre
        //butona basınca risk faktörünü labela yazdıran kodu yazınız


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = "10000 TL.";
            if (radioButton2.Checked)
                label1.Text = "15000 TL.";
            if (radioButton3.Checked)
                label1.Text = "5000 TL.";
        }
    }
}
