package Domestic2011;

import java.io.InputStream;
import java.util.List;
import java.util.Scanner;

import Math.Circle2;
import Math.Line2;
import Math.Point2;

public class ProblemF {

  public static void main(String[] args) {
    new ProblemF().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      double r = sc.nextInt();
      double x1 = sc.nextInt();
      double x2 = sc.nextInt();
      double y1 = sc.nextInt();
      double y2 = sc.nextInt();
      if (r == 0) {
        break;
      }

      double ans = calculate(r, x1, x2, y1, y2);
      System.out.println(ans);
    }
  }

  private double calculate(double r, double x1, double x2, double y1, double y2) {
    if (y1 < 0) {
      double d = y1;
      y1 = -y2;
      y2 = -d;
    }
    if (x2 < 0) {

    }

    Point2 p1 = new Point2(x1, y1);
    Point2 p2 = new Point2(x1, y2);
    Point2 p3 = new Point2(x2, y2);
    Point2 p4 = new Point2(x2, y1);

    Line2 l1 = new Line2(p1, p2);
    Line2 l2 = new Line2(p2, p3);
    Line2 l3 = new Line2(p3, p4);
    Line2 l4 = new Line2(p4, p1);

    Circle2 c = new Circle2(new Point2(0, 0), r);

    // 全ての線分との交点を求める
    List<Point2> ps1 = l1.cross(c);
    List<Point2> ps2 = l2.cross(c);
    List<Point2> ps3 = l3.cross(c);
    List<Point2> ps4 = l4.cross(c);

    if (ps1.size() + ps2.size() + ps3.size() + ps4.size() <= 1) {
      return 2 * Math.PI * r;
    }

    if (ps1.size() == 2) {
      if (ps3.size() == 2) {

      }
    }

    return 0;
  }
}
