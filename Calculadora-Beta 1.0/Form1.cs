namespace Calculadora_Beta_1._0
{
    public partial class Form1 : Form
    {
        //Inicializacion de variables

        double a,b;
        string operation;

        Class.ClassSuma objSuma = new Class.ClassSuma();
        Class.ClassResta objResta = new Class.ClassResta(); 
        Class.ClassMultiplicacion objMulti = new Class.ClassMultiplicacion();
        Class.ClassDivicion objDivicion = new Class.ClassDivicion();
      


        // Inicializando los numeros
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textScreen_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + ".";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "9";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "8";
        }




        // Funciones 

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "/";
            a = double.Parse(textScreen.Text);
            textScreen.Clear();

        }
        private void button10_Click(object sender, EventArgs e)
        {
            operation = "-";
            a = double.Parse(textScreen.Text);
            textScreen.Clear();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textScreen.Clear();

        }
 private void button12_Click(object sender, EventArgs e)
        {
            operation = "+";
            a = double.Parse(textScreen.Text);
            textScreen.Clear();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (textScreen.Text.Length ==1)
            {
                textScreen.Text = "";
            }else
                {
                    textScreen.Text = textScreen.Text.Substring(0,textScreen.Text.Length -1);   
                }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            operation = "*";
            a = double.Parse(textScreen.Text);
            textScreen.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = double.Parse(textScreen.Text);

            double sum, res, mul, divicion;

            switch (operation)
            {
                case"+": 
                     sum = objSuma.Sumar ((a),b);
                    textScreen.Text = sum.ToString();
                    break;

                case "-":
                    res = objResta.Resta((a), (b));
                   textScreen.Text = res.ToString();
                    break;

                case "*":
                    mul = objMulti.Multiplicacion((a), (b));
                    textScreen.Text = mul.ToString();
                    break;
                case "/":
                    divicion = objDivicion.Divicion((a), (b));
                    textScreen.Text = divicion.ToString();
                    break;


            }


        }
    }
}