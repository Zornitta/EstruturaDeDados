
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.X86;
using ListaLivros;

List<Book> book = new List<Book>();


for(int i=0; i<5; i++)
{
  Console.WriteLine(
    $"Insira o nome dos livros: "
);


  string? nome = Console.ReadLine();
  
  Console.WriteLine(
    $"Insira o nome da Editora do livro: "
  );
  
  string? editora = Console.ReadLine();

  Console.WriteLine(
    $"Insira o nome do autor do livro: "
  );

  string? autor = Console.ReadLine();

  Console.WriteLine(
    $"Insira quantas páginas o livro possuí: "
  );

   int? paginas = Convert.ToInt32(Console.ReadLine());

book.Add(new Book(){

    Nome = nome,
    Editora = editora,
    Autor = autor,
    Paginas = paginas,
    }
);
}

int maximo_paginas;

for(int i=0; i<5; i++)
{
   if(maximo_paginas < )
   {
    maximo_paginas = ;
   }
}