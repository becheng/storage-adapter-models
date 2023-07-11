using Azure.Storage.Blobs;

namespace StorageAdapter.Models;

public class StorageAdapterResponse
{
    public TenantToStorageMapping? storageMapping { get; }
    public BlobContainerClient? blobContainerClient { get; }
    public string? signedUri { get; }
    public StorageAdapterResponse(TenantToStorageMapping storageMapping, BlobContainerClient blobContainerClient)
    {
        this.storageMapping = storageMapping;
        this.blobContainerClient = blobContainerClient;
    }

    public StorageAdapterResponse(TenantToStorageMapping storageMapping, string signedUri)
    {
        this.storageMapping = storageMapping;
        this.signedUri = signedUri;
    }

}