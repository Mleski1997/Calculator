using System.Diagnostics.Eventing.Reader;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string num1, num2;
        string option;
        string operation = string.Empty;
        double result = 0;
        bool enterValue = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
        }

        private void btnFractiion_Click(object sender, EventArgs e)
        {
        }

        private void btnMultiplyu_Click(object sender, EventArgs e)
        {
        }

        private void btnElement_Click(object sender, EventArgs e)
        {
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = txtTotal.Text;
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }
        private void btn3_Click(object sender, EventArgs e)
        {

        }
        private void btn2_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0" || enterValue) txtTotal.Text = string.Empty;
            enterValue = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtTotal.Text.Contains("."))
                    txtTotal.Text = txtTotal.Text + button.Text;
            }
            else txtTotal.Text = txtTotal.Text + button.Text;



        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) btnEqual.PerformClick();
            else result = Double.Parse(txtTotal.Text);

            Button button = (Button )sender;
            operation = button.Text;
            enterValue = true;
            if(txtTotal.Text != "0" ) 
            {
                txtTotal.Text = string.Empty;
             }

        }
    }
}