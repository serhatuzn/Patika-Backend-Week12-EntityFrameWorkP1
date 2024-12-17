# Pratik - Code First Basic  
## Entity Framework Core ile Code First Yaklaşımı  

Bu proje, **Entity Framework Core** kullanarak **Code First** yaklaşımı ile bir veritabanı oluşturmayı amaçlamaktadır.  
Proje kapsamında **Movies** ve **Games** adında iki bağımsız tablo oluşturulmaktadır.

---

## 🚀 Proje İçeriği  

### **1. Movie Tablosu**  
| Alan        | Tür       | Açıklama                        |  
|-------------|-----------|---------------------------------|  
| `Id`        | int       | Birincil anahtar, otomatik artan. |  
| `Title`     | string    | Filmin başlığı.                |  
| `Genre`     | string    | Filmin türü (Action, Comedy, vb.).|  
| `ReleaseYear` | int     | Filmin çıkış yılı.             |  

### **2. Game Tablosu**  
| Alan        | Tür       | Açıklama                        |  
|-------------|-----------|---------------------------------|  
| `Id`        | int       | Birincil anahtar, otomatik artan. |  
| `Name`      | string    | Oyunun adı.                    |  
| `Platform`  | string    | Oynandığı platform (PC, Xbox, vb.).|  
| `Rating`    | decimal   | Oyunun puanı (0-10 arası).     |  

---

## 🛠 Kullanılan Teknolojiler  

- **C#**  
- **.NET Core**  
- **Entity Framework Core**  
- **SQL Server**  

---

## 📂 Proje Yapılandırması  

Proje klasör yapısı şu şekildedir:

PatikaCodeFirstDb1/ │ ├── Models/ │ ├── Movie.cs │ ├── Game.cs │ ├── Data/ │ ├── PatikaFirstDbContext.cs │ ├── Program.cs ├── README.md └── appsettings.json


---

## 📊 Veritabanı Bilgileri  

- **Veritabanı Adı**: `PatikaCodeFirstDb1`  
- **Tablolar**:  
  - `Movies`  
  - `Games`  

---

## 📜 Kod İçeriği  

### **Movie.cs**  
```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
}
```
### **Game.cs** 
```csharp
public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Platform { get; set; }
    public decimal Rating { get; set; }
}
```
### **PatikaFirstDbContext.cs**
```csharp
using Microsoft.EntityFrameworkCore;

public class PatikaFirstDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
    }
}
```
