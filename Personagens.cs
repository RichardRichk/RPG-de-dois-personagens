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

        public int armadura = 100;

        public string nomeArmadura;

        public string ia;

        //Metodos:
        public void P1AtacarEnergia()
        {
            Console.WriteLine($"O {nome} atacou com energia");

            armadura = (armadura - 22);
        }

        public void P1AtacarSoco()
        {
            Console.WriteLine($"O {nome} atacou com um poderoso soco");
        }
        public void P2AtacarCabecada()
        {
            Console.WriteLine($"O {nome} atacou com cabecada");
        }
       
        public void P2AtacarChute()
        {
            Console.WriteLine($"O {nome} atacou com chute");
        }
        public void P2DefenderEnergia()
        {
            Console.WriteLine($"O {nome} defendeu energia!");
        }
        public void P2DefenderSoco()
        {
            Console.WriteLine($"O {nome} defendeu soco!");
            
        }

        public void P1DefenderCabecada()
        {
            Console.WriteLine($"O {nome} defendeu a cabecada");
        }

        public void P1DefenderChute()
        {
            Console.WriteLine($"O {nome} defendeu o ataque chute");
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O {nome} restaurou a armadura!");           
        }
    }
}