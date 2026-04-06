namespace _04._06;

internal static class MovieExtensions
{
    public static bool IsHighlyRated(this Movie movie)
    {
        return movie.AverageRating >= 8;
    }

    public static bool IsLongMovie(this Movie movie)
    {
        return movie.Duration > TimeSpan.FromMinutes(125) + TimeSpan.FromSeconds(15);
    }
}
