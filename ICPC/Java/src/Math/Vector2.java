package Math;

public class Vector2 {
  public final double x;
  public final double y;

  public Vector2(double x, double y) {
    this.x = x;
    this.y = y;
  }

  public Vector2 add(Vector2 v) {
    return new Vector2(x + v.x, y + v.y);
  }

  public Vector2 sub(Vector2 v) {
    return new Vector2(x - v.x, y - v.y);
  }

  public Vector2 mul(double factor) {
    return new Vector2(x * factor, y * factor);
  }

  public Vector2 div(double factor) {
    return new Vector2(x / factor, y / factor);
  }

  public double inner(Vector2 v) {
    // |v1| * |v2| * cosθ
    return x * v.x + y * v.y;
  }

  public double outer(Vector2 v) {
    // |v1| * |v2| * sinθ
    // v1 から v2 に重なる場合，反時計回りだと正，時計回りだと負
    // (v2.x, v2.y)がv1より左側に位置すると正，右側に位置すると負
    return x * v.y - y * v.x;
  }

  public double length() {
    return Math.sqrt(x * x + y * y);
  }
}
