using Azure.Storage.Blobs;
using EmployeeManager.Common.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace EmployeeManager.Common.Services
{
    public class BlobUpload
    {
        private string _filepath = "";

        string connection_string = "DefaultEndpointsProtocol=https;AccountName=azurestoragepot;AccountKey=E2ZogKGSztwlPpYOTH6gyZUW6y04XMtCXky/3W8p/dESc0h3Z6pOhuACmg8voBmWKja2rbjN5ijq+AStDRe3/A==;EndpointSuffix=core.windows.net";

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
