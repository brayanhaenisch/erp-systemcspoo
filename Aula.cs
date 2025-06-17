/*Console.WriteLine("Hello, World!");

int idade = 33;
Console.WriteLine(idade);
string nome = "Brayan";
Console.WriteLine(nome);
decimal valor = 299.33m;
double valorDouble = 299.33;
float valorFloat = 299.33f;

Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);

var idadeNova = 34;

char flag = 'Y';

Console.WriteLine(flag);
bool ativo = false;
Console.WriteLine(ativo);


const string descricao = "Bem-vindo ao Brayan ERP";
descricao = "Salve"
Console.WriteLine(descricao);
*/

/*
var soma = numero1 + numero2;
Console.WriteLine(soma);


int divisao = numero1 - numero2;
Console.WriteLine(divisao);


int multiplicacao = (numero1 * numero2) * 10;
Console.WriteLine(multiplicacao);
*/
/*
bool ativo = true;

string valida = ativo ? "Está ativo!" : "Está inativo!";

Console.WriteLine(valida);*/



/*
EscreverNome();


void EscreverNome()
{
    var nome = NomeCompleto();
    var soma = SomaValores();

    Console.WriteLine(nome);
    Console.WriteLine(soma);
}

string NomeCompleto()
{
    var primeiroNome = "Brayan";
    var segundoNome = "Haenisch";
    return primeiroNome + " " + segundoNome;

}

int SomaValores()
{
    return 8 + 2;
}



var soma = SomaValores(1, 2);

Console.WriteLine(soma);

int SomaValores(int a, int b)
{
    return a + b;
}




var pessoa = NomeEIdade("Brayan", 24);

Console.WriteLine(pessoa);

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos.";
}




using System.Collections;

var arrayList = new ArrayList();
arrayList.Add("Brayan");
arrayList.Add(1);
arrayList.Add(true);

arrayList.Clear();

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}



//var arrayTipado = new int[3] { 1, 2, 3 };
using System.Runtime.CompilerServices;

var arrayTipado = new int[3];
arrayTipado[0] = 1;
arrayTipado[1] = 2;
arrayTipado[2] = 3;

//Array.Resize(ref arrayTipado, 100);

//arrayTipado[10] = 4;

foreach (var item in arrayTipado)
{
    if (item == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(item);
    }
}

var arrayTipadoString = new string[2];


Array.Resize(ref arrayTipadoString, 100);

arrayTipadoString[1] = "Brayan";
arrayTipadoString[15] = "Henrique";
arrayTipadoString[65] = "Haenisch";


foreach (var item in arrayTipadoString)
{
    if (string.IsNullOrEmpty(item))
    {
        continue;
    }
    else
    {
        Console.WriteLine(item);
    }
}


var lista = new List<string>(10)
{
    "Brayan",
    "Henrique",
    "Haenisch"
};


foreach (var item in lista)
{
    Console.WriteLine(item);
}

var queue = new Queue<string>();

queue.Enqueue("Brayan");
queue.Enqueue("Haenisch");

var nome = queue.Peek();


Console.WriteLine(nome);

queue.Dequeue();

var nome1 = queue.Peek();

Console.WriteLine(nome1);
*/
