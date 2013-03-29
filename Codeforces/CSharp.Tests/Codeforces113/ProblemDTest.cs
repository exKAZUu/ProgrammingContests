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

using System.IO;
using System.Text;
using NUnit.Framework;

namespace Codeforces.Tests.Codeforces113 {
	[TestFixture]
	public class ProblemDTest {
		[Test]
		public void Test() {
			var builder = new StringBuilder();
			var count = 100000;
			builder.AppendLine("100000");
			for (int i = 0; i < count; i++) {
				builder.AppendLine(i + " " + i);
			}
			builder.AppendLine("100000");
			for (int i = 0; i < count; i++) {
				builder.AppendLine(count + " " + (i / 3 * 3));
			}
			new ProblemD().Solve(new StringReader(builder.ToString()));
		}
	}
}