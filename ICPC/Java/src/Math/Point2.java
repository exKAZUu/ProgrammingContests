package Math;

public class Point2 {
  public final double x;
  public final double y;

  public Point2(double x, double y) {
    this.x = x;
    this.y = y;
  }

  public Point2 add(Vector2 v) {
    return new Point2(x + v.x, y + v.y);
  }

  public Vector2 sub(Point2 to) {
    return new Vector2(to.x - x, to.y - y);
  }
}
