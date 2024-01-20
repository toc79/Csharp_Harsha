using System.Threading;
using static System.Net.Mime.MediaTypeNames;

abstract class Character
{
	//fields
	//private string _name;
	//private int _helth;
	//private int _attack;
	//private int _defense;

	//properties
	public string Name { get; set; }
	public int Helth { get; set; }
	public int attack {  get; set; }
	public int Defense { get; set; }

	//constructor
	public Character(string name, int helth, int attack, int defense)
	{
		// ovo baš nije točno treba this._name i onda napraviti normal promerti (a ne auto-property
		this.Name = name;
		this.Helth = helth;
		this.attack = attack;
		this.Defense = defense;
	}

	public virtual void Attack(Character target)
	{
		int demage = 0;
		if (this.attack > 0) { 
			demage = this.attack - target.Defense; 
		}

		if (demage > 0) {
			target.Helth = target.Helth - demage;
			System.Console.WriteLine("Demage for " +target.Name +" is " + demage + ". Helth is now " + target.Helth);
		} else
		{
			System.Console.WriteLine("Demage for " + target.Name + " is " + demage + " (less or equal to 0). Helth is " + target.Helth);
		}
	}

	public virtual void Defend()
	{
		System.Console.WriteLine("Charachter " +Name +" is defending.");
	}

}


class Warrior : Character 
{
	//constructor
	public Warrior(string name, int helth, int attack, int defense) : base( name, helth, attack, defense)
	{
		
	}

	public void Charge(Character target)
	{

	}

	public override void Defend()
	{
		Defense = 5;
	}

}

class Mage : Character
{
	public Mage(string name, int helth, int attack, int defense) : base(name, helth, attack, defense)
	{

	}

	public void CastSpell(Character target)
	{

	}

}


class Dragon : Character
{
	public Dragon(string name, int helth, int attack, int defense) : base(name, helth, attack, defense)
	{

	}

	public void BreatheFire(Character target)
	{
		int demage = 0;
		if (this.attack > 0)
		{
			demage = this.attack - target.Defense;
		}
		System.Console.WriteLine(this.Name + " breather fire on " + target.Name + " for " + demage +" demage.\n");
	}

	public new void Attack(Character target)
	{
		base.Attack(target);
		base.Attack(target);
	}

	public sealed override void Defend()
	{
		this.Defense = this.Defense + 10;
	}

}

class Game
{
	static void Main()
	{
		//the messages are not exactly like in assigment

		Warrior arthur = new Warrior("Arthur", 100, 15, 0);
		Mage merlin = new Mage("Merlin", 100, 20, 0);
		Dragon smaug = new Dragon("Smaug", 100, 25, 0);

		System.Console.WriteLine(arthur.Name + " is a warrior.");
		System.Console.WriteLine(merlin.Name + " is a mage.");
		System.Console.WriteLine(smaug.Name + " is a dragon.");
		System.Console.WriteLine("");

		Warrior warior1 = new Warrior("Arthur", 100, 15, 0);
		Dragon dragon1 = new Dragon("Smaug", 100, 110, 0);
		dragon1.BreatheFire(warior1);


		dragon1.Defend();
		System.Console.WriteLine(dragon1.Name +" defends and gains " +dragon1.Defense +" defense.");
		System.Console.WriteLine("");


		System.Console.WriteLine("--- Battle between Arthur and Merlin ---");
		while (arthur.Helth > 0 && merlin.Helth > 0)
		{
			System.Console.WriteLine("Arthur attacks Merlin for " + arthur.attack + " damage!");
			arthur.Attack(merlin);
			System.Console.WriteLine("Merlin attacks Arthur for " + merlin.attack + " damage!");
			merlin.Attack(arthur);
		}
		if (arthur.Helth > merlin.Helth)
		{
			System.Console.WriteLine("Arthur wins!");
		}
		else
		{
			System.Console.WriteLine("Merlin wins!");
		}

		System.Console.WriteLine("");

		
		System.Console.WriteLine("--- Battle between Merlin and Smaug ---");
		Mage merlin2 = new Mage("Merlin", 100, 20, 0);
		Dragon smaug2 = new Dragon("Smaug", 100, 25, 0);

		while (merlin2.Helth > 0 && smaug2.Helth > 0)
		{
			System.Console.WriteLine(merlin2.Name + " attacks " + smaug2.Name + " for " + merlin2.attack + " damage!");
			merlin2.Attack(smaug2);
			System.Console.WriteLine(smaug2.Name + " attacks " + merlin2.Name + " for " + smaug2.attack + " damage!");
			smaug2.Attack(merlin2);
		}
		if (merlin2.Helth > smaug.Helth)
		{
			System.Console.WriteLine(merlin2.Name + " wins!");
		}
		else
		{
			System.Console.WriteLine(smaug2.Name + " wins!");
		}

		System.Console.WriteLine("");



		System.Console.ReadKey();

	}
}
