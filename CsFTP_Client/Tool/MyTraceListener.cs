using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsFTP_Client.Tool
{
    class MyTraceListener : System.Diagnostics.TraceListener
    {
        public override void Write(string message)
        {
            var filename ="Global/"+ DateTime.Now.ToString("yyyyMMdd")+".log";
            File.AppendAllText(filename, message);
        }

        public override void WriteLine(string message)
        {
            var filename = "Global/" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            File.AppendAllText(filename, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss    ") + message + Environment.NewLine);
        }
    }
}
