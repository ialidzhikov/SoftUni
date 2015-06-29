using System;
using TheSlum.Characters;
using TheSlum.Interfaces;
using TheSlum.Enumerations;
using TheSlum.Items;
using System.Collections.Generic;
using System.Linq;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        private const int DefaultHealthPoints = 75;
        private const int DefaultDefensePoints = 50;
        private const int DefaultHealingPoints = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team, 
            int healthPoints = DefaultHealthPoints, int healingPoints = DefaultHealingPoints,
            int defensePoints = DefaultDefensePoints, int range = DefaultRange)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targetsListTeammates = targetsList.Where(target => this.Team.Equals(target.Team) && this != target).ToList();
            if (!targetsListTeammates.Any())
            {
                return null;
            }

            var targetWithLeastHealth = targetsListTeammates.First();
            foreach (Character character in targetsListTeammates)
            {
                if (targetWithLeastHealth.HealthPoints > character.HealthPoints)
                {
                    targetWithLeastHealth = character;
                }
            }
            return targetWithLeastHealth;
        }

        public override void AddToInventory(Item item)
        {
            if (item is Shield)
            {
                this.DefensePoints += item.DefenseEffect;
            }
            if (item is Injection)
            {
                this.HealthPoints += item.HealthEffect;
            }
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);

            if (item is Injection && this.IsAlive == false)
            {
                this.HealthPoints = 1;
                this.IsAlive = true;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Team: {1}, Health:{2}, Defense: {3}, Healing: {4}",
                this.ID, this.Team, this.HealthPoints, this.DefensePoints, this.HealingPoints);
        }
    }
}
