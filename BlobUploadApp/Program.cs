using Azure.Storage.Blobs;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var containerName = "scripts";
var blobName = "scripts.sql";
var filePath = "C:\\tmp1\\script.sql";

var blobContainerClient = new BlobContainerClient(connectionString, containerName);

var blobClient = blobContainerClient.GetBlobClient(blobName);
await blobClient.UploadAsync(filePath, true);

Console.WriteLine("Uploaded the blob");