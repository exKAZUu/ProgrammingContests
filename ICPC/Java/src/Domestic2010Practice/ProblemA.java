package Domestic2010Practice;

import java.io.InputStream;
import java.util.Scanner;

public class ProblemA {
  public static void main(String[] args) {
    new ProblemA().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int N = sc.nextInt();
      if (N == 0) {
        break;
      }

      int count = 0;
      for (int i = 1; i < N; i++) {
        int sum = 0;
        for (int j = i; j < N; j++) {
          sum += j;
          if (sum >= N) {
            if (sum == N) {
              count++;
            }
            break;
          }
        }
      }

      System.out.println(count);
    }
  }
}
