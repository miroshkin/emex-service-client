using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient.Tasks
{
    class Intraservice196463 : IExecutable
    {
        public void Execute()
        {
            DocumentPortalClient client = new DocumentPortalClient();
            var result = client.CreateTorg12ReturnSupplier(new AuthentificationData(), 832449, DocumentOptions.ReturnPDF, 1);
            EmExFile.SaveAndOpen(result);
        }
    }
}
