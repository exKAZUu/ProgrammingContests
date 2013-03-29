package AOJ;

import java.io.InputStream;
import java.util.Scanner;

public class Problem2216 {
  public static void main(String[] args) {
    new Problem2216().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int A = sc.nextInt();
      int B = sc.nextInt();
      if (A == 0 && B == 0) {
        break;
      }
      int ret = B - A;
      int a1 = 0, a2 = 0, a3 = 0;
      while (ret >= 1000) {
        a3++;
        ret -= 1000;
      }
      while (ret >= 500) {
        a2++;
        ret -= 500;
      }
      while (ret >= 100) {
        a1++;
        ret -= 100;
      }
      System.out.println(a1 + " " + a2 + " " + a3);
    }
  }
}
