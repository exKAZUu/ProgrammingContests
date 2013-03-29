package Domestic2005;

import java.io.InputStream;
import java.util.Scanner;

public class ProblemC {

  public static void main(String[] args) {
    new ProblemC().solve(System.in);
  }

  private static int[] char2int = new int[256];

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);

    char2int['m'] = 1000;
    char2int['c'] = 100;
    char2int['x'] = 10;
    char2int['i'] = 1;

    int n = sc.nextInt();
    for (int i = 0; i < n; i++) {
      String left = sc.next();
      String right = sc.next();
      System.out.println(to(from(left) + from(right)));
    }
  }

  private int from(String str) {
    int sum = 0;
    for (int i = 0; i < str.length(); i++) {
      if (Character.isDigit(str.charAt(i))) {
        sum += char2int[str.charAt(i + 1)] * (str.charAt(i) - '0');
        i++;
      } else {
        sum += char2int[str.charAt(i)];
      }
    }
    return sum;
  }

  private String to(int value) {
    String result = "";
    int[] vs = new int[] {value / 1000, value / 100 % 10, value / 10 % 10, value % 10};
    char[] cs = new char[] {'m', 'c', 'x', 'i'};

    for (int i = 0; i < vs.length; i++) {
      if (vs[i] <= 0) {
        continue;
      }
      if (vs[i] != 1) {
        result += vs[i];
      }
      result += cs[i];
    }

    return result;
  }
}
