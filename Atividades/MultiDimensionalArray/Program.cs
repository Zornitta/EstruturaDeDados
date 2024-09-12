//Criando um vetor multidimensional com 5 linhas e 2 colunas:

using System.Diagnostics.Contracts;

int[,] numbers = int[5,2];

//Criando um vetor tridimensional.

int[,,] triNumbers = int [5,4,3];

//Podemos inicializar os valores do vetor no momento de sua declaração!

int[,] iniNumbers = int [,]
{
    {9,5,-9},
    {92,54,-79},
    {29,15,-92},
    {94,53,-90},
    {59,51,-19},
};

//Para acessar os valores contidos neste tipo de variável:

int valor = iniNumbers[0,1];    // [0,1] = 5

Console.WriteLine( $"iniNumbers[0,1] = {valor}" );

int  maior;

for(int i=0;i<15;i++)
{
    iniNumbers= 
}

Console.WriteLine( $"O maior número é = {maior}" );
