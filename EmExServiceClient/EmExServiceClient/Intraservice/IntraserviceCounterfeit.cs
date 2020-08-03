using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.ContrafactService;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient.Intraservice
{
    class IntraserviceCounterfeit : IExecutable
    {
        public void Execute()
        {
            ContrafactServiceClient client = new ContrafactServiceClient();
            client.ProcessDocsExpects();
            //DocumentPortalClient client = new DocumentPortalClient();
            //var result = client.CreateCustomerReturnsAct(new AuthentificationData(), 1, DocumentOptions.ReturnPDF, 1);
            //EmExFile.SaveAndOpen(result);

        }
    }
}
