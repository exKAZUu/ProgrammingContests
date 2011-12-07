namespace TopCoder.ITmedia {
	public class CirclesCountry {
		public int leastBorders(
				int[] X, int[] Y, int[] R, int x1, int y1, int x2, int y2) {
			var count = 0;
			for (int i = 0; i < X.Length; i++) {
				if (IsInside(X[i], Y[i], R[i], x1, y1) ^ IsInside(X[i], Y[i], R[i], x2, y2)) {
					count++;
				}
			}
			return count;
		}

		public bool IsInside(int x, int y, int r, int px, int py) {
			return (x - px) * (x - px) + (y - py) * (y - py) <= r * r;
		}
	}
}