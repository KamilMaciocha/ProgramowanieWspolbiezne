using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data {
    public class Ball {
        private int _x;
        private int _y;
        private int _xDirection;
        private int _yDirection;

        public Ball() {
            _x = 0;
            _y = 0;
            _xDirection = 0;
            _yDirection = 0;
        }

        public Ball (int x, int y, int xDirection, int yDirection) {
            _x = x;
            _y = y;
            _xDirection = xDirection;
            _yDirection = yDirection;
        }

        public int x() {
            return _x;
        }
        public int y() {
            return _y;
        }

        public int xDirection() {
            return _xDirection;
        }

        public int yDirection() {
            return _yDirection;
        }

    }
}
