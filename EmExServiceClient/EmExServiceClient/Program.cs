using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentPortalClient client = new DocumentPortalClient();
            var result = client.CreateActContrafact(new AuthentificationData(), 8537, true, DocumentOptions.ReturnPDF, 1, null, 1);
            EmExFile.SaveAndOpen(result);
        }
    }
}
