using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Booker.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Item> Items { get; set; }
        
        public DbSet<Grade> Grades { get; set; }
        public DbSet<BookGrade> BookGrades { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var bookIdGenerator = GenerateAscendingIntegers().GetEnumerator();
            var userIdGenerator = GenerateAscendingIntegers().GetEnumerator();
            var itemIdGenerator = GenerateAscendingIntegers().GetEnumerator();
            var userSequenceGenerator = GenerateEndlessLoop(1, 6).GetEnumerator();
            var rand = new Random();

            modelBuilder.Entity<Book>().HasData(
                // Polski
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 1 cz. 1", Subject = "Polski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 1 cz. 2", Subject = "Polski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 2 cz. 1", Subject = "Polski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 2 cz. 2", Subject = "Polski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 3 cz. 1", Subject = "Polski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 3 cz. 2", Subject = "Polski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Ponad słowami 4", Subject = "Polski", Level = true },

                // Język angielski
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 2 Podręcznik", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 3 Podręcznik", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 4 Podręcznik", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 5 Podręcznik", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 2 Ćwiczenia", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 3 Ćwiczenia", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 4 Ćwiczenia", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Focus 5 Ćwiczenia", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "My matura perspectives [nowa era]", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Repetytorium [Macmillan]", Subject = "Język angielski", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Repetytorium maturzysty [Oxford]", Subject = "Język angielski", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Repetytorium maturzysty [Cambridge, PWN]", Subject = "Język angielski", Level = true },

                // Język Niemiecki
                new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 1", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 2", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 3", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Welttour Deutsch 4", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 1", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 2", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 3", Subject = "Język Niemiecki", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Effekt 4", Subject = "Język Niemiecki", Level = true },

                // Biologia
                new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 1", Subject = "Biologia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 2", Subject = "Biologia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 3", Subject = "Biologia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 1", Subject = "Biologia", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 2", Subject = "Biologia", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Biologia na czasie 3", Subject = "Biologia", Level = false },

                // Chemia
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 1", Subject = "Chemia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 2", Subject = "Chemia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 1", Subject = "Chemia", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "To jest chemia 2", Subject = "Chemia", Level = false },

                // EDB
                new Book { Id = GetNextId(bookIdGenerator), Title = "Edukacja dla bezpieczeństwa [wsip]", Subject = "EDB", Level = true },

                // Fizyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 1 [wsip]", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 2 [wsip]", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 3 [wsip]", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 4 [wsip]", Subject = "Fizyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 1 [wsip]", Subject = "Fizyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 2 [wsip]", Subject = "Fizyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 3 [wsip]", Subject = "Fizyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Fizyka 4 [wsip]", Subject = "Fizyka", Level = true },

                // Geografia
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicza geografii 1", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicza geografii 2", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicz geografii karty pracy 1", Subject = "Geografia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Oblicz geografii karty pracy 2", Subject = "Geografia", Level = true },

                // Historia
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 1", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 2", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 3", Subject = "Historia", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia [wsip] 4", Subject = "Historia", Level = true },

                // HiT
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia i teraźniejszość [wsip] 1", Subject = "HiT", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Historia i teraźniejszość [wsip] 2", Subject = "HiT", Level = true },

                // Informatyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka [operon]", Subject = "Informatyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]", Subject = "Informatyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka [operon]", Subject = "Informatyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka dla szkół ponadgimnazjalnych [Migra]", Subject = "Informatyka", Level = false },

                // Matematyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 1", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 2", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 3", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 4", Subject = "Matematyka", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 1", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 2", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 3", Subject = "Matematyka", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "NOWA MATeMAtyka 4", Subject = "Matematyka", Level = false },

                // Podstawy przedsiębiorczości
                new Book { Id = GetNextId(bookIdGenerator), Title = "Krok w przedsiębiorczość", Subject = "Podstawy przedsiębiorczości", Level = true },

                // Biznes i zarządzanie
                new Book { Id = GetNextId(bookIdGenerator), Title = "Krok w biznes i zarządzanie 1", Subject = "Biznes i zarządzanie", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Krok w biznes i zarządzanie 2", Subject = "Biznes i zarządzanie", Level = true },

                // Plastyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Spotkania ze sztuką 1", Subject = "Plastyka", Level = true },

                // WOS
                new Book { Id = GetNextId(bookIdGenerator), Title = "W centrum uwagi 1", Subject = "WOS", Level = true },
                new Book { Id = GetNextId(bookIdGenerator), Title = "W centrum uwagi 2", Subject = "WOS", Level = true },

                // Angielski zawodowy
                new Book { Id = GetNextId(bookIdGenerator), Title = "Electronics", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Electrician", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "Software engineering", Subject = "Angielski zawodowy", Level = false },
                new Book { Id = GetNextId(bookIdGenerator), Title = "IT [english for IT]", Subject = "Angielski zawodowy", Level = true },

                // Informatyka
                new Book { Id = GetNextId(bookIdGenerator), Title = "Informatyka w praktyce", Subject = "Informatyka", Level = false }
            );

            modelBuilder.Entity<Grade>().HasData(
                new Grade { Id = "1", GradeNumber = "1" },
                new Grade { Id = "2", GradeNumber = "2" },
                new Grade { Id = "3", GradeNumber = "3" },
                new Grade { Id = "4", GradeNumber = "4" },
                new Grade { Id = "5", GradeNumber = "5" }
            );

            modelBuilder.Entity<BookGrade>().HasKey(bg => new { bg.BookId, bg.GradeId });

            modelBuilder.Entity<BookGrade>().HasData(
                // Polish books
                new BookGrade { BookId = 1, GradeId = "1" },
                new BookGrade { BookId = 2, GradeId = "1" },
                new BookGrade { BookId = 3, GradeId = "2" },
                new BookGrade { BookId = 4, GradeId = "2" },
                new BookGrade { BookId = 5, GradeId = "3" },
                new BookGrade { BookId = 6, GradeId = "4" },
                new BookGrade { BookId = 7, GradeId = "5" },

                // English books
                new BookGrade { BookId = 8, GradeId = "1" },
                new BookGrade { BookId = 9, GradeId = "1" },
                new BookGrade { BookId = 10, GradeId = "2" },
                new BookGrade { BookId = 11, GradeId = "2" },
                new BookGrade { BookId = 12, GradeId = "3" },
                new BookGrade { BookId = 13, GradeId = "3" },
                new BookGrade { BookId = 14, GradeId = "4" },
                new BookGrade { BookId = 15, GradeId = "4" },
                new BookGrade { BookId = 16, GradeId = "5" },
                new BookGrade { BookId = 17, GradeId = "5" },
                new BookGrade { BookId = 18, GradeId = "5" },
                new BookGrade { BookId = 19, GradeId = "5" },

                // German books
                new BookGrade { BookId = 20, GradeId = "1" },
                new BookGrade { BookId = 21, GradeId = "2" },
                new BookGrade { BookId = 22, GradeId = "3" },
                new BookGrade { BookId = 23, GradeId = "4" },
                new BookGrade { BookId = 24, GradeId = "1" },
                new BookGrade { BookId = 25, GradeId = "2" },
                new BookGrade { BookId = 26, GradeId = "3" },
                new BookGrade { BookId = 27, GradeId = "4" },

                // Biology books
                new BookGrade { BookId = 28, GradeId = "1" },
                new BookGrade { BookId = 29, GradeId = "2" },
                new BookGrade { BookId = 30, GradeId = "3" },
                new BookGrade { BookId = 31, GradeId = "1" },
                new BookGrade { BookId = 32, GradeId = "2" },
                new BookGrade { BookId = 33, GradeId = "3" },

                // Chemistry books
                new BookGrade { BookId = 34, GradeId = "1" },
                new BookGrade { BookId = 35, GradeId = "2" },
                new BookGrade { BookId = 36, GradeId = "3" },
                new BookGrade { BookId = 37, GradeId = "4" },

                // EDB books
                new BookGrade { BookId = 38, GradeId = "1" },

                // Physics books
                new BookGrade { BookId = 39, GradeId = "1" },
                new BookGrade { BookId = 40, GradeId = "2" },
                new BookGrade { BookId = 41, GradeId = "3" },
                new BookGrade { BookId = 42, GradeId = "4" },
                new BookGrade { BookId = 43, GradeId = "1" },
                new BookGrade { BookId = 44, GradeId = "2" },
                new BookGrade { BookId = 45, GradeId = "3" },
                new BookGrade { BookId = 46, GradeId = "4" },

                // Geography books
                new BookGrade { BookId = 47, GradeId = "1" },
                new BookGrade { BookId = 48, GradeId = "2" },
                new BookGrade { BookId = 49, GradeId = "1" },
                new BookGrade { BookId = 50, GradeId = "2" },

                // History books
                new BookGrade { BookId = 51, GradeId = "1" },
                new BookGrade { BookId = 52, GradeId = "2" },
                new BookGrade { BookId = 53, GradeId = "3" },
                new BookGrade { BookId = 54, GradeId = "4" },

                // HiT books
                new BookGrade { BookId = 55, GradeId = "2" },
                new BookGrade { BookId = 56, GradeId = "3" },

                // Informatics books
                new BookGrade { BookId = 57, GradeId = "1" },
                new BookGrade { BookId = 58, GradeId = "2" },
                new BookGrade { BookId = 59, GradeId = "3" },
                new BookGrade { BookId = 60, GradeId = "4" },

                // Mathematics books
                new BookGrade { BookId = 61, GradeId = "1" },
                new BookGrade { BookId = 62, GradeId = "2" },
                new BookGrade { BookId = 63, GradeId = "3" },
                new BookGrade { BookId = 64, GradeId = "4" },
                new BookGrade { BookId = 65, GradeId = "1" },
                new BookGrade { BookId = 66, GradeId = "2" },
                new BookGrade { BookId = 67, GradeId = "3" },
                new BookGrade { BookId = 68, GradeId = "4" },

                // Entrepreneurship books
                new BookGrade { BookId = 69, GradeId = "2" },

                // Business and management books
                new BookGrade { BookId = 70, GradeId = "1" },
                new BookGrade { BookId = 71, GradeId = "2" },

                // Art books
                new BookGrade { BookId = 72, GradeId = "1" },

                // Social studies books
                new BookGrade { BookId = 73, GradeId = "4" },
                new BookGrade { BookId = 74, GradeId = "5" },

                // Vocational English books
                new BookGrade { BookId = 75, GradeId = "3" },
                new BookGrade { BookId = 76, GradeId = "3" },
                new BookGrade { BookId = 77, GradeId = "3" },
                new BookGrade { BookId = 78, GradeId = "3" }
                //new BookGrade { BookId = 79, GradeId = "3" }
                //new BookGrade { BookId = 80, GradeId = "3" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = "user" + GetNextId(userIdGenerator), Email = "user" + GetCurrentId(userIdGenerator) + "@gmail.com", UserName = "user" + GetCurrentId(userIdGenerator), School = "Śl.TZN", Photo = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png" },
                new User { Id = "user" + GetNextId(userIdGenerator), Email = "user" + GetCurrentId(userIdGenerator) + "@gmail.com", UserName = "user" + GetCurrentId(userIdGenerator), School = "Śl.TZN", Photo = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png" },
                new User { Id = "user" + GetNextId(userIdGenerator), Email = "user" + GetCurrentId(userIdGenerator) + "@gmail.com", UserName = "user" + GetCurrentId(userIdGenerator), School = "Śl.TZN", Photo = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png" },
                new User { Id = "user" + GetNextId(userIdGenerator), Email = "user" + GetCurrentId(userIdGenerator) + "@gmail.com", UserName = "user" + GetCurrentId(userIdGenerator), School = "Śl.TZN", Photo = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png" },
                new User { Id = "user" + GetNextId(userIdGenerator), Email = "user" + GetCurrentId(userIdGenerator) + "@gmail.com", UserName = "user" + GetCurrentId(userIdGenerator), School = "Śl.TZN", Photo = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png" }
                );
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                new Item { Id = GetNextId(itemIdGenerator), BookId = rand.Next(1, GetCurrentId(bookIdGenerator)), UserId = "user" + GetNextId(userSequenceGenerator), Price = rand.Next(140, 600) / 7M, DateTime = DateTime.Now, Description = "Książka w dobrym stanie, prawie nie używana, nie zalana, rogi delikatnie zagięte, polecam kebab Zahir i pytam czy idziecie na sylwestra do zduniaka.", State = "bardzo dobry", Photo = "https://images.unsplash.com/photo-1517770413964-df8ca61194a6?q=80&w=1770&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" }
              );
        }

        public static IEnumerable<int> GenerateAscendingIntegers(int start = 1, int end = 1000)
        {
            for (int i = start; i < end; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> GenerateEndlessLoop(int start = 1, int end = 1000)
        {
            while (true)
            {
                for (int i = start; i < end; i++)
                {
                    yield return i;
                }
            }
        }

        private static int GetNextId(IEnumerator<int> idGenerator)
        {
            if (!idGenerator.MoveNext())
                throw new System.InvalidOperationException("Not enough IDs in the generator.");
            return idGenerator.Current;
        }

        private static int GetCurrentId(IEnumerator<int> idGenerator)
        {
            return idGenerator.Current;
        }
    }
}
