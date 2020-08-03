using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient.Tasks
{
    class Intraservice174908 : IExecutable
    {
        public void Execute()
        {
            DocumentPortalClient client = new DocumentPortalClient();

            //List<int> contrafactGroupIds = new List<int>()
            //{
            //    5235, 5236, 5237, 5238, 5239, 5240, 5537, 5572, 5808, 6121, 6188, 6335, 6404, 6567, 6575, 6578, 6580,
            //    6581, 6583, 6585, 6586, 6593, 6600, 6601, 7442, 7636, 7738, 7743, 7756, 7854, 8086, 6589, 6591, 6594,
            //    6595, 6596, 6597, 6598, 6588, 6584, 6582, 6574, 5740, 5221, 5222, 5223, 5224, 5226, 5227, 5228, 5540,
            //    7366, 7367, 7368, 7369, 7370, 7371, 7372, 7373, 7374, 7375, 7376, 7377, 7378, 7381, 7382, 7383, 7384,
            //    7386, 7387, 7388, 7389, 7390, 7391, 7392, 7393, 7395, 7396, 7397, 7400, 7401, 5544, 5744, 5745, 6024,
            //    5859, 5864, 6725, 6748, 6768, 7245, 6605, 6606, 6607, 6611, 5899, 5937, 5971, 6089, 5811, 6205, 6211,
            //    6212, 6265, 6303, 6314, 5693, 7437, 6546
            //};

            //errors
            //List<int> contrafactGroupIds = new List<int>()
            //{
            //    7636
            //    ,7738
            //    ,7854
            //    ,8086
            //    ,6591
            //    ,6595
            //    ,6597
            //    ,6598
            //    ,6588
            //    ,5224
            //    ,5228
            //    ,5540
            //    ,7366
            //    ,7367
            //    ,7368
            //    ,7369
            //    ,7370
            //    ,7371
            //    ,7372
            //    ,7373
            //    ,7374
            //    ,7375
            //    ,7376
            //    ,7377
            //    ,7391
            //    ,7392
            //    ,7400
            //    ,7401
            //    ,5544
            //    ,5744
            //    ,6725
            //    ,7437
            //};

            //errors2
            List<int> contrafactGroupIds = new List<int>()
            {
                7636, 7738, 7854, 8086, 6591, 6595, 6597, 6598, 6588, 5224, 6725, 7437
            };





            List<int> errors = new List<int>();

            foreach (var contrafactGroupId in contrafactGroupIds)
            {
                try
                {
                    var resultDoc = client.CreateActContrafact(new AuthentificationData(), contrafactGroupId, true, DocumentOptions.ReturnDoc, 1, null, 1);
                    resultDoc.Files[0].Name = $"{contrafactGroupId}_{resultDoc.Files[0].Name}";
                    EmExFile.Save(resultDoc);


                    var resultPdf = client.CreateActContrafact(new AuthentificationData(), contrafactGroupId, true, DocumentOptions.ReturnPDF, 1, null, 1);
                    resultPdf.Files[0].Name = $"{contrafactGroupId}_{resultPdf.Files[0].Name}";
                    EmExFile.Save(resultPdf);
                }
                catch (Exception e)
                {
                    errors.Add(contrafactGroupId);

                }

                
            }

            errors.ForEach(e => Console.WriteLine(e));

            

        }
    }
}
