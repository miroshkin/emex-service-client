using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.SecurityCameraService;

namespace EmExServiceClient.Tasks
{
    class SecurityCamera : IExecutable
    {
        public void Execute()
        {
            try
            {
                SecurityCameraServiceClient client = new SecurityCameraServiceClient();
                client.Open();
                var list = new List<int>() { 
                    98
                    ,101
                    ,102
                    ,103
                    ,104
                    ,105
                    ,124
                    ,125};

                var bindings = client.GetBindings().Where(b => list.Contains(b.BindingId));

                foreach (var binding in bindings)
                {
                    client.SendData("COMP265","2824", binding.Code,"Test");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
