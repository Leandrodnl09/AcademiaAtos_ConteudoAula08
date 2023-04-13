namespace AcademiaAtos_ConteudoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula 08 -> Vetores;

            int[] vetor = new int[3]; // declaração de vetor;

            int[] vetor1 = new int[] { 1, 2, 3};

            Console.WriteLine("Digite um valor do tamnanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetorN = new int[n]; // tamanho do vetor definido pelo usuario.


            // percorrer dentro do vetor
            for (int i = 0; i < vetorN.Length; i++) // boas praticas
            {
                Console.WriteLine($"Informe um valor para a posição {i + 1}: {i} ");
                vetorN[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorN.Length; i++) // boas praticas
            {
                Console.WriteLine($"Os valores digitatos é: {vetor[i]} "); // escreve o valor de todas as posições do vetor;
            }


        }
    }
}