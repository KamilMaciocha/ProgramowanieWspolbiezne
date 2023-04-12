using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data {
    public class Surface {
        private int _width;
        private int _height;

        public Surface() {
            _width = 451;
            _height = 368;
        }

        public int width() {
            return _width;
        }

        public int height() {
            return _height;
        }
    }
}
