using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class frmMain : Form
    {
        ITransport transport = new Transport();
        AutoComplete autoComplete = new AutoComplete();

        public frmMain()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try { 
                if (rdbConnections.Checked) 
                {
                    dataGridView.Rows.Clear();
                    var connections = transport.GetConnections(cboFromLocation.Text, cboToLocation.Text, dtpTime.Value, dtpDate.Value, 16);

                    foreach (Connection connection in connections.ConnectionList)
                    {
                        dataGridView.Rows.Add(new[] { 
                        connection.From.Departure.Value.ToString(), 
                        connection.From.Station.Name, 
                        connection.To.Station.Name, 
                        connection.From.Platform,
                        connection.Duration.ToString(),
                        connection.To.Arrival.Value.ToString()            
                        });
                    }
                }

                else 
                {
                    dataGridView.Rows.Clear();
                    var StationBoards = transport.GetStationBoard(cboFromLocation.Text,"0",dtpDate.Value,16);

                    foreach (StationBoard stationBoard in StationBoards.Entries)
                    {
                        dataGridView.Rows.Add(new[] { 
                        stationBoard.Stop.Departure.ToString(), 
                        StationBoards.Station.Name.ToString(), 
                        stationBoard.To 
                        });
                    }
                }
            }
            catch
            {
                MessageBox.Show("Die Eingegebene Station ist nicht verfügbar!");
            }
        }

        private void RadioButtonsShow(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if (rdbConnections.Checked)
            {
                EnableDisableItems(true);
            } else
            {
                EnableDisableItems(false);
                dtpTime.Value = DateTime.Now;
                dtpDate.Value = DateTime.Now;
                cboToLocation.Text = "";
            }
        }

        private void EnableDisableItems(bool setEnable)
        {
            lblTo.Enabled = setEnable;
            cboToLocation.Enabled = setEnable;
            btnMapTo.Enabled = setEnable;
            dtpDate.Enabled = setEnable;
            dtpTime.Enabled = setEnable;
            lblTime.Enabled = setEnable;
            dataGridView.Columns[3].Visible = setEnable;
            dataGridView.Columns[4].Visible = setEnable;
            dataGridView.Columns[5].Visible = setEnable;
        }

        private void cboKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Right && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Enter)
            {
                autoComplete.Station((ComboBox)sender);
            }
        }

        private void notInplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress");
        }
    }
}
