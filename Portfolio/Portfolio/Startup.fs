namespace Portfolio

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection

type Startup private () =
    new (configuration: IConfiguration) as this =
        Startup() then
        this.Configuration <- configuration

    // This method gets called by the runtime. Use this method to add services to the container.
    member this.ConfigureServices(services: IServiceCollection) =
        // Add framework services.
        services.AddMvc() |> ignore

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member this.Configure(app: IApplicationBuilder, env: IHostingEnvironment) =
        
        app.UseCors(fun builder -> builder.WithOrigins(this.Configuration.["ClientUrl"]).AllowAnyHeader().AllowAnyMethod() |> ignore) |>  ignore
        app.UseMvc() |> ignore

    member val Configuration : IConfiguration = null with get, set