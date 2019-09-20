using System;

namespace String_Explosion
{
	class Program
	{
		static void Main(string[] args)
		{
			// pesho>2sis>1a>2akarate>4hexmaster
			
			string input = Console.ReadLine();
			int strength = 0;
			int additional = 0;
			bool stackStrength = false;
			int index = 0;
			string explosion = string.Empty;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '>')
				{
					strength = int.Parse(input[i + 1].ToString());
					if (i + 1 + strength < input.Length)
					{
						explosion = input.Substring(i + 1, strength);
					}
					else if (i + 1 + strength >= input.Length)
					{
						explosion = input.Substring(i + 1);
					}
					if (stackStrength)
					{
						strength += additional;
					}
					stackStrength = false;
					additional = 0;
					if (!explosion.Contains(">"))
					{
						index = input.IndexOf(explosion);
						if (index + strength < input.Length)
						{
							input = input.Remove(index, strength);
						}
						else
						{
							for (int j = input.Length - 1; j > i; j--)
							{
								input = input.Remove(j, 1);
							}
						}
					}
					else if (explosion.Contains(">"))
					{
						index = explosion.IndexOf(">");
						for (int j = index - 1; j >= 0 ; j--)
						{
							explosion = explosion.Remove(j, 1);
							additional++;
						}
						input = input.Remove(i + 1, additional);
						stackStrength = true;
					}
				}
			}
			Console.WriteLine(input);
			// abv>1>1>2>2asdasd
		}
	}
}
