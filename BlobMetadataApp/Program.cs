using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var containerName = "scripts";

//await SetBlobMetadata();
await GetMetadata();

async Task SetBlobMetadata()
{
    var blobName = "scripts.sql";
    var blobClient = new BlobClient(connectionString, containerName, blobName);

    IDictionary<string, string> metadata = new Dictionary<string, string>();
    metadata.Add("Departament", "Logistics");
    metadata.Add("Application", "AppA");

    await blobClient.SetMetadataAsync(metadata);

    Console.Write("Metadata added");
}

async Task GetMetadata()
{
    var blobName = "scripts.sql";
    var blobClient = new BlobClient(connectionString, containerName, blobName);
    BlobProperties blobProperties = await blobClient.GetPropertiesAsync();

    foreach (var metadata in blobProperties.Metadata)
    {
        Console.WriteLine("The key is: " + metadata.Key);
        Console.WriteLine("The value is: " + metadata.Value);
    }
}