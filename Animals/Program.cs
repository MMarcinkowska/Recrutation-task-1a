namespace Animals
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			AnimalAction animals = new AnimalAction();
			
			for (int i = 0; i < 5; i++)
			{	
				Animal animal= animals.AnimalCreator();
				animals.WhatSound(animal);
			}

		}
	}
}
