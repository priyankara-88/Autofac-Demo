using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Utilities
{
    class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data...");
        }

        public void SaveData()
        {
            Console.WriteLine("Save Data");
        }
    }
}
