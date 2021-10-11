
namespace StringCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label2_res = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.result_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.string2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.string1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.concatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPalindromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Operations Calculator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.label2_res);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.result_btn);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.string2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.string1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(24, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 292);
            this.panel1.TabIndex = 1;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.clear_btn.ForeColor = System.Drawing.Color.Maroon;
            this.clear_btn.Location = new System.Drawing.Point(41, 145);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(124, 34);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label2_res
            // 
            this.label2_res.AutoSize = true;
            this.label2_res.Location = new System.Drawing.Point(35, 197);
            this.label2_res.Name = "label2_res";
            this.label2_res.Size = new System.Drawing.Size(134, 15);
            this.label2_res.TabIndex = 4;
            this.label2_res.Text = "Result will appear below";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(30, 215);
            this.textBox3.MaximumSize = new System.Drawing.Size(305, 60);
            this.textBox3.MinimumSize = new System.Drawing.Size(305, 25);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(305, 25);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // result_btn
            // 
            this.result_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.result_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.result_btn.Location = new System.Drawing.Point(199, 145);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(124, 34);
            this.result_btn.TabIndex = 3;
            this.result_btn.Text = "Show Result";
            this.result_btn.UseVisualStyleBackColor = false;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 23);
            this.textBox2.TabIndex = 2;
            // 
            // string2
            // 
            this.string2.AutoSize = true;
            this.string2.Location = new System.Drawing.Point(37, 102);
            this.string2.Name = "string2";
            this.string2.Size = new System.Drawing.Size(80, 15);
            this.string2.TabIndex = 3;
            this.string2.Text = "Enter String2 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 1;
            // 
            // string1
            // 
            this.string1.AutoSize = true;
            this.string1.Location = new System.Drawing.Point(37, 62);
            this.string1.Name = "string1";
            this.string1.Size = new System.Drawing.Size(80, 15);
            this.string1.TabIndex = 1;
            this.string1.Text = "Enter String1 :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.concatToolStripMenuItem,
            this.compareToolStripMenuItem,
            this.checkPalindromeToolStripMenuItem,
            this.ReverseToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // concatToolStripMenuItem
            // 
            this.concatToolStripMenuItem.CheckOnClick = true;
            this.concatToolStripMenuItem.Name = "concatToolStripMenuItem";
            this.concatToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.concatToolStripMenuItem.Text = "Concatenation";
            this.concatToolStripMenuItem.Click += new System.EventHandler(this.concatToolStripMenuItem_Click);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // checkPalindromeToolStripMenuItem
            // 
            this.checkPalindromeToolStripMenuItem.Name = "checkPalindromeToolStripMenuItem";
            this.checkPalindromeToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.checkPalindromeToolStripMenuItem.Text = "Check Palindrome";
            this.checkPalindromeToolStripMenuItem.Click += new System.EventHandler(this.checkPalindromeToolStripMenuItem_Click);
            // 
            // ReverseToolStripMenuItem
            // 
            this.ReverseToolStripMenuItem.Name = "ReverseToolStripMenuItem";
            this.ReverseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ReverseToolStripMenuItem.Text = "Reverse";
            this.ReverseToolStripMenuItem.Click += new System.EventHandler(this.ReverseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Made by: Pratik Zalate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(412, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(428, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 417);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Operations Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem concatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPalindromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReverseToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button result_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label string2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label string1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2_res;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label2;
    }
}

