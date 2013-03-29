package Math;

import java.util.ArrayList;
import java.util.List;

public class Line2 {
  public final Point2 p1, p2;
  public final Vector2 v;
  public final double a, b, c;

  public Line2(Point2 p1, Point2 p2) {
    if (p1.x > p2.x || (p1.x == p2.x && p1.y > p2.y)) {
      Point2 p = p1;
      p1 = p2;
      p2 = p;
    }
    this.p1 = p1;
    this.p2 = p2;
    this.v = p2.sub(p1);
    this.a = p2.y - p1.y;
    this.b = p1.x - p2.x;
    this.c = -(a * p1.x + b * p1.y);
  }

  public Vector2 perpendicular(Point2 p) {
    double l = v.length();
    Vector2 v = new Vector2(p2.x - p1.x / l, p2.y - p1.y / l);
    double k = -(a * p.x + b * p.y + c) / (a * v.x + b * v.y);
    return v.mul(k);
  }

  public Point2 foot(Point2 p) {
    return p.add(perpendicular(p));
  }

  public boolean on(Point2 p) {
    return XMath.bigger(p.sub(p1).length() + p2.sub(p).length(), v.length());
  }

  public List<Point2> cross(Circle2 c) {
    List<Point2> ps = new ArrayList<Point2>();
    Vector2 vf = perpendicular(c.p);
    if (XMath.bigger(vf.length(), c.r)) {
      return ps;
    }
    double s = Math.sqrt(c.r * c.r - vf.length() * vf.length());
    Point2 pf = c.p.add(vf);
    Point2 p1 = new Point2(pf.x + s * v.x, pf.y + s * v.y);
    Point2 p2 = new Point2(pf.x - s * v.x, pf.y - s * v.y);
    if (on(p1)) {
      ps.add(p1);
    }
    if (on(p2)) {
      ps.add(p2);
    }
    return ps;
  }
}
