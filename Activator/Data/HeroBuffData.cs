#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/HeroBuffData.cs
// Date:		28/07/2016
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using System.Collections.Generic;

namespace Activator.Data
{
    public class HeroBuffData
    {
        public string Name { get; set; }
        public string MenuName { get; set; }
        public string Champion { get; set; }
        public bool Evade { get; set; }
        public bool DoT { get; set; }
        public int EvadeTimer { get; set; }
        public int IncomeDamage { get; set; }
        public bool Cleanse { get; set; }
        public double Interval { get; set; }
        public int CleanseTimer { get; set; }
        public int TickLimiter { get; set; }
        public SpellSlot Slot { get; set; }
        public bool QssIgnore { get; set; }

        public bool Included { get; set; }
        public Obj_AI_Hero Sender { get; set; }

        public static List<HeroBuffData> BuffList = new List<HeroBuffData>();

        static HeroBuffData()
        {
            BuffList.Add(new HeroBuffData
            {
                Name = "suppression",
                MenuName = "Suppresion",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "summonerdot",
                MenuName = "Summoner Ignite",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "summonerexhaust",
                MenuName = "Summoner Exhaust",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "masteryburndebuff",
                MenuName = "Deathfire Touch",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 0.5
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "itemdusknightfall",
                MenuName = "Duskblade (Nightfall)",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 1650,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Vi",
                Name = "virknockup",
                MenuName = "Vi R Knockup",
                Evade = true,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Amumu",
                Name = "curseofthesadmummy",
                MenuName = "Amumu Curse of the Sad Mummy",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "itemsmitechallenge",
                MenuName = "Challenging Smite",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 0.7
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Gangplank",
                Name = "gangplankpassiveattackdot",
                MenuName = "Gangplank Passive Burn",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Teemo",
                Name = "bantamtraptarget",
                MenuName = "Teemo Shroom",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });
          
            BuffList.Add(new HeroBuffData
            {
                Champion = "Teemo",
                Name = "toxicshotparticle",
                MenuName = "Teemo Toxic Shot",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Ahri",
                Name = "ahriseduce",
                MenuName = "Ahri Charm",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Elise",
                Name = "elisehumane",
                MenuName = "Elise Cocoon",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 25,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Heimerdinger",
                Name = "heimerdingerespell",
                MenuName = "Heimerdinger Grenade",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 25,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Talon",
                Name = "talonbleeddebuf",
                MenuName = "Talon Bleed",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData()
            {
                Champion = "Malzahar",
                Name = "alzaharnethergrasp",
                MenuName = "Malzahar Nether Grasp",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Malzahar",
                Name = "alzaharmaleficvisions",
                MenuName = "Malzahar Aids",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "FiddleSticks",
                Name = "drainchannel",
                MenuName = "Fiddle Drain",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Galio",
                Name = "galioidolofdurand",
                MenuName = "Galio Idol of Durand",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Nasus",
                Name = "nasusw",
                MenuName = "Nasus Wither",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Gnar",
                Name = "gnarstun",
                MenuName = "Gnar Ultimate",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Gragas",
                Name = "gragasestun",
                MenuName = "Gragas Body Slam",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Bard",
                Name = "bardqshackledebuff",
                MenuName = "Bard Cosmic Binding",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 25,
                Slot = SpellSlot.Q,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Akali",
                Name = "akalimota",
                MenuName = "Akali Mark of the Assassin",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 1.5
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Hecarim",
                Name = "hecarimdefilelifeleech",
                MenuName = "Hecarim Defile Leech",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Swain",
                Name = "swaintorment",
                MenuName = "Swain Torment",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Brand",
                Name = "brandablaze",
                MenuName = "Brand Burn Passive",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 0.5
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Fizz",
                Name = "fizzseastonetrident",
                MenuName = "Fizz Burn Passive",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Tristana",
                Name = "tristanaechargesound",
                MenuName = "Tristana Explosive Charge",
                Evade = false,
                DoT = true, // not really a dot but can be cleansed
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Darius",
                Name = "dariushemo",
                MenuName = "Darius Hemorrhage",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Nidalee",
                Name = "bushwackdamage",
                MenuName = "Nidalee Bushwhack",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Nidalee",
                Name = "nidaleepassivehunted",
                MenuName = "Nidalee Passive Mark",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = .8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Shyvana",
                Name = "shyvanaimmolationaura",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "MissFortune",
                Name = "missfortunescattershotslow",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 0.5
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "MissFortune",
                Name = "missfortunepassivestack",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 0.5
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Shyvana",
                Name = "shyvanaimmolatedragon",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Zilean",
                Name = "zileanqenemybomb",
                MenuName = "Zilean Bomb",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 3.8
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Wukong",
                Name = "monkeykingspintowin",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Katarina",
                Name = "katarinaqmark",
                MenuName = "Katarina Bouncing Blades",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 1.5
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Kindred",
                Name = "kindredecharge",
                MenuName = "Kindred Mounting Dread",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 2.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Cassiopeia",
                Name = "cassiopeianoxiousblastpoison",
                MenuName = "Cassio Noxious Blast",
                Evade = false,
                Cleanse = false,
                DoT = true,
                EvadeTimer = 0,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 0.4
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Cassiopeia",
                Name = "cassiopeiamiasmapoison",
                MenuName = "Cassio Miasma",
                Evade = false,
                Cleanse = false,
                DoT = true,
                EvadeTimer = 0,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Cassiopeia",
                Name = "cassiopeiapetrifyinggazestun",
                MenuName = "Cassio Petrifying Gaze",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Ekko",
                Name = "ekkowstun",
                MenuName = "Ekko Parellel Convergence",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Lissandra",
                Name = "lissandrarenemy2",
                MenuName = "Lissandra Frozen Tomb",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Sejuani",
                Name = "sejuaniglacialprison",
                MenuName = "Sejuani Glacial Prison",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Fiora",
                Name = "fiorarmark",
                MenuName = "Fiora Grand Challenge",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 100,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Twitch",
                Name = "twitchdeadlyvenon",
                MenuName = "Twitch Deadly Venom",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 0.6
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Urgot",
                Name = "urgotcorrosivedebuff",
                MenuName = "Urgot Corrosive Charge",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Zac",
                Name = "zacr",
                Evade = true,
                DoT = true,
                EvadeTimer = 150,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R,
                Interval = 1.5

            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Mordekaiser",
                Name = "mordekaiserchildrenofthegrave",
                MenuName = "Mordekaiser Children of the Grave",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.5
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "burningagony",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Garen",
                Name = "garene",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.E,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Amumu",
                Name = "auraofdespair",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Hecarim",
                Name = "hecarimw",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.W,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Braum",
                Name = "braummark",
                MenuName = "Braum Passive",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 200,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Zed",
                Name = "zedultexecute",
                MenuName = "Zed Mark",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = true,
                CleanseTimer = 500,
                Slot = SpellSlot.R,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Karthus",
                Name = "fallenonetarget",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Karthus",
                Name = "karthusfallenonetarget",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Fizz",
                Name = "fizzmarinerdoombomb",
                MenuName = "Fizz Shark Bait",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Morgana",
                Name = "soulshackles",
                MenuName = "Morgana Soul Shackles",
                Evade = true,
                DoT = false,
                EvadeTimer = 2600,
                Cleanse = true,
                CleanseTimer = 1100,
                Slot = SpellSlot.R,
                Interval = 3.9
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Varus",
                Name = "varusrsecondary",
                MenuName = "Varus Chains of Corruption",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Caitlyn",
                Name = "caitlynaceinthehole",
                MenuName = "Caitlyn Ace in the Hole",
                Evade = true,
                DoT = false,
                EvadeTimer = 900,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Vladimir",
                Name = "vladimirhemoplague",
                MenuName = "Vladimir Hemoplague",
                Evade = true,
                DoT = false,
                EvadeTimer = 4500,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Diana",
                Name = "dianamoonlight",
                MenuName = "Diana Moonlight",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Urgot",
                Name = "urgotswap2",
                MenuName = "Urgot Swap",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Skarner",
                Name = "skarnerimpale",
                MenuName = "Skarner Impale",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 500,
                Slot = SpellSlot.R
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Maokai",
                Name = "maokaiunstablegrowthroot",
                MenuName = "Maokai Root",
                Evade = false,
                DoT = false,
                EvadeTimer = 0,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.W
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "LeeSin",
                Name = "blindmonkqonechaos",
                MenuName = "Lee Sonic Wave",
                Evade = false,
                DoT = true,
                EvadeTimer = 0,
                Cleanse = false,
                CleanseTimer = 0,
                Slot = SpellSlot.Q,
                Interval = 3.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Leblanc",
                Name = "leblancsoulshackle",
                MenuName = "Leblanc Shackle",
                Evade = false,
                DoT = false,
                EvadeTimer = 2000,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.E
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Leblanc",
                Name = "leblancsoulshacklem",
                MenuName = "Leblanc Shackle (R)",
                Evade = true,
                DoT = false,
                EvadeTimer = 2000,
                Cleanse = true,
                CleanseTimer = 0,
                Slot = SpellSlot.E
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Rammus",
                Name = "puncturingtauntarmordebuff",
                MenuName = "Rammus Puncturing Taunt",
                Evade = false,
                DoT = false,
                Cleanse = true,
                CleanseTimer = 0,
                EvadeTimer = 0,
                Slot = SpellSlot.E
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Vi",
                Name = "vir",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Yasuo",
                Name = "yasuorknockupcombo",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Yasuo",
                Name = "yasuorknockupcombotar",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Zyra",
                Name = "zyrabramblezoneknockup",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Velkoz",
                Name = "velkozresearchstack",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 0.3
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "frozenheartaura",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Darius",
                Name = "dariusaxebrabcone",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "frozenheartauracosmetic",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "itemsunfirecapeaura",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Fizz",
                Name = "fizzmoveback",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "blessingofthelizardelderslow",
                Evade = false,
                DoT = true,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown,
                Interval = 1.0
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "dragonburning",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Blitzcrank",
                Name = "rocketgrab2",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Ashe",
                Name = "frostarrow",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Alistar",
                Name = "pulverize",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new HeroBuffData
            {
                Name = "chilled",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Azir",
                Name = "azirqslow",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Rammus",
                Name = "powerballslow",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Rammus",
                Name = "powerballstun",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Q
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "MonkeyKing",
                Name = "monkeykingspinknockup",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Alistar",
                Name = "headbutttarget",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.W
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Hecarim",
                Name = "hecarimrampstuncheck",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });

            BuffList.Add(new HeroBuffData
            {
                Champion = "Hecarim",
                Name = "hecarimrampattackknockback",
                Evade = false,
                DoT = false,
                Cleanse = false,
                CleanseTimer = 0,
                EvadeTimer = 0,
                QssIgnore = true,
                Slot = SpellSlot.Unknown
            });
        }

        public static List<HeroBuffData> CachedAuras = new List<HeroBuffData>(); 
    }
}