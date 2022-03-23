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
    public partial class EventReport : Form {
        private DataModule dm;
        private MainMenu mm;
        private CurrencyManager cmChal;

        private int printedEvent, totalEvents;

        public EventReport(DataModule DM, MainMenu MM) {
            InitializeComponent();
            dm = DM;
            mm = MM;
            cmChal = (CurrencyManager)BindingContext[dm.dsNZESL, "Challenge"];
        }

        // handle dark mode
        private void EventReport_Load(object sender, EventArgs e)
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

        private void returnBtn_Click(object sender, EventArgs e) {
            Close();
        }

        [Obsolete]
        private void printBtn_Click(object sender, EventArgs e)
        {
            // scale the report a little bit upwards
            prDialog.Scale(3);
            prDialog.Show();
        }

        private void prDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Initialize elements needed
            Graphics g = e.Graphics; int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);

            Brush brush = new SolidBrush(Color.Black);

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            totalEvents = dm.dtEvent.Rows.Count;

            // loop through all events
            foreach (DataRow eventRecord in dm.dtEvent.Rows)
            {
                // get arena for event
                DataRow[] arenaRecord = dm.dtArena.Select("ArenaID = " + eventRecord["ArenaID"]);

                // get eventReord dateTime to be able to display only time or date
                var eventDate = (DateTime)eventRecord["EventDate"];

                // draw based on position, brush and line breaks
                g.DrawString("Event ID: " + eventRecord["EventID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading += 2;
                g.DrawString(eventRecord["EventName"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString(arenaRecord[0]["ArenaName"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                g.DrawString(arenaRecord[0]["StreetAddress"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading += 2;
                g.DrawString("Event Date: " + eventDate.ToShortDateString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;

                // challenge heading
                g.DrawString("Challenge ID:" + "\t\t" + "Challenge Name:" + "\t\t" + "Start Time:", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading += 2;

                // get challenge records related to event
                DataRow[] chalRecords = eventRecord.GetChildRows(dm.dtEvent.ChildRelations["EVENT_CHALLENGE"]);

                // Checking whether the event has challenges or not
                if (chalRecords.Length > 0)
                {
                    foreach (DataRow chalRecorda in chalRecords)
                    {
                        int challengeID = Convert.ToInt32(chalRecorda["ChallengeID"].ToString());
                        cmChal.Position = dm.dvChal.Find(challengeID);
                        DataRow drchallenge = dm.dtChal.Rows[cmChal.Position];

                        var startTime = (DateTime)chalRecorda["StartTime"];

                        g.DrawString(chalRecorda["ChallengeID"] + "\t\t" + chalRecorda["ChallengeName"] + "\t\t" + startTime.TimeOfDay, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        linesSoFarHeading++;
                    }
                } else {
                    g.DrawString("This event has no challenges scheudled", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                }
                linesSoFarHeading += 2;
                printedEvent++;
                e.HasMorePages = (printedEvent < totalEvents);
            }
        }
    }
}
