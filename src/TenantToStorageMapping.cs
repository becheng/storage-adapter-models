using Azure;
using Azure.Data.Tables;


namespace storageAdapterModels;

public class TenantToStorageMapping : ITableEntity
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
    
    public string? CxTenantId { get; set; }
    public string? CxTenantName { get; set; }
    public string? StorageIdentifier { get; set;}
    public string? StorageAccessKeySecretRef { get; set; }
    public StorageType StorageType { get; set; }
    public string? ContainerName { get; set; }
    public ConnectionType ConnectionType { get; set; }
    public string? StorageRegion { get; set; }
    public bool IsAzCrossTenant{ get; set; }
    public string? AzCrossTenantId{ get; set; }
    public string? AzCrossTenantDomain{ get; set; }
}

public enum StorageType { AzStorage, AwsS3 };
// public enum ConnectionUriType { ConnectionString, SasUri, ContainerUri, AWS3PresignedUrl };
public enum ConnectionType { AzStorageSharedKey, AzOauth, AwsCredentials };
