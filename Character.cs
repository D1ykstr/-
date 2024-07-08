using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //базовый класс
    internal class Character: ICharacter
    {
        //контруктор класса
        public string Name { get; set; }
        public string AttackType { get; set; } 
        public int Difficulty { get; set; } 
        public string Attribut { get; set; }
        public Image Image { get; set; }
        public string Info { get; set; }
        public Image skill1 { get; set; }
        public Image skill2 { get; set; }
        public Image skill3 { get; set; }
        public Image skill4 { get; set; }
        public Image HeroFull { get; set; }
        public string Skill1Info { get; set; }
        public string Skill2Info { get; set; }
        public string Skill3Info { get; set; }
        public string Skill4Info { get; set; }

        public Character(string name, string attackType, int difficulty, string attribut, Image image, string info, Image skill1, Image skill2, Image skill3, Image skill4, Image herofull, string skill1Info, string skill2Info, string skill3Info, string skill4Info)
        {
            Name = name;
            AttackType = attackType;
            Difficulty = difficulty;
            Attribut = attribut;
            Image = image;
            Info = info;
            this.skill1 = skill1;
            this.skill2 = skill2;
            this.skill3 = skill3;
            this.skill4 = skill4;
            HeroFull = herofull;
            Skill1Info = skill1Info;
            Skill2Info = skill2Info;
            Skill3Info = skill3Info;
            Skill4Info = skill4Info;
        }
    }
}
