using System;
using System.Reflection;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        enum Operators // 열거형 정의 
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None; // 열거형 변수 값 초기화
        Boolean operatorChangeFlag = false;
        // 연산자 버튼이 눌리면 기존에 입력한 숫자를 저장하고, 새로 숫자를 입력받기 위한 변수로 사용
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(Display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                Display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    Display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    Display.Text = firstOperand.ToString();
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            // 문자열 -> 정수로 변환 후 저장
            currentOperator = Operators.Add;
            // currentOperator에 + 버튼이 눌림
            operatorChangeFlag = true;
            // true 값으로 설정해야 출력된 값을 지우고 다시 출력함
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(Display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = "0";
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPM_Click(object sender, EventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false; // 연산자가 눌렸을 때, 기존에 누른 숫자 저장
            }
            string strNumber = Display.Text += "0";
            int intNumber = Int32.Parse(strNumber); // 버튼을 누르면 문자열을 strNumber 변수에 저장 -> Int32.Parse 메소드에 의해 문자열을 정수로 변환
            Display.Text = intNumber.ToString(); // 정수로 변환된 숫자를 ToString 메소드를 통해 문자열로 변환. 그 값을 Display.Text에 저장
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonEgiht_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = " ";
                operatorChangeFlag = false;
            }
            string strNumber = Display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            Display.Text = intNumber.ToString();
        }

        private void Display_Click(object sender, EventArgs e)
        {

        }
    }
}