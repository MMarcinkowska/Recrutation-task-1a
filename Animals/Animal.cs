namespace Animals
{
	internal abstract class Animal
	{
		public AnimalType Type;
		public abstract string GetSound();
	}

	enum AnimalType
	{
		COW = 0,
		SHEEP = 1,
	}
}
