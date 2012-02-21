package sample;

public class Permutation {
	public static void main(String[] args) {
	}
	
	private boolean[] usedNumber;
	private int[] perm;
	
	void permutation1(int pos, int n) {
		if (pos == n) {
			return;
		}
		
		for (int i = 0; i < n; i++) {
			if (!usedNumber[i]) {
				perm[pos] = i;
				usedNumber[i] = true;
				permutation1(pos + 1, n);
				usedNumber[i] = false;
			}
		}
	}
}
