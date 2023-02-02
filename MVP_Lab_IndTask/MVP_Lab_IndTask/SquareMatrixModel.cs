using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Lab_IndTask
{
    internal class SquareMatrixModel
    {
        private int size;
        private double[,] matrix;
        public int Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else size = value;
            }

        }
        public double[,] Matrix
        {
            
            get 
            {
                Random random = new Random();
                double[,] m = new double[Size, Size];
                for (int i = 0; i < this.Size; i++)
                {
                    for (int j = 0; j < this.Size; j++)
                    {
                        m[i, j] = random.Next(0,1000);
                    }
                }
                return m; 
            }
            set 
            { 
                
                matrix = value;
            }
        }
       
        public string PrintMatrix()
        {
           
           StringBuilder stringBuilder=new StringBuilder();
           
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    stringBuilder.Append(Matrix[i, j] + "  ");
                }
                stringBuilder.Append("\n"); 
            }
            return stringBuilder.ToString();    
        }

        

    }
}
