package AOJ;

import java.io.InputStream;
import java.util.Scanner;

public class Problem0560 {

  public static void main(String[] args) {
    new Problem0560().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    int M = sc.nextInt();
    int N = sc.nextInt();
    int K = sc.nextInt();
    int[][] js = new int[M + 1][N + 1];
    int[][] os = new int[M + 1][N + 1];
    int[][] is = new int[M + 1][N + 1];

    for (int y = 1; y <= M; y++) {
      String line = sc.next();
      for (int x = 1; x <= line.length(); x++) {
        char ch = line.charAt(x - 1);
        js[y][x] = js[y - 1][x] + js[y][x - 1] - js[y - 1][x - 1] + (ch == 'J' ? 1 : 0);
        os[y][x] = os[y - 1][x] + os[y][x - 1] - os[y - 1][x - 1] + (ch == 'O' ? 1 : 0);
        is[y][x] = is[y - 1][x] + is[y][x - 1] - is[y - 1][x - 1] + (ch == 'I' ? 1 : 0);
      }
    }

    for (int i = 0; i < K; i++) {
      int y1 = sc.nextInt() - 1;
      int x1 = sc.nextInt() - 1;
      int y2 = sc.nextInt();
      int x2 = sc.nextInt();
      int aj = js[y2][x2] - js[y2][x1] - js[y1][x2] + js[y1][x1];
      int ao = os[y2][x2] - os[y2][x1] - os[y1][x2] + os[y1][x1];
      int ai = is[y2][x2] - is[y2][x1] - is[y1][x2] + is[y1][x1];
      System.out.println(aj + " " + ao + " " + ai);
    }
  }
}
