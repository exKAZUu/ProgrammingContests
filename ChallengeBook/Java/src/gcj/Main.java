package gcj;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {

	public static class ShuffleCommand {
		public int insertCardCount;
		public int topCardCount;

		public ShuffleCommand(int topCardCount, int insertCardCount) {
			super();
			this.insertCardCount = insertCardCount;
			this.topCardCount = topCardCount;
		}
	}

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		new Main().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);

		int nTestCase = sc.nextInt();
		for (int i = 0; i < nTestCase; i++) {
			int nCards = sc.nextInt();
			int nCut = sc.nextInt();
			int index = sc.nextInt();

			ArrayList<ShuffleCommand> cmds = new ArrayList<ShuffleCommand>();
			for (int j = 0; j < nCut; j++) {
				cmds.add(new ShuffleCommand(sc.nextInt() - 1, sc.nextInt()));
			}

			for (int j = cmds.size() - 1; j >= 0; j--) {
				ShuffleCommand cmd = cmds.get(j);
				if (index <= cmd.insertCardCount) {
					index += cmd.topCardCount;
				} else if (index <= cmd.insertCardCount + cmd.topCardCount) {
					index -= cmd.insertCardCount;
				}
			}
			System.out.println("Case #" + (i + 1) + ": " + index);
		}

	}

}
