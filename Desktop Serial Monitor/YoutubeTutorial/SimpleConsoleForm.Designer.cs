
namespace YoutubeTutorial
{
    partial class SimpleConsoleForm
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
            this.textBox_Ouput = new System.Windows.Forms.TextBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.checkBox_Autoscroll = new System.Windows.Forms.CheckBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.checkBox_Timestamps = new System.Windows.Forms.CheckBox();
            this.checkBox_ClearInput = new System.Windows.Forms.CheckBox();
            this.checkBox_Echo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Ouput
            // 
            this.textBox_Ouput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ouput.Location = new System.Drawing.Point(12, 35);
            this.textBox_Ouput.Multiline = true;
            this.textBox_Ouput.Name = "textBox_Ouput";
            this.textBox_Ouput.ReadOnly = true;
            this.textBox_Ouput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Ouput.Size = new System.Drawing.Size(360, 263);
            this.textBox_Ouput.TabIndex = 0;
            // 
            // textBox_Input
            // 
            this.textBox_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Input.Location = new System.Drawing.Point(12, 329);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(279, 20);
            this.textBox_Input.TabIndex = 1;
            // 
            // checkBox_Autoscroll
            // 
            this.checkBox_Autoscroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Autoscroll.AutoSize = true;
            this.checkBox_Autoscroll.Location = new System.Drawing.Point(300, 12);
            this.checkBox_Autoscroll.Name = "checkBox_Autoscroll";
            this.checkBox_Autoscroll.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Autoscroll.TabIndex = 2;
            this.checkBox_Autoscroll.Text = "Autoscroll";
            this.checkBox_Autoscroll.UseVisualStyleBackColor = true;
            // 
            // button_Send
            // 
            this.button_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Send.Location = new System.Drawing.Point(297, 327);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // checkBox_Timestamps
            // 
            this.checkBox_Timestamps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Timestamps.AutoSize = true;
            this.checkBox_Timestamps.Location = new System.Drawing.Point(209, 12);
            this.checkBox_Timestamps.Name = "checkBox_Timestamps";
            this.checkBox_Timestamps.Size = new System.Drawing.Size(82, 17);
            this.checkBox_Timestamps.TabIndex = 4;
            this.checkBox_Timestamps.Text = "Timestamps";
            this.checkBox_Timestamps.UseVisualStyleBackColor = true;
            // 
            // checkBox_ClearInput
            // 
            this.checkBox_ClearInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ClearInput.AutoSize = true;
            this.checkBox_ClearInput.Location = new System.Drawing.Point(272, 304);
            this.checkBox_ClearInput.Name = "checkBox_ClearInput";
            this.checkBox_ClearInput.Size = new System.Drawing.Size(100, 17);
            this.checkBox_ClearInput.TabIndex = 5;
            this.checkBox_ClearInput.Text = "Clear after send";
            this.checkBox_ClearInput.UseVisualStyleBackColor = true;
            // 
            // checkBox_Echo
            // 
            this.checkBox_Echo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Echo.AutoSize = true;
            this.checkBox_Echo.Location = new System.Drawing.Point(215, 304);
            this.checkBox_Echo.Name = "checkBox_Echo";
            this.checkBox_Echo.Size = new System.Drawing.Size(51, 17);
            this.checkBox_Echo.TabIndex = 6;
            this.checkBox_Echo.Text = "Echo";
            this.checkBox_Echo.UseVisualStyleBackColor = true;
            // 
            // SimpleConsoleForm
            // 
            this.AcceptButton = this.button_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.checkBox_Echo);
            this.Controls.Add(this.checkBox_ClearInput);
            this.Controls.Add(this.checkBox_Timestamps);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.checkBox_Autoscroll);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.textBox_Ouput);
            this.Name = "SimpleConsoleForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleConsoleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimpleConsoleForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Ouput;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.CheckBox checkBox_Autoscroll;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.CheckBox checkBox_Timestamps;
        private System.Windows.Forms.CheckBox checkBox_ClearInput;
        private System.Windows.Forms.CheckBox checkBox_Echo;
    }
}