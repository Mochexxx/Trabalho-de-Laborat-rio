using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Adiciona serviços ao contêiner
        services.AddControllersWithViews();
        // Adicione outros serviços, como DbContext, se necessário
        // services.AddDbContext<YourDbContext>(options => ...);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Página de erro para desenvolvimento
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); // Página de erro para produção
            app.UseHsts(); // HSTS para maior segurança
        }

        app.UseHttpsRedirection(); // Redireciona para HTTPS
        app.UseStaticFiles(); // Permite arquivos estáticos

        app.UseRouting(); // Habilita o roteamento

        app.UseAuthorization(); // Habilita autorização

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); // Roteamento padrão
        });
    }
}
