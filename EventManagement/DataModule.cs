using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EventManagement {
    public partial class DataModule : Form {

        // Initialize DataTables
        public DataTable dtArena;
        public DataTable dtChal;
        public DataTable dtComp;
        public DataTable dtEntry;
        public DataTable dtEvent;

        // Initialize DataView
        public DataView dvArena;
        public DataView dvChal;
        public DataView dvComp;
        public DataView dvEntry;
        public DataView dvEvent;

        public DataModule() {
            InitializeComponent();

            // disable constrats rules when updating
            dsNZESL.EnforceConstraints = false;

            // try and catch to connect to db
            try {
                daArena.Fill(dsNZESL);
                daChallenge.Fill(dsNZESL);
                daCompetitor.Fill(dsNZESL);
                daEntry.Fill(dsNZESL);
                daEvent.Fill(dsNZESL);

                // if any db connection issue ~ most likely db is open so show the error and close the application
            } catch (OleDbException e) {
                MessageBox.Show(e.Message);
                Application.Exit();
                // handling other exceptions
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            
            // defining datatables
            dtArena = dsNZESL.Tables["Arena"];
            dtChal = dsNZESL.Tables["Challenge"];
            dtComp = dsNZESL.Tables["Competitor"];
            dtEntry = dsNZESL.Tables["Entry"];
            dtEvent = dsNZESL.Tables["Event"];

            // defining dataviews
            dvArena = new DataView(dtArena);
            dvArena.Sort = "ArenaID";
            dvEvent = new DataView(dtEvent);
            dvEvent.Sort = "EventID";
            dvChal = new DataView(dtChal);
            dvChal.Sort = "ChallengeID";
            dvComp = new DataView(dtComp);
            dvComp.Sort = "CompetitorID";
            dvEntry = new DataView(dtEntry);
            dvEntry.Sort = "ChallengeID";

            // put the update constraint back to true
            dsNZESL.EnforceConstraints = true;
        }

        // helper function for adding/updating/deleting db records all with try/catch for second layer of protection
        public void UpdateArena() {
            try
            {
                daArena.Update(dtArena);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateChallenge()
        {
            try
            {
                daChallenge.Update(dtChal);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateCompetitor()
        {
            try
            {
                daCompetitor.Update(dtComp);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateEntry()
        {
            try
            {
                daEntry.Update(dtEntry);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateEvent() {
            try
            {
                daEvent.Update(dtEvent);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
