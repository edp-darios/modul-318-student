namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;

    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id, DateTime date, int limit);

        Connections GetConnections(string fromStation, string toStation, DateTime time, DateTime date, int limit);
    }
}