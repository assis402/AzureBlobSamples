using Azure.Storage.Blobs;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var containerName = "data";

var blobContainerClient = new BlobContainerClient(connectionString, containerName);

await foreach(var blobItem in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine("The blob name is:" + blobItem.Name);
    Console.WriteLine("The blob size is:" + blobItem.Properties.ContentLength);
} 
