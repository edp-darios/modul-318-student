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

        public frmMain()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(rdbConnections.Checked) 
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

        private void RadioButtonsShow(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if(rdbConnections.Checked)
            {
                EnableDisableItems(true);
            } else
            {
                EnableDisableItems(false);
                dtpTime.Value = DateTime.Now;
                dtpDate.Value = DateTime.Now;
            }
        }
        private void EnableDisableItems(bool item)
        {
            lblTo.Enabled = item;
            cboToLocation.Enabled = item;
            btnMapTo.Enabled = item;
            dtpDate.Enabled = item;
            dtpTime.Enabled = item;
            lblTime.Enabled = item;
            grpTime.Enabled = item;
            dataGridView.Columns[3].Visible = item;
            dataGridView.Columns[4].Visible = item;
            dataGridView.Columns[5].Visible = item;
        }



        private void notInplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress");
        }

    }
}
