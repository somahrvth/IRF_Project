using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_GX4ZPC_IRF
{
    public partial class Vegan_or_Meatlover : Form
    {
        public Vegan_or_Meatlover()
        {
            InitializeComponent();
            this.Text = "Choose your preference";
            this.CenterToScreen();
        }

        private void vegan_button_Click(object sender, EventArgs e)
        {
            Vegan veg = new Vegan();
            veg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meatlover met = new Meatlover();
            met.Show();
            this.Hide();
        }
    }
}
