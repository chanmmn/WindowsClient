namespace WinAppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Item1");
            //comboBox1.Items.Add("Item2");
            //comboBox1.Items.Add("Item3");
            //comboBox1.SelectedIndex = comboBox1.FindStringExact("Item2");

            BankData bankData = new BankData();
            comboBox1.DataSource = bankData.BankList;
            //foreach (var item in bankData.BankList)
            //{
            //    comboBox1.Items.Add(item.BankCode);
            //}
            comboBox1.DisplayMember = "BankCode";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("004");
        }
    }
}
