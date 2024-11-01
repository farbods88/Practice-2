

class Player
{
    public string Name;
    public int Health;
    public int Stamina;
    public double Level;

    public void TakeDamage (int damage)
    {
        Health = Health - damage;
        if ( Health == 0) 
        {
            Console.WriteLine ("Died");
        }
        else
        {
            Console.WriteLine (Name + " took " + damage + " damage." + " Health is now : " + Health);
        }
        
    }

    public double Levelup (double xp)
    {
        Level = Level + (xp / 100);
        Console.WriteLine (Name + " Leveled up!" + "Current level : " + Level);
        return Level;
    }

}

class Weapon 
{
    public string Name;
    public int Ammo;
    public int MaxAmmo;
    public int Damage;
    public int Augments;

    public void Fire ()
    {
        if (MaxAmmo >= 1 && Ammo >= 1)
        {
            MaxAmmo--;
            Console.WriteLine ("Shot fired! " + "Remaining ammo : " + MaxAmmo);
        }

        else 
        {
            Console.WriteLine ("No more ammo left.");
        }
    }

    public void Reload()
    {
        for (int i = MaxAmmo; i < 7; i++)
        {
            Ammo--;
            MaxAmmo++;
            Console.WriteLine ("Weapon reloading : " + MaxAmmo + ". Ammo left : " + Ammo);
        }
    }

    public void ModifyWeapon (int augmentLevel)
    {
        if (augmentLevel == 1 && Augments > 0)
        {
            Augments--;
            Console.WriteLine ("Weapon rarity = Common. Remaining augments :" + Augments );
        }

        else if  (augmentLevel == 2 && Augments - augmentLevel > 0)
        {
            Augments = Augments - 2;
            Console.WriteLine ("Weapon rarity = Rare. Remaining augments : " + Augments);
        }
        else if  (augmentLevel >= 3 && Augments - augmentLevel > 0)
        {
            Augments = Augments - 3;
            Console.WriteLine ("Weapon rarity = Legendary. Remaining augments : " + Augments);
        }
        else 
        {
            Console.WriteLine("Not enough augments.");
        }
    }

}

class HealthBoost
{
    public int AvailableAmount;

    public void ApplyMod (int rarity)
    {
        if (AvailableAmount > 0 && rarity == 1)
        {
            AvailableAmount--;
            Console.WriteLine("Normal PulseCharge used. Remaining amount : " + AvailableAmount);
        }
        else if (AvailableAmount > 0 && rarity == 2)
        {
            AvailableAmount--;
            Console.WriteLine("Charged PulseCharge used. Remaining amount : " + AvailableAmount);
        }
        else 
        {
            Console.WriteLine("No PulseCharges available.");
        }
    }



}




class Program 
{
     static void Main(string[] args)
    {
        Player denzel = new Player{Name = "Denzel Fenix", Health = 100, Stamina = 100, Level = 1};
        Weapon serpent = new Weapon{Name = "Nebula Serpent", Ammo = 10, MaxAmmo = 7, Damage = 15, Augments = 2};
        HealthBoost pulse = new HealthBoost{AvailableAmount = 2};
        //Change values for different outcomes.
        denzel.TakeDamage(10);
        denzel.Levelup (90);
        serpent.Fire();
        serpent.Fire();
        serpent.Fire();
        serpent.Fire();
        serpent.Fire();
        serpent.Fire();
        serpent.Fire();
        serpent.Fire();
        serpent.Reload();
        serpent.ModifyWeapon(4);
        pulse.ApplyMod(2);
    }
}
