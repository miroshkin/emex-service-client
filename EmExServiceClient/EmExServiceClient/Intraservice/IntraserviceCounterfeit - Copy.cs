using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient;
using EmExServiceClient.ContrafactService;
using EmExServiceClient.ContragentService;
using EmExServiceClient.DocumentService;

namespace Services
{
    class ContragentService : IExecutable
    {
        public void Execute()
        {
            EmexContragentServiceClient client = new EmexContragentServiceClient();
            client.SendSecurityDepositTo1C();

        }
    }
}
