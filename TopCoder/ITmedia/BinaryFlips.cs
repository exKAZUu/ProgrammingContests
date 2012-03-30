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

namespace TopCoder.ITmedia {
	public class BinaryFlips {
		public int minimalMoves(int A, int B, int K) {
			for (int i = 0; i < A + B; i++) {
				var rest = i * K - A;
				if (rest % 2 != 0) {
					continue;
				}
				if (rest < 0) {
					continue;
				}
				var nCanFlip = ((i / 2) * B + ((i - 1) / 2) * A) * 2;
				if (rest > nCanFlip) {
					continue;
				}
				return i;
			}
			return -1;
		}
	}
}