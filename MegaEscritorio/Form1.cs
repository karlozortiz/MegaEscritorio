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
        Desktop mDesktop = new Desktop();

        // Choose material  
        private bool isOak = false;
        private bool isPine = false;
        private bool isLaminate = false;

        //Costs
        private float materialCost;
        private float m_Area;
        private float quote;

        //Number of drawers
        private float totalDrawers;
        private float surfaceCost;

        //Constance 
        public const float BASE = 200;
        public const float COST_PER_DRAWER = 50;

        //shipping 
        private bool s_standard = false;
        private bool days3 = false;
        private bool days5 = false;
        private bool days7 = false;
        private float ShippingCost;


        public void getQuote()
        {
            m_Area = mDesktop.CalculateArea();

            if (m_Area <= 1000)
                surfaceCost = BASE;
            else
                surfaceCost = (m_Area - 1000) + BASE;

            ShippingCost = ComputeShipping();
            Console.WriteLine("m_Area: {4}, surface cost:{0}, totalDrawers: {1}, materialCost: {2}, shipping:{3}"
                , surfaceCost, totalDrawers, materialCost, ShippingCost, m_Area);
            quote = surfaceCost + COST_PER_DRAWER * totalDrawers + materialCost + ShippingCost;
        }

        public float ComputeShipping()
        {
            if (days3)
            {
                if (m_Area > 0 && m_Area <= 1000)
                    return 60.0f;
                else if (m_Area > 1000 && m_Area <= 1999)
                    return 70.0f;
                else
                    return 80.0f;
            }
            else if (days5)
            {
                if (m_Area > 0 && m_Area <= 1000)
                    return 40.0f;
                else if (m_Area > 1000 && m_Area <= 1999)
                    return 50.0f;
                else
                    return 60.0f;
            }
            else if (days7)
            {
                if (m_Area > 0 && m_Area <= 1000)
                    return 30.0f;
                else if (m_Area > 1000 && m_Area <= 1999)
                    return 30.0f;
                else
                    return 40.0f;
            }
            else
                return 0.0f;
        }

        public void PromptWidth()
        {
            float val1 = (0.001f);

            try
            {
                val1 = float.Parse(m_width.Text.ToString());
            }
            catch
            {
                Console.WriteLine("Width should be bigger than zero");
            }
            mDesktop.SetWidth(val1);

            Console.WriteLine("val1: {0}", val1);
        }

        private void ValidateWidth(Object sender, EventArgs e)
        {
            do
            {
                PromptWidth();
                if (mDesktop.GetWidth() <= 0.0f)
                {
                    MessageBox.Show("Width should be bigger than zero", "Wrong data!");
                    m_width.Clear();
                }
            } while (mDesktop.GetWidth() <= 0.0f);
        }


        public void PromptDepth()
        {
            float depth = (0.001f);
            try
            {
                depth = float.Parse(m_depth.Text.ToString());
            }
            catch
            {
                Console.WriteLine("Depth should be bigger than zero");
            }
            mDesktop.SetDepth(depth);

            Console.WriteLine("Depth: {0}", depth);
        }

        private void ValidateDepth(Object sender, EventArgs e)
        {
            do
            {
                PromptDepth();
                if (mDesktop.GetDepth() <= 0.0f)
                {
                    MessageBox.Show("Depth should be bigger than zero", "Wrong data!");
                    m_depth.Clear();
                }
            } while (mDesktop.GetDepth() <= 0.0f);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void oak_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 200.0f;
        }

        private void pine_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 100.0f;
        }

        private void laminate_CheckedChanged(object sender, EventArgs e)
        {
            materialCost = 50.0f;
        }

        private void drawers_ValueChanged(object sender, EventArgs e)
        {
            totalDrawers = (float)drawers.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getQuote();
            quoteBox.Text = quote.ToString();
        }

        private void standard_CheckedChanged(object sender, EventArgs e)
        {
            s_standard = true;
            days3 = false;
            days5 = false;
            days7 = false;
        }

        private void day3_CheckedChanged(object sender, EventArgs e)
        {
            s_standard = false;
            days3 = true;
            days5 = false;
            days7 = false;
        }

        private void day5_CheckedChanged(object sender, EventArgs e)
        {
            s_standard = false;
            days3 = false;
            days5 = true;
            days7 = false;
        }

        private void day7_CheckedChanged(object sender, EventArgs e)
        {
            s_standard = false;
            days3 = false;
            days5 = false;
            days7 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quoteBox.Clear();
            drawers.Value = 0;
            m_width.Text = "10";
            m_depth.Text = "10";
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
            this.width = width;
        }

        public void SetDepth(float depth)
        {
            this.depth = depth;
        }

        public float CalculateArea()
        {
            return GetDepth() * GetWidth();
        }
    }
}
