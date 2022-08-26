namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List< int> list ;
        ListBox listBox;

        public Form1()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.ToString();
            list = new List<int>();
        }

        private void ente(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dayso.Items.Add(txtnhap.Text);
            if (list.Count==0)
            {
                foreach (int i in dayso.Items)
                {
                    list.Add(i);
                }
            }
            txtnhap.Clear();
            txtnhap.Focus();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {

            if(dayso.Items.Count==0)
            {
                txtkq.BackColor = Color.Yellow;
                txtkq.Text = "Vui long nhap so";
                return;
            }

            if (yeucau.SelectedIndex == 0)
            {
                int T;
                T = 0;
                for (int i = 0; i < dayso.Items.Count; i++)
                {
                    int a=0;


                    try
                    {
                         a = Convert.ToInt32(dayso.Items[i]);
                    }
                    catch
                    {
                        txtkq.BackColor = Color.Red;
                        txtkq.Text = "Con cai nit";
                        return;
                    }
                    T += a;
                }
                txtkq.Text = T.ToString();
            }

            if (yeucau.SelectedIndex != 0)
            {
                        int T;
                        T = 1;
                int a;
                        for (int i = 0; i < dayso.Items.Count; i++)
                        {
                            try
                            {
                                a = Convert.ToInt32(dayso.Items[i]);
                            }
                            catch
                            {
                                txtkq.BackColor = Color.Red;
                                txtkq.Text = "Con cai nit";
                                return;
                            }
                            T *= a;
                        }

                txtkq.Text = T.ToString();
            }
                   

                

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            dayso.Items.Clear();
            txtkq.Text = "";
            txtkq.BackColor = Color.White;
        }

        private void dayso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbchan_CheckedChanged(object sender, EventArgs e)
        {
            if (dayso.Items.Count % 2 == 0)
            {
                
            }
            dayso.Items.Add("Con cai nit");
           
        }

        private void cble_CheckedChanged(object sender, EventArgs e)
        {
            if (dayso.Items.Count % 2 != 0)
            {
                dayso.BackColor= Color.Azure;
            }
        }
    }
}