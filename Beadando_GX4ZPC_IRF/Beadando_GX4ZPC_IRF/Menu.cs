using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Beadando_GX4ZPC_IRF.Entities;


namespace Beadando_GX4ZPC_IRF
{
    
    public partial class Menu : Form
    {
        List<MenuItems> menulist = new List<MenuItems>();
        List<MenuItems> order = new List<MenuItems>();
        DataTable dt = new DataTable();
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Menu - Green Palace";
           

            


            XmlDocument xml = new XmlDocument();
            xml.Load("menu.xml");

            XmlNodeList nodeList = xml.SelectNodes("/menuitems/menuitem");
            foreach (XmlNode node in nodeList)
            {
                string name = node["name"].InnerText;
                string type = node["type"].InnerText;
                string price = node["price"].InnerText;
                string diet = node["diet"].InnerText;
                string description = node["description"].InnerText;
                string calories = node["calories"].InnerText;


                var menu = new MenuItems();
                menulist.Add(menu);
                
                menu.name = name;
                menu.type = type;
                menu.price = price;
                menu.diet = diet;
                menu.description = description;
                menu.calories = calories;
                
                
            }

            dgv_menu.DataSource = menulist;



        }

        private void textBox_searchbar_TextChanged(object sender, EventArgs e)
        {
            comboBox_options.SelectedItem = "Menu";
            var searchedList = menulist.Where(p => p.name.ToLower().Contains(textBox_searchbar.Text.ToLower()) ||
                                             p.description.ToLower().Contains(textBox_searchbar.Text.ToLower())).ToList();
            dgv_menu.DataSource = searchedList;
        }

        private void comboBox_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox_options.SelectedIndex == 0)
            {
                var veganlist = menulist.Where(p => p.diet == "vegan" && p.type=="food").ToList();
                dgv_menu.DataSource = veganlist;
            }

            else
            {
                if (comboBox_options.SelectedIndex == 1)
                {
                    var veganlist = menulist.Where(p => p.diet == "meatlover").ToList();
                    dgv_menu.DataSource = veganlist;
                }
                else
                {
                    if (comboBox_options.SelectedIndex == 2)
                    {
                        var veganlist = menulist.Where(p => p.type == "drink").ToList();
                        dgv_menu.DataSource = veganlist;
                    }

                    else
                    {
                        if (comboBox_options.SelectedIndex == 3)
                        {

                            dgv_menu.DataSource = menulist;
                        }
                    }
                }
            }
        }
        
        private void button_pick_Click(object sender, EventArgs e)
        {

            dgv_order.DataSource = null;

            string name = dgv_menu.CurrentRow.Cells[3].Value.ToString();
            string type = dgv_menu.CurrentRow.Cells[1].Value.ToString();
            string price = dgv_menu.CurrentRow.Cells[4].Value.ToString();
            string diet = dgv_menu.CurrentRow.Cells[2].Value.ToString();
            string description = dgv_menu.CurrentRow.Cells[5].Value.ToString();
            string calories = dgv_menu.CurrentRow.Cells[6].Value.ToString();

            
            var o= new MenuItems();
            
            o.name = name;
            o.type = type;
            o.price = price;
            o.diet = diet;
            o.description = description;
            o.calories = calories;
            order.Add(o);
            dgv_order.DataSource = order;
            dgv_order.Columns[1].Visible = false;
            dgv_order.Columns[2].Visible = false;
            dgv_order.Columns[5].Visible = false;
            dgv_order.Columns[6].Visible = false;
            dgv_order.Columns[3].HeaderText = "Menu";
            dgv_order.Columns[4].HeaderText = "Price";

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            dgv_order.DataSource = null;
            order.Clear();
                  
            
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_order.DataSource = null;
                Random rnd = new Random();
                int rndfood = rnd.Next(0, 8);
                int rnddrink = rnd.Next(9, 14);


                string name = dgv_menu.Rows[rndfood].Cells[3].Value.ToString();
                string type = dgv_menu.Rows[rndfood].Cells[1].Value.ToString();
                string price = dgv_menu.Rows[rndfood].Cells[4].Value.ToString();
                string diet = dgv_menu.Rows[rndfood].Cells[2].Value.ToString();
                string description = dgv_menu.Rows[rndfood].Cells[5].Value.ToString();
                string calories = dgv_menu.Rows[rndfood].Cells[6].Value.ToString();

                string name_drink = dgv_menu.Rows[rnddrink].Cells[3].Value.ToString();
                string type_drink = dgv_menu.Rows[rnddrink].Cells[1].Value.ToString();
                string price_drink = dgv_menu.Rows[rnddrink].Cells[4].Value.ToString();
                string diet_drink = dgv_menu.Rows[rnddrink].Cells[2].Value.ToString();
                string description_drink = dgv_menu.Rows[rnddrink].Cells[5].Value.ToString();
                string calories_drink = dgv_menu.Rows[rnddrink].Cells[6].Value.ToString();


                var o = new MenuItems();

                o.name = name;
                o.type = type;
                o.price = price;
                o.diet = diet;
                o.description = description;
                o.calories = calories;
                order.Add(o);

                var o_drink = new MenuItems();

                o_drink.name = name_drink;
                o_drink.type = type_drink;
                o_drink.price = price_drink;
                o_drink.diet = diet_drink;
                o_drink.description = description_drink;
                o_drink.calories = calories_drink;
                order.Add(o_drink);

                dgv_order.DataSource = order;
                dgv_order.Columns[1].Visible = false;
                dgv_order.Columns[2].Visible = false;
                dgv_order.Columns[5].Visible = false;
                dgv_order.Columns[6].Visible = false;
                dgv_order.Columns[3].HeaderText = "Menu";
                dgv_order.Columns[4].HeaderText = "Price";
            }
            catch (Exception)
            {
                MessageBox.Show("The Chef's offer feature only works when the full menu is on display.");
            }
           





        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    sw.Write("Menu");
                    sw.Write(";");
                    sw.WriteLine("Price");

                    foreach (var o_item in order)
                    {
                        sw.Write(o_item.name);
                        sw.Write(";");
                        sw.WriteLine(o_item.price);
                    }
                }
            }


        }
    }
    }
    
