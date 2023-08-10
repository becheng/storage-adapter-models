using Azure.Storage.Blobs;
using Amazon;
using Amazon.S3;

namespace StorageAdapter.Models;

public class StorageAdapterResponse
{
    public TenantToStorageMapping? storageMapping { get; }
    public BlobContainerClient? blobContainerClient { get; }
    public IAmazonS3? s3Client { get; }

    // public string? signedUri { get; }
    // public SignedUriType? signedUriType { get; }
    // public enum SignedUriType { None, AzStorageAccount, AWSS3 }
    
    public StorageAdapterResponse(TenantToStorageMapping storageMapping, BlobContainerClient blobContainerClient)
    {
        this.storageMapping = storageMapping;
        this.blobContainerClient = blobContainerClient;
    }
    public StorageAdapterResponse(TenantToStorageMapping storageMapping, IAmazonS3 s3Client)
    {
        this.storageMapping = storageMapping;
        this.s3Client = s3Client;
    }

    // TODO: remove 
    // public StorageAdapterResponse(TenantToStorageMapping storageMapping, string signedUri)
    // {
    //     this.storageMapping = storageMapping;
    //     this.signedUri = signedUri;
    // }
//    public StorageAdapterResponse(TenantToStorageMapping storageMapping, string signedUri, SignedUriType uriType)
//    {
//         this.storageMapping = storageMapping;
//         this.signedUri = signedUri;
//         this.signedUriType = uriType;
//    }

}