namespace SupplementStoreModels.Models
{
    public class Supplement
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int StoreId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
