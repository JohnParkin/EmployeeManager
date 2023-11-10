using Azure.Core.Serialization;
using Azure.Storage.Blobs;
using EmployeeManager.Common.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManager.Common.Services
{
    public class BlobUpload
    {
        private string _filepath = "";

        string connection_string = "";

        string blobContainerName = "receipts-test1";
        private BlobContainerClient _blobContainerClient;

        public BlobUpload()
        {
            _blobContainerClient = new BlobContainerClient(connection_string, blobContainerName);
            _filepath = "C:/Users/johnp/source/repos/Building Desktop Applications/EmployeeManager.WinUI/EmployeeManager.WinUI/Images/Scan 1.jpg";
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

            _blobContainerClient = new BlobContainerClient(connection_string, blobContainerName);

            string fileName = Path.GetFileName(localFilePath);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            await blobClient.UploadAsync(localFilePath, true);
        }
    }
}
