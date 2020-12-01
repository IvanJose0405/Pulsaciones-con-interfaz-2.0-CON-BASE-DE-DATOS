using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pulsaciones
{
    public static class ConfigConnection
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}
