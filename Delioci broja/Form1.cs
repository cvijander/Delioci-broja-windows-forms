namespace Delioci_broja
{
    public partial class Form1 : Form
    {
        private bool dozvolaZaZatvaranje = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int broj = int.Parse(textBox1.Text);
                listBox1.Items.Add(1);
                for (int i = 2; i <= broj / 2; i++)
                {
                    if (broj % i == 0)
                        listBox1.Items.Add(i);
                }
                if (broj > 1)
                    listBox1.Items.Add(broj);
            }
            catch
            {
                MessageBox.Show("Obavezno unesite ceo broj");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "54";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dozvolaZaZatvaranje == false)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }
            else e.Cancel = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
            }
            else
            {
                timer1.Enabled = false;
                dozvolaZaZatvaranje = true;
                this.Close();
            }
        }
    }
}