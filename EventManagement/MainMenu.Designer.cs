
namespace EventManagement {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.reportingGroupBox = new System.Windows.Forms.GroupBox();
            this.darkModeButton = new EventManagement.RoundButton();
            this.exitBtn = new EventManagement.RoundButton();
            this.compReportBtn = new EventManagement.RoundButton();
            this.eventReportBtn = new EventManagement.RoundButton();
            this.enterCompIntoChalBtn = new EventManagement.RoundButton();
            this.challMainBtn = new EventManagement.RoundButton();
            this.eventMainBtn = new EventManagement.RoundButton();
            this.compMainBtn = new EventManagement.RoundButton();
            this.arenaMainBtn = new EventManagement.RoundButton();
            this.mainGroupBox.SuspendLayout();
            this.reportingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.enterCompIntoChalBtn);
            this.mainGroupBox.Controls.Add(this.challMainBtn);
            this.mainGroupBox.Controls.Add(this.eventMainBtn);
            this.mainGroupBox.Controls.Add(this.compMainBtn);
            this.mainGroupBox.Controls.Add(this.arenaMainBtn);
            this.mainGroupBox.Location = new System.Drawing.Point(23, 56);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(538, 265);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Maintenance";
            // 
            // reportingGroupBox
            // 
            this.reportingGroupBox.Controls.Add(this.compReportBtn);
            this.reportingGroupBox.Controls.Add(this.eventReportBtn);
            this.reportingGroupBox.Location = new System.Drawing.Point(23, 341);
            this.reportingGroupBox.Name = "reportingGroupBox";
            this.reportingGroupBox.Size = new System.Drawing.Size(538, 110);
            this.reportingGroupBox.TabIndex = 1;
            this.reportingGroupBox.TabStop = false;
            this.reportingGroupBox.Text = "Reporting";
            // 
            // darkModeButton
            // 
            this.darkModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.darkModeButton.BorderColor = System.Drawing.Color.RoyalBlue;
            this.darkModeButton.BorderRadius = 20;
            this.darkModeButton.BorderSize = 0;
            this.darkModeButton.FlatAppearance.BorderSize = 0;
            this.darkModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkModeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkModeButton.ForeColor = System.Drawing.Color.White;
            this.darkModeButton.Location = new System.Drawing.Point(496, 11);
            this.darkModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.darkModeButton.Name = "darkModeButton";
            this.darkModeButton.Size = new System.Drawing.Size(65, 40);
            this.darkModeButton.TabIndex = 13;
            this.darkModeButton.Text = "Dark";
            this.darkModeButton.TextColor = System.Drawing.Color.White;
            this.darkModeButton.UseVisualStyleBackColor = false;
            this.darkModeButton.Click += new System.EventHandler(this.darkModeButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.exitBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitBtn.BorderRadius = 20;
            this.exitBtn.BorderSize = 0;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(189, 470);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(222, 40);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextColor = System.Drawing.Color.White;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // compReportBtn
            // 
            this.compReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.compReportBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.compReportBtn.BorderRadius = 20;
            this.compReportBtn.BorderSize = 0;
            this.compReportBtn.FlatAppearance.BorderSize = 0;
            this.compReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compReportBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compReportBtn.ForeColor = System.Drawing.Color.White;
            this.compReportBtn.Location = new System.Drawing.Point(288, 42);
            this.compReportBtn.Name = "compReportBtn";
            this.compReportBtn.Size = new System.Drawing.Size(222, 40);
            this.compReportBtn.TabIndex = 11;
            this.compReportBtn.Text = "Competitor Report";
            this.compReportBtn.TextColor = System.Drawing.Color.White;
            this.compReportBtn.UseVisualStyleBackColor = false;
            this.compReportBtn.Click += new System.EventHandler(this.compReportBtn_Click);
            // 
            // eventReportBtn
            // 
            this.eventReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.eventReportBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.eventReportBtn.BorderRadius = 20;
            this.eventReportBtn.BorderSize = 0;
            this.eventReportBtn.FlatAppearance.BorderSize = 0;
            this.eventReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventReportBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventReportBtn.ForeColor = System.Drawing.Color.White;
            this.eventReportBtn.Location = new System.Drawing.Point(25, 42);
            this.eventReportBtn.Name = "eventReportBtn";
            this.eventReportBtn.Size = new System.Drawing.Size(222, 40);
            this.eventReportBtn.TabIndex = 10;
            this.eventReportBtn.Text = "Events Report";
            this.eventReportBtn.TextColor = System.Drawing.Color.White;
            this.eventReportBtn.UseVisualStyleBackColor = false;
            this.eventReportBtn.Click += new System.EventHandler(this.eventReportBtn_Click);
            // 
            // enterCompIntoChalBtn
            // 
            this.enterCompIntoChalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.enterCompIntoChalBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.enterCompIntoChalBtn.BorderRadius = 20;
            this.enterCompIntoChalBtn.BorderSize = 0;
            this.enterCompIntoChalBtn.FlatAppearance.BorderSize = 0;
            this.enterCompIntoChalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterCompIntoChalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCompIntoChalBtn.ForeColor = System.Drawing.Color.White;
            this.enterCompIntoChalBtn.Location = new System.Drawing.Point(118, 189);
            this.enterCompIntoChalBtn.Name = "enterCompIntoChalBtn";
            this.enterCompIntoChalBtn.Size = new System.Drawing.Size(314, 40);
            this.enterCompIntoChalBtn.TabIndex = 9;
            this.enterCompIntoChalBtn.Text = "Enter Competitor Into Challenge";
            this.enterCompIntoChalBtn.TextColor = System.Drawing.Color.White;
            this.enterCompIntoChalBtn.UseVisualStyleBackColor = false;
            this.enterCompIntoChalBtn.Click += new System.EventHandler(this.enterCompIntoChalBtn_Click);
            // 
            // challMainBtn
            // 
            this.challMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.challMainBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.challMainBtn.BorderRadius = 20;
            this.challMainBtn.BorderSize = 0;
            this.challMainBtn.FlatAppearance.BorderSize = 0;
            this.challMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.challMainBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challMainBtn.ForeColor = System.Drawing.Color.White;
            this.challMainBtn.Location = new System.Drawing.Point(288, 115);
            this.challMainBtn.Name = "challMainBtn";
            this.challMainBtn.Size = new System.Drawing.Size(222, 40);
            this.challMainBtn.TabIndex = 8;
            this.challMainBtn.Text = "Challenge Maintenance";
            this.challMainBtn.TextColor = System.Drawing.Color.White;
            this.challMainBtn.UseVisualStyleBackColor = false;
            this.challMainBtn.Click += new System.EventHandler(this.challMainBtn_Click);
            // 
            // eventMainBtn
            // 
            this.eventMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.eventMainBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.eventMainBtn.BorderRadius = 20;
            this.eventMainBtn.BorderSize = 0;
            this.eventMainBtn.FlatAppearance.BorderSize = 0;
            this.eventMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventMainBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventMainBtn.ForeColor = System.Drawing.Color.White;
            this.eventMainBtn.Location = new System.Drawing.Point(25, 115);
            this.eventMainBtn.Name = "eventMainBtn";
            this.eventMainBtn.Size = new System.Drawing.Size(222, 40);
            this.eventMainBtn.TabIndex = 7;
            this.eventMainBtn.Text = "Event Maintenance";
            this.eventMainBtn.TextColor = System.Drawing.Color.White;
            this.eventMainBtn.UseVisualStyleBackColor = false;
            this.eventMainBtn.Click += new System.EventHandler(this.eventMainBtn_Click);
            // 
            // compMainBtn
            // 
            this.compMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.compMainBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.compMainBtn.BorderRadius = 20;
            this.compMainBtn.BorderSize = 0;
            this.compMainBtn.FlatAppearance.BorderSize = 0;
            this.compMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compMainBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compMainBtn.ForeColor = System.Drawing.Color.White;
            this.compMainBtn.Location = new System.Drawing.Point(288, 40);
            this.compMainBtn.Name = "compMainBtn";
            this.compMainBtn.Size = new System.Drawing.Size(222, 40);
            this.compMainBtn.TabIndex = 6;
            this.compMainBtn.Text = "Competitor Maintenance";
            this.compMainBtn.TextColor = System.Drawing.Color.White;
            this.compMainBtn.UseVisualStyleBackColor = false;
            this.compMainBtn.Click += new System.EventHandler(this.compMainBtn_Click);
            // 
            // arenaMainBtn
            // 
            this.arenaMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.arenaMainBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.arenaMainBtn.BorderRadius = 20;
            this.arenaMainBtn.BorderSize = 0;
            this.arenaMainBtn.FlatAppearance.BorderSize = 0;
            this.arenaMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arenaMainBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaMainBtn.ForeColor = System.Drawing.Color.White;
            this.arenaMainBtn.Location = new System.Drawing.Point(25, 40);
            this.arenaMainBtn.Name = "arenaMainBtn";
            this.arenaMainBtn.Size = new System.Drawing.Size(222, 40);
            this.arenaMainBtn.TabIndex = 5;
            this.arenaMainBtn.Text = "Arena Maintenance";
            this.arenaMainBtn.TextColor = System.Drawing.Color.White;
            this.arenaMainBtn.UseVisualStyleBackColor = false;
            this.arenaMainBtn.Click += new System.EventHandler(this.arenaMainBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(586, 527);
            this.Controls.Add(this.darkModeButton);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reportingGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainGroupBox.ResumeLayout(false);
            this.reportingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox reportingGroupBox;
        private RoundButton arenaMainBtn;
        private RoundButton enterCompIntoChalBtn;
        private RoundButton challMainBtn;
        private RoundButton eventMainBtn;
        private RoundButton compMainBtn;
        private RoundButton compReportBtn;
        private RoundButton eventReportBtn;
        private RoundButton exitBtn;
        private RoundButton darkMode;
        private RoundButton darkModeButton;
    }
}

