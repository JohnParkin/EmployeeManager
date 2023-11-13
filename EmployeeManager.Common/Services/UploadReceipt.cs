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

        private string _connectionString = "";

        string blobContainerName = "receipts-test1";

        private BlobContainerClient _blobContainerClient;

        public BlobUpload(string connectionString) 
        { 
            _connectionString = connectionString;
            _blobContainerClient = new BlobContainerClient(_connectionString, blobContainerName);
            _filepath = "C:/Users/johnp/source/repos/Building Desktop Applications/EmployeeManager.WinUI/EmployeeManager.WinUI/Images/Scan 0.jpg";
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
