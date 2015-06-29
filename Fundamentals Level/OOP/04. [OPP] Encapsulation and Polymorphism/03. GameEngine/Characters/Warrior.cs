using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Enumerations;
using TheSlum.Interfaces;
using TheSlum.Items;

namespace TheSlum.Characters
{
    public class Warrior : Character, IAttack
    {
        private const int DefaultHealthPoints = 200;
        private const int DefaultDefensePoints = 100;
        private const int DefaultAttackPoints = 150;
        private const int DefaultRange = 2;

        public Warrior(string id, int x, int y, Team team, 
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
            return targetsList.First(target => this.Team != target.Team && target.IsAlive);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);

            if (item is Injection)
            {
                this.HealthPoints += item.HealthEffect;
            }
            else if (item is Pill)
            {
                this.AttackPoints += item.AttackEffect;
            }
        }

        public override void RemoveFromInventory(Item item)
        {
            if (item is Axe)
            {
                this.AttackPoints += item.AttackEffect;
            }
            else if (item is Shield)
            {
                this.DefensePoints += item.DefenseEffect;
            }
            else if (item is Injection && this.IsAlive == false)
            {
                this.HealthPoints = 1;
                this.IsAlive = true;
            }
            else if (item is Pill)
            {
                this.AttackPoints -= item.AttackEffect;
            }
            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Team: {1}, Health: {2}, Defense: {3}, Attack {4}",
                this.ID, this.Team, this.HealthPoints, this.DefensePoints, this.AttackPoints);
        }
    }
}
