package AOJ;

import java.io.InputStream;
import java.util.Scanner;

public class Problem0145 {

  static class Deck {
    public int head;
    public int tail;

    public Deck(int head, int tail) {
      this.head = head;
      this.tail = tail;
    }
  }

  static class State implements Comparable<State> {
    public long connect1;
    public long connect2;
    public int cost;

    public State(long connect1, long connect2, int cost) {
      this.connect1 = connect1;
      this.connect2 = connect2;
      this.cost = cost;
    }

    @Override
    public int compareTo(State o) {
      return cost - o.cost;
    }
  }

  public static void main(String[] args) {
    new Problem0145().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    int nDecks = sc.nextInt();
    Deck[] decks = new Deck[nDecks];
    for (int i = 0; i < decks.length; i++) {
      decks[i] = new Deck(sc.nextInt(), sc.nextInt());
    }

    int[][] dp = new int[decks.length][decks.length];
    for (int size = 2; size <= dp.length; size++) {
      for (int l = 0; l <= dp.length - size; l++) {
        // dp[l][l + size - 1]
        int cost = Integer.MAX_VALUE;
        for (int half = 1; half <= size - 1; half++) {
          cost =
              Math.min(cost, dp[l][l + half - 1] + dp[l + half][l + size - 1] + decks[l].head
                  * decks[l + half - 1].tail * decks[l + half].head * decks[l + size - 1].tail);
        }
        dp[l][l + size - 1] = cost;
      }
    }
    System.out.println(dp[0][decks.length - 1]);
  }
}
