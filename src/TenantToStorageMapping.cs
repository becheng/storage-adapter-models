using Azure;
using Azure.Data.Tables;

#pragma warning disable 0436
namespace StorageAdapter.Models
{
    /// <summary>
    /// Represents a mapping between a tenant and a storage account.
    /// </summary>
    public class TenantToStorageMapping : ITableEntity
    {
        /// <summary>
        /// Gets or sets the partition key for the entity.
        /// </summary>
        public string PartitionKey { get; set; }

        /// <summary>
        /// Gets or sets the row key for the entity.
        /// </summary>
        public string RowKey { get; set; }

        /// <summary>
        /// Gets or sets the timestamp for the entity.
        /// </summary>
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the ETag for the entity.
        /// </summary>
        public ETag ETag { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the tenant.
        /// </summary>
        public Guid? CxTenantId { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant.
        /// </summary>
        public string? CxTenantName { get; set; }

        /// <summary>
        /// Gets or sets the secret reference for the storage account access key.
        /// </summary>
        public string? StorageAccessKeySecretRef { get; set; }

        /// <summary>
        /// Gets or sets the type of the storage account.
        /// </summary>
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the storage account.
        /// </summary>
        public string? StorageIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the name of the container in the storage account.
        /// </summary>
        public string? ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the type of connection to use for the storage account.
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the region for the storage account.
        /// </summary>
        public string? StorageRegion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an Azure cross-tenant storage account.
        /// </summary>
        public bool IsAzCrossTenant{ get; set; }

        /// <summary>
        /// Gets or sets the ID of the Azure cross-tenant.
        /// </summary>
        public string? AzCrossTenantId{ get; set; }

        /// <summary>
        /// Gets or sets the domain of the Azure cross-tenant.
        /// </summary>
        public string? AzCrossTenantDomain{ get; set; }
    }

    /// <summary>
    /// Represents the type of a storage account.
    /// </summary>
    public enum StorageType { AzStorage, AwsS3 };

    /// <summary>
    /// Represents the type of connection to use for a storage account.
    /// </summary>
    public enum ConnectionType { AzStorageSharedKey, AzOauth, AwsCredentials };
}
