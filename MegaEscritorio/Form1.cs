﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaEscritorio
{
    
    public interface IDesk
    {
        float CalculateArea();
        float calculateTotalPrice();
    }

    public partial class Form1 : Form, IDesk
    {
        Desktop mDesktop = new Desktop();
        //Costs
        private float materialCost = 0.0f;
        private float m_Area;
        private float quote;

        //Number of drawers
        private float totalDrawers;
        private float surfaceCost;

        //Constance 
        public const float BASE = 200;
        public const float COST_PER_DRAWER = 50;

        //shipping
        private float ShippingCost = 1;
        private int days;
        private string deskMaterial;
        private string selectedItem = "";
        private string name;

        /*****************************************************
         *  PromptMeasument will validate the input with the following
         * constrains:
         * -Only numbers bigger than zero
         * -No letter/symbols
         * If any of this is found, the value will change to 100 automatically.
         * ***************************************************/
        static float PromptMeasurement(TextBox dimention, string x)
        {
            float length = 0.0f;
            do
            {
                string lengthString = dimention.Text.ToString();
                Console.WriteLine(lengthString);
                try
                {
                    length = float.Parse(lengthString);
                    if (length <= 0.0f)
                    {
                        MessageBox.Show(x + " should be bigger than zero. Setting " +
                            x + " to 100 in", "Wrong Data!");
                        dimention.Text = "100";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wrong Data!");
                    MessageBox.Show(x + " should be bigger than zero. Setting " +
                            x + " to 100 in", "Wrong Data!");
                    dimention.Text = "100";
                }

            } while (length <= 0.0f);
            return length;
        }

        /*****************************************************
         *  Key event. This function will verify the input of the width box
         * 
         * ***************************************************/
        private void m_width_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                float input_width = PromptMeasurement(m_width, "Width");
                mDesktop.SetWidth(input_width);
                m_depth.Enabled = true;                
            }
        }

        /*****************************************************
         *  Key event. This function will verify the input of the  box
         * 
         * ***************************************************/
        private void m_depth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                float input_depth = PromptMeasurement(m_depth, "Depth");
                mDesktop.SetDepth(input_depth);
                drawers.Enabled = true;
            }
        }

        
        public float calculateTotalPrice()
        {
            if (materialCost == 0.0)
            {
                MessageBox.Show("Please, select a material", "Material Error!");
                return 0.0f;
            }
            if (ShippingCost == 1)
            {
                MessageBox.Show("Please, select a shipping day", "Shipping Error!");
                return 0.0f;
            }
            button3.Enabled = true;
            return surfaceCost + COST_PER_DRAWER * totalDrawers + materialCost + ShippingCost;
        }

        public float computeSurfaceCost(float area)
        {
            if ( area <= 1000)
                return BASE;
            else
                return (area - 1000) + BASE;
        }

        public float CalculateArea()
        {
            return mDesktop.GetWidth() * mDesktop.GetDepth();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void oak_CheckedChanged(object sender, EventArgs e)
        {
            deskMaterial = "Oak";
            materialCost = 200.0f;           
        }

        private void pine_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 50.0f;
            deskMaterial = "Pine";
        }

        private void laminate_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 100.0f;
            deskMaterial = "Laminate";
        }

        private void Cherry_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 250.0f;
            deskMaterial = "Cherry";
        }

        private void Glass_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 200.0f;
            deskMaterial = "Glass";
        }

        private void Walnut_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 300.0f;
            deskMaterial = "Walnut";
        }

        private void drawers_ValueChanged(object sender, EventArgs e)
        {
            totalDrawers = (float)drawers.Value;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getQuote();
            quoteBox.Text = "$" + quote.ToString();
        }

        private void standard_CheckedChanged(object sender, EventArgs e)
        {
            ShippingCost = 0.0f;
            days = 14;
        }

        private void day3_CheckedChanged(object sender, EventArgs e)
        {
            days = 3;

            if (m_Area > 0 && m_Area <= 1000)
                ShippingCost = 60.0f;
            else if (m_Area > 1000 && m_Area <= 1999)
                ShippingCost = 70.0f;
            else
                ShippingCost = 80.0f;
        }

        private void day5_CheckedChanged(object sender, EventArgs e)
        {
            days = 5;

            if (m_Area > 0 && m_Area <= 1000)
                ShippingCost = 40.0f;
            else if (m_Area > 1000 && m_Area <= 1999)
                ShippingCost = 50.0f;
            else
                ShippingCost = 60.0f;
        }

        private void day7_CheckedChanged(object sender, EventArgs e)
        {
            days = 7;

            if (m_Area > 0 && m_Area <= 1000)
                ShippingCost = 30.0f;
            else if (m_Area > 1000 && m_Area <= 1999)
                ShippingCost = 30.0f;
            else
                ShippingCost = 40.0f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quoteBox.Clear();
            drawers.Value = 0;
            m_width.Clear();
            m_depth.Clear();
            mDesktop.SetWidth(0.0f);
            mDesktop.SetDepth(0.0f);
            m_depth.Enabled = false;
            drawers.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            materialCost = 0.0f;
            ShippingCost = 1;
            standard.Checked = false;
            day3.Checked = false;
            day5.Checked = false;
            day7.Checked = false;
            selectedItem = "";
            NameCustomer.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Save quote to a File
            AddToList();
            using (StreamWriter w = File.AppendText("quotes history.txt"))
            {
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("\t\t\tCustomer name: " + name);
                w.WriteLine("Width (in): {0}\t\t\tDepth (in): {1}\t\t\tShipping days: {2}",
                    mDesktop.GetWidth(), mDesktop.GetDepth(), days);
                w.WriteLine("# of drawers: {0}\t\t\tMaterial: {1}\t\t\tShipping cost: {2}", 
                    totalDrawers, deskMaterial,ShippingCost);
                w.WriteLine("\t\t\t\nQuote: ${0:#,###,##0.00}", quote);
                w.WriteLine("----------------------------------------------");
            }
            button3.Enabled = false;
        }

        private void SeachByMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedText = SeachByMaterial.SelectedItem;
            selectedItem = selectedText.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (selectedItem.CompareTo("") == 0)
            {
                MessageBox.Show("Please, select a material to search!", "Search error!");
            }
            using (StreamReader r = File.OpenText("quotesList.txt"))
            {
                Console.WriteLine("The following quotes for {0} were found:\n", selectedItem);
                using (StreamWriter w = File.AppendText("seach.txt"))
                {
                    w.WriteLine("The following quotes for {0} were found:\n", selectedItem);
                }
                string line;
                bool isNextLine = false;
                while ((line = r.ReadLine()) != null)
                {
                    if (isNextLine)
                    {
                        using (StreamWriter w = File.AppendText("seach.txt"))
                        {
                            w.WriteLine("\t\tQuote: ${0:#,###,##0.00}", float.Parse(line));
                        }
                        Console.WriteLine(line);
                        isNextLine = false;
                    }
                    if (line.CompareTo(selectedItem) == 0)
                    {
                        isNextLine = true;
                    }

                }
            }
        }

        private void AddToList()
        {
            List<string> iQuotes = new List<string>();

            iQuotes.Add(mDesktop.GetWidth().ToString());
            iQuotes.Add(mDesktop.GetDepth().ToString());
            iQuotes.Add(totalDrawers.ToString());
            iQuotes.Add(days.ToString());
            iQuotes.Add(deskMaterial);
            iQuotes.Add(quote.ToString());
            iQuotes.Add("------------------");
            using (StreamWriter w = File.AppendText("quotesList.txt"))
            {
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                for (int i = 0; i < iQuotes.Count; i++)
                {
                    w.WriteLine(iQuotes[i]);
                }
                w.WriteLine("----------------------------------------------");
            }
        }

        public void getQuote()
        {
            // Get Customer info
            name = NameCustomer.Text.ToString();
            // Get Area
            CalculateArea();
            surfaceCost = computeSurfaceCost(m_Area);
            quote = calculateTotalPrice();
            Console.WriteLine("m_Area: {4}, surface cost:{0}, totalDrawers: {1}, materialCost: {2}, shipping:{3}",
                +surfaceCost, totalDrawers, materialCost, ShippingCost, m_Area);
            selectedItem = "";
        }

    }

    public class Desktop
    {
        private float width;
        private float depth;

        public float GetWidth()
        {
            return width;
        }

        public float GetDepth()
        {
            return depth;
        }

        public void SetWidth(float width)
        {          
            if (width <= 0)
                Console.WriteLine("Width should be bigger than zero", "Wrong Data!");
            else
                this.width = width;
        }

        public void SetDepth(float depth)
        {
            if (depth <= 0)
                Console.WriteLine("Depth should be bigger than zero", "Wrong Data!");
            else
                this.depth = depth;
        }
    }
}
