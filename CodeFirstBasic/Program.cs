using CodeFirstBasic.Data;

using (var db = new PatikaFirstDbContext())
{
    // Games ve Movies tablolarını birleştiriyoruz
    var combinedList = db.Games
                        .Select(g => new { Type = "Game", Name = g.Name })
                        .Concat(
                            db.Movies.Select(m => new { Type = "Movie", Name = m.Title })
                        );

    // Tek bir foreach döngüsü ile hem oyunları hem filmleri yazdırıyoruz
    foreach (var item in combinedList)
    {
        Console.WriteLine($"{item.Type}: {item.Name}");
    }
}
