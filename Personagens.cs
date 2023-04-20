using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_de_dois_personagens
{
    public class Personagens
    {
        //propriedades:
        public string nome;

        public int idade;

        public string armadura;

        public string ia;

        //Metodos:
        public void P1AtacarEnergia()
        {
            Console.WriteLine($"O {nome} atacou com energia");
        }

        public void P1AtacarSoco()
        {
            Console.WriteLine($"O personagem atacou com um poderoso soco");
        }
        public void P2AtacarCabecada()
        {
            Console.WriteLine($"O personagem atacou com cabecada");
        }
       
        public void P2AtacarChute()
        {
            Console.WriteLine($"O {nome} atacou com chute");
        }
        public string P2DefenderEnergia()
        {
            return "O personagem defendeu energia!";
        }
        public string P2DefenderSoco()
        {
            return "O personagem defendeu chute!";
        }

        public string P1DefenderCabecada()
        {
            return "O personagem defendeu a cabecada";
        }

        public string P1DefenderChute()
        {
            return "O personagem defendeu o ataque chute";
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura!");
            
        }
    }
}