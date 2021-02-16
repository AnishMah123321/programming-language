namespace ASEassignment
{/// <summary>
/// creating class form1
/// </summary>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.variableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Artboard = new System.Windows.Forms.Panel();
            this.Runtextbox = new System.Windows.Forms.TextBox();
            this.Grouptextcmd = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.Grouptextrunbutton = new System.Windows.Forms.Button();
            this.Cleargrouptext = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.variableListToolStripMenuItem,
            this.variableCommandToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // variableListToolStripMenuItem
            // 
            this.variableListToolStripMenuItem.Name = "variableListToolStripMenuItem";
            this.variableListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.variableListToolStripMenuItem.Text = "Variable list";
            this.variableListToolStripMenuItem.Click += new System.EventHandler(this.variableListToolStripMenuItem_Click);
            // 
            // variableCommandToolStripMenuItem
            // 
            this.variableCommandToolStripMenuItem.Name = "variableCommandToolStripMenuItem";
            this.variableCommandToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.variableCommandToolStripMenuItem.Text = "Variable Command";
            this.variableCommandToolStripMenuItem.Click += new System.EventHandler(this.variableCommandToolStripMenuItem_Click);
            // 
            // Artboard
            // 
            this.Artboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Artboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Artboard.Location = new System.Drawing.Point(213, 26);
            this.Artboard.Margin = new System.Windows.Forms.Padding(2);
            this.Artboard.Name = "Artboard";
            this.Artboard.Size = new System.Drawing.Size(379, 305);
            this.Artboard.TabIndex = 1;
            this.Artboard.Paint += new System.Windows.Forms.PaintEventHandler(this.Artboard_Paint);
            this.Artboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Artboard_MouseClick);
            // 
            // Runtextbox
            // 
            this.Runtextbox.Location = new System.Drawing.Point(10, 27);
            this.Runtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.Runtextbox.Name = "Runtextbox";
            this.Runtextbox.Size = new System.Drawing.Size(200, 20);
            this.Runtextbox.TabIndex = 2;
            this.Runtextbox.TextChanged += new System.EventHandler(this.Runtextbox_TextChanged);
            // 
            // Grouptextcmd
            // 
            this.Grouptextcmd.Location = new System.Drawing.Point(10, 82);
            this.Grouptextcmd.Margin = new System.Windows.Forms.Padding(2);
            this.Grouptextcmd.Name = "Grouptextcmd";
            this.Grouptextcmd.Size = new System.Drawing.Size(200, 249);
            this.Grouptextcmd.TabIndex = 3;
            this.Grouptextcmd.Text = "";
            this.Grouptextcmd.TextChanged += new System.EventHandler(this.Grouptextcmd_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunButton.Location = new System.Drawing.Point(10, 50);
            this.RunButton.Margin = new System.Windows.Forms.Padding(2);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(56, 28);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // Grouptextrunbutton
            // 
            this.Grouptextrunbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Grouptextrunbutton.Location = new System.Drawing.Point(10, 336);
            this.Grouptextrunbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Grouptextrunbutton.Name = "Grouptextrunbutton";
            this.Grouptextrunbutton.Size = new System.Drawing.Size(56, 28);
            this.Grouptextrunbutton.TabIndex = 6;
            this.Grouptextrunbutton.Text = "Run";
            this.Grouptextrunbutton.UseVisualStyleBackColor = true;
            this.Grouptextrunbutton.Click += new System.EventHandler(this.Grouptextrunbutton_Click);
            // 
            // Cleargrouptext
            // 
            this.Cleargrouptext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cleargrouptext.Location = new System.Drawing.Point(213, 335);
            this.Cleargrouptext.Margin = new System.Windows.Forms.Padding(2);
            this.Cleargrouptext.Name = "Cleargrouptext";
            this.Cleargrouptext.Size = new System.Drawing.Size(56, 28);
            this.Cleargrouptext.TabIndex = 7;
            this.Cleargrouptext.Text = "Clear";
            this.Cleargrouptext.UseVisualStyleBackColor = true;
            this.Cleargrouptext.Click += new System.EventHandler(this.Cleargrouptext_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resetbutton.Location = new System.Drawing.Point(274, 335);
            this.Resetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(56, 28);
            this.Resetbutton.TabIndex = 8;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loadbtn.Location = new System.Drawing.Point(534, 336);
            this.Loadbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(56, 26);
            this.Loadbtn.TabIndex = 9;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Savebtn.Location = new System.Drawing.Point(473, 336);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(56, 26);
            this.Savebtn.TabIndex = 10;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 374);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Cleargrouptext);
            this.Controls.Add(this.Grouptextrunbutton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.Grouptextcmd);
            this.Controls.Add(this.Runtextbox);
            this.Controls.Add(this.Artboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel Artboard;
        private System.Windows.Forms.TextBox Runtextbox;
        private System.Windows.Forms.RichTextBox Grouptextcmd;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button Grouptextrunbutton;
        private System.Windows.Forms.Button Cleargrouptext;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem variableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableCommandToolStripMenuItem;
    }
}

