#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/HeroSmiteData.cs
// Date:		28/07/2016
// Author:		Robin Kurisu
#endregion

using System;
using LeagueSharp;
using System.Collections.Generic;

namespace Activator.Data
{
    public class HeroSmiteData
    {
        public string Name;
        public float CastRange;
        public SpellSlot Slot;
        public int Stage;
        public SpellDataTargetType Type;

        public static List<HeroSmiteData> SpellList = new List<HeroSmiteData>();

        public bool HeroReqs(Obj_AI_Base unit)
        {
            if (unit == null)
                return false;

            switch (Activator.Player.ChampionName)
            {
                case "Twitch":
                    if (!unit.HasBuff("twitchdeadlyvenom"))
                        return false;
                    break;
                case "LeeSin":
                    if (!unit.HasBuff("blindmonkqonechaos"))
                        return false;
                    break;
                case "Diana":
                    if (!unit.HasBuff("dianamoonlight"))
                        return false;
                    break;
                case "Elise":
                    if (Activator.Player.CharData.BaseSkinName != "elisespider")
                        return false;
                    break;
                case "Nidalee":
                    if (Activator.Player.CharData.BaseSkinName == "Nidalee")
                        return false;
                    break;
            }

            return true;
        }

        static HeroSmiteData()
        {
            SpellList.Add(new HeroSmiteData
            {
                Name = "DrMundo",
                CastRange = 500f,
                Stage = 0,
                Type = SpellDataTargetType.Location,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Ekko",
                CastRange = 425f,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.E
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Rengar",
                CastRange = 150f,
                Stage = Activator.Player.Mana > 4 ? 1 : 0,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Wukong",
                CastRange = 305f,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Quinn",
                CastRange = 675f,
                Stage = 0,
                Type = SpellDataTargetType.Unit,
                Slot = SpellSlot.E
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Fiora",
                CastRange = 375f,
                Stage = 0,
                Type = SpellDataTargetType.Location,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Nidalee",
                CastRange = 375f,
                Stage = 1,
                Type = SpellDataTargetType.SelfAndUnit,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Alistar",
                CastRange = 350f,
                Stage = 0,
                Type = SpellDataTargetType.Self,
                Slot = SpellSlot.Q
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "FiddleSticks",
                CastRange = 750f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "JarvanIV",
                CastRange = 770f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Twitch",
                CastRange = 950f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Riven",
                CastRange = 150f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Malphite",
                CastRange = 200f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Nunu",
                CastRange = 200f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Olaf",
                CastRange = 325f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Elise",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Warwick",
                CastRange = 400f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Trundle",
                CastRange = 180f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "MasterYi",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Kayle",
                CastRange = 650f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Khazix",
                CastRange = 325f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "MonkeyKing",
                CastRange = 300f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Darius",
                CastRange = 425f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Diana",
                CastRange = 825f,
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Fizz",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Evelynn",
                CastRange = 225f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });


            SpellList.Add(new HeroSmiteData
            {
                Name = "Maokai",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Nocturne",
                CastRange = 500f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Pantheon",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Volibear",
                CastRange = 400f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Vi",
                CastRange = 125f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.SelfAndUnit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Tryndamere",
                CastRange = 400f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Zac",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Shen",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "XinZhao",
                CastRange = 600f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Amumu",
                CastRange = 350f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "LeeSin",
                CastRange = 1300f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new HeroSmiteData
            {
                Name = "Chogath",
                CastRange =  175 + new [] { 23f, 37f, 50f} [Math.Min(Activator.Player.Level, 18) / 6],
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });
        }
    }
}