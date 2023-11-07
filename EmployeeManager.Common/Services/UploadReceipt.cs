using Azure.Storage.Blobs;
using EmployeeManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Common.Services
{
    public class BlobUpload
    {
        private string _filepath = "";

        string connection_string = "DefaultEndpointsProtocol=https;AccountName=azurestoragepot;AccountKey=7wfdwJHLfDUP+gpTzOta+bYkDRal3mLW7ELHQcrf86RaTmlwITTPX3U/fUOohjXmU4padfjJmGFZ+ASteqI2dg==;EndpointSuffix=core.windows.net";

        string blobContainerName = "receipts-test1";

        private BlobContainerClient _blobContainerClient;

        public BlobUpload()
        {
            _blobContainerClient = new BlobContainerClient(connection_string, blobContainerName);
            _filepath = "C:/Users/johnp/source/repos/Building Desktop Applications/EmployeeManager.WinUI/EmployeeManager.WinUI/Images/Scan 6.jpg";
        }
        public async void UploadFileToBlobStorage()
        {
            Debug.WriteLine($"Reciept Upload");
            await UploadFromFileAsync(_blobContainerClient, _filepath);
        }
        public async Task UploadFromFileAsync(
            BlobContainerClient containerClient,
            string localFilePath)
        {
            string fileName = Path.GetFileName(localFilePath);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            await blobClient.UploadAsync(localFilePath, true);
        }
    }
}
