
        var builder = WebApplication.CreateBuilder(args);


        var app = builder.Build();

        app.UseHttpsRedirection();

        app.MapGet("/hello", () =>
        {
            return "Get Method :hello";
        });


        app.Run();
