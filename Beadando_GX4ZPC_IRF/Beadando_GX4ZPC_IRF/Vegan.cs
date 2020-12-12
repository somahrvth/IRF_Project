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
    
    public partial class Vegan : Form
    {
        List<MenuItems> menulist = new List<MenuItems>();
        DataTable dt = new DataTable();
        public Vegan()
        {
            InitializeComponent();
            this.CenterToScreen();

            




            //XElement xdoc = XElement.Load("Menu.xml");

            //var lines = from item in xdoc.Descendants("menuitem")
            //            let fields = item.Elements("name")
            //            select new
            //            {
            //                Description = (string)fields
            //                       .FirstOrDefault(n => (string)n.Attribute("name") == "menü elem"),
            //                Type = (string)fields
            //                       .FirstOrDefault(n => (string)n.Attribute("name") == "neve"),

            //            };
            //dataGridView1.DataSource = lines.ToArray();

            //XmlReader xmlFile = XmlReader.Create("menu.xml", new XmlReaderSettings());
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(xmlFile);
            //dataGridView1.DataSource = dataSet.Tables["menuitem"];
            //xmlFile.Close();


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

        private void checkBox_vegan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_vegan.Checked)
            {
                var veganlist = menulist.Where(p => p.diet == "vegan").ToList();
                dataGridView1.DataSource = veganlist;
            }
           

            //if (checkBox_vegan.Checked == true)
            //{
            //    try
            //    {
            //        //Check an see what's in the dgv
            //        DataView dv = new DataView(dt);
            //        dv.RowFilter = " [diet] = " + checkBox_vegan.Text.ToLower().Trim();
            //        dataGridView1.DataSource = dv;

            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Can’t find the column", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
        }
    }
    }
    
