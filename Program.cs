using RPG_de_dois_personagens;
internal class Program
{
    private static void Main(string[] args)
    {
        Personagens p1 = new Personagens();
        Personagens p2 = new Personagens();

        char escolhaAtaque;
        char escolhaDefesa;

        Console.WriteLine($"Digite o nome do primeiro personagem:");
        p1.nome = Console.ReadLine();

        Console.WriteLine($"Digite a idade do primeiro personagem:");
        p1.idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o nome da armadura do primeiro personagem:");
        p1.nomeArmadura = Console.ReadLine();

        Console.WriteLine($"Digite o nome da I.A do primeiro personagem:");
        p1.ia = Console.ReadLine();
        Console.Clear();



        Console.WriteLine($"Digite o nome do segundo personagem:");
        p2.nome = Console.ReadLine();

        Console.WriteLine($"Digite a idade do segundo personagem:");
        p2.idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o nome da armadura do segundo personagem:");
        p2.nomeArmadura = Console.ReadLine();

        Console.WriteLine($"Digite o nome da I.A do segundo personagem:");
        p2.ia = Console.ReadLine();
        Console.Clear();


        Console.WriteLine($"============================");
        Console.WriteLine
        (@$" 
        Primeiro Personagem:
        Nome: {p1.nome}
        Idade: {p1.idade}
        Armadura: {p1.nomeArmadura}
        IA: {p1.ia}
        ");

        Console.WriteLine($"============================");
        

        Console.WriteLine
        (@$"
        Segundo personagem:
        Nome: {p2.nome}
        Idade: {p2.idade}
        Armadura: {p2.nomeArmadura}
        IA: {p2.ia}
        ");
        Console.WriteLine($"============================");


        Console.WriteLine($"Aperte (Enter) para confirmar:");
        Console.ReadLine();

        for (int i = 0; i < 2; i++)
        {

            //Ataque p1 e defesa p2
            Console.WriteLine($"Vez do personagem {p1.nome} atacar!\nDigite qual opcao deseja:");
            Console.WriteLine
            (@$"
            [1] - Ataque de energia;
            [2] - Ataque com soco.
            ");
            escolhaAtaque = char.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Vez do personagem {p2.nome} Defender!\nDigite qual opcao deseja:");
            Console.WriteLine
            (@$"
            [1] - Defender ataque de energia;
            [2] - Defender ataque com soco;
            [3] - Usar restauracao de armadura.
            ");
            escolhaDefesa = char.Parse(Console.ReadLine());
            Console.Clear();

            switch (escolhaAtaque)
            {
                case '1':
                    p1.P1AtacarEnergia();
                    break;

                case '2':
                    p1.P1AtacarSoco();
                    break;

                default:
                    while (escolhaAtaque != '1' && escolhaAtaque != '2')
                    {
                        Console.WriteLine($"Opcao nao encontrada, Digite novamente:");
                        Console.WriteLine
                        (@$"
                        [1] - Ataque de energia;
                        [2] - Ataque com soco.
                        ");
                        
                        escolhaAtaque = char.Parse(Console.ReadLine());
                    }
                    break;
            }

            switch (escolhaDefesa)
            {
                case '1':
                    p2.P2DefenderEnergia();
                    break;

                case '2':
                    p2.P2DefenderSoco();
                    ;
                    break;

                case '3':
                    p2.RestaurarArmadura();
                    ;
                    break;

                default:
                    while (escolhaAtaque != '1' && escolhaAtaque != '2' && escolhaAtaque != '3')
                    {
                        Console.WriteLine($"Opcao nao encontrada, Digite novamente:");
                        Console.WriteLine
                        (@$"
                        [1] - Defender ataque de energia;
                        [2] - Defender ataque com soco;
                        [3] - Usar restauracao de armadura.
                        ");
                        
                        escolhaDefesa = char.Parse(Console.ReadLine());
                    }                
                    break;
                }
                
                    
                    //Fim ataque p1 e defesa p2


            
            
            

        }
    }
}