package Domestic2006Practice;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

public class ProblemB {

  public static void main(String[] args) {
    new ProblemB().solve(System.in);
  }

  private static class HorizontalLine {
    public int height;
    public int left;
    public int right;

    public HorizontalLine(int height, int left, int right) {
      this.height = height;
      this.left = left;
      this.right = right;
    }
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int nVerticalLines = sc.nextInt();
      int nHorizontalLines = sc.nextInt();
      int currentLine = sc.nextInt();

      if (nVerticalLines == 0) {
        break;
      }

      HashMap<Integer, List<HorizontalLine>> hashMap = new HashMap<Integer, List<HorizontalLine>>();
      for (int h = 0; h <= 1000; h++) {
        hashMap.put(h, new ArrayList<HorizontalLine>());
      }

      for (int i = 0; i < nHorizontalLines; i++) {
        HorizontalLine line = new HorizontalLine(sc.nextInt(), sc.nextInt(), sc.nextInt());
        hashMap.get(line.height).add(line);
      }

      for (int height = 1000; height >= 0; height--) {
        currentLine = nextLine(hashMap, height, currentLine);
      }
      System.out.println(currentLine);
    }
  }

  private int nextLine(Map<Integer, List<HorizontalLine>> lines, int height, int currentLine) {
    for (HorizontalLine line : lines.get(height)) {
      if (line.left == currentLine) {
        return line.right;
      }
      if (line.right == currentLine) {
        return line.left;
      }
    }
    return currentLine;
  }
}
