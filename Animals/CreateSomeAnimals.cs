namespace Animals
{
	internal class CreateSomeAnimals
	{
		public static Animal CreateAnimal(AnimalType AnimalType)
		{
			switch (AnimalType)
			{
				case AnimalType.COW:
					return new Cow() { Type = AnimalType.COW };
				case AnimalType.SHEEP:
					return new Sheep() { Type = AnimalType.SHEEP };
				default:
					throw new ArgumentNullException(nameof(AnimalType));
			}
		}
	}
}
