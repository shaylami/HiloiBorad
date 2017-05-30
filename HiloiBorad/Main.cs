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

namespace HiloiBorad
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void HiloiNamesRead()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("HiloiNamesData.xml"))
            {
                HiloiNames hn = new HiloiNames();
                hn.HiloiSet();
            }
            else
            {
                xmlDoc.Load("HiloiNamesdata.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Hiloi");
                string HiloiID1 = "", HiloiName1 = "";
                foreach (XmlNode node in nodeList)
                {
                    HiloiID1 = node.SelectSingleNode("Hiloi_id").InnerText;
                    HiloiName1 = node.SelectSingleNode("Hiloi_name").InnerText;
                    if (HiloiID1 == "1")
                    {
                        lblHiloi1.Text = HiloiName1;
                    }
                    if (HiloiID1 == "2")
                    {
                        lblHiloi2.Text = HiloiName1;
                    }
                    if (HiloiID1 == "3")
                    {
                        lblHiloi3.Text = HiloiName1;
                    }
                    if (HiloiID1 == "4")
                    {
                        lblHiloi4.Text = HiloiName1;
                    }
                    if (HiloiID1 == "5")
                    {
                        lblHiloi5.Text = HiloiName1;
                    }
                    if (HiloiID1 == "6")
                    {
                        lblHiloi6.Text = HiloiName1;
                    }
                    if (HiloiID1 == "7")
                    {
                        lblHiloi7.Text = HiloiName1;
                    }
                    if (HiloiID1 == "8")
                    {
                        lblHiloi8.Text = HiloiName1;
                    }
                    if (HiloiID1 == "9")
                    {
                        lblHiloi9.Text = HiloiName1;
                    }
                    if (HiloiID1 == "10")
                    {
                        lblHiloi10.Text = HiloiName1;
                    }
                    if (HiloiID1 == "11")
                    {
                        lblHiloi11.Text = HiloiName1;
                    }
                    if (HiloiID1 == "12")
                    {
                        lblHiloi12.Text = HiloiName1;
                    }
                    if (HiloiID1 == "13")
                    {
                        lblHiloi13.Text = HiloiName1;
                    }
                    if (HiloiID1 == "14")
                    {
                        lblHiloi14.Text = HiloiName1;
                    }
                    if (HiloiID1 == "15")
                    {
                        lblHiloi15.Text = HiloiName1;
                    }
                    if (HiloiID1 == "16")
                    {
                        lblHiloi16.Text = HiloiName1;
                    }
                    if (HiloiID1 == "17")
                    {
                        lblHiloi17.Text = HiloiName1;
                    }
                    if (HiloiID1 == "18")
                    {
                        lblHiloi18.Text = HiloiName1;
                    }
                    if (HiloiID1 == "19")
                    {
                        lblHiloi19.Text = HiloiName1;
                    }
                    if (HiloiID1 == "20")
                    {
                        lblHiloi20.Text = HiloiName1;
                    }
                    if (HiloiID1 == "21")
                    {
                        lblHiloi21.Text = HiloiName1;
                    }
                    if (HiloiID1 == "22")
                    {
                        lblHiloi22.Text = HiloiName1;
                    }
                    if (HiloiID1 == "23")
                    {
                        lblHiloi23.Text = HiloiName1;
                    }
                    if (HiloiID1 == "24")
                    {
                        lblHiloi24.Text = HiloiName1;
                    }
                    if (HiloiID1 == "25")
                    {
                        lblHiloi25.Text = HiloiName1;
                    }
                    if (HiloiID1 == "26")
                    {
                        lblHiloi26.Text = HiloiName1;
                    }
                    if (HiloiID1 == "27")
                    {
                        lblHiloi27.Text = HiloiName1;
                    }
                    if (HiloiID1 == "28")
                    {
                        lblHiloi28.Text = HiloiName1;
                    }
                    if (HiloiID1 == "29")
                    {
                        lblHiloi29.Text = HiloiName1;
                    }
                    if (HiloiID1 == "30")
                    {
                        lblHiloi30.Text = HiloiName1;
                    }
                    if (HiloiID1 == "31")
                    {
                        lblHiloi31.Text = HiloiName1;
                    }
                    if (HiloiID1 == "32")
                    {
                        lblHiloi32.Text = HiloiName1;
                    }
                    if (HiloiID1 == "33")
                    {
                        lblHiloi33.Text = HiloiName1;
                    }
                    if (HiloiID1 == "34")
                    {
                        lblHiloi34.Text = HiloiName1;
                    }
                }
            }

        }
    }
}
