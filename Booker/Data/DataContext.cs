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

            var bookIdGenerator = GenerateAscendingIntegers().GetEnumerator();
            var userIdGenerator = GenerateAscendingIntegers().GetEnumerator();
            var itemIdGenerator = GenerateAscendingIntegers().GetEnumerator();


            modelBuilder.Entity<Book>().HasData(
              // Polski
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 1 cz. 1", Grade = "1", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 1 cz. 2", Grade = "1", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 2 cz. 1", Grade = "2", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 2 cz. 2", Grade = "2/3", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 3 cz. 1", Grade = "3", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 3 cz. 2", Grade = "4", Subject = "Polski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 4", Grade = "5", Subject = "Polski", Level = true },

              // Język angielski
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 2 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 3 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 4 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 5 Podręcznik", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 2 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 3 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 4 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 5 Ćwiczenia", Grade = "Zależnie od poziomu", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "My matura perspectives [nowa era]", Grade = "4", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Repetytorium [Macmillan]", Grade = "5", Subject = "Język angielski", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Repetytorium maturzysty [Oxford]", Grade = "5", Subject = "Język angielski", Level = false },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Repetytorium maturzysty [Cambridge, PWN]", Grade = "5", Subject = "Język angielski", Level = true },

              // Język Niemiecki
              new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 1", Grade = "1", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 2", Grade = "2", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 3", Grade = "3", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 4", Grade = "4/5", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 1", Grade = "1", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 2", Grade = "2", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 3", Grade = "3", Subject = "Język Niemiecki", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 4", Grade = "4/5", Subject = "Język Niemiecki", Level = true },

              // Biologia
              new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 1", Grade = "1", Subject = "Biologia", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 2", Grade = "2/3", Subject = "Biologia", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 3", Grade = "4", Subject = "Biologia", Level = true },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 1", Grade = "1", Subject = "Biologia", Level = false },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 2", Grade = "2", Subject = "Biologia", Level = false },
              new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 3", Grade = "3/4", Subject = "Biologia", Level = false },

              // Chemia (continued)                
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 1", Grade = "1,2,3", Subject = "Chemia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 2", Grade = "4", Subject = "Chemia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 1", Grade = "1,2,3", Subject = "Chemia", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 2", Grade = "4,5", Subject = "Chemia", Level = false },

                // EDB
                new Book { Id = GetNextId(bookIdGenerator), Title = "Edukacja dla bezpieczeństwa [wsip]", Grade = "1", Subject = "EDB", Level = true },

                // Fizyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 1 [wsip]", Grade = "1", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 2 [wsip]", Grade = "2", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 3 [wsip]", Grade = "3", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 4 [wsip]", Grade = "4/5", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 1 [wsip]", Grade = "1", Subject = "Fizyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 2 [wsip]", Grade = "2", Subject = "Fizyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 3 [wsip]", Grade = "3", Subject = "Fizyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 4 [wsip]", Grade = "4/5", Subject = "Fizyka", Level = true },

                // Geografia
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicza geografii 1", Grade = "1/2", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicza geografii 2", Grade = "3/4", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicz geografii karty pracy 1", Grade = "1/2", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicz geografii karty pracy 2", Grade = "3/4", Subject = "Geografia", Level = true },

                // Historia
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 1", Grade = "1", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 2", Grade = "2", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 3", Grade = "3", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 4", Grade = "4", Subject = "Historia", Level = true },

                // HiT
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia i teraźniejszość [wsip] 1", Grade = "2", Subject = "HiT", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia i teraźniejszość [wsip] 2", Grade = "3", Subject = "HiT", Level = true },

                // Informatyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka [operon]", Grade = "1/2", Subject = "Informatyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]", Grade = "3/4", Subject = "Informatyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka [operon]", Grade = "1/2", Subject = "Informatyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]", Grade = "3/4", Subject = "Informatyka", Level = false },

                // Matematyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 1", Grade = "1/2", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 2", Grade = "2/3", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 3", Grade = "3/4", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 4", Grade = "4/5", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 1", Grade = "1/2", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 2", Grade = "2/3", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 3", Grade = "3/4", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 4", Grade = "4/5", Subject = "Matematyka", Level = false },

                // Podstawy przedsiębiorczości
                new Book { Id = GetNextId(bookIdGenerator), Title = "Krok w przedsiębiorczość", Grade = "2/3", Subject = "Podstawy przedsiębiorczości", Level = true },

                // Biznes i zarządzanie
                new Book { Id = GetNextId(bookIdGenerator), Title = "Krok w biznes i zarządzanie 1", Grade = "1", Subject = "Biznes i zarządzanie", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Krok w biznes i zarządzanie 2", Grade = "2", Subject = "Biznes i zarządzanie", Level = true },

                // Plastyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Spotkania ze sztuką 1", Grade = "1", Subject = "Plastyka", Level = true },

                // WOS
                new Book { Id = GetNextId(bookIdGenerator), Title = "W centrum uwagi 1", Grade = "4", Subject = "WOS", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "W centrum uwagi 2", Grade = "5", Subject = "WOS", Level = true },

                // Angielski zawodowy
                new Book { Id = GetNextId(bookIdGenerator), Title = "Electronics", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Electrician", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Software engineering", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Computing", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Mechanical engineering", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Mechanics", Grade = "3/4", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Enviromental Science", Grade = "3/4", Subject = "Angielski zawodowy", Level = false }
              );
            modelBuilder.Entity<User>().HasData(
                new User { Id = GetNextId(userIdGenerator), Email = "user"+GetNextId(userIdGenerator)+"@gmail.com", Password = "zaq1@WSX", Nickname = "user"+GetNextId(userIdGenerator), School = "Śl.TZN", Photo = "photo"+GetNextId(userIdGenerator)}
              );
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = GetNextId(itemIdGenerator), BookId = 1, UserID = 1, Price = 20.50, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "1"}
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
