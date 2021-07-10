using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes
{
    abstract class HeroFactory
    {
      
        public abstract Weapon CreateWeapon();
    }
    abstract class Weapon
    {
        public  int hp=100;
        public int damage;
        public abstract int Hit();
        public abstract int Heal();
    }
    class Sword : Weapon
    {
       
        public override int Hit()
        {
            Random r = new Random();

            damage = r.Next(-12,-1);
            Console.WriteLine("Sword attack");
            return damage;
        }
        public override int Heal()
        {
            Random r = new Random();

            damage = r.Next(1, 6);
            return damage;
        }
    }
    class Spear : Weapon
    {
        public override int Hit()
        {
            Random r = new Random();

            damage = r.Next(-9, -2);

            Console.WriteLine("Spear attack");
            return damage;
        }
        public override int Heal()
        {
            Random r = new Random();

            damage = r.Next(2, 7);
            return damage;
        }
    }
    class Bow : Weapon
    {
        public override int Hit()
        {
            Random r = new Random();

            damage = r.Next(-15, -3);
            Console.WriteLine("Bow shot");
            return damage;
        }
        public override int Heal()
        {
            Random r = new Random();

            damage = r.Next(3, 12);
            return damage;
        }
    }
    class Staff : Weapon
    {
        public override int Hit()
        {
            Random r = new Random();

            damage = r.Next(-18, -3);
            Console.WriteLine("Staff shot");
            return damage;
        }
        public override int Heal()
        {
            Random r = new Random();

            damage = r.Next(2, 15);
            Console.WriteLine("Staff healing");
            return damage;
        }
    }

    class SwordFactory : HeroFactory
    {
       

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
    class SpearFactory : HeroFactory
    {


        public override Weapon CreateWeapon()
        {
            return new Spear();
        }
    }
    class BowFactory : HeroFactory
    {


        public override Weapon CreateWeapon()
        {
            return new Bow();
        }
    }
    class StaffFactory : HeroFactory
    {


        public override Weapon CreateWeapon()
        {
            return new Staff();
        }
    }
    
    class Hero
    {
        public Weapon weapon;
        public int HP { get; set; }
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            HP = 100;
        }
        public int Hit()
        {
            
           return weapon.Hit();
        }
        public int Heal()
        {
            
            return  weapon.Heal();
        }
    }
}
