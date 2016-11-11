using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class AdrianR_HW_One_Test
{
	
	[Test()]
	public void TwoMax_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.TwoMax (1, 2), 2);
		Assert.AreEqual (AdrianR_HW_One.TwoMax (8, 7), 8);
		Assert.AreEqual (AdrianR_HW_One.TwoMax (1, -9), 1);
	}

	[Test()]
	public void ThreeMax_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.ThreeMax (1, 2, 3), 3);
		Assert.AreEqual (AdrianR_HW_One.ThreeMax (8, 7, 9), 9);
		Assert.AreEqual (AdrianR_HW_One.ThreeMax (1, -9, 100), 100);
	}

	[Test()]
	public void StartsWithVowel_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.StartsWithVowel ("alpha"), true);
		Assert.AreEqual (AdrianR_HW_One.StartsWithVowel ("Bravo"), false);
		Assert.AreEqual (AdrianR_HW_One.StartsWithVowel ("Alpha"), true);
		Assert.AreEqual (AdrianR_HW_One.StartsWithVowel ("bravo"), false);
	}

	[Test()]
	public void PalindromeCheck_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.PalindromeCheck ("radar"), true);
		Assert.AreEqual (AdrianR_HW_One.PalindromeCheck ("radio"), false);
	}

	[Test()]
	public void OddArray_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.OddArray (new int[]{ 1, 2, 3, 4, 5 }),  new[]{ 1, 3, 5, 0, 0 });
	}

	[Test()]
	public void Multiply_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.Multiply (new List<int>{ 2, 4, 5, 8 }), 320);
	}

	[Test()]
	public void IsSorted_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.IsSorted (new List<double>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), true);
		Assert.AreEqual (AdrianR_HW_One.IsSorted (new List<double>{ 1, 2, 3, 4, 5, 6, 8, 7, 9, 10 }), false);
	}
	
	[Test()]
	public void Lowest_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.Lowest (new int[]{ 4 ,5, 6, 2, 1, 9, -9}), -9);
	}
	
	[Test()] 
	public void Dups_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.Dups(new List<char>{ 'a', 'b', 'a', 'c', 'a', 'd', 'a', 'b', 'a' }), 5) ;
	}

	[Test()]
	public void LowestValue_Test()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		dictionary.Add ("Pear", 3);
		dictionary.Add ("Apple", 7);
		dictionary.Add ("Banana", 5);
		Assert.AreEqual(AdrianR_HW_One.LowestValue(dictionary), "Pear: 3");
	}

	[Test()]
	public void PangramCheck_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.PangramCheck("Pack my box with five dozen liquor jugs."), true);
		Assert.AreEqual (AdrianR_HW_One.PangramCheck("Pack"), false);
		Assert.AreEqual (AdrianR_HW_One.PangramCheck ("Not a Pangram Not a Pangram Not a Pangram Not a Pangram"), false);;
	}

	[Test()]
	public void LoShu_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.LoShu (new int[,]{ { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } }), true);
		Assert.AreEqual (AdrianR_HW_One.LoShu (new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }), false);
	}

	[Test()]
	public void FilterLongWords_Test()
	{
		Assert.AreEqual (AdrianR_HW_One.FilterLongWords(new List<string>{ "apple", "too", "to", "banana", "toe", "x-ray" }, 4), new List<String> {"APPLE","BANANA", "X-RAY" });

	}

	[Test()]
	public void TopTen_Test()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		dictionary.Add ("Rick", 21);
		dictionary.Add ("Sam", 19);
		dictionary.Add ("Joe", 22);
		dictionary.Add ("Bob", 23);
		dictionary.Add ("Ken", 18);
		dictionary.Add ("Don", 10);
		dictionary.Add ("Dan", 9);
		dictionary.Add ("Jorge", 33);
		dictionary.Add ("Adrian", 39);
		dictionary.Add ("Mac", 300);
		dictionary.Add ("Eric", 34);
		dictionary.Add ("Mike", 3);

		Dictionary<string, int> topTenTest = new Dictionary<string, int>();
		topTenTest.Add ("Mac", 300);
		topTenTest.Add ("Adrian", 39);
		topTenTest.Add ("Eric", 34);
		topTenTest.Add ("Jorge", 33);
		topTenTest.Add ("Bob", 23);
		topTenTest.Add ("Joe", 22);
		topTenTest.Add ("Rick", 21);
		topTenTest.Add ("Sam", 19);
		topTenTest.Add ("Ken", 18);
		topTenTest.Add ("Don", 10);
		Assert.AreEqual(AdrianR_HW_One.TopTen(dictionary), topTenTest);
	}