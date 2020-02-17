using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger _logger;
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }

        public async Task LoadData()
        {
            Console.WriteLine("Loading Data");
            Thread.Sleep(5000);
            _logger.Log("Data loaded");
        }

        public async Task SaveData(string name)
        {
            Console.WriteLine($"Saving { name }");
            Thread.Sleep(5000);
            _logger.Log(" data saved");
        }
    }
}
