package AOJ;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.Scanner;

public class Problem2300 {
  private double[][] distances;

  static class Color {
    double l, a, b;

    public Color(double l, double a, double b) {
      super();
      this.l = l;
      this.a = a;
      this.b = b;
    }

    public double distance(Color that) {
      double dl = l - that.l;
      double da = a - that.a;
      double db = b - that.b;
      return dl * dl + da * da + db * db;
    }
  }

  public static void main(String[] args) {
    new Problem2300().solve(System.in);
  }

  private double caclulateSum(double[][] distances, ArrayList<Integer> indexes) {
    double sum = 0;
    for (int i = 0; i < indexes.size(); i++) {
      for (int j = i + 1; j < indexes.size(); j++) {
        sum += distances[indexes.get(i)][indexes.get(j)];
      }
    }
    return sum;
  }

  private double find(ArrayList<Integer> indexes, int nextIndex, int count) {
    if (count == 0) {
      return caclulateSum(distances, indexes);
    }
    if (distances.length <= nextIndex) {
      return 0;
    }
    ArrayList<Integer> newIndexes = new ArrayList<Integer>(indexes);
    newIndexes.add(nextIndex);
    return Math.max(find(indexes, nextIndex + 1, count),
        find(newIndexes, nextIndex + 1, count - 1));
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    int N = sc.nextInt();
    int M = sc.nextInt();

    Color[] colors = new Color[N];
    for (int i = 0; i < N; i++) {
      colors[i] = new Color(sc.nextDouble(), sc.nextDouble(), sc.nextDouble());
    }

    distances = new double[colors.length][colors.length];
    for (int i = 0; i < distances.length; i++) {
      for (int j = 0; j < distances.length; j++) {
        distances[i][j] = distances[j][i] = colors[i].distance(colors[j]);
      }
    }
    System.out.println(find(new ArrayList<Integer>(), 0, M));
  }
}
