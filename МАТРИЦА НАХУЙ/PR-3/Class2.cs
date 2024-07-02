using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace PR_3
{
    internal class Class2
    {
        public Class2() 
        {
        }
         public int[,] Ner(int[,]  matrix, int columns, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                // Нахождение максимального элемента в строке
                int maxIndex = 0;
                for (int j = 1; j < columns; j++)
                {
                    if (matrix[i, j] > matrix[i, maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                // Вычисление произведения остальных элементов в строке
                int product = 1;
                for (int j = 0; j < columns; j++)
                {
                    if (j != maxIndex)
                    {
                        product *= matrix[i, j];
                    }
                }

                // Замена максимального элемента на произведение
                matrix[i, maxIndex] = product;
            }
            return matrix;
        }
    }
}
