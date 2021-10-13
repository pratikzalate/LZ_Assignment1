
namespace Devices
{
    partial class Device2Details
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
            this.heading_label = new System.Windows.Forms.Label();
            this.device_name_label = new System.Windows.Forms.Label();
            this.product_code_label = new System.Windows.Forms.Label();
            this.firmware_version_label = new System.Windows.Forms.Label();
            this.actual_torque_label = new System.Windows.Forms.Label();
            this.actual_speed_label = new System.Windows.Forms.Label();
            this.actual_voltage_label = new System.Windows.Forms.Label();
            this.error_status_label = new System.Windows.Forms.Label();
            this.device_name_textbox = new System.Windows.Forms.TextBox();
            this.product_code_textbox = new System.Windows.Forms.TextBox();
            this.firmware_version_textbox = new System.Windows.Forms.TextBox();
            this.actual_torque_textbox = new System.Windows.Forms.TextBox();
            this.actual_speed_textbox = new System.Windows.Forms.TextBox();
            this.actual_voltage_textbox = new System.Windows.Forms.TextBox();
            this.LED = new System.Windows.Forms.PictureBox();
            this.hint_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LED)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heading_label.Location = new System.Drawing.Point(23, 16);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(104, 20);
            this.heading_label.TabIndex = 0;
            this.heading_label.Text = "Device Deatils";
            // 
            // device_name_label
            // 
            this.device_name_label.AutoSize = true;
            this.device_name_label.Location = new System.Drawing.Point(53, 62);
            this.device_name_label.Name = "device_name_label";
            this.device_name_label.Size = new System.Drawing.Size(75, 15);
            this.device_name_label.TabIndex = 1;
            this.device_name_label.Text = "Device name";
            // 
            // product_code_label
            // 
            this.product_code_label.AutoSize = true;
            this.product_code_label.Location = new System.Drawing.Point(53, 108);
            this.product_code_label.Name = "product_code_label";
            this.product_code_label.Size = new System.Drawing.Size(78, 15);
            this.product_code_label.TabIndex = 2;
            this.product_code_label.Text = "Product code";
            // 
            // firmware_version_label
            // 
            this.firmware_version_label.AutoSize = true;
            this.firmware_version_label.Location = new System.Drawing.Point(53, 154);
            this.firmware_version_label.Name = "firmware_version_label";
            this.firmware_version_label.Size = new System.Drawing.Size(97, 15);
            this.firmware_version_label.TabIndex = 3;
            this.firmware_version_label.Text = "Firmware version";
            // 
            // actual_torque_label
            // 
            this.actual_torque_label.AutoSize = true;
            this.actual_torque_label.Location = new System.Drawing.Point(53, 200);
            this.actual_torque_label.Name = "actual_torque_label";
            this.actual_torque_label.Size = new System.Drawing.Size(79, 15);
            this.actual_torque_label.TabIndex = 4;
            this.actual_torque_label.Text = "Actual torque";
            // 
            // actual_speed_label
            // 
            this.actual_speed_label.AutoSize = true;
            this.actual_speed_label.Location = new System.Drawing.Point(53, 246);
            this.actual_speed_label.Name = "actual_speed_label";
            this.actual_speed_label.Size = new System.Drawing.Size(75, 15);
            this.actual_speed_label.TabIndex = 5;
            this.actual_speed_label.Text = "Actual speed";
            // 
            // actual_voltage_label
            // 
            this.actual_voltage_label.AutoSize = true;
            this.actual_voltage_label.Location = new System.Drawing.Point(53, 292);
            this.actual_voltage_label.Name = "actual_voltage_label";
            this.actual_voltage_label.Size = new System.Drawing.Size(83, 15);
            this.actual_voltage_label.TabIndex = 6;
            this.actual_voltage_label.Text = "Actual voltage";
            // 
            // error_status_label
            // 
            this.error_status_label.AutoSize = true;
            this.error_status_label.Location = new System.Drawing.Point(53, 343);
            this.error_status_label.Name = "error_status_label";
            this.error_status_label.Size = new System.Drawing.Size(61, 15);
            this.error_status_label.TabIndex = 7;
            this.error_status_label.Text = "Error State";
            // 
            // device_name_textbox
            // 
            this.device_name_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.device_name_textbox.Location = new System.Drawing.Point(163, 55);
            this.device_name_textbox.Name = "device_name_textbox";
            this.device_name_textbox.ReadOnly = true;
            this.device_name_textbox.Size = new System.Drawing.Size(201, 23);
            this.device_name_textbox.TabIndex = 9;
            this.device_name_textbox.TabStop = false;
            // 
            // product_code_textbox
            // 
            this.product_code_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.product_code_textbox.Location = new System.Drawing.Point(163, 101);
            this.product_code_textbox.Name = "product_code_textbox";
            this.product_code_textbox.ReadOnly = true;
            this.product_code_textbox.Size = new System.Drawing.Size(201, 23);
            this.product_code_textbox.TabIndex = 10;
            this.product_code_textbox.TabStop = false;
            // 
            // firmware_version_textbox
            // 
            this.firmware_version_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.firmware_version_textbox.Location = new System.Drawing.Point(163, 147);
            this.firmware_version_textbox.Name = "firmware_version_textbox";
            this.firmware_version_textbox.ReadOnly = true;
            this.firmware_version_textbox.Size = new System.Drawing.Size(201, 23);
            this.firmware_version_textbox.TabIndex = 11;
            this.firmware_version_textbox.TabStop = false;
            // 
            // actual_torque_textbox
            // 
            this.actual_torque_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.actual_torque_textbox.Location = new System.Drawing.Point(163, 193);
            this.actual_torque_textbox.Name = "actual_torque_textbox";
            this.actual_torque_textbox.ReadOnly = true;
            this.actual_torque_textbox.Size = new System.Drawing.Size(201, 23);
            this.actual_torque_textbox.TabIndex = 6;
            this.actual_torque_textbox.TabStop = false;
            // 
            // actual_speed_textbox
            // 
            this.actual_speed_textbox.Location = new System.Drawing.Point(163, 239);
            this.actual_speed_textbox.Name = "actual_speed_textbox";
            this.actual_speed_textbox.Size = new System.Drawing.Size(201, 23);
            this.actual_speed_textbox.TabIndex = 1;
            this.actual_speed_textbox.Leave += new System.EventHandler(this.actual_speed_textbox_TextChanged);
            // 
            // actual_voltage_textbox
            // 
            this.actual_voltage_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.actual_voltage_textbox.Location = new System.Drawing.Point(163, 285);
            this.actual_voltage_textbox.Name = "actual_voltage_textbox";
            this.actual_voltage_textbox.Size = new System.Drawing.Size(201, 23);
            this.actual_voltage_textbox.TabIndex = 2;
            this.actual_voltage_textbox.Leave += new System.EventHandler(this.actual_voltage_textbox_TextChanged);
            // 
            // LED
            // 
            this.LED.Image = global::Devices.Properties.Resources.GreenLED;
            this.LED.Location = new System.Drawing.Point(163, 338);
            this.LED.MaximumSize = new System.Drawing.Size(20, 20);
            this.LED.MinimumSize = new System.Drawing.Size(20, 20);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(20, 20);
            this.LED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LED.TabIndex = 17;
            this.LED.TabStop = false;
            // 
            // hint_label
            // 
            this.hint_label.AutoSize = true;
            this.hint_label.Enabled = false;
            this.hint_label.Location = new System.Drawing.Point(23, 449);
            this.hint_label.Name = "hint_label";
            this.hint_label.Size = new System.Drawing.Size(273, 15);
            this.hint_label.TabIndex = 18;
            this.hint_label.Text = "Hint: Use tab to switch between editable textboxes";
            // 
            // Device2Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 473);
            this.Controls.Add(this.hint_label);
            this.Controls.Add(this.LED);
            this.Controls.Add(this.actual_voltage_textbox);
            this.Controls.Add(this.actual_speed_textbox);
            this.Controls.Add(this.actual_torque_textbox);
            this.Controls.Add(this.firmware_version_textbox);
            this.Controls.Add(this.product_code_textbox);
            this.Controls.Add(this.device_name_textbox);
            this.Controls.Add(this.error_status_label);
            this.Controls.Add(this.actual_voltage_label);
            this.Controls.Add(this.actual_speed_label);
            this.Controls.Add(this.actual_torque_label);
            this.Controls.Add(this.firmware_version_label);
            this.Controls.Add(this.product_code_label);
            this.Controls.Add(this.device_name_label);
            this.Controls.Add(this.heading_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(466, 512);
            this.Name = "Device2Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceDetails";
            ((System.ComponentModel.ISupportInitialize)(this.LED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label device_name_label;
        private System.Windows.Forms.Label product_code_label;
        private System.Windows.Forms.Label firmware_version_label;
        private System.Windows.Forms.Label actual_torque_label;
        private System.Windows.Forms.Label actual_speed_label;
        private System.Windows.Forms.Label actual_voltage_label;
        private System.Windows.Forms.Label error_status_label;
        private System.Windows.Forms.TextBox device_name_textbox;
        private System.Windows.Forms.TextBox product_code_textbox;
        private System.Windows.Forms.TextBox firmware_version_textbox;
        private System.Windows.Forms.TextBox actual_torque_textbox;
        private System.Windows.Forms.TextBox actual_speed_textbox;
        private System.Windows.Forms.TextBox actual_voltage_textbox;
        private System.Windows.Forms.PictureBox LED;
        private System.Windows.Forms.Label hint_label;
    }
}