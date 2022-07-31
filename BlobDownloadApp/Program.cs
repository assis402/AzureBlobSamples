using Azure.Storage.Blobs;

var connectionString = "{yourConnectionString}";
var containerName = "scripts";
var blobName = "scripts.sql";
var filePath = "C:\\tmp1\\script.sql";

var blobClient = new BlobClient(connectionString, containerName, blobName);
blobClient.DownloadToAsync(filePath);

Console.WriteLine("The blob is downloaded");