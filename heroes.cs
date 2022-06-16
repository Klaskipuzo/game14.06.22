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
	//ORC
	public string Torch;
	public int Throw;
	//HUMAN
	public int Fire_ball;
	public string Firefly;
	public string Alohomora;
	//ELF
	public string Cat_s_eyes;
	public string Breaking;


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



