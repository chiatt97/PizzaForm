using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaForm
{
    public partial class Form1 : Form
    {
        double subtotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void endtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (smallBtn.Checked)
            {
                subtotal = 0;
                subtotal = subtotal + 7;
                if (cheeseBox.Checked)
                {
                    subtotal += 1;
                }
                if (PepperoniBox.Checked)
                {
                    subtotal += 1;
                }
                if (sausageBtn.Checked)
                {
                    subtotal += 1;
                }
                if (baconBtn.Checked)
                {
                    subtotal += 1;
                }
                if (hamBtn.Checked)
                {
                    subtotal += 1;
                }
                if (pineappleBtn.Checked)
                {
                    subtotal += 1;
                }
            }
            if (mediumBtn.Checked)
            {
                subtotal = 0;
                subtotal = subtotal + 9;
                if (cheeseBox.Checked)
                {
                    subtotal += 1;
                }
                if (PepperoniBox.Checked)
                {
                    subtotal += 1;
                }
                if (sausageBtn.Checked)
                {
                    subtotal += 1;
                }
                if (baconBtn.Checked)
                {
                    subtotal += 1;
                }
                if (hamBtn.Checked)
                {
                    subtotal += 1;
                }
                if (pineappleBtn.Checked)
                {
                    subtotal += 1;
                }
            }
            if (largeBtn.Checked)
            {
                subtotal = 0;
                subtotal = subtotal + 12;
                if (cheeseBox.Checked)
                {
                    subtotal += 1;
                }
                if (PepperoniBox.Checked)
                {
                    subtotal += 1;
                }
                if (sausageBtn.Checked)
                {
                    subtotal += 1;
                }
                if (baconBtn.Checked)
                {
                    subtotal += 1;
                }
                if (hamBtn.Checked)
                {
                    subtotal += 1;
                }
                if (pineappleBtn.Checked)
                {
                    subtotal += 1;
                }
            }
            subtotalLabel.Text = "Subtotal: $" + subtotal;
            taxLbl.Text = "Tax (6%): $" + (subtotal * 0.06);
            tipField.Text = "" + (.15 * (subtotal + (subtotal *0.06)));
            endtotalLabel.Text = "Order Total: $" + (subtotal + (subtotal * 0.06));
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipBtn_Click(object sender, EventArgs e)
        {
            endtotalLabel.Text = "Order Total: $" + (Double.Parse(tipField.Text) + (subtotal + (subtotal * 0.06)));
        }
    }
}
