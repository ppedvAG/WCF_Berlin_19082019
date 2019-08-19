using System.Windows.Forms;

namespace HalloWCF.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var client = new ServiceReference1.Service1Client();
            label1.Text = client.WelcheWochentagIstHeute();


        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            var client = new ServiceReference1.Service1Client();

            foreach (var item in client.GetAllTheBääääh())
            {
                listBox1.Items.Add(item.Hihihihih);
            }
        }
    }
}
