//JaggedArray é um vetor de vetores.

int[][] numbers = int[4][];

//Neste caso [][] sinaliza um vetor de vetores, neste exemplo um vetor de 4 posições contendo vetores de tamanho indefinido.

numbers[0] = new int[] {1, 2, 3};
numbers[1] = new int[] {4,3,2,1, 0};
numbers[2] = new int[] {1,2, 0};
numbers[3] = new int[] {57};
numbers[4] = null!;

//Obtenção de valor de JaggedArray

int valor = numbers[0][2];
Console.WriteLine(valor);

//Atribuição de valor à JaggedArray:

numbers[1][2] = 0;
Console.WriteLine( numbers[1][2] );

