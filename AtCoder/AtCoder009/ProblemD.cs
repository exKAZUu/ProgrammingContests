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

namespace AtCoder.AtCoder009 {
	internal class Piece {
		public int X { get; set; }
		public int Y { get; set; }
		public char Type { get; set; }

		public bool Equals(Piece other) {
			if (ReferenceEquals(null, other)) {
				return false;
			}
			if (ReferenceEquals(this, other)) {
				return true;
			}
			return other.X == X && other.Y == Y;
		}

		public override bool Equals(object obj) {
			if (ReferenceEquals(null, obj)) {
				return false;
			}
			if (ReferenceEquals(this, obj)) {
				return true;
			}
			if (obj.GetType() != typeof(Piece)) {
				return false;
			}
			return Equals((Piece)obj);
		}

		public override int GetHashCode() {
			unchecked {
				return (X * 397) ^ Y;
			}
		}
	}

	internal class ProblemD {
		//private static void Main(string[] args) {
		//    new ProblemD().Solve(Console.In);
		//}

		private const int margin = 3;

		private void Solve(TextReader input) {
			var hw = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			var h = hw[0];
			var w = hw[1];

			var map = new Piece[w + margin * 2,h + margin * 2];
			var piecesMaru = new HashSet<Piece>();
			var piecesBatu = new HashSet<Piece>();

			for (int y = margin; y < h + margin; y++) {
				var line = input.ReadLine();
				for (int x = margin; x < w + margin; x++) {
					var piece = new Piece { X = x, Y = y, Type = line[x - margin] };
					if (piece.Type == 'o') {
						piecesMaru.Add(piece);
						map[x, y] = piece;
					} else if (piece.Type == 'x') {
						piecesBatu.Add(piece);
						map[x, y] = piece;
					}
				}
			}

			while (piecesMaru.Count != 0 && piecesBatu.Count != 0) {
				Advance(map, piecesMaru, piecesBatu, 'o', 1, w, h);
				Advance(map, piecesBatu, piecesMaru, 'x', -1, w, h);
			}

			Console.WriteLine(piecesMaru.Count != 0 ? 'o' : 'x');
		}

		private static void Advance(
				Piece[,] map, HashSet<Piece> friends, HashSet<Piece> enemies, char type,
				int dx, int w, int h) {
			foreach (var piece in friends) {
				if (map[piece.X + dx, piece.Y] != null
				    && map[piece.X + dx, piece.Y].Type != type) {
					enemies.Remove(map[piece.X + dx, piece.Y]);
					map[piece.X, piece.Y] = null;
					piece.X += dx;
					map[piece.X, piece.Y] = piece;
					return;
				}
			}
			foreach (var piece in friends) {
				if (map[piece.X + dx, piece.Y] == null &&
				    map[piece.X + dx * 2, piece.Y] == null &&
				    map[piece.X + dx * 3, piece.Y] != null
				    && map[piece.X + dx * 3, piece.Y].Type != type) {
					map[piece.X, piece.Y] = null;
					piece.X += dx;
					map[piece.X, piece.Y] = piece;
					return;
				}
			}
			foreach (var piece in friends) {
				if (map[piece.X + dx, piece.Y] == null
				    &&
				    (map[piece.X + dx * 2, piece.Y] == null
				     || map[piece.X + dx * 2, piece.Y].Type == type)) {
					map[piece.X, piece.Y] = null;
					piece.X += dx;
					map[piece.X, piece.Y] = piece;
					return;
				}
			}
			foreach (var piece in friends) {
				map[piece.X, piece.Y] = null;
				piece.X += dx;
				map[piece.X, piece.Y] = piece;
				return;
			}
			foreach (var piece in friends) {
				map[piece.X, piece.Y] = null;
				piece.X += dx;
				map[piece.X, piece.Y] = piece;
				return;
			}
		}
	}
}