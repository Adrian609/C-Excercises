using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;

namespace AdrianR_HW_One
{
	class MainClass
	{
		//Exercise 1 ===============================================================================================
		public static int TwoMax(int a, int b)
		{

			if (a > b)
			{
				return a;
			}
			else if (a == b)
			{
				return a;
			}
			else {
				return b;
			}
		}

		//Excercise 2=================================================================================================
		public static int ThreeMax(int a, int b, int c)
		{
			if (a > b && a > c)
			{
				return a;
			}
			else if (a == b && a == c)
			{
				return a;
			}
			else if (b > c && b > a)
			{
				return b;
			}
			else {
				return c;
			}
		}

		//Exercise 3 ===============================================================================================
		public static char StartsWithVowel()
		{
			char symbol = 'a';
			if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
				(symbol == 'o') || (symbol == 'u') || (symbol == 'A') ||
				(symbol == 'E') || (symbol == 'I') || (symbol == 'O') || (symbol == 'U'))
				Console.WriteLine("It's a Vowel.");
			else if ((symbol >= '0') && (symbol <= '9'))
				Console.WriteLine("It's a digit.");
			else
				Console.Write("It's another symbol.");
			return symbol;
		}

		//excercise 4============================================================================================
		public static bool PalindromeCheck(string word)
		{
			int i = 0;
			int j = word.Length - 1;

			while (i < j)
			{//i starts on the far left and j starts on the right checking to see if the letters match as 
				if (word[i] != word[j])
				{//they move to the middle of the word.
					Console.WriteLine(word + " is not a Palindrome.");//the letters do not match, return false
					return false;
				}

				i++;//increment i
				j--;//decrement j
			}
			Console.WriteLine(word + " is a Palindrome.");
			return true;//we go through the entire word and return true
		}

		//excercise 5============================================================================================
		public static Array OddArray(int[] array)
		{
			int[] newArray = new int[array.Length];
			int j = 0;
			int count = 0;
			foreach (int element in array)
			{
				if (array[count] % 2 != 0)
				{//check to see if there is a remainder when dividing by 2
					newArray[j] = array[count];//add the odd number to the new array
					Console.WriteLine(newArray[j]);
					j++;
					count++;

				}
				else//there is no remainder, skip this number and go to the next
					count++;
			}
			return newArray;
		}

		//excercise 6============================================================================================
		public static int Multiply(List<int> multiplyInts)
		{
			int i = multiplyInts[0];//set the first element as the first multiple
			int j = multiplyInts[1];//set the second element as the second multiple
			int product = i * j;

			for (int k = 2; k < multiplyInts.Count; k++)
			{//loop to multiple all the elements in the list by the 
				product = product * multiplyInts[k];//product of the previous numbers
			}
			Console.WriteLine(product);
			return product;
		}

		//excercise 7============================================================================================
		public static bool IsSorted(List<double> listDoubles)
		{
			//this for loop checks each number to see if the next number is larger or smaller
			//if it is smaller then we return false. 
			for (int k = 1; k < listDoubles.Count; k++)
			{
				Console.WriteLine("Checking: " + listDoubles[(k - 1)] + " and " + listDoubles[k]);
				if (listDoubles[(k - 1)] > listDoubles[k])
				{
					Console.WriteLine("Not Sorted");
					return false;
				}
			}
			Console.WriteLine("end of List, all Sorted.");
			return true;
		}

		//excercise8============================================================================================
		public static int Lowest(int[] fruitInventory)
		{
			/*set the first of the element to the array and check the reamin elements to see which 
			 * is the lowest. If a lower number is found, that number is designated the lowest and the
			 * loop continues through the array checking the rest of array elements.
			 */
			int low = fruitInventory[0];
			for (int i = 0; i < fruitInventory.Length; i++)
			{
				if (fruitInventory[i] < low)
					low = fruitInventory[i];
			}
			Console.WriteLine("Lowest Number: " + low);
			return low;
		}

		//excercise 9============================================================================================
		public static int Dups(List<char> charList)
		{
			//Navigate through the list returning the total number of duplicate letters
			//in a give list of chars.
			List<char> distinct = charList.Distinct().ToList();
			int total = charList.Count() - distinct.Count();
			Console.WriteLine("Duplicate Letters: " + total);
			return total;
		}

		//excercise 10============================================================================================
		public static string LowestValue(Dictionary<string, int> dictionary)
		{
			//find the lowest value of inventory of fruit of a given dictionary and return the key and value as 
			//a string.
			string minFruit = String.Concat(dictionary.Keys.Max(), ": ", dictionary.Min(kvp => kvp.Value));
			Console.WriteLine(minFruit);
			return minFruit;

		}

		//excercise 11============================================================================================
		public static bool PangramCheck(string userPhrase)
		{
			//if the sentence is less that 26 words it can't have all the letters of the alphabet
			//so we return false
			if (userPhrase.Length < 26)
			{
				Console.WriteLine("Not a Pangram, not enough letters!");
				return false;
			}

			//set all the letters of the sentence to uppercase and compare the letters to the
			//array to see if all the letters of the alphabet are present.
			userPhrase = userPhrase.ToUpper();
			char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			foreach (char i in alpha)
			{
				if (!userPhrase.Contains(i))
				{
					Console.WriteLine("Not a Pangram");
					return false;
				}
			}
			Console.WriteLine("Neato! It's a Pangram");
			return true;
		}

		//excercise 12============================================================================================
		public static bool LoShu(int[,] square)
		{

			int sum;
			// Check each row
			for (int i = 0; i < 3; i++)
			{
				// Find the sum of row #i.
				sum = 0;
				for (int j = 0; j < 3; j++)
					sum += square[i, j];

				Console.WriteLine("Row " + (i + 1) + " = " + sum);

				// If row does not equal 15 return false
				if (sum != 15)
				{
					Console.WriteLine("This box is not magic!");
					return false;
				}
			}

			// Check columns
			for (int j = 0; j < 3; j++)
			{
				// Find the sum of column #j.
				sum = 0;
				for (int i = 0; i < 3; i++)
					sum += square[i, j];

				Console.WriteLine("Column " + (j + 1) + " = " + sum);

				// If column does not equal 15 return false
				if (sum != 15)
				{
					Console.WriteLine("This box is not magic!");
					return false;
				}
			}

			// Check diagonal
			sum = 0;
			for (int i = 0; i < 3; i++)
				sum += square[i, i];
			Console.WriteLine("Diagonal = " + sum);

			// If diagonal does not equal 15 return false
			if (sum != 15)
			{
				Console.WriteLine("This box is not magic!");
				return false;
			}

			// Check diagonal
			sum = 0;
			for (int i = 0; i < 3; i++)
				sum += square[i, square.GetLength(0) - 1 - i];
			Console.WriteLine("Diagonal = " + sum);

			// If diagonal does not equal 15 return false
			if (sum != 15)
			{
				Console.WriteLine("This box is not magic!");
				return false;
			}
			Console.WriteLine("This box is magic!");
			return true;
		}

		//excercise 13============================================================================================
		public static List<string> FilterLongWords(List<string> wordList, int i)
		{
			//using a loop we check the lengths of the words, if the length is greater than a 
			//given int we capitalize the entire word and add it to a new List.
			List<string> newList = new List<string>();
			foreach (string element in wordList)
			{
				if (element.Length >= i)
				{
					newList.Add(element.ToUpper());
					Console.WriteLine(element.ToUpper());
				}
			}
			return newList;
		}

		//excercise 14============================================================================================
		public static Dictionary<string, int> TopTen(Dictionary<string, int> scores)
		{
			//take a given dictionary, sort it and return the keys and values of the elements with the 10 
			//highest values. Return a new dictionary with those 10 keys/values.
			var sortedScores = scores.OrderByDescending(entry => entry.Value)
				.Take(10)
				.ToDictionary(pair => pair.Key, pair => pair.Value);


			foreach (KeyValuePair<string, int> pair in sortedScores)
			{
				Console.WriteLine("Name: {0}, Score: {1}", pair.Key, pair.Value);
			}

			return sortedScores;
		}

		public static void Main(string[] args)
		{
			int[] array = new int[5] { 1, 2, 3, 4, 5 };

			List<int> multiplyInts = new List<int>();
			multiplyInts.Add(2);
			multiplyInts.Add(3);
			multiplyInts.Add(7);
			multiplyInts.Add(8);
			multiplyInts.Add(10);
			multiplyInts.Add(15);

			List<double> listDoubles = new List<double>();
			listDoubles.Add(2.2);
			listDoubles.Add(3.4);
			listDoubles.Add(7.6);
			listDoubles.Add(8.4);
			listDoubles.Add(10.2);
			listDoubles.Add(15.6);

			int[] findLowest = array;

			List<Char> listChars = new List<Char>();
			listChars.Add('a');
			listChars.Add('c');
			listChars.Add('b');
			listChars.Add('e');
			listChars.Add('a');

			Dictionary<string, int> fruitInventory = new Dictionary<string, int>();
			fruitInventory.Add("Pear", 10);
			fruitInventory.Add("Kiwi", 4);
			fruitInventory.Add("Tamato", 0);
			fruitInventory.Add("Lime", 9);

			String userPhrase = "The quick brown fox jumps over the lazy dog.";

			int[,] loshu = { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
			int[,] no1 = { { 4, 9, 2 }, { 3, 7, 5 }, { 8, 1, 6 } };
			int[,] no2 = { { 4, 9, 2 }, { 3, 3, 5 }, { 8, 1, 6 } };

			List<String> wordList = new List<String>();
			wordList.Add("Hola");
			wordList.Add("Domo");
			wordList.Add("Horse");
			wordList.Add("Cat");
			wordList.Add("It");

			Dictionary<string, int> topTen = new Dictionary<string, int>();
			topTen.Add("Mark", 20);
			topTen.Add("Tom", 30);
			topTen.Add("Bob", 0);
			topTen.Add("Andy", 40);
			topTen.Add("Tim", 50);
			topTen.Add("Tyler", 60);
			topTen.Add("Zack", 70);
			topTen.Add("Jim", 80);
			topTen.Add("Adam", 90);
			topTen.Add("Adrian", 100);

			Console.WriteLine(TwoMax(2, 9));
			Console.WriteLine(ThreeMax(2, 9, 19));
			Console.WriteLine(StartsWithVowel());
			Console.WriteLine(PalindromeCheck("radar"));
			Console.WriteLine(OddArray(array));
			Console.WriteLine(Multiply(multiplyInts));
			Console.WriteLine(IsSorted(listDoubles));
			Console.WriteLine(Lowest(findLowest));
			Console.WriteLine(Dups(listChars));
			Console.WriteLine(LowestValue(fruitInventory));
			Console.WriteLine(PangramCheck(userPhrase));
			Console.WriteLine(LoShu(loshu));
			Console.WriteLine(LoShu(no1));
			Console.WriteLine(LoShu(no2));
			Console.WriteLine(FilterLongWords(wordList, 3));
			Console.WriteLine(TopTen(topTen));
		}
	}
}