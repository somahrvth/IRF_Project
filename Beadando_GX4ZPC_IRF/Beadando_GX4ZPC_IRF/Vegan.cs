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

namespace Beadando_GX4ZPC_IRF
{
    public partial class Vegan : Form
    {
        public Vegan()
        {
            InitializeComponent();
            this.CenterToScreen();
            XmlReader xmlFile = XmlReader.Create("menu.xml", new XmlReaderSettings());
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlFile);
            dataGridView1.DataSource = dataSet.Tables["menuitem"];
            xmlFile.Close();
        }
    }
}
