namespace Tamagotchi
{
    internal class Program
    {
        //main
        static void Main(string[] args)
        {
            //instancias
            Random random = new Random();
            Console.WriteLine("Digite um nome para seu tamagotchi: ");
            String nome = Console.ReadLine();
            Tamagotchi tama = new Tamagotchi(nome);

            //atributos
            bool morto = false;
            while (!morto)
            {
                int escolha = random.Next(1, 3);
                Console.WriteLine(tama);
                switch (escolha)
                {
                    case 1:
                        Program.sentirSono(tama);
                        break;
                    case 2:
                        Program.sentirFome(tama);
                        break;
                    case 3:
                        Program.ficarEntediado(tama);
                        break;
                }
                if (tama.idade >= 15)
                {
                    Console.WriteLine("\n" + nome + " morreu de velhice");
                    System.Threading.Thread.Sleep(10000);
                    morto = true;
                }
                else if (tama.quilos >= 20)
                {
                    Console.WriteLine("\n" + nome + " explodiu de tanto comer");
                    System.Threading.Thread.Sleep(10000);
                    morto = true;
                }
                else if (tama.quilos <= 0)
                {
                    Console.WriteLine("\n" + nome + " ficou desnutrido e morreu");
                    System.Threading.Thread.Sleep(10000);
                    morto = true;
                }
            }
            

        }

        //metodos
        static void sentirSono(Tamagotchi tama)
        {
            Console.WriteLine("\nEscolha uma das opções: ");
            Console.WriteLine("\n1) Dormir \n2) Permanecer acordado");
            int escolha = Convert.ToInt32(Console.ReadLine());
            if(tama.sono == 5)
            {
                escolha = 3;
                tama.sono = 0;
            }
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n" + "O " + tama.nome + " domiu");
                    tama.idade += 1;
                    break;
                case 2:
                    Console.WriteLine("\n" + "O " + tama.nome + " permaneceu acordade");
                    tama.sono += 1;
                    break;
                case 3:
                    Console.WriteLine("\n" + "O " + tama.nome + " chegou ao limite e dormiu");
                    tama.idade += 1;
                    break;
            }
        }
        static void sentirFome(Tamagotchi tama)
        {
            Console.WriteLine("\nEscolha uma das opções: ");
            Console.WriteLine("\n1) Comer muito \n2) Comer pouco \n3) Não comer");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n" + "O " + tama.nome + " comeu muito");
                    tama.quilos += 5;
                    break;
                case 2:
                    Console.WriteLine("\n" + "O " + tama.nome + " comeu pouco");
                    tama.quilos += 1;
                    break;
                case 3:
                    Console.WriteLine("\n" + "O " + tama.nome + " não comeu e emagreceu");
                    tama.quilos -= 2;
                    break;
            }
        }
        static void ficarEntediado(Tamagotchi tama)
        {
            Console.WriteLine("\nEscolha uma das opções: ");
            Console.WriteLine("\n1) Correr 10 minutos \n2) Caminhar 10 minutos");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n" + "O " + tama.nome + " correu e comeu muito");
                    tama.quilos += 1;
                    break;
                case 2:
                    Console.WriteLine("\n" + "O " + tama.nome + " caminhou e comeu um pouco");
                    break;
            }
        }
    }
}