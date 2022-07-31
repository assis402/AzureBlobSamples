using Azure.Storage.Blobs;

var connectionString = "{yourConnectionString}";
var containerName = "data";

var blobContainerClient = new BlobContainerClient(connectionString, containerName);

await foreach(var blobItem in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine("The blob name is:" + blobItem.Name);
    Console.WriteLine("The blob size is:" + blobItem.Properties.ContentLength);
} 
