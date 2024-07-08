using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Лист с информацией о героях
        public List<ICharacter> heroes = new List<ICharacter>
        {
            new Character("Pudge", "sword", 3, "strenght", Resources.pudge, "Каждый точный бросок знаменитого крюка вселяет\nстрах во врагов Pudge, ведь, притянув жертву, он\nрасчленяет её своим тесаком. С каждым убийством его\nздоровье и урон увеличиваются, и вскоре погибель от\nего рук становится неизбежной.", Resources.pudge_meat_hook, Resources.pudge_rot, Resources.pudge_flesh_heap, Resources.pudge_dismember, Resources.pudgeForm2, "MEAT HOOK\r\nБросает окровавленный крюк в указанную цель\nили в выбранном направлении. Крюк зацепится\nза первое существо, в которое попадёт,\nи притащит его к владельцу способности.", "ROT\r\nЯдовитое облако, которое замедляет\nврагов и наносит значительный урон\nкак им, так и владельцу способности.", "MEAT SHIELD\r\nГерой покрывает себя слоем плоти,\nкоторый блокирует часть любого получаемого\nурона.", "DISMEMBER\r\nПРЕРЫВАЕМАЯ — герой заживо пожирает\nврага, оглушая его и нанося\nпериодический урон"),
            new Character("Alchemist", "sword", 2, "strenght", Resources.alchemist, "Alchemist, синтезирующий дополнительные средства\nза каждое убийство, с лёгкостью получает необходимое\nвооружение. Он сражается во имя своей жадности,\nиспользуя едкую кислоту и запас нестабильных\nхимикатов.", Resources.alchemist_acid_spray, Resources.alchemist_unstable_concoction, Resources.alchemist_corrosive_weaponry, Resources.alchemist_chemical_rage, Resources.alchemistForm2, "ACID SPRAY\r\nРаспыляет в указанной области облако\nкислоты, которое наносит врагам\nпериодический урон и снижает их броню.", "UNSTABLE CONCOCTION\r\nГерой начинает встряхивать колбу\nс гремучей смесью, которую можно\nбросить во вражеского героя.\nПри попадании колба взорвётся, оглушив\nвсех противников в радиусе взрыва", "CORROSIVE WEAPONRY\r\nПокрытое кислотой оружие героя снижает\nскорость передвижения и базовый урон\nу жертв его атак. Этот эффект складывается.", "CHEMICAL RAGE\r\nОсобая химическая смесь разъяряет\nгероя, отчего задержка перед его\nатакой уменьшается, а скорость его\nпередвижения и восстановление здоровья\nувеличиваются."),
            new Character("Chaos_Knight", "sword", 2, "strenght", Resources.chaos_knight, "Chaos Knight — сам по себе армия. Он способен\nпризывать кавалерию своих двойников и разрушать\nпостройки врага, а когда покажутся защитники, он\nрасколет реальность и перенесёт себя и свои копии на\nрасстояние, достаточное для рокового взмаха булавы.", Resources.chaos_knight_chaos_bolt, Resources.chaos_knight_reality_rift, Resources.chaos_knight_chaos_strike, Resources.chaos_knight_phantasm, Resources.chaos_knightForm2, "HAOS BOLT\r\nВыпускает таинственный заряд энергии\nв указанного врага, оглушая его на\nслучайное время и нанося случайный урон.", "REALITY RIFT\r\nПереносит героя, все его иллюзии\nи выбранного врага в точку\nмежду владельцем способности\nи жертвой.", "CHAOS STRIKE\r\nГерой и его иллюзии имеют шанс\nсовершить критическую атаку\nслучайной силы и восстановить себе\nздоровье на часть от нанесённого урона. ", "PHANTASM\r\nПризывает несколько копий героя из\nпараллельных измерений.\nКопии являются иллюзиями, наносят\n100% урона, а получают 350% урона."),
            new Character("AntiMage", "sword", 1, "agility", Resources.antimage, "Если Anti-Mage наберёт полную силу, мало кто сможет\nего остановить. Он способен забирать у врагов ману\nкаждым ударом или телепортироваться на небольшие\nрасстояния, что не позволяет врагам загнать его в угол.", Resources.antimage_blink, Resources.antimage_counterspell, Resources.antimage_mana_void, null, Resources.antimageForm2, "BLINK\r\nПеремещение на короткую дистанцию,\nпозволяющее ворваться в схватку\nили быстро из неё сбежать.", "COUNTERSPELL\r\nПассивно увеличивает сопротивление\nмагическому урону.", "MANA VOID\r\nКратковременно оглушает вражескую цель,\nа затем наносит ей и всем окружающим\nеё противникам урон, пропорциональный\nчислу отсутствующей у неё маны.", null),
            new Character("Drow_Ranger", "arrow", 1, "agility", Resources.drow_ranger, "Немногим удаётся спастись от Drow Ranger.\nОбезмолвив врагов морозной волной, она накрывает\nих градом замедляющих ледяных стрел, после\nкоторого мало кто способен выжить.", Resources.drow_ranger_frost_arrows, Resources.drow_ranger_wave_of_silence, Resources.drow_ranger_multishot, Resources.drow_ranger_marksmanship, Resources.drow_rangerForm2, "FROST ARROWS\r\nДобавляет к атакам героя замораживающий\nэффект, замедляющий передвижение\nцели на 1,5 сек. и наносящий дополнительный урон.", "GUST\r\nВыпускает волну, которая отбрасывает\nвражеских существ и запрещает им\nприменять способности, а также\nраскрывает невидимость. Чем ближе\nбыл враг, тем дальше его отбросит.", "MULTISHOT\r\nПРЕРЫВАЕМАЯ — герой выпускает один залп\nстрел за другим, нанося врагам\nдолю от базового урона и\nприменяя на них способность\nFrost Arrows. Действует до 1,75 сек.", "MARKSMANSHIP\r\nОпыт в бою позволяет герою стрелять\nметче и эффективнее. С каждой\nатакой есть вероятность выпустить\nстрелу, игнорирующую базовую броню врага."),
            new Character("Hoodwink", "arrow", 2, "agility", Resources.hoodwink, "Hoodwink всегда спешит туда, где ждёт беда, и готова\nпротивостоять любой угрозе из призрачного леса,\nставшего ей домом. Даже с тяжёлым арбалетом она\nмимолётно прошмыгивает меж веток и листьев, и\nвыследить её в бою почти невозможно.", Resources.hoodwink_acorn_shot, Resources.hoodwink_bushwhack, Resources.hoodwink_scurry, Resources.hoodwink_sharpshooter, Resources.hoodwinkForm2, "ACORN SHOT\r\nГерой совершает атаку увеличенной дальности,\nзарядив особый жёлудь, который\nотскакивает во врагов неподалёку.", "BUSHWHACK\r\nГерой бросает сеть-ловушку,\nкоторая оглушает врагов в\nвыбранной области, если в ней\nесть деревья.", "SCURRY\r\nНенадолго ускоряет передвижение и\nпозволяет проходить сквозь\nсуществ и деревья.", "SHARPSHOOTER\r\nГерой готовит смертельный выстрел\nиз своего арбалета. Он наносит\nвражескому герою огромный\nурон, замедляет его и накладывает\nистощение."),
            new Character("Enchantress", "arrow", 1, "inteligence", Resources.enchantress, "Опасная вблизи и смертоносная на расстоянии,\nEnchantress пронзает врагов атаками, которые\nстановятся тем сильнее, чем больше расстояние до цели.\nБлагодаря способности замедлять своих врагов и\nзачаровать лесных существ она всегда найдёт способ\nодержать победу в схватке.", Resources.enchantress_impetus, Resources.enchantress_enchant, Resources.enchantress_natures_attendants, Resources.enchantress_untouchable, Resources.enchantressForm2, "IMPETUS\r\nУсиливает атаки героя, добавляя\nк ним урон, зависящий\nот расстояния до цели: чем\nона дальше, тем больше урон.", "ENCHANT\r\nГерой очаровывает выбранного врага.\nЕсли это крип, то он на 30 сек.\nпереходит под контроль героя, получая\nбонус к урону от атак и максимальном\n здоровью.", "NATURE'S ATTENDANTS\r\nПризывает рой светлячков, которые лечат\nгероя и всех ближайших союзников.", "UNTOUCHABLE\r\nПленённые красотой героя, противники\nатакуют его с уменьшенной скоростью."),
            new Character("Grimstroke", "arrow", 3, "inteligence", Resources.grimstroke, "Мастерски манипулируя битвой со стороны, Grimstroke\nизучает каждого неприятеля до самых мелочей, чтобы\nпоявиться из чернильной тьмы и мановением кисти\nоглушить врагов и связать их вместе. Он с\nнаслаждением досаждает противникам, натравливая на\nних своих фантомных рабов.", Resources.grimstroke_dark_artistry, Resources.grimstroke_ink_creature, Resources.grimstroke_spirit_walk, Resources.grimstroke_soul_chain, Resources.grimstrokeForm2, "STROKE OF FATE\r\nВзмахом кисти герой проводит линию\nиз чернил, нанося урон врагам\nна её пути, замедляя их\nи накладывая на них эффект\nInk Trail.", "PHANTOM'S EMBRACE\r\nПризывает фантома, который\nлетит к выбранной цели и\nсжимает её в своих объятьях,\nнанося периодический урон и\nзапрещая применять способности.", "INK SWELL\r\nГерой покрывает себя или союзника чернилами,\nкоторые повышают скорость передвижения\nи наносят урон противникам вокруг.", "SOULBIND\r\nСвязывает выбранного вражеского\nгероя с его ближайшим союзником,\nзамедляя их и не позволяя им\nразойтись слишком далеко\nдруг от друга."),
            new Character("Lina", "arrow", 2, "inteligence", Resources.lina, "Опасная и хрупкая Lina легко свалит любого одинокого\nврага. Она поражает противников огнём и молнией, а\nкаждое произнесённое ей заклинание увеличивает\nскорость её атаки, не давая выжить никому.", Resources.lina_dragon_slave, Resources.lina_light_strike_array, Resources.lina_laguna_blade, null, Resources.linaForm2, "DRAGON SLAVE\r\nГерой высвобождает дыхание дракона,\nсжигающее всех врагов на своём пути.", "LIGHT STRIKE ARRAY\r\nПризывает столб пламени, который\nоглушает врагов и наносит\nим урон.", "LAGUNA BLADE\r\nВыпускает разряд молнии в\nодного врага, нанося сокрушительный\nурон.", null),
            new Character("Clockwerk", "sword", 2, "universal", Resources.clockwerk, "Притягиваясь ко врагам своим захватным крюком,\nClockwerk изолирует жертву и разрывает её на части\nдезориентирующей шрапнелью. Разведывая поле\nбитвы своими ракетами, он всегда находит цель, на\nкоторую можно налететь.", Resources.rattletrap_battery_assault, Resources.rattletrap_power_cogs, Resources.rattletrap_rocket_flare, Resources.rattletrap_hookshot, Resources.rattletrapForm2, "BATTERY ASSAULT\r\nВыпускает высокомощную шрапнель\nв случайных существ неподалёку,\nнанося им незначительный магический урон\nи ненадолго их оглушая.", "POWER COGS\r\nСоздаёт вокруг героя кольцо\nзаряженных шестерней, захватывая\nв ловушку всех ближайших существ.", "ROCKET FLARE\r\nВыпускает сигнальную ракету в любую\nточку карты. Ракета даёт обзор\nуказанной зоны на 6 сек,\nнаносит урон противникам и ненадолго\nзамедляет их.", "HOOKSHOT\r\nБыстро выпускает захватное устройство\nв указанном направлении. Если\nкрюк попадает в существо,\nвладелец запускает себя в цель,\nоглушая всех в радиусе 175 вокруг неё\nи нанося им урон. "),
            new Character("Invoker", "arrow", 3, "universal", Resources.invoker, "Благодаря обширному арсеналу заклинаний Invoker\nможет приспособиться к ходу любой битвы. Комбинируя\nтри магичесих компонента, он может сотворить одно из\nдесяти заклинаний, позволяющих уничтожить врага или\nспастись от него.", Resources.invoker_quas, Resources.invoker_wex, Resources.invoker_exort, Resources.invoker_invoke, Resources.invokerForm2, "QUAS\r\nПозволяет манипулировать элементами льда.", "WEX\r\nПозволяет манипулировать элементами молнии.", "EXORT\r\nПозволяет манипулировать элементами огня.", "INVOKE\r\nГерой комбинирует элементы\nиспользующихся стихий, чтобы\nсоздать новое заклинание."),
            new Character("Nyx Assassin", "sword", 2, "universal", Resources.nyx_assassin, "Nyx Assassin всегда охотится за хилыми противниками.\nОн незаметно крадётся по лесам и, обнаружив жертву,\nпронзает её острыми когтями и поражает оглушающими\nшипами, отражая любой ответный удар своим панцирем.", Resources.nyx_assassin_impale, Resources.rattletrap_rocket_flare, Resources.nyx_assassin_spiked_carapace, Resources.nyx_assassin_vendetta, Resources.nyx_assassinForm2, "IMPALE\r\nИз земли прорывается полоса\nкаменных шипов. Они наносят\nурон и подбрасывают врагов в\nвоздух, оглушая их.", "MIND FLARE\r\nНаносит выбранному врагу урон,\nпропорциональный его\nмаксимальной мане.", "SPIKED CARAPACE\r\nПолностью блокирует урон от\nатаки или способности, по\nодному разу отражая урон и оглушая\nкаждого, кто пытался его нанести. ", "VENDETTA\r\nДелает героя невидимым и\nувеличивает его скорость передвижения.\nСовершив атаку из невидимости,\nгерой нанесёт огромный\nдополнительный урон.")
        };
        //дублированный список информации о героях
        private List<Character> secondListHeroes()
        {
            List<Character> secondListHero = new List<Character>();
            foreach (ICharacter hero in heroes)
            {
                if (hero is Character character)
                {
                    secondListHero.Add(character);
                }
            }
            return secondListHero;
        }
        //изначальное значение атрибута и сложности
        private string selectedAtribut = null;
        private int? selectedDifficulty = null;
        //проигрыватель музыки на задний фон 
        internal WindowsMediaPlayer WMP = new WindowsMediaPlayer();
        public Panel panel;
        //Инициализация формы
        public Form1()
        {
            InitializeComponent();
            //Отображение фона на форме
            this.BackgroundImage = Resources.фон_меню;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //Путь к файлу музыки для проигрывания
            WMP.URL = "F:\\kkkk\\WindowsFormsApp1\\soundMenu.wav";
            if (WMP.playState == WMP.playState)
            {
                WMP.controls.play();
            }
            //Настройки и добавление панели для отображения изображений героев
            panel = new Panel 
            {
                Size = new Size(1000, 290),
                Location = new Point(0,280),
                AutoScroll = true,
                BackColor = Color.Transparent
            };
            //отображение картинок атрибутов и сложности в pictureBox'ах 
            strenght.Image = Resources.Сила1;
            agility.Image = Resources.Ловкость1;
            intelligence.Image = Resources.Интеллект1;
            universal.Image = Resources.Универсал1;
            dif1.Image = Resources.сложность1;
            dif2.Image = Resources.сложность1;
            dif3.Image = Resources.сложность1;
        }
        //кнопка входа
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //После нажатия кнопки входа отображаются соответствующие элементы интерфейса
            this.BackgroundImage = Resources.Фон;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            info.Visible = Choose.Visible = 
            strenght.Visible = agility.Visible = 
            intelligence.Visible = universal.Visible = dif1.Visible =
            dif2.Visible = dif3.Visible = label1.Visible = label2.Visible = 
            buttonSearch.Visible = searchName.Visible = buttonSort.Visible = true;
            buttonStart.Visible = false;
            this.Controls.Add(panel);
        }
        //Настройка музыки
        private void playMusic_Click(object sender, EventArgs e) => WMP.controls.play();
        private void stopMusic_Click(object sender, EventArgs e) => WMP.controls.stop();
        private void upVolume_Click(object sender, EventArgs e) => WMP.settings.volume += 10;
        private void downVolume_Click(object sender, EventArgs e) => WMP.settings.volume -= 10;
        private void pauseMusic_Click(object sender, EventArgs e) => WMP.controls.pause();
        //Создание второй формы
        private void secondFormInfo(ICharacter hero)
        {
            //Инициализация второй формы и создание элементов на ней
            InfoForm infoForm = new InfoForm();
            //Создание и настройка элемента label с именем персонажа
            Label nameLabel = new Label
            {
                Text = hero.Name,
                Location = new Point(10, 10),
                Font = new Font("Microsoft Tai Le", 24, FontStyle.Bold),
                Size = new Size(200, 40),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Cursor = Cursors.IBeam
            };
            infoForm.Controls.Add(nameLabel);
            //Создание и настройка элемента label с информацией о персонаже
            Label infoLabel = new Label
            {
                Text = hero.Info,
                Location = new Point(10, 60),
                Size = new Size(300, 240),
                Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Cursor = Cursors.IBeam
            };
            infoForm.Controls.Add(infoLabel);
            //Создание и настройка элементов PictureBox с иконкой 1-4 навыков героя
            PictureBox skillFirst = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(10, 300),
                Size = new Size(100, 100),
                Image = hero.skill1,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            infoForm.Controls.Add(skillFirst);
            PictureBox skillSecond = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(150, 300),
                Size = new Size(100, 100),
                Image = hero.skill2,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            infoForm.Controls.Add(skillSecond);
            PictureBox skillThird = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(290, 300),
                Size = new Size(100, 100),
                Image = hero.skill3,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            infoForm.Controls.Add(skillThird);
            PictureBox skillForth = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(430, 300),
                Size = new Size(100, 100),
                Image = hero.skill4,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            infoForm.Controls.Add(skillForth);
            //Создание и настройка элемента PictureBox с изображением героя
            PictureBox HeroBox = new PictureBox
            {
                BackColor = Color.Transparent,
                Location = new Point(500, 30),
                Size = new Size(300, 300),
                Image = hero.HeroFull,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            infoForm.Controls.Add(HeroBox);
            //Создание и настройка элементов ToolTip для подсказок при наведении на иконки навыков
            ToolTip skill1 = new ToolTip();
            skill1.SetToolTip(skillFirst, hero.Skill1Info);
            ToolTip skill2 = new ToolTip();
            skill2.SetToolTip(skillSecond, hero.Skill2Info);
            ToolTip skill3 = new ToolTip();
            skill3.SetToolTip(skillThird, hero.Skill3Info);
            ToolTip skill4 = new ToolTip();
            skill4.SetToolTip(skillForth, hero.Skill4Info);
            infoForm.Show();
        }
        //Расстановка картинок атрибута по фильтру
        private void pictureAtribut(string atr,List<Character> newList)
        {
            //Очистка панели героев
            ClearPanel();
            int columns = 0;
            //Координаты первой иконки героя внутри панели
            int locationX = 20;
            int locationY = 0;
            foreach (var hero in newList)
            {
                //Условие расстановки героев по атрибуту
                if (hero.Attribut == atr && (selectedDifficulty == null || hero.Difficulty == selectedDifficulty))
                {
                    //Создание и настройка иконки героя
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = hero.Image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent,
                        Location = new Point(locationX, locationY),
                        Cursor = Cursors.Hand,
                        Width = 192,
                        Height = 108
                    };
                    panel.Controls.Add(pictureBox);
                    locationX += 200;
                    columns++;
                    if (columns == 4)
                    {
                        columns = 0;
                        locationX = 20;
                        locationY += 140;
                    }
                    else
                    {
                        locationX += 45;
                    }
                    //Обработчик нажатия на иконку героя
                    pictureBox.Click += (sender, e) =>
                    {
                        PictureBox clickedPictureBox = (PictureBox)sender;
                        secondFormInfo(hero);
                    };
                }
            }
        }
        //обработка нажатия на атрибут силы
        private void strenght_Click(object sender, EventArgs e)
        {
            //Изменение картинки при нажатии
            if(selectedAtribut == "strenght")
            {
                selectedAtribut = null;
                strenght.Image = Resources.Сила1;
            }
            //Изменение картинки при повторном нажатии и изменение картинок других атрибутов
            else
            {
                selectedAtribut = "strenght";
                strenght.Image = Resources.Сила;
                agility.Image = Resources.Ловкость1;
                intelligence.Image = Resources.Интеллект1;
                universal.Image = Resources.Универсал1;
            }
            //Экземпляра листа с героями
            List<Character> list = secondListHeroes();
            //Отображение иконок персонажей при выборе атрибута и сложности
            if(selectedAtribut == null)
            {
                pictureDifficulty(selectedDifficulty ?? 1, list);
            }
            else
            {
                pictureAtribut("strenght", list);
            }
        }
        //обработка нажатия на атрибут ловкости
        private void agility_Click(object sender, EventArgs e)
        {
            if(selectedAtribut == "agility")
            {
                selectedAtribut= null;
                agility.Image = Resources.Ловкость1;
            }
            else
            {
                selectedAtribut = "agility";
                agility.Image = Resources.Ловкость;
                strenght.Image = Resources.Сила1;
                intelligence.Image = Resources.Интеллект1;
                universal.Image = Resources.Универсал1;
            }
            List<Character> list = secondListHeroes();
            if(selectedAtribut == null)
            {
                pictureDifficulty(selectedDifficulty ?? 1, list);
            }
            else
            {
                pictureAtribut("agility", list);
            }
        }
        //обработка нажатия на атрибут интеллекта
        private void intelligence_Click(object sender, EventArgs e)
        {
            if (selectedAtribut == "inteligence")
            {
                selectedAtribut = null;
                intelligence.Image = Resources.Интеллект1;
            }
            else
            {
                selectedAtribut = "inteligence";
                intelligence.Image = Resources.Интеллект;
                agility.Image = Resources.Ловкость1;
                strenght.Image = Resources.Сила1;
                universal.Image = Resources.Универсал1;
            }
            List<Character> list = secondListHeroes();
            if (selectedAtribut == null)
            {
                pictureDifficulty(selectedDifficulty ?? 1, list);
            }
            else
            {
                pictureAtribut("inteligence", list);
            }
        }
        //обработка нажатия на атрибут универсала
        private void universal_Click(object sender, EventArgs e)
        {
            if (selectedAtribut == "universal")
            {
                selectedAtribut = null;
                universal.Image = Resources.Универсал1;
            }
            else
            {
                selectedAtribut = "universal";
                universal.Image = Resources.Универсал;
                intelligence.Image = Resources.Интеллект1;
                agility.Image = Resources.Ловкость1;
                strenght.Image = Resources.Сила1;
            }
            List<Character> list = secondListHeroes();
            if (selectedAtribut == null)
            {
                pictureDifficulty(selectedDifficulty ?? 1, list);
            }
            else
            {
                pictureAtribut("universal", list);
            }
        }
        //Очистка панели
        public void ClearPanel()
        {
            panel.Controls.Clear();
        }
        //расстановка картинок сложности по фильтру
        private void pictureDifficulty(int dif, List<Character> newList)
        {
            ClearPanel();
            int columns = 0;
            //Координаты первой иконки в панели
            int locationX = 20;
            int locationY = 0;
            foreach (var hero in newList)
            {
                //Условие расстановки героев по сложности
                if (hero.Difficulty == dif && (selectedAtribut == null || hero.Attribut == selectedAtribut))
                {
                    //Создание и настройка иконки героя
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = hero.Image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent,
                        Location = new Point(locationX, locationY),
                        Cursor = Cursors.Hand,
                        Width = 192,
                        Height = 108
                    };
                    panel.Controls.Add(pictureBox);
                    locationX += 200;
                    columns++;
                    if (columns == 4)
                    {
                        columns = 0;
                        locationX = 20;
                        locationY += 140;
                    }
                    else
                    {
                        locationX += 45;
                    }
                    //Обработчик нажатия на иконку героя
                    pictureBox.Click += (sender, e) =>
                    {
                        PictureBox clickedPictureBox = (PictureBox)sender;
                        secondFormInfo(hero);
                    };
                }
            }
        }
        //обработка нажатия на первую сложность
        private void dif1_Click(object sender, EventArgs e)
        {
            //Изменение картинки при нажатии
            if (selectedDifficulty == 1)
            {
                selectedDifficulty = null;
                dif1.Image = Resources.сложность1;
            }
            //Изменение картинки при повтрном нажатии и изменение других картинок сложности
            else
            {
                selectedDifficulty = 1;
                dif1.Image = Resources.сложность;
                dif2.Image = Resources.сложность1;
                dif3.Image = Resources.сложность1;
            }
            //Экземпляра листа с героями
            List<Character> list = secondListHeroes();
            //Отображение иконок персонажей при выборе атрибута и сложности
            if (selectedDifficulty == null)
            {
                pictureAtribut(selectedAtribut ?? "strength", list);
            }
            else
            {
                pictureDifficulty(1, list);
            }
        }
        //обработка нажатия на вторую сложность
        private void dif2_Click(object sender, EventArgs e)
        {
            if(selectedDifficulty == 2)
            {
                selectedDifficulty = null;
                dif1.Image = Resources.сложность1;
                dif2.Image = Resources.сложность1;
            }
            else
            {
                selectedDifficulty = 2;
                dif1.Image = Resources.сложность;
                dif2.Image = Resources.сложность;
                dif3.Image = Resources.сложность1;
            }
            List<Character> list = secondListHeroes();
            if (selectedDifficulty == null)
            {
                pictureAtribut(selectedAtribut ?? "strength", list);
            }
            else
            {
                pictureDifficulty(2, list);
            }
        }
        //обработка нажатия на третью сложность
        private void dif3_Click(object sender, EventArgs e)
        {
            if(selectedDifficulty == 3)
            {
                selectedDifficulty = null;
                dif1.Image = Resources.сложность1;
                dif2.Image = Resources.сложность1;
                dif3.Image = Resources.сложность1;
            }
            else
            {
                selectedDifficulty = 3;
                dif1.Image = Resources.сложность;
                dif2.Image = Resources.сложность;
                dif3.Image = Resources.сложность;

            }
            List<Character> list = secondListHeroes();
            if (selectedDifficulty == null)
            {
                pictureAtribut(selectedAtribut ?? "strength", list);
            }
            else
            {
                pictureDifficulty(3, list);
            }
        }
        //Закрытие формы
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point Last;
        //Обработчик события нажатия на панель для начала перемещения формы
        private void MD(object sender, MouseEventArgs e)
        {
            Last = new Point(e.X, e.Y);
        }
        //Обработчик события движения мыши для перемещения формы
        private void MV(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Last.X;
                this.Top += e.Y - Last.Y;
            }
        }
        // Поиск персонажа по имени
        private void searchHero()
        {
            string textSearch = searchName.Text.Trim();
            ClearPanel();
            int columns = 0;
            int locationX = 20;
            int locationY = 0;
            foreach (var hero in heroes)
            {
                //Условия совпадения имени героев и значения в поисковой строке 
                if (hero.Name.ToLower().Contains(textSearch.ToLower()))
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = hero.Image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent,
                        Location = new Point(locationX, locationY),
                        Cursor = Cursors.Hand,
                        Width = 192,
                        Height = 108
                    };
                    panel.Controls.Add(pictureBox);
                    locationX += 200;
                    columns++;
                    if (columns == 4)
                    {
                        columns = 0;
                        locationX = 20;
                        locationY += 140;
                    }
                    else
                    {
                        locationX += 45;
                    }
                    pictureBox.Click += (sender, e) =>
                    {
                        PictureBox clickedPictureBox = (PictureBox)sender;
                        secondFormInfo(hero);
                    };
                }
            }
        }
        //кнопка поиска
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            buttonSearch.FlatAppearance.BorderSize = 0;
            searchHero();
        }
        //сортировка героев по сложности
        private void sortHeroes()
        {
            ListHeroDif heroDif = new ListHeroDif();
            ClearPanel();
            //Добавление в лист всех героев
            foreach (ICharacter hero in heroes)
            {
                if (hero is Character character)
                {
                    heroDif.Add(character);
                }
            }
            //Сортировка героев по сложности
            heroDif.SortByDif();
            int columns = 0;
            int locationX = 20;
            int locationY = 0;
            foreach (var hero in heroDif)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = hero.Image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                    Location = new Point(locationX, locationY),
                    Cursor = Cursors.Hand,
                    Width = 192,
                    Height = 108
                };
                panel.Controls.Add(pictureBox);
                locationX += 200;
                columns++;
                if (columns == 4)
                {
                    columns = 0;
                    locationX = 20;
                    locationY += 140;
                }
                else
                {
                    locationX += 45;
                }
                pictureBox.Click += (sender, e) =>
                {
                    PictureBox clickedPictureBox = (PictureBox)sender;
                    secondFormInfo(hero);
                };
            }
        }
        //кнопка сортировки по сложности
        private void sortButton_Click(object sender, EventArgs e)
        {
            sortHeroes();
        }
    }
}
