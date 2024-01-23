namespace ShopSemka.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SEEDING DATAS
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Spoločenstvo prsteňa",
                    Description = "Spoločenstvo prsteňa je fantasy román od spisovateľa J. R. R. Tolkiena. Predstavuje prvú časť trilógie Pán prsteňov.",
                    ImageURL = "https://mrtns.sk/tovar/_xl/134/xl134254.jpg?v=17050651822",
                    Price = 11.39m
                },
                new Product
                {
                    Id = 2,
                    Title = "Hobbit, alebo cesta tam a späť",
                    Description = "Hobbit, alebo cesta tam a späť je fantasy román J. R. R. Tolkiena vydaný 21. septembra 1937. V slovenčine vyšiel prvýkrát v roku 1973.",
                    ImageURL = "https://mrtns.sk/tovar/_xl/134/xl134257.jpg?v=17050651812",
                    Price = 11.15m
                },
                new Product
                {
                    Id = 3,
                    Title = "Malý princ",
                    Description = "Malý princ je najznámejšie dielo francúzskeho spisovateľa a pilota Antoineho de Saint-Exupéryho. Je to najslávnejší rozprávkový príbeh modernej literatúry.",
                    ImageURL = "https://www.pantarhei.sk/media/catalog/product/4/6/998f08d-00460809-23.jpg",
                    Price = 11.35m
                },
                new Product
                {
                    Id = 4,
                    Title = "Zbohom zbraniam",
                    Description = "Zbohom zbraniam je román Ernesta Hemingwaya, dej sa odohráva na talianskom fronte počas Prvej svetovej vojny. Kniha bola vydaná v roku 1929.",
                    ImageURL = "https://mrtns.sk/tovar/_xl/204/xl204133.jpg?v=16968287412",
                    Price = 9.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}