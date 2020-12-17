namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;

    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);
        //Adding Date/Limit
        StationBoardRoot GetStationBoard(string station, string id, DateTime date, int limit);
        //Adding Date/Time/Limit
        Connections GetConnections(string fromStation, string toStation, DateTime time, DateTime date, int limit);
    }
}