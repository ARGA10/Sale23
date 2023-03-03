using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Antioquia",
                            Cities = new List<City>() {
                                new City() { Name = "Medellín" },
                                new City() { Name = "Itagüí" },
                                new City() { Name = "Envigado" },
                                new City() { Name = "Bello" },
                                new City() { Name = "Rionegro" },
                            }
                        },
                        new State()
                        {
                            Name = "Bogotá",
                            Cities = new List<City>() {
                                new City() { Name = "Usaquen" },
                                new City() { Name = "Champinero" },
                                new City() { Name = "Santa fe" },
                                new City() { Name = "Useme" },
                                new City() { Name = "Bosa" },
                            }
                        },
                    }
                });

                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Florida",
                            Cities = new List<City>() {
                                new City() { Name = "Orlando" },
                                new City() { Name = "Miami" },
                                new City() { Name = "Tampa" },
                                new City() { Name = "Fort Lauderdale" },
                                new City() { Name = "Key West" },
                            }
                        },
                        new State()
                        {
                                Name = "Texas",
                                Cities = new List<City>() {
                                    new City() { Name = "Houston" },
                                    new City() { Name = "San Antonio" },
                                    new City() { Name = "Dallas" },
                                    new City() { Name = "Austin" },
                                    new City() { Name = "El Paso" },
                                }
                            },
                    }
                });

                
                await _context.SaveChangesAsync();
            }
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category
                {
                    Name = "Agua",
                    ProductCategories = new List<ProductCategory>()
                    {
                        new ProductCategory()
                        {
                            Name = "CategoryAgua",
                            Products = new List<Product>() {
                                new Product() { Name = "Baño1" },
                                new Product() { Name = "Baño2" },
                                new Product() { Name = "Baño3" },
                                new Product() { Name = "Cocina" },
                            }
                        },
                    }
                });
                _context.Categories.Add(new Category
                {
                    Name = "Gas",
                    ProductCategories = new List<ProductCategory>()
                    {
                        new ProductCategory()
                        {
                            Name = "primerCategory",
                            Products = new List<Product>() {
                                new Product() { Name = "Baño1" },
                                new Product() { Name = "Baño2" },
                                new Product() { Name = "Baño3" },
                                new Product() { Name = "Cocina" },
                            }
                        },
                        new ProductCategory()
                        {
                                Name = "CategoryGas",
                                Products = new List<Product>() {
                                    new Product() { Name = "Calentador" },
                                    new Product() { Name = "Fogon" },
                                    new Product() { Name = "Horno" },
                                }
                        },
                    }
                });
                await _context.SaveChangesAsync();
            }


        }
    }
}