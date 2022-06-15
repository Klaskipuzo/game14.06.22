using System;

namespace MyProject2;

public class Character
{
	private string[] AuchReplics = new[]
	{
		"Больно!", "Кажется это кровь("
	};
	private string DieReplic = "Отомсти за меня...";
	public string Name;
	public int Health;
	public int Strange;
	public int Dextery;
	public int Wisdom;
	public string Waepon;
	public int Armor;

	public void Damage(int damage)
	{
		Health = Health - damage;
		if (Health > 0)
		{
			Console.WriteLine(AuchReplics[0]);
		}
		else
		{
			Console.WriteLine(DieReplic);
		}
	}
}

public class Monsters
{
	public string Name;
	public int Health;
	public int Strange;
	public int Dextery;
	public int Wisdom;
	public int Armor;
		private string[] AuchReplics = new[]
	{
		"угрх"
	};
	private string DieReplic = "Вы все умрете!";
	public void Damage(int damage)
	{
		Health = Health - damage;
		if (Health > 0)
		{
			Console.WriteLine(AuchReplics[0]);
		}
		else
		{
			Console.WriteLine(DieReplic);
		}
	}
}

