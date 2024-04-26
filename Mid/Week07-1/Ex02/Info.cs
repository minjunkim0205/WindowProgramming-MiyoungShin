class Info
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Info(string id, string name)
    {
        Id = id;
        Name = name;
    }
    public string infoString => $"ID = {Id}, Name = {Name}";
}