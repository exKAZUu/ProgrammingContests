package AOJ;

import java.io.InputStream;
import java.util.HashMap;
import java.util.Scanner;

public class Problem1148 {

  static class Usage {
    int student;
    int pc;

    public Usage(int student, int pc) {
      super();
      this.student = student;
      this.pc = pc;
    }

    @Override
    public int hashCode() {
      final int prime = 31;
      int result = 1;
      result = prime * result + pc;
      result = prime * result + student;
      return result;
    }

    @Override
    public boolean equals(Object obj) {
      if (this == obj) return true;
      if (obj == null) return false;
      if (getClass() != obj.getClass()) return false;
      Usage other = (Usage) obj;
      if (pc != other.pc) return false;
      if (student != other.student) return false;
      return true;
    }
  }

  public static void main(String[] args) {
    new Problem1148().solve(System.in);
  }

  private void solve(InputStream in) {
    Scanner sc = new Scanner(in);
    while (true) {
      int nPCs = sc.nextInt();
      int nStudents = sc.nextInt();
      if (nPCs == 0 && nStudents == 0) {
        break;
      }
      int nRecords = sc.nextInt();
      HashMap<Usage, Integer> usages = new HashMap<Usage, Integer>();
      boolean[][] timeTable = new boolean[nStudents + 1][1260 - 540 + 1];
      for (int i = 0; i < nRecords; i++) {
        int t = sc.nextInt() - 540;
        int pc = sc.nextInt();
        int student = sc.nextInt();
        int s = sc.nextInt();
        Usage usage = new Usage(student, pc);
        if (s == 1) {
          // login
          usages.put(usage, t);
        } else {
          int startTime = usages.get(usage);
          for (int time = startTime; time < t; time++) {
            timeTable[student][time] = true;
          }
        }
      }

      int nQueries = sc.nextInt();
      for (int i = 0; i < nQueries; i++) {
        int start = sc.nextInt() - 540;
        int end = sc.nextInt() - 540;
        int student = sc.nextInt();
        int ans = 0;
        for (int t = start; t < end; t++) {
          if (timeTable[student][t]) {
            ans++;
          }
        }
        System.out.println(ans);
      }
    }
  }
}
