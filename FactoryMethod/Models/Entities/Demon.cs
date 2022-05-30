using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.Entities
{
    class Demon : EnemyEntity
    {
        public void attack()
        {
            Console.WriteLine("El demonio ataca con su hacha");
        }
    }
}
