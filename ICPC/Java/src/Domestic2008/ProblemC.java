package Domestic2008;

import java.io.InputStream;
import java.util.Scanner;

abstract class Expression {
	public abstract int eval(int p, int q, int r);
}

class Const extends Expression {

	private int value;

	public Const(int value) {
		this.value = value;
	}

	@Override
	public int eval(int p, int q, int r) {
		return value;
	}
}

class Variable extends Expression {

	private char variable;

	public Variable(char variable) {
		this.variable = variable;
	}

	@Override
	public int eval(int p, int q, int r) {
		if (variable == 'P') {
			return p;
		} else if (variable == 'Q') {
			return q;
		}
		return r;
	}
}

class Multiple extends Expression {

	private Expression left;
	private Expression right;

	public Multiple(Expression left, Expression right) {
		this.left = left;
		this.right = right;
	}

	@Override
	public int eval(int p, int q, int r) {
		int leftValue = left.eval(p, q, r);
		int rightValue = right.eval(p, q, r);
		if (leftValue == 0 || rightValue == 0) {
			return 0;
		}
		if (leftValue == 1 || rightValue == 1) {
			return 1;
		}
		return 2;
	}
}

class Addition extends Expression {

	private Expression left;
	private Expression right;

	public Addition(Expression left, Expression right) {
		this.left = left;
		this.right = right;
	}

	@Override
	public int eval(int p, int q, int r) {
		int leftValue = left.eval(p, q, r);
		int rightValue = right.eval(p, q, r);
		if (leftValue == 2 || rightValue == 2) {
			return 2;
		}
		if (leftValue == 1 || rightValue == 1) {
			return 1;
		}
		return 0;
	}
}

class Not extends Expression {
	private Expression expression;

	public Not(Expression expression) {
		this.expression = expression;
	}

	@Override
	public int eval(int p, int q, int r) {
		int eval = expression.eval(p, q, r);
		if (eval == 0) {
			return 2;
		} else if (eval == 1) {
			return 1;
		}
		return 0;
	}
}

public class ProblemC {

	public static void main(String[] args) {
		new ProblemC().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			String line = sc.nextLine();
			if (line.equals(".")) {
				break;
			}
			index = 0;
			Expression expression = parse(line);
			int count = 0;
			for (int p = 0; p <= 2; p++) {
				for (int q = 0; q <= 2; q++) {
					for (int r = 0; r <= 2; r++) {
						if (expression.eval(p, q, r) == 2) {
							count++;
						}
					}
				}
			}
			System.out.println(count);
		}
	}

	private int index = 0;

	private Expression parse(String str) {
		char ch = str.charAt(index++);
		if (ch == '0' || ch == '1' || ch == '2') {
			return new Const((int) (ch - '0'));
		} else if (ch == 'P' || ch == 'Q' || ch == 'R') {
			return new Variable(ch);
		} else if (ch == '-') {
			return new Not(parse(str));
		} else if (ch == '(') {
			Expression left = parse(str);
			char sign = str.charAt(index++);
			Expression right = parse(str);
			index++;
			if (sign == '+') {
				return new Addition(left, right);
			} else {
				return new Multiple(left, right);
			}
		}
		return null;
	}
}
