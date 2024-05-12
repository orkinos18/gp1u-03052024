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
    public partial class maas : Form
    {
        public maas()
        {
            InitializeComponent();
        }

        private void maas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(0);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.SelectedItem = 0;

        }
        const double mmk = 1.7;//global
        int tabanmaas = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem = 0;

            //taban mmas
            if (radioButton1.Checked)
                labelTabanmaas.Text = (mmk * 10000).ToString();
            if (radioButton2.Checked)
                labelTabanmaas.Text = (mmk * 12000).ToString();
            if (radioButton3.Checked)
                labelTabanmaas.Text = (mmk * 15000).ToString();
            //aile yardımı
            if (radioButton4.Checked)//bekar
                labelAile.Text = 0.ToString();
            if (radioButton5.Checked && !checkBox1.Checked)
                labelAile.Text=(mmk*1000).ToString();
            if (checkBox1.Checked)
                labelAile.Text = 0.ToString();
            //çocuk yardımı
            string cocuksayisi =(comboBox1.SelectedItem).ToString();
            switch (cocuksayisi)
            {
                case "0": labelCocuk.Text = 0.ToString();break;
                case "1": labelCocuk.Text = (mmk * 100).ToString(); break;
                case "2": labelCocuk.Text = (mmk * 200).ToString(); break;
                default: labelCocuk.Text = (mmk * 300).ToString(); break;
            }
            //Kurum 
            if (radioButton8.Checked)
                labelKurum.Text = (mmk * 8500).ToString();
            if (radioButton7.Checked)
                labelKurum.Text = (mmk * 9000).ToString();
            if (radioButton6.Checked)
                labelKurum.Text = (mmk * 8000).ToString();
            //y.dil tazminatı
            double ydil = 0;
            if (checkBox2.Checked)
                ydil += mmk * 500;
            if (checkBox3.Checked)
                ydil += mmk * 500;
            if (checkBox4.Checked)
                ydil += mmk * 500;
            labelYdil.Text = ydil.ToString();
            //gelirV
            tabanmaas=Convert.ToInt32(labelTabanmaas.Text);
            if (radioButton11.Checked)
                labelGelirV.Text = (tabanmaas * 0.15 / 2).ToString();
            if (radioButton10.Checked)
                labelGelirV.Text = (tabanmaas * 0.2 / 2).ToString();
            if (radioButton9.Checked)
                labelGelirV.Text = (tabanmaas * 0.27 / 2).ToString();
            //sendikA
            label17.Text = (tabanmaas * 0.1).ToString();
            //
            label15.Text = (tabanmaas * 0.02).ToString();
            //
            label13.Text = labelGelirV.Text.ToString();
            //
            label25.Text = (tabanmaas + Convert.ToInt32(labelAile.Text) + Convert.ToInt32(labelCocuk.Text) + Convert.ToInt32(labelKurum.Text) + Convert.ToInt32(labelYdil.Text)).ToString();
            label23.Text = (Convert.ToInt32(labelGelirV.Text) + Convert.ToInt32(label17.Text) + Convert.ToInt32(label15.Text) + Convert.ToInt32(label13.Text)).ToString();
            label21.Text = (Convert.ToInt32(label25.Text) - Convert.ToInt32(label23.Text)).ToString();
            //
        }
    }
}
