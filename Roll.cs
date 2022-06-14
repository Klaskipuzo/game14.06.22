using System;

namespace MyProject2;

public static class Roll
{
	private static Random random = new Random();

	public static int Next()
	{
		var value = random.Next(0, 100);
		return value;
	}
}