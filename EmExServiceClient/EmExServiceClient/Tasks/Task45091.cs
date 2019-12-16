using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient.Tasks
{
    class Task45091 : IExecutable
    {
        public void Execute()
        {
            DocumentPortalClient client = new DocumentPortalClient();
            var result = client.CreateBuhSverkaReport(new AuthentificationData(), 16201, new DateTime(2019,11,1), new DateTime(2019,12,1),"62.","0001", DocumentOptions.ReturnExcel,1);
            EmExFile.SaveAndOpen(result);
        }
    }
}
