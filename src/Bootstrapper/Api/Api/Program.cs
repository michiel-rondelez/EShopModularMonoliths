namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services
                .AddCatalogModule(builder.Configuration)
                .AddBasketModule(builder.Configuration)
                .AddOrderingModule(builder.Configuration);

            var app = builder.Build();

            app.UseCatelogModule()
                .UseBasketModule()
                .UseOrderingModule();

            app.Run();
        }
    }
}
