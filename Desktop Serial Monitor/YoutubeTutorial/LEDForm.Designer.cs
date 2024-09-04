
namespace YoutubeTutorial
{
    partial class LEDForm
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
            this.components = new System.ComponentModel.Container();
            this.button_ON = new System.Windows.Forms.Button();
            this.button_OFF = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_ON
            // 
            this.button_ON.Location = new System.Drawing.Point(12, 12);
            this.button_ON.Name = "button_ON";
            this.button_ON.Size = new System.Drawing.Size(75, 23);
            this.button_ON.TabIndex = 0;
            this.button_ON.Text = "LED ON";
            this.button_ON.UseVisualStyleBackColor = true;
            this.button_ON.Click += new System.EventHandler(this.button_ON_Click);
            // 
            // button_OFF
            // 
            this.button_OFF.Location = new System.Drawing.Point(93, 12);
            this.button_OFF.Name = "button_OFF";
            this.button_OFF.Size = new System.Drawing.Size(75, 23);
            this.button_OFF.TabIndex = 1;
            this.button_OFF.Text = "LED OFF";
            this.button_OFF.UseVisualStyleBackColor = true;
            this.button_OFF.Click += new System.EventHandler(this.button_OFF_Click);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(174, 38);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Input.Location = new System.Drawing.Point(12, 41);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(156, 20);
            this.textBox_Input.TabIndex = 3;
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ports.DropDownWidth = 75;
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(174, 12);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(75, 21);
            this.comboBox_Ports.TabIndex = 4;
            this.comboBox_Ports.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Ports_SelectionChangeCommitted);
            // 
            // LEDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 75);
            this.Controls.Add(this.comboBox_Ports);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.button_OFF);
            this.Controls.Add(this.button_ON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LEDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ON;
        private System.Windows.Forms.Button button_OFF;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.ComboBox comboBox_Ports;
    }
}

