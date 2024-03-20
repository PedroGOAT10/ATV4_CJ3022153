namespace ATV4_CJ3022153
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float n1, n2, op;

            Console.WriteLine("Digite o número de n1: ");
            n1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o número de n2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero das operaçãoes : 1 - multiplicação, 2 - divisão, 3 - soma, 4 - subtração");
            op = float.Parse(Console.ReadLine());


            switch (op) { 





            case 1:
                    Console.WriteLine("multiplicação = {0}", n1 * n2); 
                break;

            case 2:
                    Console.WriteLine("divisão = {0}", n1 / n2);
                break;

            case 3:
                Console.WriteLine("soma = {0}", n1 + n2);
                break;

            case 4:
                    Console.WriteLine("subtração = {0}", n1 - n2);
                break;


            default:
                Console.WriteLine("opçao inválida");
                break;

            }
        }
    }
}
