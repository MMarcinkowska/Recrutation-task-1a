namespace Animals
{
	internal class AnimalAction
	{
		
		public Animal AnimalCreator()
		{

			Random random = new Random();
			int type = random.Next(0, 2);
			Animal animal = CreateSomeAnimals.CreateAnimal((AnimalType)type);

			return animal;
		}

		public void WhatSound(Animal animal)
		{
			Console.WriteLine($"Animal {animal.Type} make sound {animal.GetSound()}");
		}
	}
}
