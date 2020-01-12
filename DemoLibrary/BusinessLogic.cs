using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        IDataAccess _dataAccess;
        ILogger _logger;
        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _dataAccess = dataAccess;
            _logger = logger;
        }
        public void ProcessData()
        {
            _logger.Log("Started Process");

            _dataAccess.LoadData();
            _dataAccess.SaveData();

            _logger.Log("Finished Process");
        }
    }
}
