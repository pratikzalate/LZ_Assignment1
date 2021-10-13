
namespace Devices
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_device1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_device2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.owner_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_device1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 262);
            this.panel1.TabIndex = 0;
            // 
            // btn_device1
            // 
            this.btn_device1.Location = new System.Drawing.Point(12, 207);
            this.btn_device1.Name = "btn_device1";
            this.btn_device1.Size = new System.Drawing.Size(166, 41);
            this.btn_device1.TabIndex = 1;
            this.btn_device1.Text = "Show Deatails";
            this.btn_device1.UseVisualStyleBackColor = true;
            this.btn_device1.Click += new System.EventHandler(this.btn_device1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Devices.Properties.Resources.lenze_plc_c300_orig;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_device2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(237, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 262);
            this.panel2.TabIndex = 1;
            // 
            // btn_device2
            // 
            this.btn_device2.Location = new System.Drawing.Point(12, 207);
            this.btn_device2.Name = "btn_device2";
            this.btn_device2.Size = new System.Drawing.Size(166, 41);
            this.btn_device2.TabIndex = 2;
            this.btn_device2.Text = "Show Deatails";
            this.btn_device2.UseVisualStyleBackColor = true;
            this.btn_device2.Click += new System.EventHandler(this.btn_device2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Devices.Properties.Resources.i510;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // owner_label
            // 
            this.owner_label.AutoSize = true;
            this.owner_label.Enabled = false;
            this.owner_label.Location = new System.Drawing.Point(137, 449);
            this.owner_label.Name = "owner_label";
            this.owner_label.Size = new System.Drawing.Size(176, 15);
            this.owner_label.TabIndex = 19;
            this.owner_label.Text = "Made by: Pratik Mahadev Zalate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(450, 473);
            this.Controls.Add(this.owner_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(466, 512);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devices";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_device1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_device2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label owner_label;
    }
}

