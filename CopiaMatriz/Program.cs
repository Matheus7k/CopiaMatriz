internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        int[,] matrizInversa = new int[5,5];

        matriz = populaMatriz(matriz);

        matrizInversa = inverteMatriz(matriz);

        Console.WriteLine($"Matriz original: ");
        imprimeMatriz(matriz);

        Console.WriteLine("----------------------");

        Console.WriteLine($"Matriz invertida: ");
        imprimeMatriz(matrizInversa);

        //Funções
        void imprimeMatriz(int[,] matriz)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write($" | {matriz[linha, coluna]} | ");
                }
                Console.WriteLine();
            }
        }

        int[,] populaMatriz(int[,] matriz)
        {
            Random numero = new();

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    matriz[linha, coluna] = numero.Next(100);
                }
            }

            return matriz;
        }

        int[,] inverteMatriz(int[,] matriz)
        {
            int[,] matrizAux = new int[5,5];

            for(int coluna = 0; coluna < 5; coluna++)
            {
                for(int linha = 0; linha < 5; linha++)
                {
                    matrizAux[4 - linha, 4 - coluna] = matriz[linha, coluna];
                }
            }

            return matrizAux;
        }
    }
}