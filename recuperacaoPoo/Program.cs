using System;

/*Cachorro c = new Cachorro();
Console.WriteLine("informe o nome,peso,idade e" + "raça do cachorro");
c.nome = Console.ReadLine();
c.peso = Convert.ToDouble(Console.ReadLine());
c.idade = Convert.ToInt32(Console.ReadLine());
c.raca = Console.ReadLine();

c.Barulho("auuuuu");

Cachorro c2 = new Cachorro();
c2.nome = "Bob";
c2.peso = 1.5;
c2.idade = 8;
c2.raca = "Pinscher";
c2.Barulho("auauauau");*/


Funcionario fun = new Funcionario();
Console.WriteLine("digita seu: nome,cpf,email,salario");
fun.nome = Console.ReadLine();
fun.cpf = Console.ReadLine();
fun.email = Console.ReadLine();
fun.salarario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( $"digite qual sua profissao:  Medico,TI,Adm");
fun.funcao = Console.ReadLine().ToUpper();

fun.Calcular(fun.salarario) ;
