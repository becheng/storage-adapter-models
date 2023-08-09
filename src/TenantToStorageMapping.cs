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
    public string? ConnectionUriKVSecretName { get; set; }
    public string? AzAccountName { get; set; }
    public string? ContainerName { get; set; }
    public ConnectionUriType ConnectionUriType { get; set; }
    public string? StorageRegion { get; set; }
    public bool IsAzureCrossTenant{ get; set; }
    public string? AzureCrossTenantId{ get; set; }
    public string? AzureCrossTenantDomain{ get; set; }
}

public enum StorageType { AzureStorageAccount, AmazonS3 };
public enum ConnectionUriType { ConnectionString, SasUri, ContainerUri, AzSasUri, AWS3PresignedUrl };
