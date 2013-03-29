package Math;

public class XMath {
  public static final double epsilon = 1e-10;

  private XMath() {

  }

  public static boolean equal(double d1, double d2) {
    return Math.abs(d1 - d2) <= epsilon;
  }

  public static boolean bigger(double d1, double d2) {
    return d1 + epsilon > d2;
  }

  public static boolean smaller(double d1, double d2) {
    return d1 < d2 + epsilon;
  }
}
