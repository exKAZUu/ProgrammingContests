package Domestic2009;

import java.io.InputStream;
import java.util.Scanner;

public class ProblemB {

  /**
   * @param args
   */
  public static void main(String[] args) {
    new ProblemB().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner scanner = new Scanner(in);

    while (true) {
      int w = scanner.nextInt();
      int h = scanner.nextInt();
      if (w == 0 && h == 0) {
        break;
      }

      boolean[][] map = new boolean[h + 2][w + 2];
      for (int y = 1; y <= h; y++) {
        for (int x = 1; x <= w; x++) {
          map[y][x] = scanner.nextInt() == 1;
        }
      }

      int count = 0;
      for (int y = 1; y <= h; y++) {
        for (int x = 1; x <= w; x++) {
          if (search(map, w, h, x, y)) {
            count++;
          }
        }
      }
      System.out.println(count);
    }
  }

  int[] dx = {-1, -1, -1, 0, 0, 0, 1, 1, 1};
  int[] dy = {-1, 0, 1, -1, 0, 1, -1, 0, 1,};

  private boolean search(boolean[][] map, int w, int h, int x, int y) {
    if (map[y][x] == false) {
      return false;
    }
    map[y][x] = false;
    for (int i = 0; i < dx.length; i++) {
      search(map, w, h, x + dx[i], y + dy[i]);
    }
    return true;
  }
}
