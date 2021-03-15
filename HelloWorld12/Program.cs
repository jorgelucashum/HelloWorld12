using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld12
{
    class Program
    {
        // É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras e que o mantenha em um estado consistente.
        // - O objeto deve sempre estar em um estado consistente, e a própria classe deve garantir isso.
        // - Todo atributo é definido como private.
        // - Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio.
        // - Não é usual na plataforma C#
        static void Main(string[] args)
        {
            Produto p1 = new Produto("TV", 500.00, 10);
            // p1._nome = "TV 4K"; // não é mais possivel alterar/definir o valor do '_nome' dessa forma na classe Produto porque o atributo está privado.
            p1.SetNome("TV 4K"); // agora para alterar será que chamar o método 'SetNome();'

            // Console.WriteLine(p1._nome); // não é mais possível trazer/obter a variável dessa forma pois ela está privada.
            Console.WriteLine(p1.GetNome()); // agora para chama-la foi necessário usar o método 'GetNome()' criado na classe produto.

            Console.WriteLine(p1.GetPreco());
            Console.WriteLine(p1.GetQuantidade());

            Console.ReadLine();

        }
    }
}
