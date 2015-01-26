namespace PostgreSQLManager
{
    partial class MainForm
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
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDatabaseName = new System.Windows.Forms.TextBox();
            this.btConnectionTest = new System.Windows.Forms.Button();
            this.btLoadQuery = new System.Windows.Forms.Button();
            this.btSaveQuery = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(411, 89);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 0;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(16, 334);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run Query";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(12, 138);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QueryTextBox.Size = new System.Drawing.Size(725, 175);
            this.QueryTextBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 409);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(57, 39);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(92, 20);
            this.tbServerName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(189, 39);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(61, 20);
            this.tbPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User ID";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(305, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(122, 20);
            this.tbUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(492, 31);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Database";
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Location = new System.Drawing.Point(659, 31);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Size = new System.Drawing.Size(78, 20);
            this.tbDatabaseName.TabIndex = 13;
            // 
            // btConnectionTest
            // 
            this.btConnectionTest.Location = new System.Drawing.Point(16, 89);
            this.btConnectionTest.Name = "btConnectionTest";
            this.btConnectionTest.Size = new System.Drawing.Size(108, 23);
            this.btConnectionTest.TabIndex = 14;
            this.btConnectionTest.Text = "Test Connection";
            this.btConnectionTest.UseVisualStyleBackColor = true;
            this.btConnectionTest.Click += new System.EventHandler(this.btConnectionTest_Click);
            // 
            // btLoadQuery
            // 
            this.btLoadQuery.Location = new System.Drawing.Point(189, 89);
            this.btLoadQuery.Name = "btLoadQuery";
            this.btLoadQuery.Size = new System.Drawing.Size(75, 23);
            this.btLoadQuery.TabIndex = 15;
            this.btLoadQuery.Text = "Load Query";
            this.btLoadQuery.UseVisualStyleBackColor = true;
            this.btLoadQuery.Click += new System.EventHandler(this.btLoadQuery_Click);
            // 
            // btSaveQuery
            // 
            this.btSaveQuery.Location = new System.Drawing.Point(305, 89);
            this.btSaveQuery.Name = "btSaveQuery";
            this.btSaveQuery.Size = new System.Drawing.Size(75, 23);
            this.btSaveQuery.TabIndex = 16;
            this.btSaveQuery.Text = "Save Query";
            this.btSaveQuery.UseVisualStyleBackColor = true;
            this.btSaveQuery.Click += new System.EventHandler(this.btSaveQuery_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileManagementToolStripMenuItem
            // 
            this.profileManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.deleteProfileToolStripMenuItem});
            this.profileManagementToolStripMenuItem.Name = "profileManagementToolStripMenuItem";
            this.profileManagementToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.profileManagementToolStripMenuItem.Text = "Profile Management";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.saveProfileToolStripMenuItem_Click);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete Profile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 803);
            this.Controls.Add(this.btSaveQuery);
            this.Controls.Add(this.btLoadQuery);
            this.Controls.Add(this.btConnectionTest);
            this.Controls.Add(this.tbDatabaseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PostreSQL Query Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDatabaseName;
        private System.Windows.Forms.Button btConnectionTest;
        private System.Windows.Forms.Button btLoadQuery;
        private System.Windows.Forms.Button btSaveQuery;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
    }
}

