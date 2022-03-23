
namespace EventManagement {
    partial class EventMaintenance {
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
            this.eventList = new System.Windows.Forms.ListBox();
            this.addCancel = new EventManagement.RoundButton();
            this.addSave = new EventManagement.RoundButton();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.updateStatusComboBox = new System.Windows.Forms.ComboBox();
            this.updateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.updateCapcityNumBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.updateArenaNameTxtBox = new System.Windows.Forms.TextBox();
            this.updateArenaIDTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.updateNameTxtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.updateCancel = new EventManagement.RoundButton();
            this.updateSave = new EventManagement.RoundButton();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addArenaNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addCapcityNumBox = new System.Windows.Forms.NumericUpDown();
            this.addArenaIDComboBox = new System.Windows.Forms.ComboBox();
            this.addStatusComboBox = new System.Windows.Forms.ComboBox();
            this.addDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.addNameTxtBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.utilityTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.previousBtn = new EventManagement.RoundButton();
            this.nextBtn = new EventManagement.RoundButton();
            this.capacityTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnBtn = new EventManagement.RoundButton();
            this.deleteEventBtn = new EventManagement.RoundButton();
            this.updateEventBtn = new EventManagement.RoundButton();
            this.addEventBtn = new EventManagement.RoundButton();
            this.arenaIDTxtBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.arenaNameTxtBox = new System.Windows.Forms.TextBox();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dsNZESL1 = new EventManagement.dsNZESL();
            this.nzeslDataSet1 = new EventManagement.NZESLDataSet();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCapcityNumBox)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCapcityNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZESL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nzeslDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(22, 20);
            this.eventList.Margin = new System.Windows.Forms.Padding(2);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(192, 368);
            this.eventList.TabIndex = 51;
            this.eventList.SelectedIndexChanged += new System.EventHandler(this.eventList_SelectedIndexChanged);
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
            this.addSave.Location = new System.Drawing.Point(321, 320);
            this.addSave.Margin = new System.Windows.Forms.Padding(2);
            this.addSave.Name = "addSave";
            this.addSave.Size = new System.Drawing.Size(128, 32);
            this.addSave.TabIndex = 21;
            this.addSave.Text = "Save Event";
            this.addSave.TextColor = System.Drawing.Color.White;
            this.addSave.UseVisualStyleBackColor = false;
            this.addSave.Click += new System.EventHandler(this.addSave_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.label8);
            this.updatePanel.Controls.Add(this.updateStatusComboBox);
            this.updatePanel.Controls.Add(this.updateDatePicker);
            this.updatePanel.Controls.Add(this.updateCapcityNumBox);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.updateArenaNameTxtBox);
            this.updatePanel.Controls.Add(this.updateArenaIDTxtBox);
            this.updatePanel.Controls.Add(this.label9);
            this.updatePanel.Controls.Add(this.label10);
            this.updatePanel.Controls.Add(this.label11);
            this.updatePanel.Controls.Add(this.updateNameTxtBox);
            this.updatePanel.Controls.Add(this.label20);
            this.updatePanel.Controls.Add(this.updateCancel);
            this.updatePanel.Controls.Add(this.updateSave);
            this.updatePanel.Enabled = false;
            this.updatePanel.Location = new System.Drawing.Point(218, 20);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(2);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(574, 367);
            this.updatePanel.TabIndex = 53;
            this.updatePanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(197, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 88;
            this.label8.Text = "* Required Fields";
            // 
            // updateStatusComboBox
            // 
            this.updateStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatusComboBox.FormattingEnabled = true;
            this.updateStatusComboBox.Items.AddRange(new object[] {
            "Confirmed",
            "Unconfirmed",
            "Cancelled"});
            this.updateStatusComboBox.Location = new System.Drawing.Point(200, 162);
            this.updateStatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateStatusComboBox.Name = "updateStatusComboBox";
            this.updateStatusComboBox.Size = new System.Drawing.Size(117, 25);
            this.updateStatusComboBox.TabIndex = 79;
            // 
            // updateDatePicker
            // 
            this.updateDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateDatePicker.Location = new System.Drawing.Point(200, 264);
            this.updateDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.updateDatePicker.Name = "updateDatePicker";
            this.updateDatePicker.Size = new System.Drawing.Size(132, 24);
            this.updateDatePicker.TabIndex = 80;
            // 
            // updateCapcityNumBox
            // 
            this.updateCapcityNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCapcityNumBox.Location = new System.Drawing.Point(200, 216);
            this.updateCapcityNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateCapcityNumBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.updateCapcityNumBox.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.updateCapcityNumBox.Name = "updateCapcityNumBox";
            this.updateCapcityNumBox.Size = new System.Drawing.Size(96, 24);
            this.updateCapcityNumBox.TabIndex = 79;
            this.updateCapcityNumBox.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Event Date:";
            // 
            // updateArenaNameTxtBox
            // 
            this.updateArenaNameTxtBox.Enabled = false;
            this.updateArenaNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateArenaNameTxtBox.Location = new System.Drawing.Point(277, 106);
            this.updateArenaNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateArenaNameTxtBox.Name = "updateArenaNameTxtBox";
            this.updateArenaNameTxtBox.ReadOnly = true;
            this.updateArenaNameTxtBox.Size = new System.Drawing.Size(158, 24);
            this.updateArenaNameTxtBox.TabIndex = 71;
            // 
            // updateArenaIDTxtBox
            // 
            this.updateArenaIDTxtBox.Enabled = false;
            this.updateArenaIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateArenaIDTxtBox.Location = new System.Drawing.Point(200, 106);
            this.updateArenaIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateArenaIDTxtBox.Name = "updateArenaIDTxtBox";
            this.updateArenaIDTxtBox.ReadOnly = true;
            this.updateArenaIDTxtBox.Size = new System.Drawing.Size(74, 24);
            this.updateArenaIDTxtBox.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 68;
            this.label9.Text = "Arena:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 218);
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
            this.label11.Location = new System.Drawing.Point(130, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Status:*";
            // 
            // updateNameTxtBox
            // 
            this.updateNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNameTxtBox.Location = new System.Drawing.Point(200, 52);
            this.updateNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateNameTxtBox.Name = "updateNameTxtBox";
            this.updateNameTxtBox.Size = new System.Drawing.Size(236, 24);
            this.updateNameTxtBox.TabIndex = 63;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(89, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 18);
            this.label20.TabIndex = 62;
            this.label20.Text = "Event Name:*";
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
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addArenaNameTxtBox);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.addCapcityNumBox);
            this.addPanel.Controls.Add(this.addArenaIDComboBox);
            this.addPanel.Controls.Add(this.addStatusComboBox);
            this.addPanel.Controls.Add(this.addDatePicker);
            this.addPanel.Controls.Add(this.label18);
            this.addPanel.Controls.Add(this.label19);
            this.addPanel.Controls.Add(this.label21);
            this.addPanel.Controls.Add(this.label22);
            this.addPanel.Controls.Add(this.addNameTxtBox);
            this.addPanel.Controls.Add(this.label23);
            this.addPanel.Controls.Add(this.addCancel);
            this.addPanel.Controls.Add(this.addSave);
            this.addPanel.Enabled = false;
            this.addPanel.Location = new System.Drawing.Point(218, 20);
            this.addPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(574, 367);
            this.addPanel.TabIndex = 52;
            this.addPanel.Visible = false;
            // 
            // addArenaNameTxtBox
            // 
            this.addArenaNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArenaNameTxtBox.Location = new System.Drawing.Point(254, 86);
            this.addArenaNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.addArenaNameTxtBox.Name = "addArenaNameTxtBox";
            this.addArenaNameTxtBox.ReadOnly = true;
            this.addArenaNameTxtBox.Size = new System.Drawing.Size(182, 24);
            this.addArenaNameTxtBox.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(197, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 87;
            this.label3.Text = "* Required Fields";
            // 
            // addCapcityNumBox
            // 
            this.addCapcityNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCapcityNumBox.Location = new System.Drawing.Point(200, 202);
            this.addCapcityNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.addCapcityNumBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.addCapcityNumBox.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.addCapcityNumBox.Name = "addCapcityNumBox";
            this.addCapcityNumBox.Size = new System.Drawing.Size(96, 24);
            this.addCapcityNumBox.TabIndex = 78;
            this.addCapcityNumBox.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // addArenaIDComboBox
            // 
            this.addArenaIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArenaIDComboBox.FormattingEnabled = true;
            this.addArenaIDComboBox.Location = new System.Drawing.Point(200, 86);
            this.addArenaIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.addArenaIDComboBox.Name = "addArenaIDComboBox";
            this.addArenaIDComboBox.Size = new System.Drawing.Size(50, 25);
            this.addArenaIDComboBox.TabIndex = 76;
            this.addArenaIDComboBox.SelectedIndexChanged += new System.EventHandler(this.addArenaIDComboBox_SelectedIndexChanged);
            // 
            // addStatusComboBox
            // 
            this.addStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStatusComboBox.FormattingEnabled = true;
            this.addStatusComboBox.Items.AddRange(new object[] {
            "Confirmed",
            "Unconfirmed",
            "Cancelled"});
            this.addStatusComboBox.Location = new System.Drawing.Point(200, 146);
            this.addStatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.addStatusComboBox.Name = "addStatusComboBox";
            this.addStatusComboBox.Size = new System.Drawing.Size(117, 25);
            this.addStatusComboBox.TabIndex = 75;
            // 
            // addDatePicker
            // 
            this.addDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addDatePicker.Location = new System.Drawing.Point(200, 254);
            this.addDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.addDatePicker.Name = "addDatePicker";
            this.addDatePicker.Size = new System.Drawing.Size(132, 24);
            this.addDatePicker.TabIndex = 74;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(100, 254);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 18);
            this.label18.TabIndex = 72;
            this.label18.Text = "Event Date:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(130, 89);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 18);
            this.label19.TabIndex = 70;
            this.label19.Text = "Arena:*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(115, 202);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 18);
            this.label21.TabIndex = 66;
            this.label21.Text = "Capacity:*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(130, 146);
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
            this.label23.Location = new System.Drawing.Point(90, 32);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 18);
            this.label23.TabIndex = 62;
            this.label23.Text = "Event Name:*";
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
            this.previousBtn.Location = new System.Drawing.Point(64, 396);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(2);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(45, 32);
            this.previousBtn.TabIndex = 34;
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
            this.nextBtn.Location = new System.Drawing.Point(113, 398);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(45, 32);
            this.nextBtn.TabIndex = 33;
            this.nextBtn.Text = ">>";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.utilityTooltip.SetToolTip(this.nextBtn, "Next");
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // capacityTxtBox
            // 
            this.capacityTxtBox.Enabled = false;
            this.capacityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityTxtBox.Location = new System.Drawing.Point(415, 263);
            this.capacityTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.capacityTxtBox.Name = "capacityTxtBox";
            this.capacityTxtBox.ReadOnly = true;
            this.capacityTxtBox.Size = new System.Drawing.Size(97, 24);
            this.capacityTxtBox.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Capacity:";
            // 
            // statusTxtBox
            // 
            this.statusTxtBox.Enabled = false;
            this.statusTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxtBox.Location = new System.Drawing.Point(413, 204);
            this.statusTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusTxtBox.Name = "statusTxtBox";
            this.statusTxtBox.ReadOnly = true;
            this.statusTxtBox.Size = new System.Drawing.Size(117, 24);
            this.statusTxtBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Status:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Enabled = false;
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(414, 96);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(236, 24);
            this.nameTxtBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Event Name:";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtBox.Location = new System.Drawing.Point(414, 48);
            this.idTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(74, 24);
            this.idTxtBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Event ID:";
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
            this.returnBtn.Location = new System.Drawing.Point(673, 396);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(102, 32);
            this.returnBtn.TabIndex = 38;
            this.returnBtn.Text = "Return";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // deleteEventBtn
            // 
            this.deleteEventBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.deleteEventBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteEventBtn.BorderRadius = 15;
            this.deleteEventBtn.BorderSize = 0;
            this.deleteEventBtn.FlatAppearance.BorderSize = 0;
            this.deleteEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEventBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.deleteEventBtn.ForeColor = System.Drawing.Color.White;
            this.deleteEventBtn.Location = new System.Drawing.Point(505, 396);
            this.deleteEventBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteEventBtn.Name = "deleteEventBtn";
            this.deleteEventBtn.Size = new System.Drawing.Size(130, 32);
            this.deleteEventBtn.TabIndex = 37;
            this.deleteEventBtn.Text = "Delete Event";
            this.deleteEventBtn.TextColor = System.Drawing.Color.White;
            this.deleteEventBtn.UseVisualStyleBackColor = false;
            this.deleteEventBtn.Click += new System.EventHandler(this.deleteEventBtn_Click);
            // 
            // updateEventBtn
            // 
            this.updateEventBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.updateEventBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateEventBtn.BorderRadius = 15;
            this.updateEventBtn.BorderSize = 0;
            this.updateEventBtn.FlatAppearance.BorderSize = 0;
            this.updateEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEventBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.updateEventBtn.ForeColor = System.Drawing.Color.White;
            this.updateEventBtn.Location = new System.Drawing.Point(370, 396);
            this.updateEventBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateEventBtn.Name = "updateEventBtn";
            this.updateEventBtn.Size = new System.Drawing.Size(130, 32);
            this.updateEventBtn.TabIndex = 36;
            this.updateEventBtn.Text = "Update Event";
            this.updateEventBtn.TextColor = System.Drawing.Color.White;
            this.updateEventBtn.UseVisualStyleBackColor = false;
            this.updateEventBtn.Click += new System.EventHandler(this.updateEventBtn_Click);
            // 
            // addEventBtn
            // 
            this.addEventBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.addEventBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addEventBtn.BorderRadius = 15;
            this.addEventBtn.BorderSize = 0;
            this.addEventBtn.FlatAppearance.BorderSize = 0;
            this.addEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.addEventBtn.ForeColor = System.Drawing.Color.White;
            this.addEventBtn.Location = new System.Drawing.Point(236, 396);
            this.addEventBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(130, 32);
            this.addEventBtn.TabIndex = 35;
            this.addEventBtn.Text = "Add Event";
            this.addEventBtn.TextColor = System.Drawing.Color.White;
            this.addEventBtn.UseVisualStyleBackColor = false;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // arenaIDTxtBox
            // 
            this.arenaIDTxtBox.Enabled = false;
            this.arenaIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaIDTxtBox.Location = new System.Drawing.Point(414, 147);
            this.arenaIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.arenaIDTxtBox.Name = "arenaIDTxtBox";
            this.arenaIDTxtBox.ReadOnly = true;
            this.arenaIDTxtBox.Size = new System.Drawing.Size(74, 24);
            this.arenaIDTxtBox.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(344, 150);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 18);
            this.label17.TabIndex = 54;
            this.label17.Text = "Arena:";
            // 
            // arenaNameTxtBox
            // 
            this.arenaNameTxtBox.Enabled = false;
            this.arenaNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaNameTxtBox.Location = new System.Drawing.Point(490, 147);
            this.arenaNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.arenaNameTxtBox.Name = "arenaNameTxtBox";
            this.arenaNameTxtBox.ReadOnly = true;
            this.arenaNameTxtBox.Size = new System.Drawing.Size(159, 24);
            this.arenaNameTxtBox.TabIndex = 57;
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Enabled = false;
            this.dateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxtBox.Location = new System.Drawing.Point(413, 318);
            this.dateTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.ReadOnly = true;
            this.dateTxtBox.Size = new System.Drawing.Size(137, 24);
            this.dateTxtBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Event Date:";
            // 
            // dsNZESL1
            // 
            this.dsNZESL1.DataSetName = "dsNZESL";
            this.dsNZESL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nzeslDataSet1
            // 
            this.nzeslDataSet1.DataSetName = "NZESLDataSet";
            this.nzeslDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EventMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.dateTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arenaNameTxtBox);
            this.Controls.Add(this.arenaIDTxtBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.capacityTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.deleteEventBtn);
            this.Controls.Add(this.updateEventBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventMaintenance";
            this.Text = "Event Maintenance";
            this.Load += new System.EventHandler(this.EventMaintenance_Load);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCapcityNumBox)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCapcityNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZESL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nzeslDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventList;
        private RoundButton addCancel;
        private RoundButton addSave;
        private System.Windows.Forms.Panel updatePanel;
        private RoundButton updateCancel;
        private RoundButton updateSave;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.ToolTip utilityTooltip;
        private RoundButton previousBtn;
        private RoundButton nextBtn;
        private System.Windows.Forms.TextBox capacityTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label1;
        private RoundButton returnBtn;
        private RoundButton deleteEventBtn;
        private RoundButton updateEventBtn;
        private RoundButton addEventBtn;
        private System.Windows.Forms.TextBox arenaIDTxtBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox arenaNameTxtBox;
        private System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox addNameTxtBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker addDatePicker;
        private System.Windows.Forms.ComboBox addArenaIDComboBox;
        private System.Windows.Forms.ComboBox addStatusComboBox;
        private System.Windows.Forms.ComboBox updateStatusComboBox;
        private System.Windows.Forms.DateTimePicker updateDatePicker;
        private System.Windows.Forms.NumericUpDown updateCapcityNumBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateArenaNameTxtBox;
        private System.Windows.Forms.TextBox updateArenaIDTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox updateNameTxtBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown addCapcityNumBox;
        private dsNZESL dsNZESL1;
        private NZESLDataSet nzeslDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addArenaNameTxtBox;
        private System.Windows.Forms.Label label8;
    }
}