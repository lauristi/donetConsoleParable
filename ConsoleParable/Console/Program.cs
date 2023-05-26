using ConsoleApp.Business;

// Definindo os delegates

public delegate int OperationDelegate(int a, int b);
public delegate int LambdaDelegate(int x, int y);

class Program
{
    static void Main(string[] args)
    {

        //-----------------------------------------------------------------
        //Delegate instanciado
        //-----------------------------------------------------------------

        // Criando uma instância do delegate OperationDelegate
        // e associando ao método Add da classe Calculator
         OperationDelegate operation = new OperationDelegate(new Calculator().Add);

        // Invocando o delegate como se fosse um método
        int result = operation(5, 3);
        Console.WriteLine("Resultado: " + result); // Saída: Resultado: 8

        // Alterando a associação do delegate para o método
        // Subtract da classe Calculator
        operation = new OperationDelegate(new Calculator().Subtract);

        result = operation(5, 3);
        Console.WriteLine("Resultado: " + result); // Saída: Resultado: 2
        
        //-----------------------------------------------------------------
        //Delegate generico  com tipo interno Func (out,in,in)
        //-----------------------------------------------------------------
        Func<int, int, int> multiplicationDelegate = (x, y) => x * y;

        result = multiplicationDelegate(5, 3); 
        Console.WriteLine("Resultado: " + result); // Saída: Resultado: 15

        //-----------------------------------------------------------------
        //Delegate Lambda
        //-----------------------------------------------------------------

        LambdaDelegate lambdaDelegate = (x, y) => x / y;
        
        result = lambdaDelegate(10, 2); // Saída: Resultado: 5
        Console.WriteLine("Resultado: " + result); // Saída: Resultado: 5

        //-----------------------------------------------------------------
        //Action
        //-----------------------------------------------------------------

        Action<int, string> minhaAction = (numero, texto) =>
        {
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Texto: " + texto);
        };

        minhaAction(10, "Olá, mundo!");



    }
}