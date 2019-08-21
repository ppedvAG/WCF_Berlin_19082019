using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var json = wc.DownloadString($"https://www.googleapis.com/books/v1/volumes?q={suchTextBox.Text}");
                jsonTextBox.Text = json;

                var result = JsonConvert.DeserializeObject<BookResult>(json);
                dataGridView1.DataSource = result.items.Select(x => x.volumeInfo).ToList();
            }
        }
    }
}
