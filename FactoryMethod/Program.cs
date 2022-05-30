using FactoryMethod.Interfaces;
using FactoryMethod.Models.Factories;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EnemyEntity> enemies = new List<EnemyEntity>();

            EnemyFactory demonFactory = new EnemyFactoryDemon();

            for(int x = 0; x < 10; x++)
            {
                enemies.Add(demonFactory.createEnemy());
            }

            foreach (EnemyEntity enemy in enemies)
            {
                enemy.attack();
            }
            
        }
    }
}
