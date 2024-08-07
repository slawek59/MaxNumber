public static class MaxNumber
{
	public static int MaxNumberOfUnequalConsecutiveChars(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			throw new ArgumentNullException(nameof(input), "Input parameter can not be null.");
		}

		if (!input.All(Char.IsLetter))
		{
			throw new ArgumentException("Input should contain letters only.", nameof(input));
		}

		var differentSymbolsCounter = 1;
		var maxNumber = 1;
		var maxNumbersList = new List<int>();
		var indexOfInnerString = 0;

		for (var i = 0; i < input.Length - 1; i++)
		{
			if (!input[i].Equals(input[i + 1]))
			{
				differentSymbolsCounter++;
			}
		}

		if (differentSymbolsCounter == 1)
		{
			return maxNumber;
		}

		for (; indexOfInnerString < input.Length - 1; indexOfInnerString++)
		{
			if ((input[indexOfInnerString] + 1).Equals(input[indexOfInnerString + 1]))
			{
				maxNumber++;
			}
			else
			{
				maxNumbersList.Add(maxNumber);
				maxNumber = 1;
			}

		}

		maxNumbersList.Add(maxNumber);
		maxNumber = maxNumbersList.Max();

		return maxNumber;
	}

	public static int MaxNumberOfConsecutiveIdenticalLettersOfLatin(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			throw new ArgumentNullException(nameof(input), "Input parameter can not be null.");
		}

		if (!input.All(Char.IsLetter))
		{
			throw new ArgumentException("Input should contain letters only.", nameof(input));
		}

		return CountIdenticalConsecutive(input);
	}

	public static int MaxNumberOfConsecutiveIdenticalDigits(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			throw new ArgumentNullException(nameof(input), "Input parameter can not be null.");
		}

		if (!input.All(Char.IsDigit))
		{
			throw new ArgumentException("Input should contain digits only.", nameof(input));
		}

		return CountIdenticalConsecutive(input);
	}

	public static int CountIdenticalConsecutive(string input)
	{
		var differentSymbolsCounter = 1;
		var maxNumber = 1;
		var maxNumbersList = new List<int>();
		var indexOfInnerString = 0;

		for (var i = 0; i < input.Length - 1; i++)
		{
			if (!input[i].Equals(input[i + 1]))
			{
				differentSymbolsCounter++;
			}
		}

		if (differentSymbolsCounter == 1)
		{
			return maxNumber;
		}

		for (var i = 0; i < differentSymbolsCounter; i++)
		{
			maxNumber = 1;

			for (; indexOfInnerString < input.Length - 1; indexOfInnerString++)
			{
				if (input[indexOfInnerString].Equals(input[indexOfInnerString + 1]))
				{
					maxNumber++;
				}
				else
				{
					maxNumbersList.Add(maxNumber);
					indexOfInnerString++;
					break;
				}

			}
		}

		maxNumbersList.Add(maxNumber);
		maxNumber = maxNumbersList.Max();

		return maxNumber;
	}
}