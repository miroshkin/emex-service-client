using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.ContragentService;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient.Tasks
{
    class Intraservice201221 : IExecutable
    {
        public void Execute()
        {
            var client = new EmexContragentServiceClient();
            client.LocalStorageSetMonthlyBill_v2();
        }
    }
}
