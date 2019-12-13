﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using EmExServiceClient.DocumentService;

namespace EmExServiceClient
{
    public static class EmExFile
    {
        private static string _reportFolder;

        static EmExFile()
        {
            _reportFolder = ConfigurationManager.AppSettings.Get("reportFolder");
        }

        public static void Save(OperationResultWithFiles result)
        {
            var reportBytes = result.Files[0].Content[0];
            var filename = result.Files[0].Name;
            Directory.CreateDirectory(_reportFolder);
            File.WriteAllBytes(Path.Combine(_reportFolder, filename),reportBytes);
        }

        public static void SaveAndOpen(OperationResultWithFiles result)
        {
            Save(result);
            Open(result);
        }

        private static void Open(OperationResultWithFiles result)
        {
            System.Diagnostics.Process.Start(Path.Combine(_reportFolder, result.Files[0].Name));
        }
    }
}