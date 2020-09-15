namespace MiniTut3
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.textBoxCapcity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 18;
            this.listBoxData.Location = new System.Drawing.Point(21, 31);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(928, 472);
            this.listBoxData.TabIndex = 0;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(362, 542);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(146, 51);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1021, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room No:";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(1100, 177);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomNo.TabIndex = 3;
            // 
            // textBoxCapcity
            // 
            this.textBoxCapcity.Location = new System.Drawing.Point(1100, 252);
            this.textBoxCapcity.Name = "textBoxCapcity";
            this.textBoxCapcity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapcity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1025, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1011, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Standard",
            "Large",
            "Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(1100, 213);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoomType.TabIndex = 7;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(1028, 308);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(193, 23);
            this.buttonAddRoom.TabIndex = 8;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFileToolStripMenuItem.Text = "Load File...";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveFileToolStripMenuItem.Text = "Save File...";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 620);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCapcity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.TextBox textBoxCapcity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

