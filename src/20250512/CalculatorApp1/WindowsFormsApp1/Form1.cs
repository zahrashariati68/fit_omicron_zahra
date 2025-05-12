using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public enum OperatorState
    {
        ADD,
        SUB,
        MUL,
        DIV,
        MOD,
        INV,
        POW,
        RAD,
        SIGN
    }
    public partial class Calclulator : Form
    {
        private double lastInputValue, firstInputValue;
        double resultValue;
        private OperatorState lastOperator;
        bool keepResults = false;
        bool floatingPoint = false;
        int zeroPlaceHolder =0;

        private Rectangle btt0OriginalRect, btt1OriginalRect, btt2OriginalRect, btt3OriginalRect, btt4OriginalRect, btt5OriginalRect, btt6OriginalRect, btt7OriginalRect, btt8OriginalRect, btt9OriginalRect ,
            bttResultOriginalRect , bttSignOriginalRect, bttPntOriginalRect, bttAddOriginalRect, bttSubOriginalRect, bttMultiplyOriginalRect, bttDivOriginalRect, bttRadicalOriginalRect, bttPowOriginalRect,
            bttInvOriginalRect, bttDelOriginalRect, bttCOriginalRect, bttCEOriginalRect, bttModOriginalRect, txtBox1OriginalRect, txtResultOriginalRect, txtUserInputOriginalRect;

        private Size formOriginalSize; 
        public Calclulator()
        {
            InitializeComponent();
        }

        private void btt_0_Click(object sender, EventArgs e)
        {
            if (keepResults) {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 0 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 0;
            txt_userInput.Text += "0".ToString();
        }
        private void btt_1_Click(object sender, EventArgs e)
        {
            
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 1/(Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 1;
            txt_userInput.Text += "1".ToString();
        }
        private void btt_2_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 2 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 2;
            txt_userInput.Text += "2".ToString();
        }
        private void btt_3_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 3 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 3;
            txt_userInput.Text += "3".ToString();
        }
        private void btt_4_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 4 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 4;
            txt_userInput.Text += "4".ToString();
        }
        private void btt_5_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 5 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 5;
            txt_userInput.Text += "5".ToString();
        }
        private void btt_6_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 6 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 6;
            txt_userInput.Text += "6".ToString();
        }
        private void btt_7_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 7 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 7;
            txt_userInput.Text += "7".ToString();
        }
        private void btt_8_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 8 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 8;
            txt_userInput.Text += "8".ToString();
        }
        private void btt_9_Click(object sender, EventArgs e)
        {
            if (keepResults)
            {
                keepResults = false;
                lastInputValue = 0;
            }
            if (floatingPoint)
            {
                lastInputValue = lastInputValue + 9 / (Math.Pow(10, ++zeroPlaceHolder));
            }
            else
                lastInputValue = lastInputValue * 10 + 9;
            txt_userInput.Text += "9".ToString();
        }

        private void btt_result_Click(object sender, EventArgs e)
        {
            keepResults = true; 
            txt_userInput.Text = "";
            floatingPoint = false;
            zeroPlaceHolder = 0;
            switch (lastOperator)
            {
                case OperatorState.ADD:
                    resultValue = firstInputValue + lastInputValue;
                    txt_result.Text = resultValue.ToString();
                    break;
                case OperatorState.SUB:
                    resultValue = firstInputValue - lastInputValue;
                    txt_result.Text = resultValue.ToString();
                    break;
                case OperatorState.MUL:
                    resultValue = firstInputValue * lastInputValue;
                    txt_result.Text = resultValue.ToString();
                    break;
                case OperatorState.DIV:
                    if (lastInputValue != 0)
                    {
                        resultValue = firstInputValue / lastInputValue;
                        txt_result.Text = resultValue.ToString();
                    }
                    else
                        txt_result.Text = "ERROR";
                    break;
                case OperatorState.MOD:
                    if (lastInputValue != 0)
                    {
                        resultValue = firstInputValue % lastInputValue;
                        txt_result.Text = resultValue.ToString();
                    }
                    else
                        txt_result.Text = "ERROR";
                    break;
                case OperatorState.INV:
                    if (firstInputValue != 0)
                    {
                        resultValue = 1 / firstInputValue;
                        txt_result.Text = resultValue.ToString();
                    }
                    else
                        txt_result.Text = "ERROR";
                    break;
                case OperatorState.POW:
                    resultValue = Math.Pow(firstInputValue, 2);
                    txt_result.Text = resultValue.ToString();
                    break;
                case OperatorState.RAD:
                    resultValue = Math.Sqrt(firstInputValue);
                    txt_result.Text = resultValue.ToString();
                    break;
                case OperatorState.SIGN:
                    if (firstInputValue != 0)
                    {
                        resultValue = (-1)* firstInputValue;
                        txt_result.Text = resultValue.ToString();
                    }
                    break;
                default:
                    resultValue = lastInputValue;
                    txt_result.Text = resultValue.ToString();
                    break;
            }
            firstInputValue = 0;
            lastInputValue = resultValue;  
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = lastInputValue; 
            lastInputValue = 0;
            lastOperator = OperatorState.ADD;
            txt_userInput.Text += "+";
        }
        private void btt_sub_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = lastInputValue;
            lastInputValue = 0;
            lastOperator = OperatorState.SUB;
            txt_userInput.Text += "-";
        }
        private void btt_multiply_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = lastInputValue;
            lastInputValue = 0;
            lastOperator = OperatorState.MUL;
            txt_userInput.Text += "x";
        }
        private void btt_div_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = lastInputValue;
            lastInputValue = 0;
            lastOperator = OperatorState.DIV;
            txt_userInput.Text += "/";
        }
        private void btt_mod_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = lastInputValue;
            lastInputValue = 0;
            lastOperator = OperatorState.MOD;
            txt_userInput.Text += "%";
        }
        private void btt_radical_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = Math.Sqrt(lastInputValue);
            lastOperator = OperatorState.RAD;
            txt_userInput.Text = lastInputValue + "^0.5";
            txt_result.Text = firstInputValue.ToString();
            lastInputValue = firstInputValue;
            //  lastInputValue = 0;
        } 
        private void btt_pow2_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            firstInputValue = Math.Pow(lastInputValue,2);
            lastOperator = OperatorState.POW;
            txt_userInput.Text = lastInputValue + "^2";
            txt_result.Text = firstInputValue.ToString();
            lastInputValue = firstInputValue;
            //lastInputValue = 0;
        }
        private void btt_inv_Click(object sender, EventArgs e)
        {
            floatingPoint = false;
            zeroPlaceHolder = 0;
            if(lastInputValue!=0)
                firstInputValue = 1/lastInputValue;
            else
                txt_result.Text = "ERROR";
            lastOperator = OperatorState.INV;
            txt_userInput.Text = "1/"+lastInputValue.ToString();
            txt_result.Text = firstInputValue.ToString(); 
            lastInputValue = firstInputValue;
            //lastInputValue = 0;
        }
        private void btt_sign_Click(object sender, EventArgs e)
        {
            firstInputValue = (-1) * lastInputValue;
            lastOperator = OperatorState.SIGN;
            txt_userInput.Text = firstInputValue.ToString();
            lastInputValue = firstInputValue;
            //lastInputValue = 0;
        }
        private void btt_pnt_Click(object sender, EventArgs e)
        {
            if (floatingPoint == false)
            {
                floatingPoint = true;
                zeroPlaceHolder = 0;
                txt_userInput.Text += ".";
            }  
        }
        private void btt_CE_Click(object sender, EventArgs e)
        {
            firstInputValue = 0;
            lastInputValue = 0;
            txt_userInput.Text = "";
            txt_result.Text = ""; 
        }
        private void btt_C_Click(object sender, EventArgs e)
        {
            firstInputValue = 0;
            lastInputValue = 0;
            txt_userInput.Text = "";
            txt_result.Text = "";
        }
        private void btt_del_Click(object sender, EventArgs e)
        {
            lastInputValue = (int)(lastInputValue/10);
            if(txt_userInput.Text.Length>0)
                txt_userInput.Text= txt_userInput.Text.Remove(txt_userInput.Text.Length-1);
        }

        private void Calclulator_Load(object sender, EventArgs e)
        {
            btt0OriginalRect = new Rectangle(btt_0.Location.X, btt_0.Location.Y, btt_0.Width, btt_0.Height);
            btt1OriginalRect = new Rectangle(btt_1.Location.X, btt_1.Location.Y, btt_1.Width, btt_1.Height);
            btt2OriginalRect = new Rectangle(btt_2.Location.X, btt_2.Location.Y, btt_2.Width, btt_2.Height);
            btt3OriginalRect = new Rectangle(btt_3.Location.X, btt_3.Location.Y, btt_3.Width, btt_3.Height);
            btt4OriginalRect = new Rectangle(btt_4.Location.X, btt_4.Location.Y, btt_4.Width, btt_4.Height);
            btt5OriginalRect = new Rectangle(btt_5.Location.X, btt_5.Location.Y, btt_5.Width, btt_5.Height);
            btt6OriginalRect = new Rectangle(btt_6.Location.X, btt_6.Location.Y, btt_6.Width, btt_6.Height);
            btt7OriginalRect = new Rectangle(btt_7.Location.X, btt_7.Location.Y, btt_7.Width, btt_7.Height);
            btt8OriginalRect = new Rectangle(btt_8.Location.X, btt_8.Location.Y, btt_8.Width, btt_8.Height);
            btt9OriginalRect = new Rectangle(btt_9.Location.X, btt_9.Location.Y, btt_9.Width, btt_9.Height);
            bttResultOriginalRect = new Rectangle(btt_result.Location.X, btt_result.Location.Y, btt_result.Width, btt_9.Height);
            bttSignOriginalRect = new Rectangle(btt_sign.Location.X, btt_sign.Location.Y, btt_sign.Width, btt_sign.Height);
            bttPntOriginalRect = new Rectangle(btt_pnt.Location.X, btt_pnt.Location.Y, btt_pnt.Width, btt_pnt.Height);
            bttAddOriginalRect = new Rectangle(btt_add.Location.X, btt_add.Location.Y, btt_add.Width, btt_add.Height);
            bttSubOriginalRect = new Rectangle(btt_sub.Location.X, btt_sub.Location.Y, btt_sub.Width, btt_sub.Height);
            bttMultiplyOriginalRect = new Rectangle(btt_multiply.Location.X, btt_multiply.Location.Y, btt_multiply.Width, btt_multiply.Height);
            bttDivOriginalRect = new Rectangle(btt_div.Location.X, btt_div.Location.Y, btt_div.Width, btt_div.Height);
            bttRadicalOriginalRect = new Rectangle(btt_radical.Location.X, btt_radical.Location.Y, btt_radical.Width, btt_radical.Height);
            bttPowOriginalRect = new Rectangle(btt_pow2.Location.X, btt_pow2.Location.Y, btt_pow2.Width, btt_pow2.Height);
            bttInvOriginalRect = new Rectangle(btt_inv.Location.X, btt_inv.Location.Y, btt_inv.Width, btt_inv.Height);
            bttDelOriginalRect = new Rectangle(btt_del.Location.X, btt_del.Location.Y, btt_del.Width, btt_del.Height);
            bttCOriginalRect = new Rectangle(btt_C.Location.X, btt_C.Location.Y, btt_C.Width, btt_C.Height);
            bttCEOriginalRect = new Rectangle(btt_CE.Location.X, btt_CE.Location.Y, btt_CE.Width, btt_CE.Height);
            bttModOriginalRect = new Rectangle(btt_mod.Location.X, btt_mod.Location.Y, btt_mod.Width, btt_mod.Height);
            txtBox1OriginalRect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            txtResultOriginalRect = new Rectangle(txt_result.Location.X, txt_result.Location.Y, txt_result.Width, txt_result.Height);
            txtUserInputOriginalRect = new Rectangle(txt_userInput.Location.X, txt_userInput.Location.Y, txt_userInput.Width, txt_userInput.Height);
            formOriginalSize = this.Size;
        } 
        private void Calclulator_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
        private void resizeChildrenControls()
        {
            resizeControl(btt0OriginalRect, btt_0);
            resizeControl(btt1OriginalRect, btt_1);
            resizeControl(btt2OriginalRect, btt_2);
            resizeControl(btt3OriginalRect, btt_3);
            resizeControl(btt4OriginalRect, btt_4);
            resizeControl(btt5OriginalRect, btt_5);
            resizeControl(btt6OriginalRect, btt_6);
            resizeControl(btt7OriginalRect, btt_7);
            resizeControl(btt8OriginalRect, btt_8);
            resizeControl(btt9OriginalRect, btt_9);
            resizeControl(bttResultOriginalRect, btt_result);
            resizeControl(bttSignOriginalRect, btt_sign);
            resizeControl(bttPntOriginalRect, btt_pnt);
            resizeControl(bttAddOriginalRect, btt_add);
            resizeControl(bttSubOriginalRect, btt_sub);
            resizeControl(bttMultiplyOriginalRect, btt_multiply);
            resizeControl(bttDivOriginalRect, btt_div);
            resizeControl(bttRadicalOriginalRect, btt_radical);
            resizeControl(bttPowOriginalRect, btt_pow2);
            resizeControl(bttInvOriginalRect, btt_inv);
            resizeControl(bttDelOriginalRect, btt_del);
            resizeControl(bttCOriginalRect, btt_C);
            resizeControl(bttCEOriginalRect, btt_CE);
            resizeControl(bttModOriginalRect, btt_mod);
            resizeControl(txtBox1OriginalRect, textBox1);
            resizeControl(txtResultOriginalRect, txt_result);
            resizeControl(txtUserInputOriginalRect, txt_userInput);
        }

        private void resizeControl (Rectangle originalControlRect , Control control)
        { 
            float xRatio = ((float)this. Width)/((float)formOriginalSize.Width);
            float yRatio = ((float)this.Height) / ((float)formOriginalSize.Height);
            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
         
    }
}
