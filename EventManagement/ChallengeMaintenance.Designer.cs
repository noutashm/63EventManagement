
namespace EventManagement {
    partial class ChallengeMaintenance {
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
            this.components = new System.ComponentModel.Container();
            this.utilityTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.previousBtn = new EventManagement.RoundButton();
            this.nextBtn = new EventManagement.RoundButton();
            this.addCapacityTxtBox = new System.Windows.Forms.NumericUpDown();
            this.addEventIDComboBox = new System.Windows.Forms.ComboBox();
            this.addStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventNameTxtBox = new System.Windows.Forms.TextBox();
            this.eventIDTxtBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.capacityTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.challengeList = new System.Windows.Forms.ListBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.updateStatusTxtBox = new System.Windows.Forms.TextBox();
            this.updateStartTime = new System.Windows.Forms.DateTimePicker();
            this.updateCapacityTxtBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.updateEventNameTxtBox = new System.Windows.Forms.TextBox();
            this.updateEventIDTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.updateNameTxtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.updateCancel = new EventManagement.RoundButton();
            this.updateSave = new EventManagement.RoundButton();
            this.label21 = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addEventNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addStartTime = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.addNameTxtBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.addCancel = new EventManagement.RoundButton();
            this.addSave = new EventManagement.RoundButton();
            this.startTimeTxtBox = new System.Windows.Forms.TextBox();
            this.completeChalBtn = new EventManagement.RoundButton();
            this.finishChalBtn = new EventManagement.RoundButton();
            this.returnBtn = new EventManagement.RoundButton();
            this.deleteChalBtn = new EventManagement.RoundButton();
            this.updateChalBtn = new EventManagement.RoundButton();
            this.addChalBtn = new EventManagement.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.addCapacityTxtBox)).BeginInit();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCapacityTxtBox)).BeginInit();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.previousBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.previousBtn.BorderRadius = 15;
            this.previousBtn.BorderSize = 0;
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.ForeColor = System.Drawing.Color.White;
            this.previousBtn.Location = new System.Drawing.Point(62, 396);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(2);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(45, 32);
            this.previousBtn.TabIndex = 61;
            this.previousBtn.Text = "<<";
            this.previousBtn.TextColor = System.Drawing.Color.White;
            this.utilityTooltip.SetToolTip(this.previousBtn, "Previous");
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.nextBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextBtn.BorderRadius = 15;
            this.nextBtn.BorderSize = 0;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(112, 398);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(45, 32);
            this.nextBtn.TabIndex = 60;
            this.nextBtn.Text = ">>";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.utilityTooltip.SetToolTip(this.nextBtn, "Next");
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // addCapacityTxtBox
            // 
            this.addCapacityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCapacityTxtBox.Location = new System.Drawing.Point(200, 255);
            this.addCapacityTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.addCapacityTxtBox.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.addCapacityTxtBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.addCapacityTxtBox.Name = "addCapacityTxtBox";
            this.addCapacityTxtBox.Size = new System.Drawing.Size(96, 24);
            this.addCapacityTxtBox.TabIndex = 78;
            this.addCapacityTxtBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // addEventIDComboBox
            // 
            this.addEventIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventIDComboBox.FormattingEnabled = true;
            this.addEventIDComboBox.Location = new System.Drawing.Point(200, 82);
            this.addEventIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.addEventIDComboBox.Name = "addEventIDComboBox";
            this.addEventIDComboBox.Size = new System.Drawing.Size(50, 25);
            this.addEventIDComboBox.TabIndex = 76;
            this.addEventIDComboBox.SelectedIndexChanged += new System.EventHandler(this.addEventIDComboBox_SelectedIndexChanged);
            // 
            // addStatusComboBox
            // 
            this.addStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStatusComboBox.FormattingEnabled = true;
            this.addStatusComboBox.Items.AddRange(new object[] {
            "Scheduled",
            "Finished",
            "Completed"});
            this.addStatusComboBox.Location = new System.Drawing.Point(200, 200);
            this.addStatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.addStatusComboBox.Name = "addStatusComboBox";
            this.addStatusComboBox.Size = new System.Drawing.Size(117, 25);
            this.addStatusComboBox.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(102, 146);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 18);
            this.label18.TabIndex = 72;
            this.label18.Text = "Start Time:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Start Time:";
            // 
            // eventNameTxtBox
            // 
            this.eventNameTxtBox.Enabled = false;
            this.eventNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTxtBox.Location = new System.Drawing.Point(488, 157);
            this.eventNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventNameTxtBox.Name = "eventNameTxtBox";
            this.eventNameTxtBox.ReadOnly = true;
            this.eventNameTxtBox.Size = new System.Drawing.Size(159, 24);
            this.eventNameTxtBox.TabIndex = 79;
            // 
            // eventIDTxtBox
            // 
            this.eventIDTxtBox.Enabled = false;
            this.eventIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIDTxtBox.Location = new System.Drawing.Point(411, 157);
            this.eventIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventIDTxtBox.Name = "eventIDTxtBox";
            this.eventIDTxtBox.ReadOnly = true;
            this.eventIDTxtBox.Size = new System.Drawing.Size(74, 24);
            this.eventIDTxtBox.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(342, 159);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 18);
            this.label17.TabIndex = 77;
            this.label17.Text = "Event:";
            // 
            // capacityTxtBox
            // 
            this.capacityTxtBox.Enabled = false;
            this.capacityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTxtBox.Location = new System.Drawing.Point(412, 312);
            this.capacityTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.capacityTxtBox.Name = "capacityTxtBox";
            this.capacityTxtBox.ReadOnly = true;
            this.capacityTxtBox.Size = new System.Drawing.Size(97, 24);
            this.capacityTxtBox.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Capacity:";
            // 
            // statusTxtBox
            // 
            this.statusTxtBox.Enabled = false;
            this.statusTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxtBox.Location = new System.Drawing.Point(412, 260);
            this.statusTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusTxtBox.Name = "statusTxtBox";
            this.statusTxtBox.ReadOnly = true;
            this.statusTxtBox.Size = new System.Drawing.Size(117, 24);
            this.statusTxtBox.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Status:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Enabled = false;
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(411, 102);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(236, 24);
            this.nameTxtBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Challenge Name:";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtBox.Location = new System.Drawing.Point(412, 48);
            this.idTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(74, 24);
            this.idTxtBox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Challenge ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(132, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 18);
            this.label19.TabIndex = 70;
            this.label19.Text = "Event:*";
            // 
            // challengeList
            // 
            this.challengeList.FormattingEnabled = true;
            this.challengeList.Location = new System.Drawing.Point(20, 20);
            this.challengeList.Margin = new System.Windows.Forms.Padding(2);
            this.challengeList.Name = "challengeList";
            this.challengeList.Size = new System.Drawing.Size(192, 368);
            this.challengeList.TabIndex = 74;
            this.challengeList.SelectedIndexChanged += new System.EventHandler(this.challengeList_SelectedIndexChanged);
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.label8);
            this.updatePanel.Controls.Add(this.updateStatusTxtBox);
            this.updatePanel.Controls.Add(this.updateStartTime);
            this.updatePanel.Controls.Add(this.updateCapacityTxtBox);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.updateEventNameTxtBox);
            this.updatePanel.Controls.Add(this.updateEventIDTxtBox);
            this.updatePanel.Controls.Add(this.label9);
            this.updatePanel.Controls.Add(this.label10);
            this.updatePanel.Controls.Add(this.label11);
            this.updatePanel.Controls.Add(this.updateNameTxtBox);
            this.updatePanel.Controls.Add(this.label20);
            this.updatePanel.Controls.Add(this.updateCancel);
            this.updatePanel.Controls.Add(this.updateSave);
            this.updatePanel.Enabled = false;
            this.updatePanel.Location = new System.Drawing.Point(216, 20);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(573, 367);
            this.updatePanel.TabIndex = 76;
            this.updatePanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(200, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "* Required Fields";
            // 
            // updateStatusTxtBox
            // 
            this.updateStatusTxtBox.Enabled = false;
            this.updateStatusTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatusTxtBox.Location = new System.Drawing.Point(200, 211);
            this.updateStatusTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateStatusTxtBox.Name = "updateStatusTxtBox";
            this.updateStatusTxtBox.ReadOnly = true;
            this.updateStatusTxtBox.Size = new System.Drawing.Size(117, 24);
            this.updateStatusTxtBox.TabIndex = 81;
            // 
            // updateStartTime
            // 
            this.updateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updateStartTime.Location = new System.Drawing.Point(200, 158);
            this.updateStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.updateStartTime.Name = "updateStartTime";
            this.updateStartTime.Size = new System.Drawing.Size(117, 24);
            this.updateStartTime.TabIndex = 80;
            // 
            // updateCapacityTxtBox
            // 
            this.updateCapacityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCapacityTxtBox.Location = new System.Drawing.Point(200, 266);
            this.updateCapacityTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateCapacityTxtBox.Maximum = new decimal(new int[] {
            39,
            0,
            0,
            0});
            this.updateCapacityTxtBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updateCapacityTxtBox.Name = "updateCapacityTxtBox";
            this.updateCapacityTxtBox.Size = new System.Drawing.Size(96, 24);
            this.updateCapacityTxtBox.TabIndex = 79;
            this.updateCapacityTxtBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Start Time:*";
            // 
            // updateEventNameTxtBox
            // 
            this.updateEventNameTxtBox.Enabled = false;
            this.updateEventNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventNameTxtBox.Location = new System.Drawing.Point(254, 106);
            this.updateEventNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateEventNameTxtBox.Name = "updateEventNameTxtBox";
            this.updateEventNameTxtBox.ReadOnly = true;
            this.updateEventNameTxtBox.Size = new System.Drawing.Size(181, 24);
            this.updateEventNameTxtBox.TabIndex = 71;
            // 
            // updateEventIDTxtBox
            // 
            this.updateEventIDTxtBox.Enabled = false;
            this.updateEventIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventIDTxtBox.Location = new System.Drawing.Point(200, 106);
            this.updateEventIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateEventIDTxtBox.Name = "updateEventIDTxtBox";
            this.updateEventIDTxtBox.ReadOnly = true;
            this.updateEventIDTxtBox.Size = new System.Drawing.Size(50, 24);
            this.updateEventIDTxtBox.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "Event:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "Capacity:*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 214);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Status:";
            // 
            // updateNameTxtBox
            // 
            this.updateNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNameTxtBox.Location = new System.Drawing.Point(200, 50);
            this.updateNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateNameTxtBox.Name = "updateNameTxtBox";
            this.updateNameTxtBox.Size = new System.Drawing.Size(236, 24);
            this.updateNameTxtBox.TabIndex = 63;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(61, 52);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 18);
            this.label20.TabIndex = 62;
            this.label20.Text = "Challenge Name:*";
            // 
            // updateCancel
            // 
            this.updateCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.updateCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateCancel.BorderRadius = 15;
            this.updateCancel.BorderSize = 0;
            this.updateCancel.FlatAppearance.BorderSize = 0;
            this.updateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCancel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.updateCancel.ForeColor = System.Drawing.Color.White;
            this.updateCancel.Location = new System.Drawing.Point(455, 320);
            this.updateCancel.Margin = new System.Windows.Forms.Padding(2);
            this.updateCancel.Name = "updateCancel";
            this.updateCancel.Size = new System.Drawing.Size(102, 32);
            this.updateCancel.TabIndex = 31;
            this.updateCancel.Text = "Cancel";
            this.updateCancel.TextColor = System.Drawing.Color.White;
            this.updateCancel.UseVisualStyleBackColor = false;
            this.updateCancel.Click += new System.EventHandler(this.updateCancel_Click);
            // 
            // updateSave
            // 
            this.updateSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.updateSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateSave.BorderRadius = 15;
            this.updateSave.BorderSize = 0;
            this.updateSave.FlatAppearance.BorderSize = 0;
            this.updateSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSave.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.updateSave.ForeColor = System.Drawing.Color.White;
            this.updateSave.Location = new System.Drawing.Point(321, 320);
            this.updateSave.Margin = new System.Windows.Forms.Padding(2);
            this.updateSave.Name = "updateSave";
            this.updateSave.Size = new System.Drawing.Size(128, 32);
            this.updateSave.TabIndex = 21;
            this.updateSave.Text = "Save Changes";
            this.updateSave.TextColor = System.Drawing.Color.White;
            this.updateSave.UseVisualStyleBackColor = false;
            this.updateSave.Click += new System.EventHandler(this.updateSave_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(115, 255);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 18);
            this.label21.TabIndex = 66;
            this.label21.Text = "Capacity:*";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addEventNameTxtBox);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.addStartTime);
            this.addPanel.Controls.Add(this.addCapacityTxtBox);
            this.addPanel.Controls.Add(this.addEventIDComboBox);
            this.addPanel.Controls.Add(this.addStatusComboBox);
            this.addPanel.Controls.Add(this.label18);
            this.addPanel.Controls.Add(this.label19);
            this.addPanel.Controls.Add(this.label21);
            this.addPanel.Controls.Add(this.label22);
            this.addPanel.Controls.Add(this.addNameTxtBox);
            this.addPanel.Controls.Add(this.label23);
            this.addPanel.Controls.Add(this.addCancel);
            this.addPanel.Controls.Add(this.addSave);
            this.addPanel.Enabled = false;
            this.addPanel.Location = new System.Drawing.Point(216, 20);
            this.addPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(573, 367);
            this.addPanel.TabIndex = 75;
            this.addPanel.Visible = false;
            // 
            // addEventNameTxtBox
            // 
            this.addEventNameTxtBox.Enabled = false;
            this.addEventNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventNameTxtBox.Location = new System.Drawing.Point(254, 82);
            this.addEventNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.addEventNameTxtBox.Name = "addEventNameTxtBox";
            this.addEventNameTxtBox.ReadOnly = true;
            this.addEventNameTxtBox.Size = new System.Drawing.Size(182, 24);
            this.addEventNameTxtBox.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(197, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 87;
            this.label3.Text = "* Required Fields";
            // 
            // addStartTime
            // 
            this.addStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addStartTime.Location = new System.Drawing.Point(200, 146);
            this.addStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.addStartTime.Name = "addStartTime";
            this.addStartTime.Size = new System.Drawing.Size(117, 24);
            this.addStartTime.TabIndex = 81;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(130, 200);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 18);
            this.label22.TabIndex = 64;
            this.label22.Text = "Status:*";
            // 
            // addNameTxtBox
            // 
            this.addNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameTxtBox.Location = new System.Drawing.Point(200, 30);
            this.addNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.addNameTxtBox.Name = "addNameTxtBox";
            this.addNameTxtBox.Size = new System.Drawing.Size(236, 24);
            this.addNameTxtBox.TabIndex = 63;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(58, 33);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(127, 18);
            this.label23.TabIndex = 62;
            this.label23.Text = "Challenge Name:*";
            // 
            // addCancel
            // 
            this.addCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.addCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addCancel.BorderRadius = 15;
            this.addCancel.BorderSize = 0;
            this.addCancel.FlatAppearance.BorderSize = 0;
            this.addCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.addCancel.ForeColor = System.Drawing.Color.White;
            this.addCancel.Location = new System.Drawing.Point(455, 320);
            this.addCancel.Margin = new System.Windows.Forms.Padding(2);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(102, 32);
            this.addCancel.TabIndex = 31;
            this.addCancel.Text = "Cancel";
            this.addCancel.TextColor = System.Drawing.Color.White;
            this.addCancel.UseVisualStyleBackColor = false;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // addSave
            // 
            this.addSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.addSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addSave.BorderRadius = 15;
            this.addSave.BorderSize = 0;
            this.addSave.FlatAppearance.BorderSize = 0;
            this.addSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSave.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.addSave.ForeColor = System.Drawing.Color.White;
            this.addSave.Location = new System.Drawing.Point(309, 320);
            this.addSave.Margin = new System.Windows.Forms.Padding(2);
            this.addSave.Name = "addSave";
            this.addSave.Size = new System.Drawing.Size(140, 32);
            this.addSave.TabIndex = 21;
            this.addSave.Text = "Save Challenge";
            this.addSave.TextColor = System.Drawing.Color.White;
            this.addSave.UseVisualStyleBackColor = false;
            this.addSave.Click += new System.EventHandler(this.addSave_Click);
            // 
            // startTimeTxtBox
            // 
            this.startTimeTxtBox.Enabled = false;
            this.startTimeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeTxtBox.Location = new System.Drawing.Point(412, 209);
            this.startTimeTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.startTimeTxtBox.Name = "startTimeTxtBox";
            this.startTimeTxtBox.ReadOnly = true;
            this.startTimeTxtBox.Size = new System.Drawing.Size(97, 24);
            this.startTimeTxtBox.TabIndex = 81;
            // 
            // completeChalBtn
            // 
            this.completeChalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.completeChalBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.completeChalBtn.BorderRadius = 15;
            this.completeChalBtn.BorderSize = 0;
            this.completeChalBtn.FlatAppearance.BorderSize = 0;
            this.completeChalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeChalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.completeChalBtn.ForeColor = System.Drawing.Color.White;
            this.completeChalBtn.Location = new System.Drawing.Point(348, 448);
            this.completeChalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.completeChalBtn.Name = "completeChalBtn";
            this.completeChalBtn.Size = new System.Drawing.Size(284, 32);
            this.completeChalBtn.TabIndex = 83;
            this.completeChalBtn.Text = "Mark Challenge as Complete";
            this.completeChalBtn.TextColor = System.Drawing.Color.White;
            this.completeChalBtn.UseVisualStyleBackColor = false;
            this.completeChalBtn.Click += new System.EventHandler(this.completeChalBtn_Click);
            // 
            // finishChalBtn
            // 
            this.finishChalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.finishChalBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.finishChalBtn.BorderRadius = 15;
            this.finishChalBtn.BorderSize = 0;
            this.finishChalBtn.FlatAppearance.BorderSize = 0;
            this.finishChalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishChalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.finishChalBtn.ForeColor = System.Drawing.Color.White;
            this.finishChalBtn.Location = new System.Drawing.Point(20, 448);
            this.finishChalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.finishChalBtn.Name = "finishChalBtn";
            this.finishChalBtn.Size = new System.Drawing.Size(284, 32);
            this.finishChalBtn.TabIndex = 82;
            this.finishChalBtn.Text = "Mark Challenge as Finished";
            this.finishChalBtn.TextColor = System.Drawing.Color.White;
            this.finishChalBtn.UseVisualStyleBackColor = false;
            this.finishChalBtn.Click += new System.EventHandler(this.finishChalBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.returnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnBtn.BorderRadius = 15;
            this.returnBtn.BorderSize = 0;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(671, 448);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(102, 32);
            this.returnBtn.TabIndex = 65;
            this.returnBtn.Text = "Return";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // deleteChalBtn
            // 
            this.deleteChalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.deleteChalBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteChalBtn.BorderRadius = 15;
            this.deleteChalBtn.BorderSize = 0;
            this.deleteChalBtn.FlatAppearance.BorderSize = 0;
            this.deleteChalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteChalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.deleteChalBtn.ForeColor = System.Drawing.Color.White;
            this.deleteChalBtn.Location = new System.Drawing.Point(609, 396);
            this.deleteChalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteChalBtn.Name = "deleteChalBtn";
            this.deleteChalBtn.Size = new System.Drawing.Size(164, 32);
            this.deleteChalBtn.TabIndex = 64;
            this.deleteChalBtn.Text = "Delete Challenge";
            this.deleteChalBtn.TextColor = System.Drawing.Color.White;
            this.deleteChalBtn.UseVisualStyleBackColor = false;
            this.deleteChalBtn.Click += new System.EventHandler(this.deleteChalBtn_Click);
            // 
            // updateChalBtn
            // 
            this.updateChalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.updateChalBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateChalBtn.BorderRadius = 15;
            this.updateChalBtn.BorderSize = 0;
            this.updateChalBtn.FlatAppearance.BorderSize = 0;
            this.updateChalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateChalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.updateChalBtn.ForeColor = System.Drawing.Color.White;
            this.updateChalBtn.Location = new System.Drawing.Point(419, 398);
            this.updateChalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateChalBtn.Name = "updateChalBtn";
            this.updateChalBtn.Size = new System.Drawing.Size(164, 32);
            this.updateChalBtn.TabIndex = 63;
            this.updateChalBtn.Text = "Update Challenge";
            this.updateChalBtn.TextColor = System.Drawing.Color.White;
            this.updateChalBtn.UseVisualStyleBackColor = false;
            this.updateChalBtn.Click += new System.EventHandler(this.updateChalBtn_Click);
            // 
            // addChalBtn
            // 
            this.addChalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.addChalBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addChalBtn.BorderRadius = 15;
            this.addChalBtn.BorderSize = 0;
            this.addChalBtn.FlatAppearance.BorderSize = 0;
            this.addChalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChalBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.addChalBtn.ForeColor = System.Drawing.Color.White;
            this.addChalBtn.Location = new System.Drawing.Point(232, 398);
            this.addChalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addChalBtn.Name = "addChalBtn";
            this.addChalBtn.Size = new System.Drawing.Size(164, 32);
            this.addChalBtn.TabIndex = 62;
            this.addChalBtn.Text = "Add Challenge";
            this.addChalBtn.TextColor = System.Drawing.Color.White;
            this.addChalBtn.UseVisualStyleBackColor = false;
            this.addChalBtn.Click += new System.EventHandler(this.addChalBtn_Click);
            // 
            // ChallengeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.completeChalBtn);
            this.Controls.Add(this.finishChalBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventNameTxtBox);
            this.Controls.Add(this.eventIDTxtBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.capacityTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.deleteChalBtn);
            this.Controls.Add(this.updateChalBtn);
            this.Controls.Add(this.addChalBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.challengeList);
            this.Controls.Add(this.startTimeTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChallengeMaintenance";
            this.Text = "Challenge Maintenance";
            this.Load += new System.EventHandler(this.ChallengeMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addCapacityTxtBox)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCapacityTxtBox)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip utilityTooltip;
        private RoundButton previousBtn;
        private RoundButton nextBtn;
        private System.Windows.Forms.NumericUpDown addCapacityTxtBox;
        private System.Windows.Forms.ComboBox addEventIDComboBox;
        private System.Windows.Forms.ComboBox addStatusComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventNameTxtBox;
        private System.Windows.Forms.TextBox eventIDTxtBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox capacityTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label1;
        private RoundButton returnBtn;
        private RoundButton deleteChalBtn;
        private RoundButton updateChalBtn;
        private RoundButton addChalBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox challengeList;
        private RoundButton addCancel;
        private RoundButton addSave;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.DateTimePicker updateStartTime;
        private System.Windows.Forms.NumericUpDown updateCapacityTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateEventNameTxtBox;
        private System.Windows.Forms.TextBox updateEventIDTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox updateNameTxtBox;
        private System.Windows.Forms.Label label20;
        private RoundButton updateCancel;
        private RoundButton updateSave;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox addNameTxtBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox startTimeTxtBox;
        private RoundButton finishChalBtn;
        private RoundButton completeChalBtn;
        private System.Windows.Forms.DateTimePicker addStartTime;
        private System.Windows.Forms.TextBox updateStatusTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addEventNameTxtBox;
    }
}