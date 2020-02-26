using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;
using EmExServiceClient.Tasks;

namespace EmExServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutable task = new Intraservice174908(); 
            task.Execute();
        }
}
}
