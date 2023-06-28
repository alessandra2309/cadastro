public class Funcionario
{

    public string nome;
    public string cpf;
    public string email;
    public double salarario;
    public string funcao;

    public void Calcular(double salarario)
    {
        if (funcao == "MEDICO")
        {
            double conta = salarario * 0.20;
            double conta2 = conta + salarario;

            Console.WriteLine($"seu salario e:{conta2}");
        }
        else if (funcao == "TI")
        { 
            double conta3 = salarario + 5600;

            Console.WriteLine($"seu salario e de: {conta3}");
        }
        else if (funcao == "ADM")
        {
            double conta4 = salarario * 0.15;
            double conta5 = conta4 + salarario;
            Console.WriteLine($"seu salario e de: {conta5}");
        }

       
    }
}