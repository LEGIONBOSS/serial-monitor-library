
namespace YoutubeTutorial
{
    partial class ConnectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.comboBox_Bauds = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_RefreshPorts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM port:";
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(74, 12);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(98, 21);
            this.comboBox_Ports.TabIndex = 1;
            // 
            // comboBox_Bauds
            // 
            this.comboBox_Bauds.FormattingEnabled = true;
            this.comboBox_Bauds.Location = new System.Drawing.Point(74, 39);
            this.comboBox_Bauds.Name = "comboBox_Bauds";
            this.comboBox_Bauds.Size = new System.Drawing.Size(98, 21);
            this.comboBox_Bauds.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud rate:";
            // 
            // button_Connect
            // 
            this.button_Connect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Connect.Location = new System.Drawing.Point(99, 75);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_RefreshPorts
            // 
            this.button_RefreshPorts.Location = new System.Drawing.Point(178, 10);
            this.button_RefreshPorts.Name = "button_RefreshPorts";
            this.button_RefreshPorts.Size = new System.Drawing.Size(75, 23);
            this.button_RefreshPorts.TabIndex = 5;
            this.button_RefreshPorts.Text = "Refresh";
            this.button_RefreshPorts.UseVisualStyleBackColor = true;
            this.button_RefreshPorts.Click += new System.EventHandler(this.button_RefreshPorts_Click);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.button_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 110);
            this.Controls.Add(this.button_RefreshPorts);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Bauds);
            this.Controls.Add(this.comboBox_Ports);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.ComboBox comboBox_Bauds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_RefreshPorts;
    }
}