using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLibraryModified
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public async Task ProcessData()
        {
            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            await _dataAccess.LoadData();
           await _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
