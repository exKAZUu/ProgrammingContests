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
	internal class Shoe {
		public int Price { get; set; }
		public int Size { get; set; }
		public int Index { get; set; }
		public List<Customer> Customers { get; set; }

		public Shoe() {
			Customers = new List<Customer>(2);
		}
	}

	internal class Customer {
		public int Money { get; set; }
		public int Feet { get; set; }
		public Shoe BoughtShoe { get; set; }
	}

	public class ProblemD {
		public static void Main(string[] args) {
			new ProblemD().Solve(Console.In);
		}

		public void Solve(TextReader input) {
			var nShoes = int.Parse(input.ReadLine());
			var shoes =
					Enumerable.Range(0, nShoes)
							.Select(_ => input.ReadLine().Split(' ').Select(int.Parse).ToList())
							.Select((cs, i) => new Shoe { Price = cs[0], Size = cs[1], Index = i })
							.ToDictionary(s => s.Size);
			var nCustomers = int.Parse(input.ReadLine());
			var customers = Enumerable.Range(0, nCustomers)
					.Select(_ => input.ReadLine().Split(' ').Select(int.Parse).ToList())
					.Select(
							(dl, i) =>
							new Customer { Money = dl[0], Feet = dl[1] })
					.ToList();
			foreach (var customer in customers) {
				Shoe shoe;
				if (shoes.TryGetValue(customer.Feet, out shoe) &&
				    customer.Money >= shoe.Price) {
					shoe.Customers.Add(customer);
				}
				if (shoes.TryGetValue(customer.Feet + 1, out shoe) &&
				    customer.Money >= shoe.Price) {
					shoe.Customers.Add(customer);
				}
			}
			long money = 0;
			var count = 0;
			foreach (var shoe in shoes.Values.OrderByDescending(s => s.Price)) {
				if (SearchGreedy(shoe)) {
					money += shoe.Price;
					count++;
				}
			}
			Console.WriteLine(money);
			Console.WriteLine(count);
			for (int i = 0; i < customers.Count; i++) {
				var shoe = customers[i].BoughtShoe;
				if (shoe != null) {
					Console.WriteLine((i + 1) + " " + (shoe.Index + 1));
				}
			}
		}

		private bool SearchGreedy(Shoe shoe) {
			foreach (var customer in shoe.Customers) {
				var otherShoe = customer.BoughtShoe;
				if (otherShoe == null) {
					customer.BoughtShoe = shoe;
					return true;
				}
				if (shoe != otherShoe && SearchGreedy(otherShoe)) {
					customer.BoughtShoe = shoe;
					return true;
				}
			}
			return false;
		}
	}
}