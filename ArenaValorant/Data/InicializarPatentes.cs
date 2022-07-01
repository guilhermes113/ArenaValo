using ArenaValorant.Models;

namespace ArenaValorant.Data
{
    public class InicializarPatentes
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<ArenaDbContext>();

                    context.Database.EnsureCreated();
                if (!context.Patentes.Any())
                {
                    context.Patentes.AddRange(new List<Patente>()
                    {
                        new Patente("Ferro I"),
                        new Patente("Ferro II"),
                        new Patente("Ferro III"),
                        new Patente("Bronze I"),
                        new Patente("Bronze II"),
                        new Patente("Bronze III"),
                        new Patente("Prata I"),
                        new Patente("Prata II"),
                        new Patente("Prata III"),
                        new Patente("Ouro I"),
                        new Patente("Ouro II"),
                        new Patente("Ouro III"),
                        new Patente("Platina I"),
                        new Patente("Platina II"),
                        new Patente("Platina III"),
                        new Patente("Diamante I"),
                        new Patente("Diamante II"),
                        new Patente("Diamante III"),
                        new Patente("Ascendente I"),
                        new Patente("Ascendente II"),
                        new Patente("Ascendente III"),
                        new Patente("Imortal I"),
                        new Patente("Imortal II"),
                        new Patente("Imortal III"),
                        new Patente("Radiante")

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
