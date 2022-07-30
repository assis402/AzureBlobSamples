using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var containerName = "scripts";

//await SetBlobMetadata();
await AcquireLease();

async Task AcquireLease()
{
    var blobName = "scripts.sql";
    var blobClient = new BlobClient(connectionString, containerName, blobName);
    var blobLeaseClient = blobClient.GetBlobLeaseClient();

    var leaseTime = new TimeSpan(0, 0, 1, 00);

    var response = await blobLeaseClient.AcquireAsync(leaseTime);

    Console.Write("Lease id is: " + response.Value.LeaseId);
}