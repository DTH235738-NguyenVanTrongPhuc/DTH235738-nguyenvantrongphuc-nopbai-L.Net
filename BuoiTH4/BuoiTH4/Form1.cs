namespace BuoiTH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int sopt = 0;
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
        }


        private void lblkq_Click(object sender, EventArgs e)
        {

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++) ;
                if (this.sopt == a.Length)
                {
                    this.txtnhap.Text = "";
                    MessageBox.Show("Mảng đầy", "Thông báo");
                }
                else
                {
                    if (this.txtnhap.Text == "")
                        MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");
                    else
                    {
                        a[sopt] = int.Parse(this.txtnhap.Text);
                        sopt++;
                        this.txtkq.Text += this.txtnhap.Text + " ";
                        this.txtnhap.Clear();
                        this.txtnhap.Focus();
                        if (sopt > 0)
                            this.btnin.Enabled = true;
                    }
                }
          
        }
        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
