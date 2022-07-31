using Azure.Storage.Blobs;

var connectionString = "{yourConnectionString}";
var containerName = "scripts";
var blobName = "scripts.sql";
var filePath = "C:\\tmp1\\script.sql";

var blobContainerClient = new BlobContainerClient(connectionString, containerName);

var blobClient = blobContainerClient.GetBlobClient(blobName);
await blobClient.UploadAsync(filePath, true);

Console.WriteLine("Uploaded the blob");