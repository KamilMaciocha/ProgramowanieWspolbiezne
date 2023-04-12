using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data {
    public abstract class DataAPI {
        public abstract void add(Ball newBall);
        public abstract void remove(int index);
        public abstract void clear();
        public abstract Ball get(int index);
        public abstract int size();
    }
}
