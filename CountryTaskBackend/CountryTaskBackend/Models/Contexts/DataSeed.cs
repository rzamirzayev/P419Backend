using Microsoft.AspNetCore.Mvc;
using CountryTaskBackend.Models.Entities;

namespace CountryTaskBackend.Models.Contexts
{
    public static class DataSeed
    {
        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();

                var list = new[] {
                        new Country { Id = 1, Name = "Aqil", CountryCode = "P622" },
                        new Country { Id = 2, Name = "Emin", CountryCode = "P622" },
                        new Country { Id = 3, Name = "Taleh",  CountryCode = "P622" },
                        new Country { Id = 4, Name = "Huseyn", CountryCode = "P622" }
                };

                db.Countries.AddRange(list);
                db.SaveChanges();
            }

            return app;
        }
    }
}
