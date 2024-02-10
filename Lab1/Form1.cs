namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Завдання 1
            label1.Text = "a = ";
            label2.Text = "b = ";
            label3.Text = "c = ";
            label4.Text = "d = ";
            label6.Text = "Результат";
            btnOK.Text = "Порахувати";
            lblResult.Text = " ";

            //Завдання 2
            label5.Text = "v = ";
            label7.Text = "v1 = ";
            label8.Text = "t1 = ";
            label9.Text = "t2 = ";
            label10.Text = "Результат";
            btnOK2.Text = "Порахувати";
            lblResult2.Text = " ";

            //Завдання 3
            label11.Text = "N = ";
            label12.Text = "Результат";
            btnOK3.Text = "Порахувати";
            lblResult3.Text = " ";

            //Завдання 4
            label13.Text = "x1 = ";
            label14.Text = "x2 = ";
            label15.Text = "x3 = ";
            label16.Text = "x4 = ";
            label17.Text = "y1 = ";
            label18.Text = "y2 = ";
            label19.Text = "y3 = ";
            label20.Text = "y4 = ";
            label21.Text = "Результат";
            btnOK4.Text = "Порахувати";
            lblResult4.Text = " ";

            //Завдання 5
            label22.Text = "A = ";
            label23.Text = "B = ";
            label24.Text = "C = ";
            label25.Text = "D = ";
            label26.Text = "Результат";
            btnOK5.Text = "Порахувати";
            lblResult5.Text = " ";

            //Завдання 6
            label27.Text = "a1, a2...an";
            label28.Text = "b1, b2...bm";
            label29.Text = "Результат";
            btnOK6.Text = "Порахувати";
            lblResult6.Text = " ";

            //Завдання 7
            label30.Text = "Введіть англійський текст";
            label31.Text = "Кількість слів:";
            btnOK7.Text = "Порахувати";
            lblResult6.Text = " ";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text) ||
                string.IsNullOrWhiteSpace(txtD.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }

            //Завдання 1
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            double d = Convert.ToDouble(txtD.Text);
            double result = ((a / b) * (b / d)) - ((a * b - c) / (c * d));
            lblResult.Text = result.ToString();

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
            

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
            

        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtV.Text) ||
                string.IsNullOrWhiteSpace(txtV1.Text) ||
                string.IsNullOrWhiteSpace(txtT1.Text) ||
                string.IsNullOrWhiteSpace(txtT2.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }

            //Завдання 2
            double v = Convert.ToDouble(txtV.Text);
            double v1 = Convert.ToDouble(txtV1.Text);
            double t1 = Convert.ToDouble(txtT1.Text);
            double t2 = Convert.ToDouble(txtT2.Text);
            double distanceLake = v * t1;
            double distanceRiver = (v - v1) * t2;
            double totalDistance = distanceLake + distanceRiver;
            lblResult2.Text = totalDistance.ToString();
        }

        private void txtV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Будьласка. введіть цифру");
                return;
            }

            //Завдання 3
            double N = Convert.ToDouble(txtN.Text);
            var sum = 0;
            int temp = (int)N;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            bool isSumEven = sum % 2 == 0;
            lblResult3.Text = isSumEven.ToString();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtX1.Text) ||
                string.IsNullOrWhiteSpace(txtX2.Text) ||
                string.IsNullOrWhiteSpace(txtX3.Text) ||
                string.IsNullOrWhiteSpace(txtX4.Text) ||
                string.IsNullOrWhiteSpace(txtY1.Text) ||
                string.IsNullOrWhiteSpace(txtY2.Text) ||
                string.IsNullOrWhiteSpace(txtY3.Text) ||
                string.IsNullOrWhiteSpace(txtY4.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            //Завдання 4
            double x1 = Convert.ToDouble(txtX1.Text);
            double x2 = Convert.ToDouble(txtX2.Text);
            double x3 = Convert.ToDouble(txtX3.Text);
            double x4 = Convert.ToDouble(txtX4.Text);
            double y1 = Convert.ToDouble(txtY1.Text);
            double y2 = Convert.ToDouble(txtY2.Text);
            double y3 = Convert.ToDouble(txtY3.Text);
            double y4 = Convert.ToDouble(txtY4.Text);

            bool isConvex = true;

            double a1 = (y2 - y1) * (x3 - x2) - (x2 - x1) * (y3 - y2);
            double a2 = (y3 - y2) * (x4 - x3) - (x3 - x2) * (y4 - y3);
            double a3 = (y4 - y3) * (x1 - x4) - (x4 - x3) * (y1 - y4);
            double a4 = (y1 - y4) * (x2 - x1) - (x1 - x4) * (y2 - y1);

            if (a1 * a2 > 0 || a2 * a3 > 0 || a3 * a4 > 0 || a4 * a1 > 0)
            {
                isConvex = false;
            }

            lblResult4.Text = isConvex.ToString();

        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAx.Text) ||
              string.IsNullOrWhiteSpace(txtBx.Text) ||
              string.IsNullOrWhiteSpace(txtCx.Text) ||
              string.IsNullOrWhiteSpace(txtDx.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            ////Завдання 5
            double A = Convert.ToDouble(txtAx.Text);
            double B = Convert.ToDouble(txtBx.Text);
            double D = Convert.ToDouble(txtCx.Text);
            double C = Convert.ToDouble(txtDx.Text);

            for (int x = (int)-Math.Abs(D); x <= Math.Abs(D); x++)
            {
                if (D % x == 0)
                {
                    if (A * x * x * x + B * x * x + C * x + D == 0) ;

                    lblResult5.Text = x.ToString();
                }
            }
        }

        private void txtAx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtCx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtDx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSequenceA.Text) ||
              string.IsNullOrWhiteSpace(txtSequenceB.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            ////Завдання 6
            string[] sequenceA = txtSequenceA.Text.Split(',');
            string[] sequenceB = txtSequenceB.Text.Split(',');

            bool allElementsInSequenceA = sequenceB.All(item => sequenceA.Contains(item));

            if (allElementsInSequenceA)
            {
                lblResult6.Text = ("Усі елементи послідовності B входять в послідовність A.");
            }
            else
            {
                lblResult6.Text = ("Не всі елементи послідовності B входять в послідовність A.");
            }
        }

        private void txtSequenceA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == ',')
            {
                return;
            }
            e.Handled = true;
        }

        private void txtSequenceB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == ',')
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEnglish.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            //Завдання 7
            string inputText = txtEnglish.Text;
            string[] words = inputText.Split(new char[] { ' ', ',', '.', ';', ':', '?', '!', '\n' });

            int count = 0;
            foreach (string word in words)
            {
                if (word.StartsWith("b")) 
                {
                    count++;
                }
            }
            lblResult7.Text = count.ToString();
        }
    }
}
