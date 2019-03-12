namespace EF
{
    class Tag
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public Blog Blog { get; set; }
    }
}
