using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLessConv2
{
	class Program
	{
		static void Main(string[] args)
		{
			encodingMgr _letterMgr = new encodingMgr(Encoding.base64);
			var number = _letterMgr.encodingToInt("HelloWorld");
			Console.WriteLine($"Letters = {number}.");
			var letters = _letterMgr.intToEncoding(number, Encoding.base64);
			Console.WriteLine($"letters = {letters}");

			Console.ReadLine();
		}
	}

	public static class baseMgr
	{

		public static char[] retrieveBase(Encoding enc)
	{
		char[] lettersA = {

								 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',

								 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',

								 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'

							  };
		char[] base64 = {
								   'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9','+','/'
							   };

		char[] oct = {
								'0', '1', '2', '3', '4', '5', '6', '7'
							};

		char[] hex = {
								 '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
								 'A', 'B', 'C', 'D','E','F'
							};
		char[] dec = {
								 '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
							};
		char[] bin = {
								 '0', '1'
							 };



		Dictionary<Encoding, char[]> baseDict = new Dictionary<Encoding, char[]>();

		baseDict.Add(Encoding.lettersA, lettersA);
		baseDict.Add(Encoding.base64, base64);
		baseDict.Add(Encoding.oct, oct);
		baseDict.Add(Encoding.hex, hex);
		baseDict.Add(Encoding.dec, dec);
		baseDict.Add(Encoding.bin, bin);

		return baseDict[enc];
	}
}

	public enum Encoding
	{
		lettersA,
		base64,
		oct,
		hex,
		dec,
		bin
	}

	public class encodingMgr
	{
		public Encoding currentEncoding { get; set; }
		public encodingMgr()
		{
			// this will run when letterMgr is first created to set the dict
			Int64 index = 0;
			foreach (char a in baseMgr.retrieveBase(Encoding.lettersA))
			{
				charDict.Add(a, index++);
			}
		}

		public encodingMgr(Encoding enc)
		{
			this.currentEncoding = enc;
			// this will run when letterMgr is first created to set the dict
			Int64 index = 0;
			foreach (char a in baseMgr.retrieveBase(enc))
			{
				charDict.Add(a, index++);
			}
		}

		public Dictionary<char, Int64> charDict = new Dictionary<char, Int64>();

		public Int64 encodingToInt(String letters)
		{	
			if (currentEncoding == Encoding.lettersA)
			{
				letters = letters.ToLower();
			}
			Int64 v = 0;
			Int64 n = letters.Length;
			foreach (char c in letters)
			{
				v += (charDict[c] + 1) * (Int64)Math.Pow(charDict.Count, n-- - 1);
			}
			return v - 1;
		}

		//public Int64 encodingBase64ToInt64(string base64str)
		//{
		//	Int64 v = 0;
		//	Int64 n = base64str.Length;
		//	foreach (char c in base64str)
		//	{
		//		v += (charDict[c] + 1) * (Int64)Math.Pow(charDict.Count, n-- - 1);
		//	}
		//	return v - 1;
		//}

		public void Test1()
		{
			Int64 num = encodingToInt("aa");
			String letter = intToEncoding(num, Encoding.lettersA);
			num++;
			letter = intToEncoding(num, Encoding.lettersA);  // should equal 'ba'   if you want it reverse just reverse the code using an insert(0, etc.. which will prepend it.
		}

		public string intToEncoding(Int64 num, Encoding enc)
		{
			Int64 count = 0;
			StringBuilder sb = new StringBuilder();
			while (true)
			{
				Int64 r;
				r = (Int64)(num % charDict.Count);
				if (r != 0)
				{
					sb.Append(baseMgr.retrieveBase(enc)[r].ToString());
					count++;
				}
				else
				{
					sb.Append(baseMgr.retrieveBase(enc)[r]);
				}
				if (num >= charDict.Count)
				{
					num = num / charDict.Count - 1;
				}
				else break;
			}
			StringBuilder sb2 = new StringBuilder();

			for (int i = sb.Length - 1; i >= 0; i--)
			{
				sb2.Append(sb[i]);
			}
			return sb2.ToString();
		}
	}




}