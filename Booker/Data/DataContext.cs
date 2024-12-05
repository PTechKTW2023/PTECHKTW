using Microsoft.EntityFrameworkCore;

namespace Booker.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var idGenerator = GenerateAscendingIntegers().GetEnumerator();


            modelBuilder.Entity<Book>().HasData(
              // Polski
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 1 cz. 1", Grade = "1", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 1 cz. 2", Grade = "1", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 2 cz. 1", Grade = "2", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 2 cz. 2", Grade = "2/3", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 3 cz. 1", Grade = "3", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 3 cz. 2", Grade = "4", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Ponad słowami 4", Grade = "5", Subject = "Polski", Level = true },

              // Język angielski
              new Book { Id = GetNextId(idGenerator), Title = "Focus 2 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 3 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 4 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 5 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 2 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 3 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 4 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Focus 5 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "My matura perspectives [nowa era]", Grade = "4", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Repetytorium [Macmillan]", Grade = "5", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Repetytorium maturzysty [Oxford]", Grade = "5", Subject = "Język angielski", Level = false },
              new Book { Id = GetNextId(idGenerator), Title = "Repetytorium maturzysty [Cambridge, PWN]", Grade = "5", Subject = "Język angielski", Level = true },

              // Język Niemiecki
              new Book { Id = GetNextId(idGenerator), Title = "Welttour Deutsch 1", Grade = "1", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Welttour Deutsch 2", Grade = "2", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Welttour Deutsch 3", Grade = "3", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Welttour Deutsch 4", Grade = "4/5", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Effekt 1", Grade = "1", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Effekt 2", Grade = "2", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Effekt 3", Grade = "3", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Effekt 4", Grade = "4/5", Subject = "Język Niemiecki", Level = true },

              // Biologia
              new Book { Id = GetNextId(idGenerator), Title = "Biologia na czasie 1", Grade = "1", Subject = "Biologia", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Biologia na czasie 2", Grade = "2/3", Subject = "Biologia", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Biologia na czasie 3", Grade = "4", Subject = "Biologia", Level = true },
              new Book { Id = GetNextId(idGenerator), Title = "Biologia na czasie 1", Grade = "1", Subject = "Biologia", Level = false },
              new Book { Id = GetNextId(idGenerator), Title = "Biologia na czasie 2", Grade = "2", Subject = "Biologia", Level = false },
              new Book { Id = GetNextId(idGenerator), Title = "Biologia na czasie 3", Grade = "3/4", Subject = "Biologia", Level = false },

              // Chemia (continued)                
                new Book { Id = GetNextId(idGenerator), Title = "To jest chemia 1", Grade = "1,2,3", Subject = "Chemia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "To jest chemia 2", Grade = "4", Subject = "Chemia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "To jest chemia 1", Grade = "1,2,3", Subject = "Chemia", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "To jest chemia 2", Grade = "4,5", Subject = "Chemia", Level = false },

                // EDB
                new Book { Id = GetNextId(idGenerator), Title = "Edukacja dla bezpieczeństwa [wsip]", Grade = "1", Subject = "EDB", Level = true },

                // Fizyka
                new Book { Id = GetNextId(idGenerator), Title = "Fizyka 1 [wsip]", Grade = "1", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Fizyka 2 [wsip]", Grade = "2", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Fizyka 3 [wsip]", Grade = "3", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Fizyka 4 [wsip]", Grade = "4/5", Subject = "Fizyka", Level = false },

                // Geografia
                new Book { Id = GetNextId(idGenerator), Title = "Oblicza geografii 1", Grade = "1/2", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Oblicza geografii 2", Grade = "3/4", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Oblicz geografii karty pracy 1", Grade = "1/2", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Oblicz geografii karty pracy 2", Grade = "3/4", Subject = "Geografia", Level = true },

                // Historia
                new Book { Id = GetNextId(idGenerator), Title = "Historia [wsip] 1", Grade = "1", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Historia [wsip] 2", Grade = "2", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Historia [wsip] 3", Grade = "3", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Historia [wsip] 4", Grade = "4", Subject = "Historia", Level = true },

                // HiT
                new Book { Id = GetNextId(idGenerator), Title = "Historia i teraźniejszość [wsip] 1", Grade = "2", Subject = "HiT", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Historia i teraźniejszość [wsip] 2", Grade = "3", Subject = "HiT", Level = true },

                // Informatyka
                new Book { Id = GetNextId(idGenerator), Title = "Informatyka [operon]", Grade = "1/2", Subject = "Informatyka", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]", Grade = "3/4", Subject = "Informatyka", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Informatyka [operon]", Grade = "1/2", Subject = "Informatyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]", Grade = "3/4", Subject = "Informatyka", Level = false },

                // Matematyka
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 1", Grade = "1/2", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 2", Grade = "2/3", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 3", Grade = "3/4", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 4", Grade = "4/5", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 1", Grade = "1/2", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 2", Grade = "2/3", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 3", Grade = "3/4", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "NOWA MATeMAtyka 4", Grade = "4/5", Subject = "Matematyka", Level = false },

                // Podstawy przedsiębiorczości
                new Book { Id = GetNextId(idGenerator), Title = "Krok w przedsiębiorczość", Grade = "2/3", Subject = "Podstawy przedsiębiorczości", Level = true },

                // Biznes i zarządzanie
                new Book { Id = GetNextId(idGenerator), Title = "Krok w biznes i zarządzanie 1", Grade = "1", Subject = "Biznes i zarządzanie", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "Krok w biznes i zarządzanie 2", Grade = "2", Subject = "Biznes i zarządzanie", Level = true },

                // Plastyka
                new Book { Id = GetNextId(idGenerator), Title = "Spotkania ze sztuką 1", Grade = "1", Subject = "Plastyka", Level = true },

                // WOS
                new Book { Id = GetNextId(idGenerator), Title = "W centrum uwagi 1", Grade = "4", Subject = "WOS", Level = true },
                new Book { Id = GetNextId(idGenerator), Title = "W centrum uwagi 2", Grade = "5", Subject = "WOS", Level = true },

                // Angielski zawodowy
                new Book { Id = GetNextId(idGenerator), Title = "Electronics", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Electrician", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Software engineering", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Computing", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Mechanical engineering", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Mechanics", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(idGenerator), Title = "Enviromental Science", Grade = "3/4", Subject = "Angielski zawodowy", Level = false }
              );
            
        }

        public static IEnumerable<int> GenerateAscendingIntegers(int start = 1, int end = 1000)
        {            
            for (int i = start; i < end; i++)
            {
                yield return i;
            }
        }

        private static int GetNextId(IEnumerator<int> idGenerator)
        {
            if (!idGenerator.MoveNext())
                throw new System.InvalidOperationException("Not enough IDs in the generator.");
            return idGenerator.Current;
        }
    }
}
