using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string width = txtEnterWidth.Text;
            string length = txtEnterLength.Text;
            string numDrawers = comSelectDrawers.Text;
            string material = comSelectMaterial.Text;
            string rushDays = comSelectDays.Text;

            try
            {
                Desk myDesk = new Desk(Convert.ToDouble(width), Convert.ToDouble(width), Convert.ToInt16(numDrawers), material.ToLower());
                Order newOrder = new Order(myDesk, Convert.ToInt16(rushDays));
                double orderTotal = newOrder.getTotalPrice();

                TotalField.Text = Convert.ToString(orderTotal);
                newOrder.writeFile();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Data");
            }
        }
    }
}
