using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalkulatorWaluty.BazaDanych
{
    public class KalkulatorWalutContext: DbContext
    {
        public DbSet<Waluta> Waluty { get; set; }

        public KalkulatorWalutContext(DbContextOptions<KalkulatorWalutContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Waluta>().HasData(WalutyPoczatkowe);

            Waluty.ToListAsync();
        }

        private static IEnumerable<Waluta> WalutyPoczatkowe => new List<Waluta>()
        {
            new Waluta(1, "Dolar", "USD", 1),
            new Waluta(2, "Złoty", "PLN", 0.2663),
            new Waluta(3, "Euro", "EUR", 1.1977),
            new Waluta(4, "Frank Szwajcarski", "CHF", 1.1075),
            new Waluta(5, "Funt Szterling", "GBP", 1.3690)
        };
    }
}
