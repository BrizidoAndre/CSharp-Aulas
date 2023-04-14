// Crie um programa para calcular o IMC de uma pessoa

// Algoritmo
// Entrada: nome, idade, peso, altura
// processamento: peso dividido por altura ao quadrado
// string name = "Carlos";
// Console.WriteLine(name);

// int idade = 36;
// idade = 50;

// const int idade = 36;
// idade = 45;

// Console.WriteLine("A idade do " + name + " é " + idade + " anos");

// float preco = 10.95f;

// bool careca = false;
// Console.WriteLine(careca);

// Operadores

// atribuição =
// int x = 15;

// operadores aritméticos

// soma
// Console.WriteLine(5 + 4);
// Console.WriteLine(5 + "4");
// Console.WriteLine(5 + x);

// subtração
// Console.WriteLine(15 - 3);

// multiplicação
// Console.WriteLine(5 * 5);

// divisão
// Console.WriteLine(10 / 10);

// modular
// Console.WriteLine(5 % 2);


// //operadores de comparação

// //igual a
// Console.WriteLine(5 == 7);

// // maior ou igual a
// Console.WriteLine(5 >= 10);

// //menor ou igual a
// Console.WriteLine(4 <= 10);

// //maior que
// Console.WriteLine(150 > 95);

// //menor que
// Console.WriteLine(54 < 54);

// //diferente de
// Console.WriteLine( 5 != 6);

//operadores lógicos

// && : e
// || : ou 
// ! : não

// Console.WriteLine(5 == 5 && 8 == 8);// TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 5);// TRUE && FALSE = FALSE
// // // Outro exemplo, se 5 é iqual a 5 E 8 é igual a 5 então o valor deve retornar como TRUE
// Console.WriteLine(5 == 6 && 8 == 8);// FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 5);// FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 == 3);// TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 3 == 4);// TRUE || FALSE = TRUE
// Console.WriteLine(2 == 4 || 3 == 3);// FALSE || TRUE = TRUE
// Console.WriteLine(2 == 4 || 3 == 5);// FALSE || FALSE = FALSE

// Console.WriteLine((2 == 4 || 4 == 4) && (7 == 6));

// Console.WriteLine(!(2 == 2 || 3 == 3));

//Crie um programa para calcular o IMC de uma pessoa

//Algoritmo
//entrada: nome, idade, peso, altura
//processamento: peso dividido por altura ao quadrado

//entrada
// string nome = "André";

// int idade = 18;
// float peso = 89;
// float altura = 1.74F;

// //processamento
// float imc = peso / (altura * altura);

// //saida
// Console.WriteLine("O IMC do " + nome + " é de aproximadamente " + Math.Round(imc,2));


Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine($@"
-----------------
[ Programa para  ]
[ calcular IMC   ]
-----------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome}");

Console.WriteLine($"Informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float)Math.Pow(altura,2));

Console.WriteLine($"O IMC de {nome} é de :{imc}");