using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfChat2000.Contracts;

namespace WcfChat2000.Client
{
    public partial class Form1 : MaterialForm, IClient
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            msgTextBox.Enabled = false;
            sendTextButton.Enabled = false;
            sendPicButton.Enabled = false;

            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            listBox1.MeasureItem += ListBox1_MeasureItem;
            listBox1.DrawItem += ListBox1_DrawItem;
        }

        private void ListBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var lb = (ListBox)sender;

            if (lb.Items[e.Index] is Image img)
                e.ItemHeight = img.Height;
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lb = (ListBox)sender;
            // Make sure we're not trying to draw something that isn't there.
            if (e.Index >= lb.Items.Count || e.Index <= -1)
                return;

            // Get the item object.
            object item = lb.Items[e.Index];
            if (item == null)
                return;

            // if the item is selected or not.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // The item is selected.
                // We want a blue background color.
                e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
            }
            else
            {
                // The item is NOT selected.
                // We want a white background color.
                e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
            }

            if (item is Image img)
            {

                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);

            }
            else
            {
                string text = item.ToString();
                SizeF stringSize = e.Graphics.MeasureString(text, this.Font);
                e.Graphics.DrawString(text, this.Font, new SolidBrush(Color.White),
                    new PointF(5, e.Bounds.Y + (e.Bounds.Height - stringSize.Height) / 2));
            }

        }

        public void ShowPic(Stream pic)
        {
            //pictureBox1.Image = Image.FromStream(pic);
            listBox1.Items.Add(Image.FromStream(pic));

        }

        public void ShowText(string text)
        {
            listBox1.Items.Add(text);
        }

        public void ShowUsers(IEnumerable<string> users)
        {
            usersListBox.DataSource = users;
        }


        IServer server;
        private int myProperty;

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            var netTcp = new NetTcpBinding();
            netTcp.MaxReceivedMessageSize = int.MaxValue;

            var cf = new DuplexChannelFactory<IServer>(this, netTcp, new EndpointAddress("net.tcp://localhost:1"));
            server = cf.CreateChannel();
            server.Login(userNameTextBox.Text);
        }

        public void LoginResponse(bool ok, string msg)
        {
            if (!ok)
                MessageBox.Show(msg);
            else
                SetUI(true);


        }

        private void SetUI(bool loggedIn)
        {
            if (loggedIn)
            {
                logoutButton.Visible = true;
                userNameTextBox.Enabled = false;
                loginButton.Enabled = false;

                msgTextBox.Enabled = true;
                sendTextButton.Enabled = true;
                sendPicButton.Enabled = true;
            }
            else
            {
                logoutButton.Visible = !true;
                userNameTextBox.Enabled = !false;
                loginButton.Enabled = !false;

                msgTextBox.Enabled = !true;
                sendTextButton.Enabled = !true;
                sendPicButton.Enabled = !true;
                usersListBox.DataSource = null;
            }
        }


        private void SendTextButton_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                server.SendText(msgTextBox.Text);
                msgTextBox.Clear();
                msgTextBox.Focus();
            }
        }

        private void SendPicButton_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Ein Bild|*.png;*.jpg;*.bmp;*.gif;" };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                server.SendPic(File.OpenRead(dlg.FileName));
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            server?.Logout();
        }

        public void LogoutResponse(bool ok, string msg)
        {
            if (ok)
                SetUI(false);
            else
                MessageBox.Show(msg);

        }
    }
}
