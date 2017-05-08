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

        public void getQuote()
        {
            float m_Area = mDesktop.CalculateArea();
        }

        public void PromptWidth()
        {
            float val1=(0.001f);
            
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
