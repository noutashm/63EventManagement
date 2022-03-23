
namespace EventManagement {
    partial class EnterCompetitorIntoChallenge {
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
            this.compDataGrid = new System.Windows.Forms.DataGridView();
            this.chalDataGrid = new System.Windows.Forms.DataGridView();
            this.entryDataGrid = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.eventStatusTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.removeEntryBtn = new EventManagement.RoundButton();
            this.addEntryBtn = new EventManagement.RoundButton();
            this.returnBtn = new EventManagement.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.compDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chalDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // compDataGrid
            // 
            this.compDataGrid.AllowUserToAddRows = false;
            this.compDataGrid.AllowUserToDeleteRows = false;
            this.compDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compDataGrid.Location = new System.Drawing.Point(9, 10);
            this.compDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.compDataGrid.Name = "compDataGrid";
            this.compDataGrid.ReadOnly = true;
            this.compDataGrid.RowHeadersWidth = 51;
            this.compDataGrid.RowTemplate.Height = 24;
            this.compDataGrid.Size = new System.Drawing.Size(534, 212);
            this.compDataGrid.TabIndex = 0;
            // 
            // chalDataGrid
            // 
            this.chalDataGrid.AllowUserToAddRows = false;
            this.chalDataGrid.AllowUserToDeleteRows = false;
            this.chalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chalDataGrid.Location = new System.Drawing.Point(9, 234);
            this.chalDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.chalDataGrid.Name = "chalDataGrid";
            this.chalDataGrid.ReadOnly = true;
            this.chalDataGrid.RowHeadersWidth = 51;
            this.chalDataGrid.RowTemplate.Height = 24;
            this.chalDataGrid.Size = new System.Drawing.Size(534, 206);
            this.chalDataGrid.TabIndex = 8;
            this.chalDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chalDataGrid_CellContentClick);
            // 
            // entryDataGrid
            // 
            this.entryDataGrid.AllowUserToAddRows = false;
            this.entryDataGrid.AllowUserToDeleteRows = false;
            this.entryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryDataGrid.Location = new System.Drawing.Point(574, 234);
            this.entryDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.entryDataGrid.Name = "entryDataGrid";
            this.entryDataGrid.ReadOnly = true;
            this.entryDataGrid.RowHeadersWidth = 51;
            this.entryDataGrid.RowTemplate.Height = 24;
            this.entryDataGrid.Size = new System.Drawing.Size(313, 206);
            this.entryDataGrid.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(571, 82);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 18);
            this.label20.TabIndex = 80;
            this.label20.Text = "Event Status:";
            // 
            // eventStatusTxtBox
            // 
            this.eventStatusTxtBox.Enabled = false;
            this.eventStatusTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventStatusTxtBox.Location = new System.Drawing.Point(681, 80);
            this.eventStatusTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventStatusTxtBox.Name = "eventStatusTxtBox";
            this.eventStatusTxtBox.ReadOnly = true;
            this.eventStatusTxtBox.Size = new System.Drawing.Size(117, 24);
            this.eventStatusTxtBox.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(574, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 18);
            this.label11.TabIndex = 82;
            this.label11.Text = "Entry Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Confirmed",
            "Pending",
            "Disqualified"});
            this.statusComboBox.Location = new System.Drawing.Point(681, 121);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(117, 25);
            this.statusComboBox.TabIndex = 83;
            // 
            // removeEntryBtn
            // 
            this.removeEntryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.removeEntryBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeEntryBtn.BorderRadius = 15;
            this.removeEntryBtn.BorderSize = 0;
            this.removeEntryBtn.FlatAppearance.BorderSize = 0;
            this.removeEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEntryBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.removeEntryBtn.ForeColor = System.Drawing.Color.White;
            this.removeEntryBtn.Location = new System.Drawing.Point(152, 461);
            this.removeEntryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeEntryBtn.Name = "removeEntryBtn";
            this.removeEntryBtn.Size = new System.Drawing.Size(130, 32);
            this.removeEntryBtn.TabIndex = 10;
            this.removeEntryBtn.Text = "Remove Entry";
            this.removeEntryBtn.TextColor = System.Drawing.Color.White;
            this.removeEntryBtn.UseVisualStyleBackColor = false;
            this.removeEntryBtn.Click += new System.EventHandler(this.removeEntryBtn_Click);
            // 
            // addEntryBtn
            // 
            this.addEntryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.addEntryBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addEntryBtn.BorderRadius = 15;
            this.addEntryBtn.BorderSize = 0;
            this.addEntryBtn.FlatAppearance.BorderSize = 0;
            this.addEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEntryBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.addEntryBtn.ForeColor = System.Drawing.Color.White;
            this.addEntryBtn.Location = new System.Drawing.Point(9, 461);
            this.addEntryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addEntryBtn.Name = "addEntryBtn";
            this.addEntryBtn.Size = new System.Drawing.Size(130, 32);
            this.addEntryBtn.TabIndex = 9;
            this.addEntryBtn.Text = "Add Entry";
            this.addEntryBtn.TextColor = System.Drawing.Color.White;
            this.addEntryBtn.UseVisualStyleBackColor = false;
            this.addEntryBtn.Click += new System.EventHandler(this.addEntryBtn_Click);
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
            this.returnBtn.Location = new System.Drawing.Point(784, 461);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(102, 32);
            this.returnBtn.TabIndex = 7;
            this.returnBtn.Text = "Return";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // EnterCompetitorIntoChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(896, 509);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.eventStatusTxtBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.entryDataGrid);
            this.Controls.Add(this.removeEntryBtn);
            this.Controls.Add(this.addEntryBtn);
            this.Controls.Add(this.chalDataGrid);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.compDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnterCompetitorIntoChallenge";
            this.Text = "Enter Competitor Into Challenge";
            this.Load += new System.EventHandler(this.EnterCompetitorIntoChallenge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chalDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView compDataGrid;
        private RoundButton returnBtn;
        private System.Windows.Forms.DataGridView chalDataGrid;
        private RoundButton removeEntryBtn;
        private RoundButton addEntryBtn;
        private System.Windows.Forms.DataGridView entryDataGrid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox eventStatusTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}