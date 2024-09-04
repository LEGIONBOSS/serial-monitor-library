
namespace SerialMonitor1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(12, 12);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Output.Size = new System.Drawing.Size(460, 408);
            this.textBox_Output.TabIndex = 0;
            this.textBox_Output.TabStop = false;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(12, 428);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(379, 20);
            this.textBox_Input.TabIndex = 1;
            // 
            // button_Send
            // 
            this.button_Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Send.Location = new System.Drawing.Point(397, 426);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.button_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.textBox_Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_Send;
    }
}

