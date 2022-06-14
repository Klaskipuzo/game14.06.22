using System;

namespace MyProject2;

public class Character
{
	private string[] AuchReplics = new[]
	{
		"Больно!", "Кажется это кровь("
	};
	private string DieReplic = "Постойте зиккурат...";
	public string Name;
	public int Health;
	public string Waepon;

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