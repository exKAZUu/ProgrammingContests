using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UPLC2013 {
    internal class ProblemC {
        //private static void Main(string[] args) {
        //    new ProblemC().Solve(Console.In);
        //}

        private bool CanMove(List<string> map, int wallX, int wallY, int tox, int toy) {
            if (!(0 <= tox && tox < map[0].Length && 0 <= toy && toy < map.Count)) {
                return false;
            }
            return map[wallY][wallX] == '0';
        }

        private static readonly Tuple<int, int>[] dxys = new[] {
                Tuple.Create(0, 1),
                Tuple.Create(1, 0),
                Tuple.Create(0, -1),
                Tuple.Create(-1, 0),
        };

        private void Solve(TextReader reader) {
            while (true) {
                var whs = reader.ReadLine().Split(' ').Select(s => int.Parse(s.Trim())).ToList();
                var width = whs[0];
                var height = whs[1];
                if (width == 0 && height == 0) {
                    return;
                }

                var map = new List<string>();
                for (int i = 0; i < height * 2 - 1; i++) {
                    var text = reader.ReadLine();
                    if (text.StartsWith(" ") && !text.EndsWith(" ")) {
                        text += " ";
                    }
                    map.Add(text);
                }

                var count = 0;
                var que = new Queue<Tuple<int, int>>();
                var newQue = new Queue<Tuple<int, int>>();
                var walked = new HashSet<Tuple<int, int>>();
                que.Enqueue(Tuple.Create(0, 0));
                while (!que.Contains(Tuple.Create(2 * width - 2, 2 * height - 2)) && que.Count > 0) {
                    newQue.Clear();

                    while (que.Count > 0) {
                        var p = que.Dequeue();
                        var x = p.Item1;
                        var y = p.Item2;

                        foreach (var dxy in dxys) {
                            if (!walked.Contains(Tuple.Create(x + dxy.Item1 * 2,
                                    y + dxy.Item2 * 2))) {
                                if (CanMove(map, x + dxy.Item1, y + dxy.Item2, x + dxy.Item1 * 2,
                                        y + dxy.Item2 * 2)) {
                                    newQue.Enqueue(Tuple.Create(x + dxy.Item1 * 2, y + dxy.Item2 * 2));
                                    walked.Add(Tuple.Create(x + dxy.Item1 * 2, y + dxy.Item2 * 2));
                                }
                            }
                        }
                    }

                    var tmpQue = que;
                    que = newQue;
                    newQue = tmpQue;
                    count++;
                }

                if (que.Count == 0) {
                    Console.WriteLine(0);
                } else {
                    Console.WriteLine(count + 1);
                }
            }
        }
    }
}