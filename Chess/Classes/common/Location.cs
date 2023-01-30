using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Classes.common
{
    public class Location
    {
        private readonly File file;
        private readonly int rank;

        public Location(File file, int rank)
        {
            this.file = file;
            this.rank = rank;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public File getfile()
        {
            return file;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int getrank()
        {
            return rank;
        }


    }
}
