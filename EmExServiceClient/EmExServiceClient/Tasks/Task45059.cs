using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.ContragentService;
using EmExServiceClient.DocumentService;
using DocumentOptions = EmExServiceClient.DocumentService.DocumentOptions;

namespace EmExServiceClient.Tasks
{
    class Task45059 : IExecutable
    {
        public void Execute()
        {
            EmexContragentServiceClient client = new EmexContragentServiceClient();
            var result = client.CreateBuhSverkaReport(new AuthentificationData(), 16201, new DateTime(2019,11,1), new DateTime(2019,12,1),"62.","0001", DocumentOptions.ReturnExcel,1);
            EmExFile.SaveAndOpen(result);
        }
    }
}
