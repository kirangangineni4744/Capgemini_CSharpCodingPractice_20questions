using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static readonly object lockObject = new object();

        private ConfigurationManager() { } // Private constructor

        public static ConfigurationManager GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject) // Ensures thread safety
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
            }
            return instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("Singleton Instance: Configuration Loaded");
        }
    }
}
