namespace AnniesCatSanctuary.Data
{
    public class Pet
    {
        public int Id { get; set; } // Unique identifier
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsHidden { get; set; } = false; // Default visibility
    }
}
