using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsole
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> _servers = new List<string>();
        private int nextServerIndex = 0;

        private TableServers()
        {
            _servers.Add("Tim");
            _servers.Add("Sue");
            _servers.Add("Mary");
            _servers.Add("Bob");
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string nextServer = _servers[nextServerIndex];
            nextServerIndex++;
            if(nextServerIndex >= _servers.Count)
            {
                nextServerIndex = 0;
            }
            return nextServer;
        }
    }
}
