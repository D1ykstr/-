using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ListHeroDif : List<Character>
    {
        //сортировка героев по сложности
        public void SortByDif()
        {
            Sort(new CompareHeroes());
        }
    }
}
