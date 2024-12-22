namespace Score_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Unknown1, Unknown2, Unknown3, Total, Average;
            string Grade;

            Unknown1 = int.Parse(textUnknown1.Text);
            Unknown2 = int.Parse(textUnknown2.Text);
            Unknown3 = int.Parse(textUnknown3.Text);

            Total = Unknown1 + Unknown2 + Unknown3;
            textTotal.Text = Total.ToString();

            Average = Total / 3;
            textAverage.Text = Average.ToString();

            if (Average >= 75)
            {
                Grade = "A";
            }

            else if (Average >= 65)
            {
                Grade = "B";
            }

            else if (Average >= 55)
            {
                Grade = "C";
            }

            else if (Average >= 45)
            {
                Grade = "D";
            }

            else
            {
                Grade = "E";
            }

            textGrade.Text = Grade;
        }

        private void textAverage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
