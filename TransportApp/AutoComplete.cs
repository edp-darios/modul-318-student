using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace TransportApp
{
    class AutoComplete
    {

        ITransport transport = new Transport();

        public void Station(ComboBox combobox)
        {
            if (combobox.Text != "" && combobox.Text.Length >= 3)
            {
                try
                {
                    string eingabe = combobox.Text;
                    combobox.Items.Clear();
                    combobox.SelectionStart = combobox.Text.Length + 1;
                    List<string> stations = StationSuggestion(eingabe);

                    foreach (String station in stations)
                    {
                        if (station != null)
                        {
                            combobox.Items.Add(station);
                        }
                    }

                    combobox.DroppedDown = true;
                    combobox.Text = eingabe;
                    combobox.SelectionStart = combobox.Text.Length + 1;

                }
                catch
                {
                    combobox.Items.Clear();
                    combobox.SelectionStart = combobox.Text.Length + 1;
                    combobox.Items.Add("Kein Resultat");
                }
            } 
        }
        
        public List<string> StationSuggestion(string query)
        {
            List<string> stationList = new List<string>();
            var stations = transport.GetStations(query);
            foreach (Station station in stations.StationList)
            {
                if (!string.IsNullOrEmpty(station.Name) && !string.IsNullOrEmpty(station.Id)) 
                { 
                    stationList.Add(station.Name);
                }
            }
            if (stationList.Count == 0)
            {
                stationList.Add("Kein Resultat");
            }
            return stationList;
        }


    }
}
