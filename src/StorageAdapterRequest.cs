namespace StorageAdapter.Models;

public class StorageAdapterRequest 
{
    public string cxTenantId { get; }
    public string? fileName { get; }
    public double timeoutDurationInHrs { get; }
    public StorageRequestType storageRequestType { get; }
    public SignedURIAction signedURIAction { get; }
    public enum StorageRequestType
    {
        None,
        AWS3,
        AzStorageAccount
    }
    public enum SignedURIAction
    {
        None,
        Upload,
        Download
        //TODO - support Delete?
    }
     
    public StorageAdapterRequest(string cxTenantId) : 
        this(StorageRequestType.AzStorageAccount, cxTenantId, String.Empty, SignedURIAction.None, Double.NaN) { }

    private StorageAdapterRequest(
        StorageRequestType storageRequestType, 
        string cxTenantId, 
        string fileName, 
        SignedURIAction signedURIAction, 
        double timeoutDurationInHrs)
    {
        this.storageRequestType = storageRequestType;
        this.signedURIAction = signedURIAction;
        this.cxTenantId = cxTenantId;
        this.fileName = fileName;
        this.timeoutDurationInHrs = timeoutDurationInHrs;
    }

}