using System;
using System.Collections.Generic;
using System.Text;

namespace MySparseMatrix
{
    public class SparseMatrix<T>
    {
        Dictionary<string, T> matrix = new Dictionary<string, T>();
        int maxX, maxY, maxZ;
        T nullElement;
        public SparseMatrix(int px, int py, int pz, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this.matrix.ContainsKey(key))
                {
                    return this.matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this.matrix.Add(key, value);
            }
        }
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + "going out of bounds");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + "going out of bounds");
            if (z < 0 || z >= this.maxZ) throw new Exception("z=" + z + "going out of bounds");
        }
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + " " + y.ToString() + " " + z.ToString();
        }
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append("[");
                for (int j = 0; j < this.maxY; j++)
                {
                    if (j > 0) b.Append(",\t");
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0) b.Append(";\t");
                        if (this[i, j, k] != null)
                            b.Append(this[i, j, k].ToString());
                        else
                            b.Append("null");
                    }
                    b.Append("]");
                }
                b.Append("]\n");
            }
            return b.ToString();
        }
    }
}
