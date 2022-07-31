using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;

var connectionString = "{yourConnectionString}";
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