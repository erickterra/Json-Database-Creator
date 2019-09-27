using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

    public class Globals
    {
        public static string filePath
    {
        get
        {
            return ConfigurationManager.AppSettings["FILEPATH"];
        }
    }

        public static string fileName
    {
        get
        {
            return ConfigurationManager.AppSettings["FILENAME"];
        }
    }
    
    }

