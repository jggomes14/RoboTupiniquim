internal class Program
{
    static void Main(string[] args)
    {
        string[] entradasComandos = new string[2];
        string[] entradasPosicoes = new string[2];

        Console.Write("Digite o tamanho da área: ");
        string area = Console.ReadLine();

        Console.Write("Informe a localição do robô 01: ");
        entradasPosicoes[0] = Console.ReadLine(); //1 2 N

        Console.Write("Informe o comando do robô 01: ");
        entradasComandos[0] = Console.ReadLine();

        Console.Write("Informe a localição do robô 02: ");
        entradasPosicoes[1] = Console.ReadLine(); //3 3 L

        Console.Write("Informe o comando do robô 02: ");
        entradasComandos[1] = Console.ReadLine();

        for (int i = 0; i < entradasComandos.Length; i++)
        {
            string[] entradaRobo = entradasPosicoes[i].Split(" ");

            int GradeX = Convert.ToInt32(entradaRobo[0]);
            int GradeY = Convert.ToInt32(entradaRobo[1]);

            char direcao = Convert.ToChar(entradaRobo[2]);

            string comando = entradasComandos[i];

            char[] instrucoes = comando.ToCharArray();

            for (int j = 0; j < instrucoes.Length; j++)
            {
                if (instrucoes[j] == 'M')
                {
                    if (direcao == 'N')
                        GradeY = GradeY + 1;

                    if (direcao == 'O')
                        GradeX = GradeX - 1;

                    if (direcao == 'S')
                        GradeY = GradeY - 1;

                    if (direcao == 'L')
                        GradeX = GradeX + 1;
                }
                else if (instrucoes[j] == 'E')
                {
                    if (direcao == 'N')
                        direcao = 'O';
                    else if (direcao == 'O')
                        direcao = 'S';
                    else if (direcao == 'S')
                        direcao = 'L';
                    else if (direcao == 'L')
                        direcao = 'N';
                }
                else if (instrucoes[j] == 'D')
                {
                    switch (direcao)
                    {
                        case 'N':
                            direcao = 'L';
                            break;
                        case 'O':
                            direcao = 'N';
                            break;
                        case 'S':
                            direcao = 'O';
                            break;
                        case 'L':
                            direcao = 'S';
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(GradeX + " " + GradeY + " " + direcao);
        }

        Console.ReadLine();
    }
}
