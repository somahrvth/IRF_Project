﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Vegan_or_Meatlover vom = new Vegan_or_Meatlover();
            vom.Show();
            this.Hide();
        }
    }
}
