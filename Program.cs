using System.Net;

namespace ConsoleApp10
{
    class ConnectionPoint
    {
        public IPAddress IP { get; set; }
        public int Port { get; set; }
        public string NetworkType { get; set; }

        public ConnectionPoint(IPAddress ip, int port, string networkType)
        {
            IP = ip;
            Port = port;
            NetworkType = networkType;
        }

        public override string ToString()
        {
            return $"IP: {IP}, Port: {Port}, Network Type: {NetworkType}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddress = IPAddress.Parse("192.168.100.3");
            int port = 80;
            string networkType = "TCP";

            ConnectionPoint connectionPoint = new ConnectionPoint(ipAddress, port, networkType);
            Console.WriteLine(connectionPoint);
        }
    }
}
