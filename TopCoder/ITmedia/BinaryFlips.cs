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
				var nCanFlip = ((i / 2) * B + ((i - 1) / 2) * A)*2;
				if (rest > nCanFlip) {
					continue;
				}
				return i;
			}
			return -1;
		}
	}
}