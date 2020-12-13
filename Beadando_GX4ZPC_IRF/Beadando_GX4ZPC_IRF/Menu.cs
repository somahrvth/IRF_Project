using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            dataGridView1.DataSource = menulist;



        }

        private void textBox_searchbar_TextChanged(object sender, EventArgs e)
        {
            comboBox_options.SelectedItem = "Menu";
            var searchedList = menulist.Where(p => p.name.ToLower().Contains(textBox_searchbar.Text.ToLower()) ||
                                             p.description.ToLower().Contains(textBox_searchbar.Text.ToLower())).ToList();
            dataGridView1.DataSource = searchedList;
        }

        private void comboBox_options_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox_options.SelectedIndex == 0)
            {
                var veganlist = menulist.Where(p => p.diet == "vegan" && p.type=="food").ToList();
                dataGridView1.DataSource = veganlist;
            }

            else
            {
                if (comboBox_options.SelectedIndex == 1)
                {
                    var veganlist = menulist.Where(p => p.diet == "meatlover").ToList();
                    dataGridView1.DataSource = veganlist;
                }
                else
                {
                    if (comboBox_options.SelectedIndex == 2)
                    {
                        var veganlist = menulist.Where(p => p.type == "drink").ToList();
                        dataGridView1.DataSource = veganlist;
                    }

                    else
                    {
                        if (comboBox_options.SelectedIndex == 3)
                        {

                            dataGridView1.DataSource = menulist;
                        }
                    }
                }
            }
        }

       
    }
    }
    
