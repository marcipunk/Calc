using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();

            NumberFormatInfo nfi = new CultureInfo("hu-HU", false).NumberFormat;

            Memory calcMemory = new Memory();
            button1.Click += calcMemory.NewPress;
            button2.Click += calcMemory.NewPress;
            button3.Click += calcMemory.NewPress;
            button4.Click += calcMemory.NewPress;
            button5.Click += calcMemory.NewPress;
            button6.Click += calcMemory.NewPress;
            button7.Click += calcMemory.NewPress;
            button8.Click += calcMemory.NewPress;
            button9.Click += calcMemory.NewPress;
            button0.Click += calcMemory.NewPress;
            bDecimal.Click += calcMemory.NewPress;
            calcMemory.ElementEvent += RefreshDisplay;
            bPlus.Click += calcMemory.OpPress;
            bEnter.Click += calcMemory.Calc;
            bMinus.Click += calcMemory.OpPress;
            bDivide.Click += calcMemory.OpPress;
            bMultiply.Click += calcMemory.OpPress;
            
            
        }

        private void RefreshDisplay(string Element)
        {
           displayBox.Text = Element;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
