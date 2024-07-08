using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    //интерфейс героя
    public interface ICharacter
    {
        //имя героя
        string Name { get; }
        //тип атаки
        string AttackType { get; }
        //сложность
        int Difficulty { get; }
        //атрибут
        string Attribut { get; }
        //иконка героя
        Image Image { get; }
        //описание героя
        string Info { get; }
        //изображение 1 навыка
        Image skill1 { get; }
        //изображение 2 навыка
        Image skill2 { get; }
        //изображение 3 навыка
        Image skill3 { get; }
        //изображение 4 навыка
        Image skill4 { get; }
        //изображение героя
        Image HeroFull { get; }
        //описание 1 навыка
        string Skill1Info { get; }
        //описание 2 навыка
        string Skill2Info { get; }
        //описание 3 навыка
        string Skill3Info { get; }
        //описание 4 навыка
        string Skill4Info { get; }
    }
}
