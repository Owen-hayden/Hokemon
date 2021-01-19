using System;

namespace Hokemon
{
	class hokemon
	{
		private string name;
		private int health;
		private int max_health;
		private int attack;
		private int defence;
		private int speed;


		public string Name
		{
			get { return name; }
			set { name = value; }

		}
		public int Health
		{
			get { return health; }
			set { health = value; }
		}
		public hokemon()
		{
			provided_name();
			max_health = 100;
			health = random_int_generator(10, 100);
			attack = random_int_generator(10, 100);
			defence = random_int_generator(10, 100);
			speed = random_int_generator(10, 100);
		}
		public void provided_name()
		{
			string userName;

			Console.WriteLine("Please enter your name: ");
			userName = Console.ReadLine();
			Console.WriteLine(userName);

		}

		public void details()
		{
			Console.WriteLine("Name: {0}\n Health: {1}/{2}\n Defence: {3}\n Speed: {4}",name,Health,max_health,defence,speed);

		}


		public int random_int_generator(int min_value, int max_value)
		{
			Random rnd = new Random();

			int randomValue;

			randomValue = rnd.Next(min_value, max_value);

			return randomValue;
	}	}

		public void About()
		{
		Console.WriteLine("I am a mystical creature known as a Hokemon");
		}
	
}
