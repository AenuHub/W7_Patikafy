using W7_Patikafy;

public class Program
{
    public static void Main(string[] args)
    {
        List<Artist> artists = new List<Artist>()
        {
            new Artist("Ajda Pekkan", new List<string>() {"Pop"}, 1968, 20_000_000),
            new Artist("Sezen Aksu", new List<string>() {"Türk Halk Müziği", "Pop"}, 1971, 
                10_000_000),
            new Artist("Funda Arar", new List<string>() {"Pop"}, 1999, 3_000_000),
            new Artist("Sertab Erener", new List<string>() {"Pop"}, 1994, 5_000_000),
            new Artist("Sıla", new List<string>() {"Pop"}, 2009, 3_000_000),
            new Artist("Serdar Ortaç", new List<string>() {"Pop"}, 1994, 10_000_000),
            new Artist("Tarkan", new List<string>() {"Pop"}, 1992, 40_000_000),
            new Artist("Hande Yener", new List<string>() {"Pop"}, 1999, 7_000_000),
            new Artist("Hadise", new List<string>() {"Pop"}, 2005, 5_000_000),
            new Artist("Gülben Ergen", new List<string>() {"Pop", "Türk Halk Müziği"}, 1997, 
                10_000_000),
            new Artist("Neşet Ertaş", new List<string>() {"Türk Halk Müziği", "Türk Sanat Müziği"}, 
                1960, 2_000_000),
        };
        
        var artistsStartsWithS = artists.Where(x => x.Name.StartsWith("S")).ToList();
        Console.WriteLine("Artists with their names starting with S:");
        foreach (var artist in artistsStartsWithS)
        {
            Console.WriteLine(artist.Name);
        }
        Console.WriteLine("------------------");
        
        var artistsWithSalesOver10M = artists.Where(x => x.AlbumSales > 10_000_000).ToList();
        Console.WriteLine("Artists with sales over 10M:");
        foreach (var artist in artistsWithSalesOver10M)
        {
            Console.Write($"{artist.Name} -> {artist.AlbumSales} albums sold.\n");
        }
        Console.WriteLine("------------------");

        var artistsWithDebutBefore2000AndGenrePop = artists.Where(x => x.DebutYear < 2000
                                                                       && x.Genres.Contains("Pop"))
            .OrderBy(x => x.Name).GroupBy(x => x.DebutYear).ToList();
        Console.WriteLine("Artists with debut before year 2000 and made pop music:");
        foreach (var debutYear in artistsWithDebutBefore2000AndGenrePop)
        {
            Console.WriteLine($"Year: {debutYear.Key} -> {debutYear.Count()} artists:");
            var orderedArtists = debutYear.OrderBy(x => x.Name).ToList();
            foreach (var artist in orderedArtists)
            {
                Console.Write($"{artist.Name} -> Genres: ");
                artist.PrintGenres();
                Console.WriteLine();
            }
        }
        Console.WriteLine("------------------");
        
        var artistWithMaxSales = artists.MaxBy(x => x.AlbumSales);
        Console.WriteLine($"Artist with max sales:");
        Console.WriteLine($"{artistWithMaxSales.Name} -> {artistWithMaxSales.AlbumSales} albums sold.");
        Console.WriteLine("------------------");
        
        var newestArtist = artists.MaxBy(x => x.DebutYear);
        Console.WriteLine($"Newest artist:");
        Console.WriteLine($"{newestArtist.Name} -> Debut year: {newestArtist.DebutYear}");
        Console.WriteLine("------------------");
        
        var oldestArtist = artists.MinBy(x => x.DebutYear);
        Console.WriteLine($"Oldest artist:");
        Console.WriteLine($"{oldestArtist.Name} -> Debut year: {oldestArtist.DebutYear}");

        Console.ReadKey();
    }
}