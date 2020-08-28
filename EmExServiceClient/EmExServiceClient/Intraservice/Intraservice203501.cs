using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient.Tasks
{
    class Intraservice203501 : IExecutable
    {
        public void Execute()
        {
            DocumentPortalClient client = new DocumentPortalClient();
            var result = client.GetLocalStorageDocuments_v2(new AuthentificationData(), 1713);
            EmExFile.SaveAndOpen(result);
        }
    }
}
