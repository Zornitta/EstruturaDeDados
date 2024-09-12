//As pilhas trabalham com uma estrutura LIFO -> Last In First Out

// Três métodos importantes:

//  Push()  -> Insere um elemento no topo da pilha.
//  POP()   -> Remove um elemento do topo e o retorna.
//  Peek()  -> Retorna o elemento do topo sem removêlo.

//Invertendo as bolas:

Stack<char> caracteres = new Stack<char>();

Console.Write("Escreva o nome: ");
string? nome = Console.ReadLine().ToUpper();

foreach(char c in nome)
{
    caracteres.Push(c);
    
}

//  Desempilhamento:

string invertido = string.Empty;
while(caracteres.Count > 0)
{
   invertido += caracteres.Pop();
}

Console.WriteLine(invertido);

if( invertido == nome)

{
    Console.WriteLine($"Sim, se trata de um PALÍNDROMO o termo citado.");
}

else

Console.WriteLine($"Não, infelizmente o dado termo não se trata de um PALÍNDROMO.");
