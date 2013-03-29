package AOJ;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.Scanner;

public class Problem0509 {

  static class Rect {
    int x1, y1;
    int x2, y2;

    public Rect(int x1, int y1, int x2, int y2) {
      super();
      this.x1 = x1;
      this.y1 = y1;
      this.x2 = x2;
      this.y2 = y2;
    }
  }

  public static void main(String[] args) {
    new Problem0509().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int nRects = sc.nextInt();
      int type = sc.nextInt();
      if (nRects == 0 && type == 0) {
        return;
      }
      int[] table = new int[10002 * 10002 / 32 + 1];
      int[] table2 = new int[10002 * 10002 / 32 + 1];
      ArrayList<Rect> rects = new ArrayList<Rect>();

      int s = 0;
      for (int i = 0; i < nRects; i++) {
        int x1 = sc.nextInt() + 1;
        int y1 = sc.nextInt() + 1;
        int x2 = sc.nextInt() + 1;
        int y2 = sc.nextInt() + 1;
        rects.add(new Rect(x1, y1, x2, y2));
        for (int x = x1; x < x2; x++) {
          for (int y = y1; y < y2; y++) {
            s += 1 - setAndGet(table, x, y);
          }
        }
      }

      System.out.println(s);
      if (type == 2) {
        int length = 0;
        for (Rect rect : rects) {
          int x1 = rect.x1;
          int y1 = rect.y1;
          int x2 = rect.x2 - 1;
          int y2 = rect.y2 - 1;
          for (int x = x1 + 1; x <= x2 - 1; x++) {
            if (get(table2, x, y1) == 0) {
              length += 1 - get(table, x, y1 - 1);
            }
            if (get(table2, x, y2) == 0) {
              length += 1 - get(table, x, y2 + 1);
            }
            set(table2, x, y1);
            set(table2, x, y2);
          }
          for (int y = y1 + 1; y <= y2 - 1; y++) {
            if (get(table2, x1, y) == 0) {
              length += 1 - get(table, x1 - 1, y);
            }
            if (get(table2, x2, y) == 0) {
              length += 1 - get(table, x2 + 1, y);
            }
            set(table2, x1, y);
            set(table2, x2, y);
          }
          if (get(table2, x1, y1) == 0) {
            set(table2, x1, y1);
            length += 1 - get(table, x1 - 1, y1);
            length += 1 - get(table, x1 + 1, y1);
            length += 1 - get(table, x1, y1 - 1);
            length += 1 - get(table, x1, y1 + 1);
          }
          if (get(table2, x2, y1) == 0) {
            set(table2, x2, y1);
            length += 1 - get(table, x2 - 1, y1);
            length += 1 - get(table, x2 + 1, y1);
            length += 1 - get(table, x2, y1 - 1);
            length += 1 - get(table, x2, y1 + 1);
          }
          if (get(table2, x1, y2) == 0) {
            set(table2, x1, y2);
            length += 1 - get(table, x1 - 1, y2);
            length += 1 - get(table, x1 + 1, y2);
            length += 1 - get(table, x1, y2 - 1);
            length += 1 - get(table, x1, y2 + 1);
          }
          if (get(table2, x2, y2) == 0) {
            set(table2, x2, y2);
            length += 1 - get(table, x2 - 1, y2);
            length += 1 - get(table, x2 + 1, y2);
            length += 1 - get(table, x2, y2 - 1);
            length += 1 - get(table, x2, y2 + 1);
          }
        }
        System.out.println(length);
      }
    }
  }

  int setAndGet(int[] table, int x, int y) {
    int i = x * 10002 + y;
    int v = table[i >> 5];
    int r = (v >>> (i & 31)) & 1;
    table[i >> 5] = v | (1 << (i & 31));
    return r;
  }

  void set(int[] table, int x, int y) {
    int i = x * 10002 + y;
    table[i >> 5] |= (1 << (i & 31));
  }

  void clear(int[] table, int x, int y) {
    int i = x * 10002 + y;
    table[i >> 5] &= ~(1 << (i & 31));
  }

  int get(int[] table, int x, int y) {
    int i = x * 10002 + y;
    return (table[i >> 5] >>> (i & 31)) & 1;
  }
}
