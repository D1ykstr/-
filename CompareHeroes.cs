using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CompareHeroes : IComparer<Character>
    {
        //сравнение героев по сложности
        public int Compare(Character x, Character y)
        {
            return x.Difficulty.CompareTo(y.Difficulty);
        }
    }
}
