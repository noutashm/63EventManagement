using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement {
    public partial class CompetitorReport : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cmChal;
        DataRow[] entryRecords;

        private int printedComp, expectedCompetitors;

        public CompetitorReport(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            cmChal = (CurrencyManager)BindingContext[dm.dsNZESL, "Challenge"];
        }

        // handle dark mode on form load
        private void CompetitorReport_Load(object sender, EventArgs e)
        {
            if (mm.darkModeBool)
                enableDarkMode();
            else
                disableDarkMode();
        }
        
        // dark mode helper functions
        private void enableDarkMode()
        {
            BackColor = mm.darkModeBackColor;
            ForeColor = mm.darkModeForeColor;
            foreach (RoundButton button in Controls.OfType<RoundButton>())
            {
                button.BackColor = mm.darkModeBtnBackColor;
                button.ForeColor = Color.White;
                button.BorderColor = mm.darkModeBtnBackColor;
            }
        }

        private void disableDarkMode()
        {
            BackColor = mm.defaultBackColor;
            ForeColor = mm.defaultForeColor;
            foreach (RoundButton button in Controls.OfType<RoundButton>())
            {
                button.BackColor = mm.defaultBackColor;
                button.ForeColor = Color.RoyalBlue;
                button.BorderColor = Color.RoyalBlue;
            }
        }

        // close form
        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        // recommended for prDialog.Scale to make the class nono inheritabled
        [Obsolete]
        private void printBtn_Click(object sender, EventArgs e)
        {
            // get the total expected competitors by putting dstinct competitorids in entry table into a temp table
            DataTable temp = dm.dtEntry.DefaultView.ToTable(true, "CompetitorID");
            // and recording that number
            expectedCompetitors = temp.Rows.Count;

            // scale and show report
            prDialog.Scale(3);
            prDialog.Show();
        }

        // at the start of printing event handler
        private void prDoc_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printedComp = 0;
        }

        // printing event handler
        private void prDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // initiale necessary components
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);

            Brush brush = new SolidBrush(Color.Black);

            // margins
            float pageHeight = e.MarginBounds.Height;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int lineHeight = textFont.Height;

            // loop through all the competitors data tables
            foreach(DataRow compRecord in dm.dtComp.Rows)
            {
                // get relational data
                entryRecords = compRecord.GetChildRows(dm.dtComp.ChildRelations["COMPETITOR_ENTRY"]);

                if (entryRecords.Length > 0)
                {
                    // draw only if competitor has entry
                    g.DrawString("Competitor ID: " + compRecord["CompetitorID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar += 2;
                    g.DrawString("Username: " + compRecord["UserName"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar++;
                    g.DrawString("Name: " + compRecord["FirstName"] + " " + compRecord["LastName"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar++;
                    g.DrawString("Gender: " + compRecord["Gender"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar++;
                    g.DrawString("Date of Birth: " + compRecord["DateOfBirth"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar++;
                    g.DrawString("Email: " + compRecord["EmailAddress"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar += 2;

                    g.DrawString("Challenge ID:" + "\t\t" + "Challenge Name:" + "\t\t" + "Start Time:", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                    linesSoFar += 2;

                    // loop through entry records
                    foreach (DataRow entryRecord in entryRecords)
                    {
                        // Get the challege records for the entry with entry challenge id
                        int chalID = Convert.ToInt32(entryRecord["ChallengeID"]);
                        cmChal.Position = dm.dvChal.Find(chalID);
                        DataRow chalRecord = dm.dtChal.Rows[cmChal.Position];

                        // if no record, add a note, that there are no records
                        if (chalRecord == null)
                        {
                            g.DrawString("This Competitor has no challenges", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                        } else
                        {
                            // record startTime in a var to only show 'TimeOfDay'
                            var startTime = (DateTime)chalRecord["StartTime"];

                            g.DrawString(chalRecord["ChallengeID"] + "\t\t" + chalRecord["ChallengeName"] + "\t\t" + startTime.TimeOfDay, textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * lineHeight));
                            linesSoFar++;
                        }
                    }
                    linesSoFar += 3;
                    printedComp++;
                    //e.HasMorePages = (printedComp != expectedCompetitors);
                }
            }
        }
    }
}
