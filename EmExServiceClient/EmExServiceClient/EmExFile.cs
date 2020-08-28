using EmExServiceClient.DocumentService;
using System.Configuration;
using System.IO;

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
            foreach (var fileDescription in result.Files)
            {
                var reportBytes = fileDescription.Content[0];
                var filename = fileDescription.Name;
                Directory.CreateDirectory(_reportFolder);
                File.WriteAllBytes(Path.Combine(_reportFolder, filename),reportBytes);
            }
        }

        public static void SaveAndOpen(OperationResultWithFiles result)
        {
            Save(result);
            Open(result);
        }

        private static void Open(OperationResultWithFiles result)
        {
            foreach (var file in result.Files)
            {
                System.Diagnostics.Process.Start(Path.Combine(_reportFolder, file.Name));
            }
        }
    }
}
