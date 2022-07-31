using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

var connectionString = "{yourConnectionString}";
var containerName = "scripts";

var blobServiceClient = new BlobServiceClient(connectionString);
await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);

Console.WriteLine("Container created");