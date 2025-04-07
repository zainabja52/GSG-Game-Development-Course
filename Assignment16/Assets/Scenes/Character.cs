using UnityEngine;

namespace Assignment18
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) {}

        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}, Health: {Health}");
            position.PrintPosition();
        }

        private void ApplyDamage(int damage, Character target)
        {
            target.Health -= damage;
        }

        public void Attack(int damage, Character target)
        {
            ApplyDamage(damage, target);
        }

        public void Attack(int damage, Character target, string attackType)
        {
            ApplyDamage(damage, target);
            Debug.Log($"Attack Type: {attackType}");
        }
    }
}
