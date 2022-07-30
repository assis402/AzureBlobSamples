using Azure.Storage.Blobs;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var containerName = "scripts";
var blobName = "scripts.sql";
var filePath = "C:\\tmp1\\script.sql";

var blobClient = new BlobClient(connectionString, containerName, blobName);
blobClient.DownloadToAsync(filePath);

Console.WriteLine("The blob is downloaded");