﻿using EmExServiceClient.Intraservice;
using EmExServiceClient.Tasks;

namespace EmExServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutable task = new Intraservice201221(); 
            task.Execute();
        }
}
}
