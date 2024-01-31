namespace SupplementStoreModels.Models.Responses;

public class GetAllSupplementsByStoreResponse
{
    public Store ?Store {  get; set; }	
    public List<Supplement> ?Supplements { get; set; }

}