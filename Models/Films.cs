namespace StarWarsApp.Models;

public class Film
{
    public string Title { get; set; }
    public int EpisodeId { get; set; }
    public string OpeningCrawl { get; set; }
    public string Director { get; set; }
    public string Producer { get; set; }
    public string ReleaseDate { get; set; }
    public string Url { get; set; }
    public List<string> Characters { get; set; }
    public List<string> Vehicles { get; set; }
}