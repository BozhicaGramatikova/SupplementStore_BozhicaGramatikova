namespace SupplementStoreModels.Models.Requests;

public class GetAllSupplementsByStoreRequest
{
    public int StoreId { get; set; }
    public DateTime AfterDate {get; set;}

}