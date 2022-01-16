using InjecaoDeDependencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// adicionando servicoes no container

//// Descarte - Sim | Varias implementacoes - Sim | Passar argumentos - Nao
//builder.Services.AddScoped<IOperacao, Operacao>();

//// Descarte - Sim | Varias implementacoes - Sim | Passar argumentos - Sim
//builder.Services.AddScoped<IOperacao>(x => new Operacao());

////Descarte - Sim | Varias implementacoes - Nao | Passar argumentos - Nao
//builder.Services.AddSingleton<Operacao>();

//// Descarte - Nao | Varias implementacoes - Sim | Passar argumentos - Sim
//builder.Services.AddSingleton<IOperacao>(new Operacao());

//// Descarte - Nao | Varias implementacoes - Nao | Passar argumentos - Sim
//builder.Services.AddSingleton(new Operacao());

builder.Services.Add(ServiceDescriptor.Describe(typeof(IOperacao), typeof(Operacao), ServiceLifetime.Scoped));

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
