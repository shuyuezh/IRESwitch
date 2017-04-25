﻿namespace NationalInstruments.Examples.MakingConnectionsOnASwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topologyNameLabel = new System.Windows.Forms.Label();
            this.topologyNameComboBox = new System.Windows.Forms.ComboBox();
            this.resourceNameLabel = new System.Windows.Forms.Label();
            this.resourceNameComboBox = new System.Windows.Forms.ComboBox();
            this.firstConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.channel2TextBox = new System.Windows.Forms.TextBox();
            this.channel1TextBox = new System.Windows.Forms.TextBox();
            this.channel2Label = new System.Windows.Forms.Label();
            this.channel1Label = new System.Windows.Forms.Label();
            this.secConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.channel4TextBox = new System.Windows.Forms.TextBox();
            this.channel3TextBox = new System.Windows.Forms.TextBox();
            this.channel4Label = new System.Windows.Forms.Label();
            this.channel3Label = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.Default = new System.Windows.Forms.Button();
            this.firstConnectionGroupBox.SuspendLayout();
            this.secConnectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topologyNameLabel
            // 
            this.topologyNameLabel.AutoSize = true;
            this.topologyNameLabel.Location = new System.Drawing.Point(422, 48);
            this.topologyNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.topologyNameLabel.Name = "topologyNameLabel";
            this.topologyNameLabel.Size = new System.Drawing.Size(215, 32);
            this.topologyNameLabel.TabIndex = 6;
            this.topologyNameLabel.Text = "Topology Name";
            // 
            // topologyNameComboBox
            // 
            this.topologyNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topologyNameComboBox.FormattingEnabled = true;
            this.topologyNameComboBox.Location = new System.Drawing.Point(430, 85);
            this.topologyNameComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.topologyNameComboBox.Name = "topologyNameComboBox";
            this.topologyNameComboBox.Size = new System.Drawing.Size(374, 39);
            this.topologyNameComboBox.TabIndex = 1;
            // 
            // resourceNameLabel
            // 
            this.resourceNameLabel.AutoSize = true;
            this.resourceNameLabel.Location = new System.Drawing.Point(32, 48);
            this.resourceNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.resourceNameLabel.Name = "resourceNameLabel";
            this.resourceNameLabel.Size = new System.Drawing.Size(218, 32);
            this.resourceNameLabel.TabIndex = 5;
            this.resourceNameLabel.Text = "Resource Name";
            // 
            // resourceNameComboBox
            // 
            this.resourceNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceNameComboBox.FormattingEnabled = true;
            this.resourceNameComboBox.Location = new System.Drawing.Point(32, 85);
            this.resourceNameComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.resourceNameComboBox.Name = "resourceNameComboBox";
            this.resourceNameComboBox.Size = new System.Drawing.Size(374, 39);
            this.resourceNameComboBox.TabIndex = 0;
            // 
            // firstConnectionGroupBox
            // 
            this.firstConnectionGroupBox.Controls.Add(this.channel2TextBox);
            this.firstConnectionGroupBox.Controls.Add(this.channel1TextBox);
            this.firstConnectionGroupBox.Controls.Add(this.channel2Label);
            this.firstConnectionGroupBox.Controls.Add(this.channel1Label);
            this.firstConnectionGroupBox.Location = new System.Drawing.Point(32, 196);
            this.firstConnectionGroupBox.Margin = new System.Windows.Forms.Padding(8);
            this.firstConnectionGroupBox.Name = "firstConnectionGroupBox";
            this.firstConnectionGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.firstConnectionGroupBox.Size = new System.Drawing.Size(382, 238);
            this.firstConnectionGroupBox.TabIndex = 2;
            this.firstConnectionGroupBox.TabStop = false;
            this.firstConnectionGroupBox.Text = "First Connection";
            // 
            // channel2TextBox
            // 
            this.channel2TextBox.Location = new System.Drawing.Point(24, 176);
            this.channel2TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.channel2TextBox.Name = "channel2TextBox";
            this.channel2TextBox.Size = new System.Drawing.Size(260, 38);
            this.channel2TextBox.TabIndex = 1;
            // 
            // channel1TextBox
            // 
            this.channel1TextBox.Location = new System.Drawing.Point(24, 76);
            this.channel1TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.channel1TextBox.Name = "channel1TextBox";
            this.channel1TextBox.Size = new System.Drawing.Size(260, 38);
            this.channel1TextBox.TabIndex = 0;
            // 
            // channel2Label
            // 
            this.channel2Label.AutoSize = true;
            this.channel2Label.Location = new System.Drawing.Point(16, 132);
            this.channel2Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.channel2Label.Name = "channel2Label";
            this.channel2Label.Size = new System.Drawing.Size(145, 32);
            this.channel2Label.TabIndex = 3;
            this.channel2Label.Text = "Channel 2";
            // 
            // channel1Label
            // 
            this.channel1Label.AutoSize = true;
            this.channel1Label.Location = new System.Drawing.Point(16, 39);
            this.channel1Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.channel1Label.Name = "channel1Label";
            this.channel1Label.Size = new System.Drawing.Size(145, 32);
            this.channel1Label.TabIndex = 2;
            this.channel1Label.Text = "Channel 1";
            // 
            // secConnectionGroupBox
            // 
            this.secConnectionGroupBox.Controls.Add(this.channel4TextBox);
            this.secConnectionGroupBox.Controls.Add(this.channel3TextBox);
            this.secConnectionGroupBox.Controls.Add(this.channel4Label);
            this.secConnectionGroupBox.Controls.Add(this.channel3Label);
            this.secConnectionGroupBox.Location = new System.Drawing.Point(430, 196);
            this.secConnectionGroupBox.Margin = new System.Windows.Forms.Padding(8);
            this.secConnectionGroupBox.Name = "secConnectionGroupBox";
            this.secConnectionGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.secConnectionGroupBox.Size = new System.Drawing.Size(382, 238);
            this.secConnectionGroupBox.TabIndex = 3;
            this.secConnectionGroupBox.TabStop = false;
            this.secConnectionGroupBox.Text = "Second Connection";
            // 
            // channel4TextBox
            // 
            this.channel4TextBox.Location = new System.Drawing.Point(24, 169);
            this.channel4TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.channel4TextBox.Name = "channel4TextBox";
            this.channel4TextBox.Size = new System.Drawing.Size(260, 38);
            this.channel4TextBox.TabIndex = 1;
            // 
            // channel3TextBox
            // 
            this.channel3TextBox.Location = new System.Drawing.Point(24, 76);
            this.channel3TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.channel3TextBox.Name = "channel3TextBox";
            this.channel3TextBox.Size = new System.Drawing.Size(260, 38);
            this.channel3TextBox.TabIndex = 0;
            // 
            // channel4Label
            // 
            this.channel4Label.AutoSize = true;
            this.channel4Label.Location = new System.Drawing.Point(16, 132);
            this.channel4Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.channel4Label.Name = "channel4Label";
            this.channel4Label.Size = new System.Drawing.Size(145, 32);
            this.channel4Label.TabIndex = 3;
            this.channel4Label.Text = "Channel 4";
            // 
            // channel3Label
            // 
            this.channel3Label.AutoSize = true;
            this.channel3Label.Location = new System.Drawing.Point(16, 39);
            this.channel3Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.channel3Label.Name = "channel3Label";
            this.channel3Label.Size = new System.Drawing.Size(145, 32);
            this.channel3Label.TabIndex = 2;
            this.channel3Label.Text = "Channel 3";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(160, 450);
            this.connectButton.Margin = new System.Windows.Forms.Padding(8);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(200, 54);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // Default
            // 
            this.Default.Location = new System.Drawing.Point(514, 450);
            this.Default.Margin = new System.Windows.Forms.Padding(8);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(200, 54);
            this.Default.TabIndex = 7;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 556);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.secConnectionGroupBox);
            this.Controls.Add(this.firstConnectionGroupBox);
            this.Controls.Add(this.topologyNameLabel);
            this.Controls.Add(this.topologyNameComboBox);
            this.Controls.Add(this.resourceNameLabel);
            this.Controls.Add(this.resourceNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Making Connections On A Switch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.firstConnectionGroupBox.ResumeLayout(false);
            this.firstConnectionGroupBox.PerformLayout();
            this.secConnectionGroupBox.ResumeLayout(false);
            this.secConnectionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topologyNameLabel;
        private System.Windows.Forms.ComboBox topologyNameComboBox;
        private System.Windows.Forms.Label resourceNameLabel;
        private System.Windows.Forms.ComboBox resourceNameComboBox;
        private System.Windows.Forms.GroupBox firstConnectionGroupBox;
        private System.Windows.Forms.GroupBox secConnectionGroupBox;
        private System.Windows.Forms.Label channel2Label;
        private System.Windows.Forms.Label channel1Label;
        private System.Windows.Forms.Label channel4Label;
        private System.Windows.Forms.Label channel3Label;
        private System.Windows.Forms.TextBox channel2TextBox;
        private System.Windows.Forms.TextBox channel1TextBox;
        private System.Windows.Forms.TextBox channel4TextBox;
        private System.Windows.Forms.TextBox channel3TextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button Default;
    }
}

