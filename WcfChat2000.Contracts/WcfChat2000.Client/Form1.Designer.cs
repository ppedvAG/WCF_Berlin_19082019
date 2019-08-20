namespace WcfChat2000.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sendTextButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.msgTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sendPicButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.userNameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Depth = 0;
            this.userNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextBox.Hint = "";
            this.userNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.Size = new System.Drawing.Size(690, 28);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TabStop = false;
            this.userNameTextBox.Text = "Fred";
            this.userNameTextBox.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Depth = 0;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(700, 6);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
            this.loginButton.Size = new System.Drawing.Size(72, 36);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 20;
            this.usersListBox.Location = new System.Drawing.Point(512, 126);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(276, 424);
            this.usersListBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.sendTextButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.msgTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sendPicButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 502);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 48);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // sendTextButton
            // 
            this.sendTextButton.AutoSize = true;
            this.sendTextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendTextButton.Depth = 0;
            this.sendTextButton.Icon = null;
            this.sendTextButton.Location = new System.Drawing.Point(380, 6);
            this.sendTextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendTextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendTextButton.Name = "sendTextButton";
            this.sendTextButton.Primary = true;
            this.sendTextButton.Size = new System.Drawing.Size(66, 36);
            this.sendTextButton.TabIndex = 3;
            this.sendTextButton.Text = "Send";
            this.sendTextButton.UseVisualStyleBackColor = true;
            this.sendTextButton.Click += new System.EventHandler(this.SendTextButton_Click);
            // 
            // msgTextBox
            // 
            this.msgTextBox.Depth = 0;
            this.msgTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgTextBox.Hint = "";
            this.msgTextBox.Location = new System.Drawing.Point(3, 3);
            this.msgTextBox.MaxLength = 32767;
            this.msgTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.PasswordChar = '\0';
            this.msgTextBox.SelectedText = "";
            this.msgTextBox.SelectionLength = 0;
            this.msgTextBox.SelectionStart = 0;
            this.msgTextBox.Size = new System.Drawing.Size(370, 28);
            this.msgTextBox.TabIndex = 0;
            this.msgTextBox.TabStop = false;
            this.msgTextBox.Text = "materialSingleLineTextField2";
            this.msgTextBox.UseSystemPasswordChar = false;
            // 
            // sendPicButton
            // 
            this.sendPicButton.AutoSize = true;
            this.sendPicButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendPicButton.Depth = 0;
            this.sendPicButton.Icon = null;
            this.sendPicButton.Location = new System.Drawing.Point(454, 6);
            this.sendPicButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendPicButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendPicButton.Name = "sendPicButton";
            this.sendPicButton.Primary = true;
            this.sendPicButton.Size = new System.Drawing.Size(36, 36);
            this.sendPicButton.TabIndex = 4;
            this.sendPicButton.Text = "...";
            this.sendPicButton.UseVisualStyleBackColor = true;
            this.sendPicButton.Click += new System.EventHandler(this.SendPicButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(494, 364);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "WCF Chat 2000";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField userNameTextBox;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField msgTextBox;
        private MaterialSkin.Controls.MaterialFlatButton sendTextButton;
        private MaterialSkin.Controls.MaterialFlatButton sendPicButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

