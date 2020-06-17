using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

                for (int i = 0; i < 5; i++)
                {
                    string message = $"TEST {(i + 1) * 111} HILOAD";
                    
                    foreach (var binding in bindings)
                    {
                        client.SendData("COMP265","2824", binding.Code,message);
                        Thread.Sleep(1000);

                    }
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
