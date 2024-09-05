using System.Collections;

//Utilizando a Lista Simples:

ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Mauricio");

//Método .Add() insere o valor ao final do vetor.

arrList.AddRange(new int[] {1,2,3});

//Já o método Insert inclui o valor desejado a posição especificada no primeiro parâmetro.

arrList.Insert(0, 15);

//Lendo valores da Lista

object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

//Percorrendo a Lista com Foreach

foreach(object obj in arrList)
{
    Console.Write($" | {obj}");
}

//Quantos elementos há na lista:

int tamanho = arrList.Count;

//Qual a capacidade da lista:

int capacidade = arrList.Capacity;

//Percorrendo no modo clássico:

for( int i=0; i< arrList.Count; i++ )
{
    Console.Write( $" | {arrList[i]}" );
}

//Recursos Importantes da Lista:

//Verificar valores contidos na lista:

bool contemNome = arrList.Contains("Mauricio");

if(!contemNome)
{
    Console.WriteLine("Nome Mauricio não encontrado");
}

//Verificar índice do valor buscado, caso o valor exista na lista retornará o índice, caso não haja o retorno será -1.

int indiceDoValor = arrList.IndexOf("Mauricio");

if (indiceDoValor >= 0){
    Console.WriteLine(
        $"Mauricio está em [{indiceDoValor}]"
    );
}
else

    Console.WriteLine("Infelizmente de fato não existe isso aí não.");

//Remoção de itens da lista:

arrList.Remove("Mauricio");          //Remoção por valor.
arrList.RemoveAt(4);                 //Remoção por índice.
arrList.RemoveRange(0,2);            //Primeiro Parâmetro = Índice
                                     //Segundo Parâmetro = Número de casas pós-índice.
