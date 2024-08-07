namespace MaxNumbersTests
{
	[TestFixture]
	public class MaxNumberTests
	{
		[Test]
		public void MaxNumberOfUnequalConsecutiveChars_StrParamIsNull_ThrowsNullException()
		{
			// Act
			Assert.Throws<ArgumentNullException>(() => MaxNumber.MaxNumberOfUnequalConsecutiveChars(null));
		}

		[Test]
		public void MaxNumberOfUnequalConsecutiveChars_StrParamIsEmpty_ThrowsNullException()
		{
			// Act
			Assert.Throws<ArgumentNullException>(() => MaxNumber.MaxNumberOfUnequalConsecutiveChars(""));
		}

		[Test]
		public void MaxNumberOfUnequalConsecutiveChars_StrParamsIsWhitespace_ThrowsArgumentException()
		{
			// Act
			Assert.Throws<ArgumentException>(() => MaxNumber.MaxNumberOfUnequalConsecutiveChars(" "));
		}

		[Test]
		public void MaxNumberOfUnequalConsecutiveChars_StrParamContainsDigits_ThrowsArgumentException()
		{
			// Act
			Assert.Throws<ArgumentException>(() => MaxNumber.MaxNumberOfUnequalConsecutiveChars("a1b"));
		}

		[TestCase("a", ExpectedResult = 1)]
		[TestCase("ab", ExpectedResult = 2)]
		[TestCase("abcde", ExpectedResult = 5)]
		[TestCase("aabbc", ExpectedResult = 2)]
		[TestCase("aabcde", ExpectedResult = 5)]
		[TestCase("aabbcdefg", ExpectedResult = 6)]
		public int MaxNumberOfUnequalConsecutiveChars_ParameterIsValid_ReturnsResult(string input)
		{
			// Act
			return MaxNumber.MaxNumberOfUnequalConsecutiveChars(input);
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalLettersOfLatin_StrParamIsNull_ThrowsNullException()
		{
			// Act
			Assert.Throws<ArgumentNullException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalLettersOfLatin(null));
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalLettersOfLatin_StrParamIsEmpty_ThrowsNullException()
		{
			// Act
			Assert.Throws<ArgumentNullException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalLettersOfLatin(""));
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalLettersOfLatin_StrParamsIsWhitespace_ThrowsArgumentException()
		{
			// Act
			Assert.Throws<ArgumentException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalLettersOfLatin(" "));
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalLettersOfLatin_StrParamContainsDigits_ThrowsArgumentException()
		{
			// Act
			Assert.Throws<ArgumentException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalLettersOfLatin("a1b"));
		}

		[TestCase("aaabc", ExpectedResult = 3)]
		[TestCase("aabbbbc", ExpectedResult = 4)]
		[TestCase("abccc", ExpectedResult = 3)]
		[TestCase("abc", ExpectedResult = 1)]
		[TestCase("a", ExpectedResult = 1)]
		[TestCase("hippopotomonstrosesquippedaliophobia", ExpectedResult = 2)]
		[TestCase("hippopotomonstrooooosesquippedaliophobia", ExpectedResult = 5)]
		public int MaxNumberOfConsecutiveIdenticalLettersOfLatin_ParameterIsValid_ReturnsResult(string input)
		{
			// Act
			return MaxNumber.MaxNumberOfConsecutiveIdenticalLettersOfLatin(input);
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalDigits_StrParamIsNull_ThrowsNullException()
		{
			// Act
			Assert.Throws<ArgumentNullException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalDigits(null));
		}

		public void MaxNumberOfConsecutiveIdenticalDigits_StrParamIsEmpty_ThrowsNullException()
		{
			// Act
			Assert.Throws<ArgumentNullException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalDigits(""));
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalDigits_StrParamsIsWhitespace_ThrowsArgumentException()
		{
			// Act
			Assert.Throws<ArgumentException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalDigits(" "));
		}

		[Test]
		public void MaxNumberOfConsecutiveIdenticalDigits_StrParamContainsLetters_ThrowsArgumentException()
		{
			// Act
			Assert.Throws<ArgumentException>(() => MaxNumber.MaxNumberOfConsecutiveIdenticalDigits("1a2"));
		}

		[TestCase("11123", ExpectedResult = 3)]
		[TestCase("1122223", ExpectedResult = 4)]
		[TestCase("12333", ExpectedResult = 3)]
		[TestCase("012", ExpectedResult = 1)]
		[TestCase("1", ExpectedResult = 1)]
		[TestCase("9283716455572819", ExpectedResult = 3)]
		[TestCase("928555553716455572819", ExpectedResult = 5)]
		public int MaxNumberOfConsecutiveIdenticalDigits_ParameterIsValid_ReturnsResult(string input)
		{
			// Act
			return MaxNumber.MaxNumberOfConsecutiveIdenticalDigits(input);
		}
	}
}