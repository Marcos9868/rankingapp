namespace Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ImageId { get; set; }
        public int Ranking { get; set; }
        public int ItemType { get; set; }
    }
}