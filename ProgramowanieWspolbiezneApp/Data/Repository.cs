using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data {
    internal class Repository : DataAPI {
        private List<Ball> balls;

        public Repository() {
            balls = new List<Ball>();
        }

        public Repository(List<Ball> list) {
            balls = list;
        }

        public override void add(Ball newBall) {
            balls.Add(newBall);
        }

        public override void clear() {
            balls.Clear();
        }

        public override Ball get(int index) {
            return balls[index];
        }

        public override void remove(int index) {
            balls.Remove(get(index));
        }

        public override int size() {
            return balls.Count;
        }
    }
}
