using MyConcept.Data;
using System.Reflection;

namespace MyConcept.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var assemblies = Assembly.GetExecutingAssembly()
                .GetReferencedAssemblies()
                .Where(asm => asm.FullName!.Contains("MyConcept"))
                .Select(ra => Assembly.Load(ra))
                .ToArray();
            builder.Services.AddMediatR(cfg => 
                cfg.RegisterServicesFromAssemblies(assemblies));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<MyConceptContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}