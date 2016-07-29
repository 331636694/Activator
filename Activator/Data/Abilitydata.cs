#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/Spelldata.cs
// Date:		28/07/2016
// Author:		Robin Kurisu
#endregion

using System.Linq;
using LeagueSharp;
using Activator.Base;
using LeagueSharp.Common;
using System.Collections.Generic;

namespace Activator.Data
{
    public class Abilitydata
    {
        public string SDataName { get; set; }
        public string ChampionName { get; set; }
        public SpellSlot Slot { get; set; }
        public float CastRange { get; set; }
        public float Radius { get; set; } = 0f;
        public bool Global { get; set; }
        public float Delay { get; set; }
        public bool FixedRange { get; set; }
        public string MissileName { get; set; }
        public string[] ExtraMissileNames { get; set; }
        public int MissileSpeed { get; set; }
        public string[] FromObject { get; set; }
        public HitType[] HitType { get; set; }

        static Abilitydata()
        {
            Spells.Add(new Abilitydata
            {
                SDataName = "aatroxq",
                ChampionName = "aatrox",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aatroxw",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aatroxw2",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aatroxe",
                ChampionName = "aatrox",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "aatroxeconemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aatroxr",
                ChampionName = "aatrox",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ahriorbofdeception",
                ChampionName = "ahri",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ahriorbmissile",
                ExtraMissileNames = new[] { "ahriorbreturn" },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ahrifoxfire",
                ChampionName = "ahri",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ahriseduce",
                ChampionName = "ahri",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 975f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "ahriseducemissile",
                MissileSpeed = 1550
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ahritumble",
                ChampionName = "ahri",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "akalimota",
                ChampionName = "akali",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 650f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "akalismokebomb",
                ChampionName = "akali",
                Slot = SpellSlot.W,
                CastRange = 1000f, // Range: 700 + additional for stealth detection
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "akalishadowswipe",
                ChampionName = "akali",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "akalishadowdance",
                ChampionName = "akali",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pulverize",
                ChampionName = "alistar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 365f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "headbutt",
                ChampionName = "alistar",
                Slot = SpellSlot.W,
                CastRange = 660f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "triumphantroar",
                ChampionName = "alistar",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "feroucioushowl",
                ChampionName = "alistar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bandagetoss",
                ChampionName = "amumu",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "sadmummybandagetoss",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "auraofdespair",
                ChampionName = "amumu",
                Slot = SpellSlot.W,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tantrum",
                ChampionName = "amumu",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "curseofthesadmummy",
                ChampionName = "amumu",
                Slot = SpellSlot.R,
                CastRange = 560f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "flashfrost",
                ChampionName = "anivia",
                Slot = SpellSlot.Q,
                CastRange = 1150f, // 1075 + Shatter Radius
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "flashfrostspell",
                MissileSpeed = 850
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "crystalize",
                ChampionName = "anivia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "frostbite",
                ChampionName = "anivia",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "glacialstorm",
                ChampionName = "anivia",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "disintegrate",
                ChampionName = "annie",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "incinerate",
                ChampionName = "annie",
                Slot = SpellSlot.W,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "moltenshield",
                ChampionName = "annie",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "infernalguardian",
                ChampionName = "annie",
                Slot = SpellSlot.R,
                CastRange = 900f, // 600 + Cast Radius
                Delay = 0f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "frostshot",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "frostarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "volley",
                ChampionName = "ashe",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "volleyattack",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ashespiritofthehawk",
                ChampionName = "ashe",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "enchantedcrystalarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "enchantedcrystalarrow",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aurelionsolq",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.Q,
                CastRange = 1500f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "aurelionsolqmissile",
                MissileSpeed = 850
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aurelionsolw",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.None },
                MissileName = "aurelionsolwmis",
                MissileSpeed = 450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aurelionsole",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.None },
                MissileName = "aurelionsole",
                MissileSpeed = 900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aurelionsolr",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.R,
                CastRange = 1420f,
                Delay = 300f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Ultimate, Base.HitType.Danger },
                MissileName = "aurelionsolrbeammissile",
                MissileSpeed = 4600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "azirq",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "azirsoldiermissile",
                FromObject = new[] { "AzirSoldier" },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "azirqwrapper",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "azirsoldiermissile",
                FromObject = new[] { "AzirSoldier" },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "azirr",
                ChampionName = "azir",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 475f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bardq",
                ChampionName = "bard",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "bardqmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bardw",
                ChampionName = "bard",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "barde",
                ChampionName = "bard",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bardr",
                ChampionName = "bard",
                Slot = SpellSlot.R,
                CastRange = 3400f,
                Delay = 450f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "bardr",
                MissileSpeed = 2100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rocketgrabmissile",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "overdrive",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "powerfist",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.E,
                CastRange = 100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "staticfield",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "brandq",
                ChampionName = "brand",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "brandqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "brandw",
                ChampionName = "brand",
                Slot = SpellSlot.W,
                CastRange = 240f,
                Delay = 550f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "",
                MissileSpeed = 20
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "brande",
                ChampionName = "brand",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "brandr",
                ChampionName = "brand",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "braumq",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "braumqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "braumqmissle",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "braumw",
                ChampionName = "braum",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "braume",
                ChampionName = "braum",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "braumrwrapper",
                ChampionName = "braum",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1250f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "braumrmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "caitlynpiltoverpeacemaker",
                ChampionName = "caitlyn",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 2000f,
                Delay = 625f,
                HitType = new HitType[] { },
                MissileName = "caitlynpiltoverpeacemaker",
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "caitlynyordletrap",
                ChampionName = "caitlyn",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "caitlynentrapment",
                ChampionName = "caitlyn",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "caitlynentrapmentmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "cassiopeianoxiousblast",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "cassiopeianoxiousblast",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "cassiopeiamiasma",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.W,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "cassiopeiatwinfang",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "cassiopeiapetrifyinggaze",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 875f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "cassiopeiapetrifyinggaze",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rupture",
                ChampionName = "chogath",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 1000f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "rupture",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "feralscream",
                ChampionName = "chogath",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 675f,
                Delay = 175f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vorpalspikes",
                ChampionName = "chogath",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 347
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "feast",
                ChampionName = "chogath",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "phosphorusbomb",
                ChampionName = "corki",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "phosphorusbombmissile",
                MissileSpeed = 1125
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "carpetbomb",
                ChampionName = "corki",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ggun",
                ChampionName = "corki",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "missilebarrage",
                ChampionName = "corki",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1225f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileName = "missilebarragemissile",
                ExtraMissileNames = new[] { "missilebarragemissile2" },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dariuscleave",
                ChampionName = "darius",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 425f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dariusnoxiantacticsonh",
                ChampionName = "darius",
                Slot = SpellSlot.W,
                CastRange = 205f,
                Delay = 150f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dariusaxegrabcone",
                ChampionName = "darius",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 555f,
                Delay = 150f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "dariusaxegrabcone",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dariusexecute",
                ChampionName = "darius",
                Slot = SpellSlot.R,
                CastRange = 465f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dianaarc",
                ChampionName = "diana",
                Slot = SpellSlot.Q,
                CastRange = 830f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "dianaarc",
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dianaorbs",
                ChampionName = "diana",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dianavortex",
                ChampionName = "diana",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dianateleport",
                ChampionName = "diana",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dravenspinning",
                ChampionName = "draven",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dravenfury",
                ChampionName = "draven",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dravendoubleshot",
                ChampionName = "draven",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "dravendoubleshotmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "dravenrcast",
                ChampionName = "draven",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "dravenr",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "infectedcleavermissilecast",
                ChampionName = "drmundo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "infectedcleavermissile",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "burningagony",
                ChampionName = "drmundo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "masochism",
                ChampionName = "drmundo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sadism",
                ChampionName = "drmundo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ekkoq",
                ChampionName = "ekko",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1075f,
                Delay = 66f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "ekkoqmis",
                ExtraMissileNames = new[] { "ekkoqreturn" },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ekkoeattack",
                ChampionName = "ekko",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ekkor",
                ChampionName = "ekko",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                FromObject = new[] { "Ekko_Base_R_TrailEnd" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisehumanq",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisespiderqcast",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisehumanw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 5000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisespiderw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisehumane",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "elisehumane",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisespidereinitial",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisespideredescent",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "eliser",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "elisespiderr",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "evelynnq",
                ChampionName = "evelynn",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "evelynnw",
                ChampionName = "evelynn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "evelynne",
                ChampionName = "evelynn",
                Slot = SpellSlot.E,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "evelynnr",
                ChampionName = "evelynn",
                Slot = SpellSlot.R,
                CastRange = 900f, // 650f + Radius
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "evelynnr",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ezrealmysticshot",
                ChampionName = "ezreal",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "ezrealmysticshotmissile",
                ExtraMissileNames = new[] { "ezrealmysticshotpulsemissile" },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ezrealessenceflux",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ezrealessencefluxmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ezrealessencemissle",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ezrealarcaneshift",
                ChampionName = "ezreal",
                Slot = SpellSlot.E,
                CastRange = 750f, // 475f + Bolt Range
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ezrealtrueshotbarrage",
                ChampionName = "ezreal",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 20000f,
                Global = true,
                Delay = 1000f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "ezrealtrueshotbarrage",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "terrify",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "drain",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.W,
                CastRange = 575f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fiddlesticksdarkwind",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "crowstorm",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.ForceExhaust },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fioraq",
                ChampionName = "fiora",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fioraw",
                ChampionName = "fiora",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fiorae",
                ChampionName = "fiora",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fiorar",
                ChampionName = "fiora",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fizzpiercingstrike",
                ChampionName = "fizz",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fizzseastonepassive",
                ChampionName = "fizz",
                Slot = SpellSlot.W,
                CastRange = 175f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fizzjump",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 700f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fizzjumpbuffer",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 330f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fizzjumptwo",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 270f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fizzmarinerdoom",
                ChampionName = "fizz",
                Slot = SpellSlot.R,
                CastRange = 1275f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "fizzmarinerdoommissile",
                MissileSpeed = 1350
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "galioresolutesmite",
                ChampionName = "galio",
                Slot = SpellSlot.Q,
                CastRange = 1040f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "galioresolutesmite",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "galiobulwark",
                ChampionName = "galio",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "galiorighteousgust",
                ChampionName = "galio",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1280f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "galiorighteousgust",
                MissileSpeed = 1300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "galioidolofdurand",
                ChampionName = "galio",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 0f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gangplankqwrapper",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gangplankqproceed",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gangplankw",
                ChampionName = "gangplank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gangplanke",
                ChampionName = "gangplank",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gangplankr",
                ChampionName = "gangplank",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "garenq",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "garenqattack",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });


            Spells.Add(new Abilitydata
            {
                SDataName = "gnarq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1185f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2400,
                MissileName = "gnarqmissile",
                ExtraMissileNames = new[] { "gnarqmissilereturn" }
            });


            Spells.Add(new Abilitydata
            {
                SDataName = "gnarbigq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2000,
                MissileName = "gnarbigqmissile"
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gnarbigw",
                ChampionName = "gnar",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 600f,
                Delay = 600f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gnarult",
                ChampionName = "gnar",
                CastRange = 600f, // 590f + 10 Better safe than sorry. :)
                Slot = SpellSlot.R,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },

                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "garenw",
                ChampionName = "garen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "garene",
                ChampionName = "garen",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "garenr",
                ChampionName = "garen",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gragasq",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1000, // 850f + Radius
                Delay = 500f,
                HitType = new HitType[] { },
                MissileName = "gragasqmissile",
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gragasqtoggle",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gragasw",
                ChampionName = "gragas",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gragase",
                ChampionName = "gragas",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 600f,
                Delay = 200f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "gragase",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gragasr",
                ChampionName = "gragas",
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "gragasrboom",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gravesq",
                ChampionName = "graves",
                Slot = SpellSlot.Q,
                CastRange = 1025,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "gravesclustershotattack",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gravesw",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f, // 950 + Radius
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1350
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gravese",
                ChampionName = "graves",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "gravesr",
                ChampionName = "graves",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                FixedRange = true,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "graveschargeshotshot",
                MissileSpeed = 2100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hecarimrapidslash",
                ChampionName = "hecarim",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hecarimw",
                ChampionName = "hecarim",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hecarimramp",
                ChampionName = "hecarim",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hecarimult",
                ChampionName = "hecarim",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1350f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },

                MissileName = "hecarimultmissilesknr1",
                ExtraMissileNames =
                    new[]
                    {
                        "hecarimultmissileskn4r1", "hecarimultmissileskn4r2", "hecarimultmissileskn411",
                        "hecarimultmissileskn412"
                    },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "heimerdingerturretenergyblast",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 435f,
                HitType = new HitType[] { },
                FromObject = new[] { "heimerdinger_turret_idle" },
                MissileSpeed = 1650
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "heimerdingerturretbigenergyblast",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 350f,
                HitType = new HitType[] { },
                FromObject = new[] { "heimerdinger_base_r" },
                MissileSpeed = 1650
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "heimerdingerw",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1100,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "heimerdingere",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1025f, // 925 + Radius
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "heimerdingerespell",
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "heimerdingerr",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "heimerdingereult",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1450f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ireliagatotsu",
                ChampionName = "irelia",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ireliahitenstyle",
                ChampionName = "irelia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ireliaequilibriumstrike",
                ChampionName = "irelia",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ireliatranscendentblades",
                ChampionName = "irelia",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1200f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "ireliatranscendentbladesspell",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "illaoiq",
                ChampionName = "illaoi",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "illaoiemis",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "illaoiw",
                ChampionName = "illaoi",
                Slot = SpellSlot.W,
                CastRange = 365f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "illaoie",
                ChampionName = "illaoi",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "illaoiemis",
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "illaoir",
                ChampionName = "illaoi",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Ultimate, Base.HitType.Danger, },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "howlinggalespell",
                ChampionName = "janna",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1550f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "howlinggalespell",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sowthewind",
                ChampionName = "janna",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "eyeofthestorm",
                ChampionName = "janna",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reapthewhirlwind",
                ChampionName = "janna",
                Slot = SpellSlot.R,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jarvanivdragonstrike",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jarvanivgoldenaegis",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jarvanivdemacianstandard",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.E,
                CastRange = 830f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "jarvanivdemacianstandard",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jarvanivcataclysm",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaxleapstrike",
                ChampionName = "jax",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaxempowertwo",
                ChampionName = "jax",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaxrelentlessasssault",
                ChampionName = "jax",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaycetotheskies",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 450f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jayceshockblast",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1570f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "jayceshockblastmis",
                MissileSpeed = 2350
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaycestaticfield",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 285f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaycehypercharge",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaycethunderingblow",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jayceaccelerationgate",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaycestancehtg",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jaycestancegth",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jhinq",
                ChampionName = "jhin",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jhinw",
                ChampionName = "jhin",
                Slot = SpellSlot.W,
                CastRange = 2250f,
                Delay = 750f,
                FixedRange = true,
                HitType = new HitType[] { },
                MissileName = "jhinwmissile",
                MissileSpeed = 5000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jhine",
                ChampionName = "jhin",
                Slot = SpellSlot.E,
                CastRange = 2250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jhinrshot",
                ChampionName = "jhin",
                Slot = SpellSlot.R,
                CastRange = 3500f,
                Delay = 250f,
                FixedRange = true,
                MissileName = "jhinrshotmis",
                HitType = new HitType[] { },
                ExtraMissileNames = new[] { "jhinrMmissile", "Jhinrshotmis4" },
                MissileSpeed = 5000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jinxq",
                ChampionName = "jinx",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jinxw",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1550f,
                Delay = 600f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "jinxwmissile",
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jinxe",
                ChampionName = "jinx",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jinxr",
                ChampionName = "jinx",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 25000f,
                Global = true,
                Delay = 600f,
                MissileName = "jinxr",
                ExtraMissileNames = new[] { "jinxrwrapper" },
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "karmaq",
                ChampionName = "karma",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "karmaqmissile",
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "karmaspiritbind",
                ChampionName = "karma",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "karmasolkimshield",
                ChampionName = "karma",
                Slot = SpellSlot.E,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "karmamantra",
                ChampionName = "karma",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "laywaste",
                ChampionName = "karthus",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 900f,
                HitType = new HitType[] { },
                ExtraMissileNames = new[]  {
                            "karthuslaywastea3", "karthuslaywastea1", "karthuslaywastedeada1", "karthuslaywastedeada2",
                            "karthuslaywastedeada3"
                        },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "wallofpain",
                ChampionName = "karthus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "defile",
                ChampionName = "karthus",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fallenone",
                ChampionName = "karthus",
                Slot = SpellSlot.R,
                CastRange = 22000f,
                Global = true,
                Delay = 2800f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nulllance",
                ChampionName = "kassadin",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "netherblade",
                ChampionName = "kassadin",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "forcepulse",
                ChampionName = "kassadin",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "riftwalk",
                ChampionName = "kassadin",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "riftwalk",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "katarinaq",
                ChampionName = "katarina",
                Slot = SpellSlot.Q,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "katarinaw",
                ChampionName = "katarina",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "katarinae",
                ChampionName = "katarina",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "katarinar",
                ChampionName = "katarina",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.ForceExhaust },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "judicatorreckoning",
                ChampionName = "kayle",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "judicatordevineblessing",
                ChampionName = "kayle",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 220f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "judicatorrighteousfury",
                ChampionName = "kayle",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "judicatorintervention",
                ChampionName = "kayle",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kennenshurikenhurlmissile1",
                ChampionName = "kennen",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "kennenshurikenhurlmissile1",
                MissileSpeed = 1700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kennenbringthelight",
                ChampionName = "kennen",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kennenlightningrush",
                ChampionName = "kennen",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kennenshurikenstorm",
                ChampionName = "kennen",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixq",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixqlong",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 375f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixw",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "khazixwmissile",
                MissileSpeed = 81700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixwlong",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixe",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "khazixe",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixelong",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixr",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "khazixrlong",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kindredq",
                ChampionName = "kindred",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kindrede",
                ChampionName = "kindred",
                Slot = SpellSlot.E,
                CastRange = 510f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kogmawq",
                ChampionName = "kogmaw",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "kogmawq",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kogmawbioarcanebarrage",
                ChampionName = "kogmaw",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kogmawvoidooze",
                ChampionName = "kogmaw",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "kogmawvoidoozemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kogmawlivingartillery",
                ChampionName = "kogmaw",
                Slot = SpellSlot.R,
                CastRange = 2200f,
                Delay = 1200f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "kogmawlivingartillery",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancchaosorb",
                ChampionName = "leblanc",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancslide",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "leblancslide",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblacslidereturn",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancsoulshackle",
                ChampionName = "leblanc",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "leblancsoulshackle",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancchaosorbm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancslidem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "leblancslidem",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancslidereturnm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leblancsoulshacklem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "leblancsoulshacklem",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonkqone",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "blindmonkqone",
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonkqtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonkwone",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonkwtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonkeone",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonketwo",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindmonkrkick",
                ChampionName = "leesin",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leonashieldofdaybreak",
                ChampionName = "leona",
                Slot = SpellSlot.Q,
                CastRange = 215f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leonasolarbarrier",
                ChampionName = "leona",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 3000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leonazenithblade",
                ChampionName = "leona",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 900f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "leonazenithblademissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "leonasolarflare",
                ChampionName = "leona",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 1200f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "leonasolarflare",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lissandraq",
                ChampionName = "lissandra",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "lissandraqmissile",
                MissileSpeed = 2250
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lissandraw",
                ChampionName = "lissandra",
                Slot = SpellSlot.W,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lissandrae",
                ChampionName = "lissandra",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "lissandraemissile",
                MissileSpeed = 850
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lissandrar",
                ChampionName = "lissandra",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lucianq",
                ChampionName = "lucian",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "lucianq",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lucianw",
                ChampionName = "lucian",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "lucianwmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luciane",
                ChampionName = "lucian",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lucianr",
                ChampionName = "lucian",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "lucianrmissileoffhand",
                ExtraMissileNames = new[] { "lucianrmissile" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luluq",
                ChampionName = "lulu",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "luluqmissile",
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luluw",
                ChampionName = "lulu",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 640f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lulue",
                ChampionName = "lulu",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 640f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "lulur",
                ChampionName = "lulu",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luxlightbinding",
                ChampionName = "lux",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1300f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "luxlightbindingmis",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luxprismaticwave",
                ChampionName = "lux",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luxlightstrikekugel",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "luxlightstrikekugel",
                MissileSpeed = 1300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luxlightstriketoggle",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "luxmalicecannon",
                ChampionName = "lux",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 3340f,
                Delay = 1000f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "luxmalicecannonmis",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kalistamysticshot",
                ChampionName = "kalista",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "kalistamysticshotmis",
                ExtraMissileNames = new[] { "kalistamysticshotmistrue" },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kalistaw",
                ChampionName = "kalista",
                Slot = SpellSlot.W,
                CastRange = 5000f,
                Delay = 800f,
                HitType = new HitType[] { },
                MissileSpeed = 200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "kalistaexpungewrapper",
                ChampionName = "kalista",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "seismicshard",
                ChampionName = "malphite",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "obduracy",
                ChampionName = "malphite",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "landslide",
                ChampionName = "malphite",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ufslash",
                ChampionName = "malphite",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "ufslash",
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "alzaharcallofthevoid",
                ChampionName = "malzahar",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 600f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "alzaharcallofthevoid",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "alzaharnullzone",
                ChampionName = "malzahar",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "alzaharmaleficvisions",
                ChampionName = "malzahar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "alzaharnethergrasp",
                ChampionName = "malzahar",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "maokaitrunkline",
                ChampionName = "maokai",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "maokaiunstablegrowth",
                ChampionName = "maokai",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "maokaisapling2",
                ChampionName = "maokai",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "maokaidrain3",
                ChampionName = "maokai",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "alphastrike",
                ChampionName = "masteryi",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 600f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "meditate",
                ChampionName = "masteryi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "wujustyle",
                ChampionName = "masteryi",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "highlander",
                ChampionName = "masteryi",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 370f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "missfortunericochetshot",
                ChampionName = "missfortune",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "missfortuneviciousstrikes",
                ChampionName = "missfortune",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "missfortunescattershot",
                ChampionName = "missfortune",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "missfortunebullettime",
                ChampionName = "missfortune",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1400f,
                Delay = 200f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "monkeykingdoubleattack",
                ChampionName = "monkeyking",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "monkeykingdecoy",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "monkeykingdecoyswipe",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "monkeykingnimbus",
                ChampionName = "monkeyking",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "monkeykingspintowin",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "monkeykingspintowinleave",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "mordekaisermaceofspades",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "mordekaisercreepindeathcast",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "mordekaisersyphoneofdestruction",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "mordekaiserchildrenofthegrave",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "darkbindingmissile",
                ChampionName = "morgana",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "darkbindingmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tormentedsoil",
                ChampionName = "morgana",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blackshield",
                ChampionName = "morgana",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "soulshackles",
                ChampionName = "morgana",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "namiq",
                ChampionName = "nami",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "namiqmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "namiw",
                ChampionName = "nami",
                Slot = SpellSlot.W,
                CastRange = 725f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "namie",
                ChampionName = "nami",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "namir",
                ChampionName = "nami",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 2550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileName = "namirmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nasusq",
                ChampionName = "nasus",
                Slot = SpellSlot.Q,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nasusw",
                ChampionName = "nasus",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nasuse",
                ChampionName = "nasus",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nasusr",
                ChampionName = "nasus",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nautilusanchordrag",
                ChampionName = "nautilus",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1080f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "nautilusanchordragmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nautiluspiercinggaze",
                ChampionName = "nautilus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nautilussplashzone",
                ChampionName = "nautilus",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nautilusgandline",
                ChampionName = "nautilus",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "javelintoss",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1500f,
                Delay = 125f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "javelintoss",
                MissileSpeed = 1300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "takedown",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 150f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bushwhack",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pounce",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 375f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "primalsurge",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "swipe",
                ChampionName = "nidalee",
                FixedRange = true,
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "aspectofthecougar",
                ChampionName = "nidalee",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nocturneduskbringer",
                ChampionName = "nocturne",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nocturneshroudofdarkness",
                ChampionName = "nocturne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nocturneunspeakablehorror",
                ChampionName = "nocturne",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "nocturneparanoia",
                ChampionName = "nocturne",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "consume",
                ChampionName = "nunu",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bloodboil",
                ChampionName = "nunu",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "iceblast",
                ChampionName = "nunu",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "absolutezero",
                ChampionName = "nunu",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "olafaxethrowcast",
                ChampionName = "olaf",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "olafaxethrow",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "olaffrenziedstrikes",
                ChampionName = "olaf",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "olafrecklessstrike",
                ChampionName = "olaf",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "olafragnarok",
                ChampionName = "olaf",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "orianaizunacommand",
                ChampionName = "orianna",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "orianaizuna",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "orianadissonancecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "orianadissonancecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "orianaredactcommand",
                ChampionName = "orianna",
                Slot = SpellSlot.E,
                CastRange = 1095f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "orianaredact",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "orianadetonatecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "orianadetonatecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pantheonq",
                ChampionName = "pantheon",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pantheonw",
                ChampionName = "pantheon",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pantheone",
                ChampionName = "pantheon",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pantheonrjump",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pantheonrfall",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "poppyq",
                ChampionName = "poppy",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "poppyw",
                ChampionName = "poppy",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "poppye",
                ChampionName = "poppy",
                Slot = SpellSlot.E,
                CastRange = 525f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "poppyrspell",
                ChampionName = "poppy",
                FixedRange = true,
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "poppyrspellmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "poppyrspellinstant",
                ChampionName = "poppy",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 450f,
                Delay = 300f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "quinnq",
                ChampionName = "quinn",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "quinnqmissile",
                ExtraMissileNames = new[] { "quinnq" },
                MissileSpeed = 1550
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "quinnw",
                ChampionName = "quinn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "quinne",
                ChampionName = "quinn",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 775
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "quinnr",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "quinnrfinale",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "powerball",
                ChampionName = "rammus",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 775
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "defensiveballcurl",
                ChampionName = "rammus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "puncturingtaunt",
                ChampionName = "rammus",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tremors2",
                ChampionName = "rammus",
                Slot = SpellSlot.R,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "renektoncleave",
                ChampionName = "renekton",
                Slot = SpellSlot.Q,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "renektonpreexecute",
                ChampionName = "renekton",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "renektonsliceanddice",
                ChampionName = "renekton",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "renektonreignofthetyrant",
                ChampionName = "renekton",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rengarq",
                ChampionName = "rengar",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rengarw",
                ChampionName = "rengar",
                Slot = SpellSlot.W,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rengare",
                ChampionName = "rengar",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "rengarefinal",
                ExtraMissileNames = new[] { "rengarefinalmax" },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rengarr",
                ChampionName = "rengar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksaiq",
                ChampionName = "reksai",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 275f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksaiqburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 1650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "reksaiqburrowedmis",
                MissileSpeed = 1950
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksaiw",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksaiwburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksaie",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksaieburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 900f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "reksair",
                ChampionName = "reksai",
                Slot = SpellSlot.R,
                CastRange = 2.147484E+09f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "riventricleave",
                ChampionName = "riven",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 270f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rivenmartyr",
                ChampionName = "riven",
                Slot = SpellSlot.W,
                CastRange = 260f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rivenfeint",
                ChampionName = "riven",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rivenfengshuiengine",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rivenizunablade",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "rivenlightsabermissile",
                ExtraMissileNames = new[] { "rivenlightsabermissileside" },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rumbleflamethrower",
                ChampionName = "rumble",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rumbleshield",
                ChampionName = "rumble",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rumbegrenade",
                ChampionName = "rumble",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "rumblecarpetbomb",
                ChampionName = "rumble",
                Slot = SpellSlot.R,
                CastRange = 1700f,
                Delay = 400f,
                HitType = new HitType[] { },
                MissileName = "rumblecarpetbombmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ryzeq",
                ChampionName = "ryze",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ryzeqmissile",
                ExtraMissileNames = new[] { "ryzeq" },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ryzew",
                ChampionName = "ryze",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ryzee",
                ChampionName = "ryze",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ryzer",
                ChampionName = "ryze",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sejuaniarcticassault",
                ChampionName = "sejuani",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sejuaninorthernwinds",
                ChampionName = "sejuani",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sejuaniwintersclaw",
                ChampionName = "sejuani",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sejuaniglacialprisoncast",
                ChampionName = "sejuani",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "sejuaniglacialprison",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "deceive",
                ChampionName = "shaco",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "jackinthebox",
                ChampionName = "shaco",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twoshivpoison",
                ChampionName = "shaco",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hallucinatefull",
                ChampionName = "shaco",
                Slot = SpellSlot.R,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 395
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shenq",
                ChampionName = "shen",
                Slot = SpellSlot.Q,
                CastRange = 1650f,
                Delay = 0f,
                HitType = new HitType[] { },
                FromObject = new[] { "ShenArrowVfxHostMinion" },
                MissileSpeed = 1350
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shenw",
                ChampionName = "shen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shene",
                ChampionName = "shen",
                Slot = SpellSlot.E,
                CastRange = 675f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "shene",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shenr",
                ChampionName = "shen",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanadoubleattack",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanadoubleattackdragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanaimmolationauraqw",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanaimmolateddragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanafireball",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "shyvanafireballmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanafireballdragon2",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "shyvanatransformcast",
                ChampionName = "shyvana",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 100f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.CrowdControl,
                        Base.HitType.Ultimate
                    },
                MissileName = "shyvanatransformcast",
                MissileSpeed = 1100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "poisentrail",
                ChampionName = "singed",
                Slot = SpellSlot.Q,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "megaadhesive",
                ChampionName = "singed",
                Slot = SpellSlot.W,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "fling",
                ChampionName = "singed",
                Slot = SpellSlot.E,
                CastRange = 125f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "insanitypotion",
                ChampionName = "singed",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sionq",
                ChampionName = "sion",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sionwdetonate",
                ChampionName = "sion",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sione",
                ChampionName = "sion",
                Slot = SpellSlot.E,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "sionemissile",
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sionr",
                ChampionName = "sion",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sivirq",
                ChampionName = "sivir",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1165f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "sivirqmissile",
                ExtraMissileNames = new[] { "sivirqmissilereturn" },
                MissileSpeed = 1350
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sivirw",
                ChampionName = "sivir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sivire",
                ChampionName = "sivir",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sivirr",
                ChampionName = "sivir",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "skarnervirulentslash",
                ChampionName = "skarner",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "skarnerexoskeleton",
                ChampionName = "skarner",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "skarnerfracture",
                ChampionName = "skarner",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "skarnerfracturemissile",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "skarnerimpale",
                ChampionName = "skarner",
                Slot = SpellSlot.R,
                CastRange = 350f,
                Delay = 350f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sonaq",
                ChampionName = "sona",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sonaw",
                ChampionName = "sona",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sonae",
                ChampionName = "sona",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sonar",
                ChampionName = "sona",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "sonar",
                MissileSpeed = 2400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sorakaq",
                ChampionName = "soraka",
                Slot = SpellSlot.Q,
                CastRange = 970f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = 1100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sorakaw",
                ChampionName = "soraka",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sorakae",
                ChampionName = "soraka",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 1750f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "sorakar",
                ChampionName = "soraka",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "swaindecrepify",
                ChampionName = "swain",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "swainshadowgrasp",
                ChampionName = "swain",
                Slot = SpellSlot.W,
                CastRange = 1040f,
                Delay = 1100f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "swainshadowgrasp",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "swaintorment",
                ChampionName = "swain",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "swainmetamorphism",
                ChampionName = "swain",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1950
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "syndraq",
                ChampionName = "syndra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "syndraq",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "syndrawcast",
                ChampionName = "syndra",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "syndrawcast",
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "syndrae",
                ChampionName = "syndra",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 950f,
                Delay = 300f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "syndrae",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "syndrar",
                ChampionName = "syndra",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1250
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tahmkenchq",
                ChampionName = "tahmkench",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 2800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "talonnoxiandiplomacy",
                ChampionName = "talon",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "talonrake",
                ChampionName = "talon",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "talonrakemissileone",
                MissileSpeed = 2300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "taloncutthroat",
                ChampionName = "talon",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "talonshadowassault",
                ChampionName = "talon",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 260f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "taricq",
                ChampionName = "taric",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "taricw",
                ChampionName = "taric",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tarice",
                ChampionName = "taric",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 1000f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "taricr",
                ChampionName = "taric",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "blindingdart",
                ChampionName = "teemo",
                Slot = SpellSlot.Q,
                CastRange = 580f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "movequick",
                ChampionName = "teemo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 943
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "toxicshot",
                ChampionName = "teemo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bantamtrap",
                ChampionName = "teemo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "threshq",
                ChampionName = "thresh",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1175f,
                Delay = 500f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "threshqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "threshw",
                ChampionName = "thresh",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "threshe",
                ChampionName = "thresh",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "threshemissile1",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "threshrpenta",
                ChampionName = "thresh",
                Slot = SpellSlot.R,
                CastRange = 420f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1550
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tristanaq",
                ChampionName = "tristana",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tristanaw",
                ChampionName = "tristana",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1150
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tristanae",
                ChampionName = "tristana",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "tristanar",
                ChampionName = "tristana",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "trundletrollsmash",
                ChampionName = "trundle",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "trundledesecrate",
                ChampionName = "trundle",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "trundlecircle",
                ChampionName = "trundle",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "trundlepain",
                ChampionName = "trundle",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bloodlust",
                ChampionName = "tryndamere",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "mockingshout",
                ChampionName = "tryndamere",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "slashcast",
                ChampionName = "tryndamere",
                Slot = SpellSlot.E,
                CastRange = 660f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "slashcast",
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "undyingrage",
                ChampionName = "tryndamere",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twitchhideinshadows",
                ChampionName = "twitch",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twitchvenomcask",
                ChampionName = "twitch",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "twitchvenomcaskmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twitchvenomcaskmissle",
                ChampionName = "twitch",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twitchexpungewrapper",
                ChampionName = "twitch",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twitchexpunge",
                ChampionName = "twitch",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "twitchfullautomatic",
                ChampionName = "twitch",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "wildcards",
                ChampionName = "twistedfate",
                Slot = SpellSlot.Q,
                CastRange = 1450f,
                FixedRange = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "sealfatemissile",
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "pickacard",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "goldcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "redcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bluecardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "cardmasterstack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "destiny",
                ChampionName = "twistedfate",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "udyrtigerstance",
                ChampionName = "udyr",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "udyrturtlestance",
                ChampionName = "udyr",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "udyrbearstanceattack",
                ChampionName = "udyr",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "udyrphoenixstance",
                ChampionName = "udyr",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "urgotheatseekinglineqqmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "urgotheatseekingmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "urgotterrorcapacitoractive2",
                ChampionName = "urgot",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "urgotplasmagrenade",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "urgotplasmagrenadeboom",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "urgotplasmagrenadeboom",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "urgotswap2",
                ChampionName = "urgot",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1800
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "varusq",
                ChampionName = "varus",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "varusqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "varusw",
                ChampionName = "varus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "varuse",
                ChampionName = "varus",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "varuse",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "varusr",
                ChampionName = "varus",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1300f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileName = "varusrmissile",
                MissileSpeed = 1950
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vaynetumble",
                ChampionName = "vayne",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vaynesilverbolts",
                ChampionName = "vayne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vaynecondemnmissile",
                ChampionName = "vayne",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vayneinquisition",
                ChampionName = "vayne",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "veigarbalefulstrike",
                ChampionName = "veigar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "veigarbalefulstrikemis",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "veigardarkmatter",
                ChampionName = "veigar",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 1200f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "veigareventhorizon",
                ChampionName = "veigar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "veigarprimordialburst",
                ChampionName = "veigar",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "velkozq",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1250f,
                Delay = 100f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "velkozqmissile",
                MissileSpeed = 1300
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "velkozqsplitactivate",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "velkozqmissilesplit",
                MissileSpeed = 2100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "velkozw",
                ChampionName = "velkoz",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "velkozwmissile",
                MissileSpeed = 1700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "velkoze",
                ChampionName = "velkoz",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 0f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "velkozemissile",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "velkozr",
                ChampionName = "velkoz",
                Slot = SpellSlot.R,
                CastRange = 1575f,
                Delay = 0f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "viqmissile",
                ChampionName = "vi",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "viw",
                ChampionName = "vi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vie",
                ChampionName = "vi",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vir",
                ChampionName = "vi",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "viktorpowertransfer",
                ChampionName = "viktor",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1050
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "viktorgravitonfield",
                ChampionName = "viktor",
                Slot = SpellSlot.W,
                CastRange = 815f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "viktordeathray",
                ChampionName = "viktor",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileName = "viktordeathraymis",
                ExtraMissileNames = new[] { "viktoreaugmissile", },
                MissileSpeed = 1210
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "viktorchaosstorm",
                ChampionName = "viktor",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.CrowdControl, Base.HitType.Ultimate,
                        Base.HitType.Danger
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vladimirq",
                ChampionName = "vladimir",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vladimirw",
                ChampionName = "vladimir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vladimire",
                ChampionName = "vladimir",
                Slot = SpellSlot.E,
                CastRange = 610f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "vladimirr",
                ChampionName = "vladimir",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "volibearq",
                ChampionName = "volibear",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "volibearw",
                ChampionName = "volibear",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "volibeare",
                ChampionName = "volibear",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 825
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "volibearr",
                ChampionName = "volibear",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 825
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hungeringstrike",
                ChampionName = "warwick",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "hunterscall",
                ChampionName = "warwick",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "bloodscent",
                ChampionName = "warwick",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "infiniteduress",
                ChampionName = "warwick",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xeratharcanopulsechargeup",
                ChampionName = "xerath",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 750f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xeratharcanebarrage2",
                ChampionName = "xerath",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "xeratharcanebarrage2",
                MissileSpeed = 20
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xerathmagespear",
                ChampionName = "xerath",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileName = "xerathmagespearmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xerathlocusofpower2",
                ChampionName = "xerath",
                Slot = SpellSlot.R,
                CastRange = 5600f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xenzhaothrust3",
                ChampionName = "xinzhao",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xenzhaobattlecry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xenzhaosweep",
                ChampionName = "xinzhao",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl, Base.HitType.Danger },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "xenzhaoparry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yasuoqw",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yasuoq2w",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yasuoq3",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "yasuoq3mis",
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yasuowmovingwall",
                ChampionName = "yasuo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yasuodashwrapper",
                ChampionName = "yasuo",
                Slot = SpellSlot.E,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yasuorknockupcombow",
                ChampionName = "yasuo",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yorickspectral",
                ChampionName = "yorick",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yorickdecayed",
                ChampionName = "yorick",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yorickravenous",
                ChampionName = "yorick",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "yorickreviveally",
                ChampionName = "yorick",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zacq",
                ChampionName = "zac",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "zacq",
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zacw",
                ChampionName = "zac",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zace",
                ChampionName = "zac",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zacr",
                ChampionName = "zac",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zedq",
                ChampionName = "zed",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "zedqmissile",
                FromObject = new[] { "Zed_Base_W_tar.troy", "Zed_Base_W_cloneswap_buf.troy" },
                ExtraMissileNames = new[] { "zedqmissiletwo", "zedqmissilethree" },
                MissileSpeed = 1700
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zedw",
                ChampionName = "zed",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zede",
                ChampionName = "zed",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zedr",
                ChampionName = "zed",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 450f,
                HitType = new[] { Base.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ziggsq",
                ChampionName = "ziggs",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ziggsqspell",
                ExtraMissileNames = new[] { "ziggsqspell2", "ziggsqspell3" },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ziggsw",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "ziggsw",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ziggswtoggle",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ziggse",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "ziggse",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ziggse2",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "ziggsr",
                ChampionName = "ziggs",
                Slot = SpellSlot.R,
                CastRange = 2250f,
                Delay = 1800f,
                HitType = new[] { Base.HitType.Danger, Base.HitType.Ultimate },
                MissileName = "ziggsr",
                MissileSpeed = 1750
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zileanq",
                ChampionName = "zilean",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "zileanqmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zileanw",
                ChampionName = "zilean",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zileane",
                ChampionName = "zilean",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zileanr",
                ChampionName = "zilean",
                Slot = SpellSlot.R,
                CastRange = 780f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zyraq",
                ChampionName = "zyra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "zyraqmissile",
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zyraw",
                ChampionName = "zyra",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zyrae",
                ChampionName = "zyra",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Base.HitType.CrowdControl },
                MissileName = "zyraemissile",
                MissileSpeed = 1400
            });

            Spells.Add(new Abilitydata
            {
                SDataName = "zyrar",
                ChampionName = "zyra",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Base.HitType.Danger, Base.HitType.Ultimate,
                        Base.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
        }

        public static List<Abilitydata> Spells = new List<Abilitydata>();
        public static List<Abilitydata> SomeSpells = new List<Abilitydata>();

        public static Dictionary<SpellDamageDelegate, SpellSlot> DamageLib =
            new Dictionary<SpellDamageDelegate, SpellSlot>();

        public static Abilitydata GetByMissileName(string missilename)
        {
            foreach (var sdata in Spells)
            {
                if (sdata.MissileName != null && sdata.MissileName.ToLower() == missilename ||
                    sdata.ExtraMissileNames != null && sdata.ExtraMissileNames.Contains(missilename))
                {
                    return sdata;
                }
            }

            return null;
        }
    }
}