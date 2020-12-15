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
    public partial class Form1 : Form
    {
        ITransport transport = new Transport();

        public Form1()
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
                    dataGridView.Rows.Add(new[] { connection.From.Departure.Value.ToString(), connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, connection.Duration.ToString(), connection.To.Arrival.Value.ToString() });
                }
            }
            else
            {
                dataGridView.Rows.Clear();

                var StationBoards = transport.GetStationBoard(cboFromLocation.Text,"0");

                foreach (StationBoard stationBoard in StationBoards.Entries)
                {
                    dataGridView.Rows.Add(new[] { stationBoard.Name.ToString() });
                }
            }

        }
    


    }
}
