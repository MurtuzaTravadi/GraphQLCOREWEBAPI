using GraphiQl;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using GraphQLWEBAPI.Interface;
using GraphQLWEBAPI.Model;
using GraphQLWEBAPI.Model.GraphQL;
using GraphQLWEBAPI.Model.GraphQLQuery;
using GraphQLWEBAPI.Repository;
using GraphQLWEBAPI.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLWEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(_ => new
            FuncDependencyResolver(_.GetRequiredService));
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddScoped<IDocumentWriter, DocumentWriter>();
            services.AddScoped<ToDoService>();
            services.AddScoped<AuthorService>();
            services.AddScoped<TodoRepository>();
            services.AddScoped<AuthorRepository>();
            services.AddScoped<ToDoQuery>();
            services.AddScoped<AuthorQuery>();
            services.AddScoped<TodoGraphType>();
            services.AddScoped<AuthorType>();
            services.AddScoped<BlogPostType>();
            services.AddScoped<ISchema, GraphQLDemoSchema>();
            services.AddControllers(options => options.EnableEndpointRouting = false);

            services.AddDbContext<TODOContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("ToDo")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphiQl("/graphql");
            app.UseMvc();
        }
    }
}
