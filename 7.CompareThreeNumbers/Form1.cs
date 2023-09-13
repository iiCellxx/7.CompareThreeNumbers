namespace _7.CompareThreeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void meowTB_Click(object sender, EventArgs e)
        {
            string no1, no2, no3;
            no1 = fnoTB.Text;
            no2 = SnoTB.Text;
            no3 = tnoTB.Text;

            //Creating if else who is the greatest
            if (int.TryParse(fnoTB.Text, out int num1) &&
                int.TryParse(SnoTB.Text, out int num2) &&
                int.TryParse(tnoTB.Text, out int num3))
            {
                if (num1 > num2 && num1 > num3)
                {
                    MessageBox.Show("The Greatest Number Is FirstNumber: " + no1);
                }
                else if (num2 > num1 && num2 > num3)
                {
                    MessageBox.Show("The Greatest Number Is SecondNumber: " + no2);
                }
                else
                {
                    MessageBox.Show("The Greatest Number Is ThirdNumber: " + no3);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}