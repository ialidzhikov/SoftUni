using System;
using TheSlum.Interfaces;
using TheSlum.Enumerations;
using TheSlum.Items;
using System.Collections.Generic;
using System.Linq;

namespace TheSlum.Characters
{
    public class Mage : Character, IAttack
    {
        private const int DefaultHealthPoints = 150;
        private const int DefaultDefensePoints = 50;
        private const int DefaultAttackPoints = 300;
        private const int DefaultRange = 5;

        public Mage(string id, int x, int y, Team team, 
            int healthPoints = DefaultHealthPoints, int attackPoints = DefaultAttackPoints,
            int defensePoints = DefaultDefensePoints, int range = DefaultRange)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            if (targetsList.Count(target => this.Team != target.Team && target.IsAlive) == 0)
            {
                return null;
            }
            return targetsList.Last(target => this.Team != target.Team && target.IsAlive);
        }

        public override void AddToInventory(Item item)
        {
            if (item is Axe)
            {
                this.AttackPoints += item.AttackEffect;
            }
            else if (item is Shield)
            {
                this.DefensePoints += item.DefenseEffect;
            }
            else if (item is Injection)
            {
                this.HealthPoints += item.HealthEffect;
            }
            else if (item is Pill)
            {
                this.AttackPoints += item.AttackEffect;
            }
            
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);

            if (item is Injection)
            {
                this.HealthPoints -= item.HealthEffect;
                if (this.HealthPoints <= 0)
                {
                    this.HealthPoints = 1;
                }
            }
            else if (item is Pill)
            {
                this.AttackPoints -= item.AttackEffect;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Team: {1}, Health:{2}, Defense: {3}, Attack: {4}",
                this.ID, this.Team, this.HealthPoints, this.DefensePoints, this.AttackPoints);
        }
    }
}
