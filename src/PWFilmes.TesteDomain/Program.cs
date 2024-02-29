// See https://aka.ms/new-console-template for more information
using PWFilmes.Domain.Entities;


var categoria01 = new Categoria("Suspense");
Console.WriteLine(categoria01.Id);
Console.WriteLine(categoria01.Descricao);

Console.WriteLine();
Console.WriteLine();

var categoria02 = new Categoria("Comédia");
Console.WriteLine(categoria02.Id);
Console.WriteLine(categoria02.Descricao);
