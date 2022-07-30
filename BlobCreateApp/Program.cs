using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var containerName = "scripts";

var blobServiceClient = new BlobServiceClient(connectionString);
await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);

Console.WriteLine("Container created");