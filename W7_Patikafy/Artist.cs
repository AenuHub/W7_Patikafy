namespace W7_Patikafy;

public class Artist
{
    public string Name { get; set; }
    public List<string> Genres { get; set; }
    public int DebutYear { get; set; }
    public int AlbumSales { get; set; }

    public Artist(string name, List<string> genres, int debutYear, int albumSales)
    {
        Name = name;
        Genres = genres;
        DebutYear = debutYear;
        AlbumSales = albumSales;
    }
    
    // for easily printing genres
    public void PrintGenres()
    {
        for (int i = 0; i < Genres.Count; i++)
        {
            if (i == Genres.Count - 1)
            {
                Console.Write(Genres[i]);
            }
            else
            {
                Console.Write(Genres[i] + " / ");
            }
        }
    }
}