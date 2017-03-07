using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public delegate void ElementChanged(string Element);

    class Memory
    {
        private string firstElement = string.Empty;
        private string secondElement = string.Empty;
        private char operation = '0';

        CultureInfo culture = new CultureInfo("hu-HU");
        


        public event ElementChanged ElementEvent;

        public string FirstElement
        {
            get
            {
                return firstElement;
            }

            set
            {
                firstElement = value;
            }
        }

        public string SecondElement
        {
            get
            {
                return secondElement;
            }

            set
            {
                secondElement = value;
            }
        }

        public char Operation
        {
            get
            {
                return operation;
            }

            set
            {
                operation = value;
            }
        }

        internal void Calc(object sender, EventArgs e)
        {
            double result;


            if (Operation != '0')
            {
                switch (Operation)
                {
           
                    case '+':
                        result = Double.Parse(firstElement, culture.NumberFormat) + Double.Parse(secondElement, culture.NumberFormat);
                        Operation = '0';
                        firstElement = result.ToString();
                        secondElement = string.Empty;
                        OnElementChanged(result.ToString());
                        break;
                    case '-':
                        result = Double.Parse(firstElement, culture.NumberFormat) - Double.Parse(secondElement, culture.NumberFormat);
                        Operation = '0';
                        firstElement = result.ToString();
                        secondElement = string.Empty;
                        OnElementChanged(result.ToString());
                        break;
                    case '/':
                        result = Double.Parse(firstElement, culture.NumberFormat) / Double.Parse(secondElement, culture.NumberFormat);
                        Operation = '0';
                        firstElement = result.ToString();
                        secondElement = string.Empty;
                        OnElementChanged(result.ToString());
                        break;
                    case '*':
                        result = Double.Parse(firstElement, culture.NumberFormat) * Double.Parse(secondElement, culture.NumberFormat);
                        Operation = '0';
                        firstElement = result.ToString();
                        secondElement = string.Empty;
                        OnElementChanged(result.ToString());
                        break;


                }
            }
        }

        internal void NewPress(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (operation == '0')
            {
                firstElement = firstElement + b.Text;
                OnElementChanged(firstElement);
            }
            else
            {
                secondElement = secondElement + b.Text;
                OnElementChanged(secondElement);
            }
            
        }

        private void OnElementChanged(string Element)
        {
            if (ElementEvent != null)
            {
                ElementEvent.Invoke(Element);
            }
        }

        internal void OpPress(object sender, EventArgs e)
        {
            if (firstElement.Length!=0)
            {
                Button b = (Button)sender;
                Operation = Convert.ToChar(b.Text);
                OnElementChanged(b.Text);
            }

        }




    }
}
