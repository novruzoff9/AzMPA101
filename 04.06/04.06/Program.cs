using _04._06;

Movie movie1 = new Movie() { Name = "Inception", Genre = Genre.Action, Duration = TimeSpan.FromMinutes(148) };


MovieExtensions.IsHighlyRated(movie1);
movie1.IsHighlyRated();