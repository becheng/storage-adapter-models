using Azure;
using Azure.Data.Tables;

#pragma warning disable 0436
namespace StorageAdapter.Models;

public class TenantToStorageMapping : ITableEntity
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
    
    // public string? CxTenantId { get; set; }
    public Guid? CxTenantId { get; set; }
    public string? CxTenantName { get; set; }
    public StorageType StorageType { get; set; }
    public string? StorageAccessKeySecretRef { get; set; }
    public string? StorageIdentifier { get; set; }
    public string? ContainerName { get; set; }
    public ConnectionType ConnectionType { get; set; }
    public string? StorageRegion { get; set; }
    public bool IsAzureCrossTenant{ get; set; }
    public string? AzureCrossTenantId{ get; set; }
    public string? AzureCrossTenantDomain{ get; set; }
}

public enum StorageType { None, AzStorage, AwsS3 };
public enum ConnectionType { None, AzConnectionString, AzSasUri, AzStorageSharedKey, AzOauth, AwsCredentials };
