package Domestic2007Practice;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.Scanner;

public class ProblemB {

  static class Range {
    int start;
    int end;

    public Range(int start, int end) {
      this.start = start;
      this.end = end;
    }
  }

  public static void main(String[] args) {
    new ProblemB().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int n = sc.nextInt();
      if (n == 0) {
        break;
      }
      ArrayList<Range> ranges = new ArrayList<Range>();
      for (int i = 0; i < n; i++) {
        int start = parse(sc.next());
        int end = parse(sc.next());
        ranges.add(new Range(start, end));
      }

      int max = 0;
      for (Range range : ranges) {
        int count = 0, count2 = 0;
        for (Range range2 : ranges) {
          if (range2.start <= range.start && range.start < range2.end) {
            count++;
          }
          if (range2.start < range.end && range.end <= range2.end) {
            count2++;
          }
        }
        max = Math.max(max, Math.max(count2, count));
      }
      System.out.println(max);
    }
  }

  private int parse(String time) {
    String[] times = time.split(":");
    int h = Integer.parseInt(times[0]);
    int m = Integer.parseInt(times[1]);
    int s = Integer.parseInt(times[2]);
    return h * 60 * 60 + m * 60 + s;
  }

}
