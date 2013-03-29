package AOJ;

import java.io.InputStream;
import java.util.Scanner;

public class Problem2012 {
  public static void main(String[] args) {
    new Problem2012().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int e = sc.nextInt();
      if (e == 0) {
        break;
      }
      int ans = Integer.MAX_VALUE;
      for (int z = 0; z * z * z <= e; z++) {
        int m = e - z * z * z;
        int y = (int) Math.sqrt(m);
        int x = m - y * y;
        ans = Math.min(ans, x + y + z);
      }
      System.out.println(ans);
    }
  }
}
