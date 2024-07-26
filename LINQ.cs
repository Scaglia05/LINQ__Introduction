using LINQ.Models;

namespace LINQ {
    public class LINQ {
        public static void Executar() {

            var songs = new List<Songs> {
    new Songs(id: 1, name: "Californication", band: "Red Hot Chili Peppers", new DateTime(year: 1999, month: 6, day: 8)),
    new Songs(id: 2, name: "Hotel California", band: "Eagles", new DateTime(year: 1977, month: 2, day: 22)),
    new Songs(id: 3, name: "November Rain", band: "Guns N' Roses", new DateTime(year: 1992, month: 2, day: 18)),
    new Songs(id: 4, name: "A Little Piece of Heaven", band: "Avenged Sevenfold", new DateTime(year: 2007, month: 10, day: 30)),
    new Songs(id: 5, name: "Wait and Bleed", band: "Slipknot", new DateTime(year: 1999, month: 7, day: 28))
};


            Console.WriteLine("Songs released in 1999");
            var songs1999 = songs
                .Where(x => x.ReleaseDate.Year == 1999)
                .ToList();
            songs1999.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("\nSongs released in February ");
            var songsFebruary = songs
               .Where(y => y.ReleaseDate.Month == 2)
               .ToList();
            songsFebruary.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("\nReturn songs in alphabetical order");
            var songsOrder = songs
                .OrderBy(x => x.Name)
                .ToList();
            songsOrder.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nLast two songs registered in alphabetical order");
            var songsLastTwo = songsOrder
                .TakeLast(2)
                .ToList();
            songsLastTwo.ForEach(x => Console.WriteLine(x));
        }
    }

}