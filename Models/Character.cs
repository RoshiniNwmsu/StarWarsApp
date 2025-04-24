namespace StarWarsApp.Models;

public class Character
{
    public int Id => int.Parse(Url.TrimEnd('/').Split('/').Last());
    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Films { get; set; } = new();
    public string Url { get; set; }
}