using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Calculator
{
    public partial class MainWindow : Form
    {
        private double _value;
        private string _operation;
        private bool _valueWasCalculated;

        public MainWindow()
        {
            InitializeComponent();
            Reset();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (resultLbl.Text == "0" || _valueWasCalculated) resultLbl.Text = string.Empty;
            resultLbl.Text += ((Button)sender).Text;
            _valueWasCalculated = false;
        }

        private void AddFloatingPoint(object sender, EventArgs e)
        {
            if(!resultLbl.Text.Contains(","))
            {
                resultLbl.Text += ",";
                _valueWasCalculated = false;
            }
        }
        private void OperationClick(object sender, EventArgs e)
        {
            if(!_valueWasCalculated) CalculateValue();
            resultLbl.Text = _value.ToString();
            _operation = ((Button)sender).Text;
        }

        private void CalculateValue()
        {
            _valueWasCalculated = true;

            switch (_operation)
            {
                case "+":
                    _value += double.Parse(resultLbl.Text);
                    break;
                case "-":
                    _value -= double.Parse(resultLbl.Text);
                    break;
                case "*":
                    _value *= double.Parse(resultLbl.Text);
                    break;
                case "/":
                    _value /= double.Parse(resultLbl.Text);
                    break;
                default:
                    _value = double.Parse(resultLbl.Text);
                    break;
            }
        }
        private void GetAnswer(object sender, EventArgs e)
        {
            CalculateValue();
            _operation = string.Empty;
            resultLbl.Text = _value.ToString();
        }

        private void Reset(object sender = null, EventArgs e = null)
        {
            _value = 0;
            _operation = string.Empty;
            _valueWasCalculated = false;
            resultLbl.Text = "0";
        }
        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
         {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    zeroBtn.PerformClick();
                    break;
                case "1":
                    oneBtn.PerformClick();
                    break;
                case "2":
                    twoBtn.PerformClick();
                    break;
                case "3":
                    threeBtn.PerformClick();
                    break;
                case "4":
                    fourBtn.PerformClick();
                    break;
                case "5":
                    fiveBtn.PerformClick();
                    break;
                case "6":
                    sixBtn.PerformClick();
                    break;
                case "7":
                    sevenBtn.PerformClick();
                    break;
                case "8":
                    eightBtn.PerformClick();
                    break;
                case "9":
                    nineBtn.PerformClick();
                    break;
                case "*":
                    multiplyBtn.PerformClick();
                    break;
                case "/":
                    divideBtn.PerformClick();
                    break;
                case "+":
                    plusBtn.PerformClick();
                    break;
                case "-":
                    minusBtn.PerformClick();
                    break;
                case ".":
                    decimalBtn.PerformClick();
                    break;
            }
        }
    }
}
