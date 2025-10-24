namespace WinFormsApp3
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

        private void button1_Click(object sender, EventArgs e)
        {
            int maxRoll = 4;

            if(k4radioButton1.Checked)
                maxRoll = 4;
            if(k6radioButton2.Checked)
                maxRoll = 6;    
            if(k8radioButton3.Checked)
                maxRoll = 8;
            if(k10radioButton4.Checked)
                maxRoll = 10;
            if(k12radioButton5.Checked)
                maxRoll = 12;
            if(k20radioButton6.Checked)
                maxRoll = 20;
            Random r = new Random();
            int roll = r.Next(1, maxRoll + 1);
            ResultLabel.Text = roll.ToString();
        }
    }
}
