using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        IDataAccess _dataAccess;
        ILogger _logger;
        public BetterBusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _dataAccess = dataAccess;
            _logger = logger;
        }
        public void ProcessData()
        {
            _logger.Log("Started Process Better");

            _dataAccess.LoadData();
            _dataAccess.SaveData();

            _logger.Log("Finished Process Better");
        }
    }
}
