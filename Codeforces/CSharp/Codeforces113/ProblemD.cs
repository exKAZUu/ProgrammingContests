#region License

// Copyright (C) 2011-2012 Kazunori Sakamoto
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Codeforces {
	internal class Shoes {
		public int Price { get; set; }
		public int Size { get; set; }
	}

	internal class Customer {
		public int Money { get; set; }
		public int Feet { get; set; }
	}

	public class ProblemD {
		private List<Customer> customers;
		private List<Shoes> shoes;

		//public static void Main(string[] args) {
		//    new ProblemD().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var nShoes = int.Parse(input.ReadLine());
			shoes = Enumerable.Range(0, nShoes)
					.Select(_ => input.ReadLine().Split(' ').Select(int.Parse).ToList())
					.Select(cs => new Shoes { Price = cs[0], Size = cs[1] })
					.OrderBy(s => s.Size)
					.ToList();
			var nCustomers = int.Parse(input.ReadLine());
			customers = Enumerable.Range(0, nCustomers)
					.Select(_ => input.ReadLine().Split(' ').Select(int.Parse).ToList())
					.Select(dl => new Customer { Money = dl[0], Feet = dl[1] })
					.OrderBy(c => c.Feet)
					.ToList();
			Console.WriteLine(DepthFirstSearch(0, 0, 0));
		}

		private int DepthFirstSearch(int iShoes, int iCustomers, int sum) {
			if (iShoes >= shoes.Count || iCustomers >= customers.Count) {
				return sum;
			}

			var diff = customers[iCustomers].Feet - shoes[iShoes].Size;
			if (diff < 0) {
				return DepthFirstSearch(iShoes, iCustomers + 1, sum);
			}
			if (diff == 0 || diff == 1) {
				var ret = DepthFirstSearch(iShoes, iCustomers + 1, sum);
				if (shoes[iShoes].Price <= customers[iCustomers].Money) {
					ret = Math.Max(
							ret, DepthFirstSearch(
									iShoes + 1, iCustomers + 1,
									sum + shoes[iShoes].Price));
				}
				return ret;
			}
			return DepthFirstSearch(iShoes + 1, iCustomers, sum);
		}
	}
}