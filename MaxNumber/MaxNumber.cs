public static class MaxNumber
{
	public static int MaxNumberOfUnequalConsecutiveChars(string input)
	{
		var counter = 1;

		for (var i = 0; i < input.Length - 1; i++)
		{
			if (!input[i].Equals(input[i + 1]))
			{
				counter++;
			}
		}

		return counter;
	}

	public static int MaxNumberOfConsecutiveIdenticalLettersOfLatin(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			throw new ArgumentNullException(nameof(input), "Input parameter can not be null.");
		}

		var differentLettersCounter = 1;
		var maxNumber = 1;
		var maxNumbersList = new List<int>();
		var indexOfInnerString = 0;

		for (var i = 0; i < input.Length - 1; i++)
		{
			if (!input[i].Equals(input[i + 1]))
			{
				differentLettersCounter++;
			}
		}

		for (var i = 0; i < differentLettersCounter; i++)
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

		maxNumber = maxNumbersList.Max();

		return maxNumber;
	}

	public static int MaxNumberOfConsecutiveIdenticalDigits(string input)
	{
		var counter = 1;

		for (var i = 0; i < input.Length - 1; i++)
		{
			if (input[i].Equals(input[i + 1]))
			{
				counter++;
			}
		}

		return counter;
	}
}