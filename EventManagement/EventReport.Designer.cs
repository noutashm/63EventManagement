
namespace EventManagement {
    partial class EventReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventReport));
            this.returnBtn = new EventManagement.RoundButton();
            this.printBtn = new EventManagement.RoundButton();
            this.prDoc = new System.Drawing.Printing.PrintDocument();
            this.prDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.returnBtn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.BorderRadius = 25;
            this.returnBtn.BorderSize = 3;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.Location = new System.Drawing.Point(258, 60);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(159, 55);
            this.returnBtn.TabIndex = 11;
            this.returnBtn.Text = "Return";
            this.returnBtn.TextColor = System.Drawing.Color.RoyalBlue;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.printBtn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.printBtn.BorderRadius = 25;
            this.printBtn.BorderSize = 3;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.printBtn.Location = new System.Drawing.Point(25, 60);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(210, 55);
            this.printBtn.TabIndex = 10;
            this.printBtn.Text = "Print Events";
            this.printBtn.TextColor = System.Drawing.Color.RoyalBlue;
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // prDoc
            // 
            this.prDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prDoc_PrintPage);
            // 
            // prDialog
            // 
            this.prDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.prDialog.Document = this.prDoc;
            this.prDialog.Enabled = true;
            this.prDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("prDialog.Icon")));
            this.prDialog.Name = "printPreviewDialog";
            this.prDialog.Visible = false;
            // 
            // EventReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(450, 177);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.printBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventReport";
            this.Text = "Event Report";
            this.Load += new System.EventHandler(this.EventReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton returnBtn;
        private RoundButton printBtn;
        private System.Drawing.Printing.PrintDocument prDoc;
        private System.Windows.Forms.PrintPreviewDialog prDialog;
    }
}