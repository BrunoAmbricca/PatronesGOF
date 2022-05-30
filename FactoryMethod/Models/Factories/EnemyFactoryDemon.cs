using FactoryMethod.Interfaces;
using FactoryMethod.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models.Factories
{
    class EnemyFactoryDemon : EnemyFactory
    {
        public EnemyEntity createEnemy()
        {
            return new Demon();
        }
    }
}
