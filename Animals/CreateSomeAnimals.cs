namespace Animals
{
	internal class CreateSomeAnimals
	{
		public static Animal CreateAnimal(AnimalType animalType)
		{
			switch (animalType)
			{
				case AnimalType.COW:
					return new Cow() { Type = AnimalType.COW };
				case AnimalType.SHEEP:
					return new Sheep() { Type = AnimalType.SHEEP };
				default:
					throw new ArgumentNullException(nameof(animalType));
			}
		}
	}
}
