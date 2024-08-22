




//Declarando Variável.
using Aula01;

int number;

//Atribuindo valor.
number = 10;

//Declarando Constante.
const int DAYS_IN_WEEK =7;

//Imprimindo String Concatenada.
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() -> Invoca o método construtor do objeto.
//Toda classe tem o seu construtor padrão implícito sem argumentos/params.
//É possível sobrescrever este método especificando argumentos.
//Todavia, se o fizermos, perdemos o original implícito e precisaremos
// defini-lo explicitamente.
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish =
    tipoEnum.GetLanguageEnum("inglês");

Console.WriteLine( $"Enum de english é {enumEnglish}" );
