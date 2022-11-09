using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			在主控台應用程式裡,宣告一個 static method, 名稱為GetEvenItems
			傳回型別是 List<int>
			傳入參數有二個  List<int> 是待篩選的集合, 內含多個奇/偶數的數值
						 Func<int ,bool> 用來篩選, 是偶數傳回true, 奇數傳回false
			在 Main 裡叫用 GetEvenItems, 傳入一個集合, 並傳回一個只包含偶數的集合*/

			List<int> list = new List<int> {1,10,2,3,13,79,99,101,55,68 };

			Func<int, bool> func = x => x % 2 == 0;

			List<int> OddNumber = GetEvenItems(list, func);

			foreach (int i in OddNumber)
			{
				Console.WriteLine(i);
			}

		}
		public static List<int> GetEvenItems(List<int> sourse,Func<int,bool> func)
		{
			var result = new List<int>();
			foreach(int item in sourse)
			{
				if (func(item) == true)
				{
					result.Add(item);
				}
			}

			return result;
		}
	}
}
