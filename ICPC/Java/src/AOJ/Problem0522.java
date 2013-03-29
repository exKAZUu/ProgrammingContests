package AOJ;

import java.io.InputStream;
import java.util.Scanner;

public class Problem0522 {

  public static void main(String[] args) {
    new Problem0522().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (sc.hasNext()) {
      String line = sc.next();
      int joi = 0;
      int ioi = 0;
      for (int i = 0; i < line.length() - 2; i++) {
        if (line.charAt(i + 1) == 'O' && line.charAt(i + 2) == 'I') {
          if (line.charAt(i) == 'J') {
            joi++;
          } else if (line.charAt(i) == 'I') {
            ioi++;
          }
        }
      }
      System.out.println(joi);
      System.out.println(ioi);
    }
  }
}
