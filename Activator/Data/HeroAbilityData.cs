#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/HeroAbilityData.cs
// Date:		28/07/2016
// Author:		Robin Kurisu
#endregion

using System.Collections.Generic;
using System.Linq;
using Activator.Base;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Data
{
    public class HeroAbilityData
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
        public HitType[] HitTypes { get; set; }

        static HeroAbilityData()
        {
            Spells.Add(new HeroAbilityData
            {
                SDataName = "aatroxq",
                ChampionName = "aatrox",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aatroxw",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aatroxw2",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aatroxe",
                ChampionName = "aatrox",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1025f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "aatroxeconemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aatroxr",
                ChampionName = "aatrox",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ahriorbofdeception",
                ChampionName = "ahri",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "ahriorbmissile",
                ExtraMissileNames = new[] { "ahriorbreturn" },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ahrifoxfire",
                ChampionName = "ahri",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ahriseduce",
                ChampionName = "ahri",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 975f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "ahriseducemissile",
                MissileSpeed = 1550
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ahritumble",
                ChampionName = "ahri",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "akalimota",
                ChampionName = "akali",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 650f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "akalismokebomb",
                ChampionName = "akali",
                Slot = SpellSlot.W,
                CastRange = 1000f, // Range: 700 + additional for stealth detection
                Delay = 250f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "akalishadowswipe",
                ChampionName = "akali",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "akalishadowdance",
                ChampionName = "akali",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pulverize",
                ChampionName = "alistar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 365f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "headbutt",
                ChampionName = "alistar",
                Slot = SpellSlot.W,
                CastRange = 660f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "triumphantroar",
                ChampionName = "alistar",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "feroucioushowl",
                ChampionName = "alistar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bandagetoss",
                ChampionName = "amumu",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "sadmummybandagetoss",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "auraofdespair",
                ChampionName = "amumu",
                Slot = SpellSlot.W,
                CastRange = 300f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tantrum",
                ChampionName = "amumu",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 150f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "curseofthesadmummy",
                ChampionName = "amumu",
                Slot = SpellSlot.R,
                CastRange = 560f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "flashfrost",
                ChampionName = "anivia",
                Slot = SpellSlot.Q,
                CastRange = 1150f, // 1075 + Shatter Radius
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "flashfrostspell",
                MissileSpeed = 850
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "crystalize",
                ChampionName = "anivia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "frostbite",
                ChampionName = "anivia",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "glacialstorm",
                ChampionName = "anivia",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "disintegrate",
                ChampionName = "annie",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "incinerate",
                ChampionName = "annie",
                Slot = SpellSlot.W,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "moltenshield",
                ChampionName = "annie",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "infernalguardian",
                ChampionName = "annie",
                Slot = SpellSlot.R,
                CastRange = 900f, // 600 + Cast Radius
                Delay = 0f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "frostshot",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "frostarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "volley",
                ChampionName = "ashe",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "volleyattack",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ashespiritofthehawk",
                ChampionName = "ashe",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "enchantedcrystalarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileName = "enchantedcrystalarrow",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aurelionsolq",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.Q,
                CastRange = 1500f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "aurelionsolqmissile",
                MissileSpeed = 850
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aurelionsolw",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.None },
                MissileName = "aurelionsolwmis",
                MissileSpeed = 450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aurelionsole",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.None },
                MissileName = "aurelionsole",
                MissileSpeed = 900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aurelionsolr",
                ChampionName = "aurelionsol",
                Slot = SpellSlot.R,
                CastRange = 1420f,
                Delay = 300f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Ultimate, HitType.Danger, HitType.Initiator },
                MissileName = "aurelionsolrbeammissile",
                MissileSpeed = 4600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "azirq",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay =  250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "azirqmissile",
                FromObject = new[] { "AzirSoldier" },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "azirqwrapper",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "azirqmissile",
                FromObject = new[] { "AzirSoldier" },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "azirr",
                ChampionName = "azir",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 475f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bardq",
                ChampionName = "bard",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "bardqmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bardw",
                ChampionName = "bard",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "barde",
                ChampionName = "bard",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 350f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bardr",
                ChampionName = "bard",
                Slot = SpellSlot.R,
                CastRange = 3400f,
                Delay = 450f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "bardr",
                MissileSpeed = 2100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rocketgrabmissile",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "overdrive",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "powerfist",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.E,
                CastRange = 100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "staticfield",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "brandq",
                ChampionName = "brand",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "brandqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "brandw",
                ChampionName = "brand",
                Slot = SpellSlot.W,
                CastRange = 240f,
                Delay = 550f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "",
                MissileSpeed = 20
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "brande",
                ChampionName = "brand",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "brandr",
                ChampionName = "brand",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "braumq",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "braumqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "braumqmissle",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "braumw",
                ChampionName = "braum",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "braume",
                ChampionName = "braum",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "braumrwrapper",
                ChampionName = "braum",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1250f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileName = "braumrmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "caitlynpiltoverpeacemaker",
                ChampionName = "caitlyn",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 2000f,
                Delay = 625f,
                HitTypes = new HitType[] { },
                MissileName = "caitlynpiltoverpeacemaker",
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "caitlynyordletrap",
                ChampionName = "caitlyn",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 550f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "caitlynentrapment",
                ChampionName = "caitlyn",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "caitlynentrapmentmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "cassiopeiaq",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "cassiopeianoxiousblast",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "cassiopeiw",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.W,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 2500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "cassiopeiae",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "cassiopeiar",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 875f,
                Delay = 350f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileName = "cassiopeiapetrifyinggaze",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rupture",
                ChampionName = "chogath",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 1000f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "rupture",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "feralscream",
                ChampionName = "chogath",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 675f,
                Delay = 175f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vorpalspikes",
                ChampionName = "chogath",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 347
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "feast",
                ChampionName = "chogath",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "phosphorusbomb",
                ChampionName = "corki",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "phosphorusbombmissile",
                MissileSpeed = 1125
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "carpetbomb",
                ChampionName = "corki",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ggun",
                ChampionName = "corki",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "missilebarrage",
                ChampionName = "corki",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1225f,
                Delay = 150f,
                HitTypes = new HitType[] { },
                MissileName = "missilebarragemissile",
                ExtraMissileNames = new[] { "missilebarragemissile2" },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dariuscleave",
                ChampionName = "darius",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 425f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dariusnoxiantacticsonh",
                ChampionName = "darius",
                Slot = SpellSlot.W,
                CastRange = 205f,
                Delay = 150f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dariusaxegrabcone",
                ChampionName = "darius",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 555f,
                Delay = 150f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "dariusaxegrabcone",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dariusexecute",
                ChampionName = "darius",
                Slot = SpellSlot.R,
                CastRange = 465f,
                Delay = 450f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dianaarc",
                ChampionName = "diana",
                Slot = SpellSlot.Q,
                CastRange = 830f,
                Delay = 300f,
                HitTypes = new HitType[] { },
                MissileName = "dianaarc",
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dianaorbs",
                ChampionName = "diana",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dianavortex",
                ChampionName = "diana",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dianateleport",
                ChampionName = "diana",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Initiator },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dravenspinning",
                ChampionName = "draven",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dravenfury",
                ChampionName = "draven",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dravendoubleshot",
                ChampionName = "draven",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "dravendoubleshotmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "dravenrcast",
                ChampionName = "draven",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 500f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileName = "dravenr",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "infectedcleavermissilecast",
                ChampionName = "drmundo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "infectedcleavermissile",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "burningagony",
                ChampionName = "drmundo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "masochism",
                ChampionName = "drmundo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sadism",
                ChampionName = "drmundo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ekkoq",
                ChampionName = "ekko",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1075f,
                Delay = 66f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "ekkoqmis",
                ExtraMissileNames = new[] { "ekkoqreturn" },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ekkoeattack",
                ChampionName = "ekko",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ekkor",
                ChampionName = "ekko",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                FromObject = new[] { "Ekko_Base_R_TrailEnd" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisehumanq",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 550f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisespiderqcast",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisehumanw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = 5000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisespiderw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisehumane",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1075f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "elisehumane",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisespidereinitial",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisespideredescent",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "eliser",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "elisespiderr",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "evelynnq",
                ChampionName = "evelynn",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 500f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "evelynnw",
                ChampionName = "evelynn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f, 
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "evelynne",
                ChampionName = "evelynn",
                Slot = SpellSlot.E,
                CastRange = 225f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "evelynnr",
                ChampionName = "evelynn",
                Slot = SpellSlot.R,
                CastRange = 900f, // 650f + Radius
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileName = "evelynnr",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ezrealmysticshot",
                ChampionName = "ezreal",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "ezrealmysticshotmissile",
                ExtraMissileNames = new[] { "ezrealmysticshotpulsemissile" },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ezrealessenceflux",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "ezrealessencefluxmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ezrealessencemissle",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ezrealarcaneshift",
                ChampionName = "ezreal",
                Slot = SpellSlot.E,
                CastRange = 750f, // 475f + Bolt Range
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ezrealtrueshotbarrage",
                ChampionName = "ezreal",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 20000f,
                Global = true,
                Delay = 1000f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileName = "ezrealtrueshotbarrage",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "terrify",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "drain",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.W,
                CastRange = 575f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fiddlesticksdarkwind",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "crowstorm",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new[] { HitType.ForceExhaust, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fioraq",
                ChampionName = "fiora",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fioraw",
                ChampionName = "fiora",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fiorae",
                ChampionName = "fiora",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fiorar",
                ChampionName = "fiora",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 150f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fizzpiercingstrike",
                ChampionName = "fizz",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fizzseastonepassive",
                ChampionName = "fizz",
                Slot = SpellSlot.W,
                CastRange = 175f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fizzjump",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 700f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fizzjumpbuffer",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 330f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fizzjumptwo",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 270f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fizzmarinerdoom",
                ChampionName = "fizz",
                Slot = SpellSlot.R,
                CastRange = 1275f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "fizzmarinerdoommissile",
                MissileSpeed = 1350
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "galioresolutesmite",
                ChampionName = "galio",
                Slot = SpellSlot.Q,
                CastRange = 1040f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "galioresolutesmite",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "galiobulwark",
                ChampionName = "galio",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "galiorighteousgust",
                ChampionName = "galio",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1280f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "galiorighteousgust",
                MissileSpeed = 1300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "galioidolofdurand",
                ChampionName = "galio",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 0f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gangplankqwrapper",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gangplankqproceed",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gangplankw",
                ChampionName = "gangplank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gangplanke",
                ChampionName = "gangplank",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gangplankr",
                ChampionName = "gangplank",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "garenq",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 300f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "garenqattack",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });


            Spells.Add(new HeroAbilityData
            {
                SDataName = "gnarq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1185f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 2400,
                MissileName = "gnarqmissile",
                ExtraMissileNames = new[] { "gnarqmissilereturn" }
            });


            Spells.Add(new HeroAbilityData
            {
                SDataName = "gnarbigq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 2000,
                MissileName = "gnarbigqmissile"
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gnarbigw",
                ChampionName = "gnar",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 600f,
                Delay = 600f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gnarult",
                ChampionName = "gnar",
                CastRange = 600f, // 590f + 10 Better safe than sorry. :)
                Slot = SpellSlot.R,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },

                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "garenw",
                ChampionName = "garen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "garene",
                ChampionName = "garen",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "garenr",
                ChampionName = "garen",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gragasq",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1000, // 850f + Radius
                Delay = 500f,
                HitTypes = new HitType[] { },
                MissileName = "gragasqmissile",
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gragasqtoggle",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gragasw",
                ChampionName = "gragas",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gragase",
                ChampionName = "gragas",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 600f,
                Delay = 200f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl, HitType.Initiator },
                MissileName = "gragase",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gragasr",
                ChampionName = "gragas",
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "gragasrboom",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gravesq",
                ChampionName = "graves",
                Slot = SpellSlot.Q,
                CastRange = 1025,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "gravesclustershotattack",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gravesw",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f, // 950 + Radius
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1350
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gravese",
                ChampionName = "graves",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 300f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "gravesr",
                ChampionName = "graves",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                FixedRange = true,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileName = "graveschargeshotshot",
                MissileSpeed = 2100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hecarimrapidslash",
                ChampionName = "hecarim",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hecarimw",
                ChampionName = "hecarim",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hecarimramp",
                ChampionName = "hecarim",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hecarimult",
                ChampionName = "hecarim",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1350f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
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

            Spells.Add(new HeroAbilityData
            {
                SDataName = "heimerdingerturretenergyblast",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 435f,
                HitTypes = new HitType[] { },
                FromObject = new[] { "heimerdinger_turret_idle" },
                MissileSpeed = 1650
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "heimerdingerturretbigenergyblast",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 350f,
                HitTypes = new HitType[] { },
                FromObject = new[] { "heimerdinger_base_r" },
                MissileSpeed = 1650
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "heimerdingerw",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1100,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "heimerdingere",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1025f, // 925 + Radius
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "heimerdingerespell",
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "heimerdingerr",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 230f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "heimerdingereult",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1450f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ireliagatotsu",
                ChampionName = "irelia",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 150f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ireliahitenstyle",
                ChampionName = "irelia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 230f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ireliaequilibriumstrike",
                ChampionName = "irelia",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ireliatranscendentblades",
                ChampionName = "irelia",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1200f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileName = "ireliatranscendentbladesspell",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "illaoiq",
                ChampionName = "illaoi",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "illaoiemis",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "illaoiw",
                ChampionName = "illaoi",
                Slot = SpellSlot.W,
                CastRange = 365f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "illaoie",
                ChampionName = "illaoi",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "illaoiemis",
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "illaoir",
                ChampionName = "illaoi",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 500f,
                HitTypes = new[] { HitType.Ultimate, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "howlinggalespell",
                ChampionName = "janna",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1550f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "howlinggalespell",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sowthewind",
                ChampionName = "janna",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "eyeofthestorm",
                ChampionName = "janna",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reapthewhirlwind",
                ChampionName = "janna",
                Slot = SpellSlot.R,
                CastRange = 725f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jarvanivdragonstrike",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jarvanivgoldenaegis",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jarvanivdemacianstandard",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.E,
                CastRange = 830f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "jarvanivdemacianstandard",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jarvanivcataclysm",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 0f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaxleapstrike",
                ChampionName = "jax",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaxempowertwo",
                ChampionName = "jax",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaxrelentlessasssault",
                ChampionName = "jax",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaycetotheskies",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 450f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jayceshockblast",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1570f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "jayceshockblastmis",
                MissileSpeed = 2350
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaycestaticfield",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 285f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaycehypercharge",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaycethunderingblow",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jayceaccelerationgate",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaycestancehtg",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jaycestancegth",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jhinq",
                ChampionName = "jhin",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jhinw",
                ChampionName = "jhin",
                Slot = SpellSlot.W,
                CastRange = 2250f,
                Delay = 750f,
                FixedRange = true,
                HitTypes = new HitType[] { },
                MissileName = "jhinwmissile",
                MissileSpeed = 5000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jhine",
                ChampionName = "jhin",
                Slot = SpellSlot.E,
                CastRange = 2250f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jhinrshot",
                ChampionName = "jhin",
                Slot = SpellSlot.R,
                CastRange = 3500f,
                Delay = 250f,
                FixedRange = true,
                MissileName = "jhinrshotmis",
                HitTypes = new HitType[] { },
                ExtraMissileNames = new[] { "jhinrmmissile", "jhinrshotmis4" },
                MissileSpeed = 5000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jinxq",
                ChampionName = "jinx",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jinxw",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1550f,
                Delay = 600f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "jinxwmissile",
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jinxe",
                ChampionName = "jinx",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
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
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = 1700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "karmaq",
                ChampionName = "karma",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "karmaqmissile",
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "karmaspiritbind",
                ChampionName = "karma",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "karmasolkimshield",
                ChampionName = "karma",
                Slot = SpellSlot.E,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "karmamantra",
                ChampionName = "karma",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "laywaste",
                ChampionName = "karthus",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 900f,
                HitTypes = new HitType[] { },
                ExtraMissileNames = new[]  {
                            "karthuslaywastea3", "karthuslaywastea1", "karthuslaywastedeada1", "karthuslaywastedeada2",
                            "karthuslaywastedeada3"
                        },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "wallofpain",
                ChampionName = "karthus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "defile",
                ChampionName = "karthus",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fallenone",
                ChampionName = "karthus",
                Slot = SpellSlot.R,
                CastRange = 22000f,
                Global = true,
                Delay = 2800f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nulllance",
                ChampionName = "kassadin",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "netherblade",
                ChampionName = "kassadin",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "forcepulse",
                ChampionName = "kassadin",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "riftwalk",
                ChampionName = "kassadin",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileName = "riftwalk",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "katarinaq",
                ChampionName = "katarina",
                Slot = SpellSlot.Q,
                CastRange = 675f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "katarinaw",
                ChampionName = "katarina",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "katarinae",
                ChampionName = "katarina",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "katarinar",
                ChampionName = "katarina",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new[] { HitType.ForceExhaust },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "judicatorreckoning",
                ChampionName = "kayle",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "judicatordevineblessing",
                ChampionName = "kayle",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 220f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "judicatorrighteousfury",
                ChampionName = "kayle",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "judicatorintervention",
                ChampionName = "kayle",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kennenshurikenhurlmissile1",
                ChampionName = "kennen",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1175f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "kennenshurikenhurlmissile1",
                MissileSpeed = 1700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kennenbringthelight",
                ChampionName = "kennen",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kennenlightningrush",
                ChampionName = "kennen",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kennenshurikenstorm",
                ChampionName = "kennen",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 500f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixq",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixqlong",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 375f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixw",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "khazixwmissile",
                MissileSpeed = 81700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixwlong",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixe",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "khazixe",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixelong",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixr",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "khazixrlong",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kindredq",
                ChampionName = "kindred",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kindrede",
                ChampionName = "kindred",
                Slot = SpellSlot.E,
                CastRange = 510f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kogmawq",
                ChampionName = "kogmaw",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1300f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "kogmawq",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kogmawbioarcanebarrage",
                ChampionName = "kogmaw",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kogmawvoidooze",
                ChampionName = "kogmaw",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "kogmawvoidoozemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kogmawlivingartillery",
                ChampionName = "kogmaw",
                Slot = SpellSlot.R,
                CastRange = 2200f,
                Delay = 1200f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "kogmawlivingartillery",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancchaosorb",
                ChampionName = "leblanc",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancslide",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Initiator },
                MissileName = "leblancslide",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblacslidereturn",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancsoulshackle",
                ChampionName = "leblanc",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "leblancsoulshackle",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancchaosorbm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancslidem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate, HitType.Initiator },
                MissileName = "leblancslidem",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancslidereturnm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leblancsoulshacklem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "leblancsoulshacklem",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonkqone",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "blindmonkqone",
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonkqtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonkwone",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonkwtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonkeone",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonketwo",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindmonkrkick",
                ChampionName = "leesin",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 500f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leonashieldofdaybreak",
                ChampionName = "leona",
                Slot = SpellSlot.Q,
                CastRange = 215f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leonasolarbarrier",
                ChampionName = "leona",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 3000f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leonazenithblade",
                ChampionName = "leona",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 900f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileName = "leonazenithblademissile",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "leonasolarflare",
                ChampionName = "leona",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 1200f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "leonasolarflare",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lissandraq",
                ChampionName = "lissandra",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 725f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "lissandraqmissile",
                MissileSpeed = 2250
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lissandraw",
                ChampionName = "lissandra",
                Slot = SpellSlot.W,
                CastRange = 450f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lissandrae",
                ChampionName = "lissandra",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "lissandraemissile",
                MissileSpeed = 850
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lissandrar",
                ChampionName = "lissandra",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new[]
                {
                    HitType.CrowdControl, HitType.Initiator,
                    HitType.Danger, HitType.Ultimate
                },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lucianq",
                ChampionName = "lucian",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1150f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "lucianq",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lucianw",
                ChampionName = "lucian",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "lucianwmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luciane",
                ChampionName = "lucian",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lucianr",
                ChampionName = "lucian",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1400f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "lucianrmissileoffhand",
                ExtraMissileNames = new[] { "lucianrmissile" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luluq",
                ChampionName = "lulu",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "luluqmissile",
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luluw",
                ChampionName = "lulu",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 640f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lulue",
                ChampionName = "lulu",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 640f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "lulur",
                ChampionName = "lulu",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luxlightbinding",
                ChampionName = "lux",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1300f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "luxlightbindingmis",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luxprismaticwave",
                ChampionName = "lux",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luxlightstrikekugel",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "luxlightstrikekugel",
                MissileSpeed = 1300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luxlightstriketoggle",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "luxmalicecannon",
                ChampionName = "lux",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 3340f,
                Delay = 1000f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileName = "luxmalicecannonmis",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kalistamysticshot",
                ChampionName = "kalista",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "kalistamysticshotmis",
                ExtraMissileNames = new[] { "kalistamysticshotmistrue" },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kalistaw",
                ChampionName = "kalista",
                Slot = SpellSlot.W,
                CastRange = 5000f,
                Delay = 800f,
                HitTypes = new HitType[] { },
                MissileSpeed = 200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "kalistaexpungewrapper",
                ChampionName = "kalista",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "seismicshard",
                ChampionName = "malphite",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "obduracy",
                ChampionName = "malphite",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "landslide",
                ChampionName = "malphite",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 500f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ufslash",
                ChampionName = "malphite",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileName = "ufslash",
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "malzaharq",
                ChampionName = "malzahar",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 600f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "alzaharcallofthevoid",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "malzaharw",
                ChampionName = "malzahar",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "malzahare",
                ChampionName = "malzahar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "malzaharr",
                ChampionName = "malzahar",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "maokaitrunkline",
                ChampionName = "maokai",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "maokaiunstablegrowth",
                ChampionName = "maokai",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "maokaisapling2",
                ChampionName = "maokai",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "maokaidrain3",
                ChampionName = "maokai",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "alphastrike",
                ChampionName = "masteryi",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 600f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "meditate",
                ChampionName = "masteryi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "wujustyle",
                ChampionName = "masteryi",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 230f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "highlander",
                ChampionName = "masteryi",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 370f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "missfortunericochetshot",
                ChampionName = "missfortune",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "missfortuneviciousstrikes",
                ChampionName = "missfortune",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "missfortunescattershot",
                ChampionName = "missfortune",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "missfortunebullettime",
                ChampionName = "missfortune",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1400f,
                Delay = 250f,
                HitTypes = new [] { HitType.Initiator, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingdoubleattack",
                ChampionName = "monkeyking",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingdecoy",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingdecoyswipe",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 300f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                FromObject = new [] { "Base_W_Copy" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingdecoyswipe",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 325f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingnimbus",
                ChampionName = "monkeyking",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingspintowin",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "monkeykingspintowinleave",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "mordekaisermaceofspades",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "mordekaisercreepindeathcast",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "mordekaisersyphoneofdestruction",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "mordekaiserchildrenofthegrave",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "darkbindingmissile",
                ChampionName = "morgana",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1175f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "darkbindingmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tormentedsoil",
                ChampionName = "morgana",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blackshield",
                ChampionName = "morgana",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "soulshackles",
                ChampionName = "morgana",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "namiq",
                ChampionName = "nami",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "namiqmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "namiw",
                ChampionName = "nami",
                Slot = SpellSlot.W,
                CastRange = 725f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "namie",
                ChampionName = "nami",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "namir",
                ChampionName = "nami",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 2550f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileName = "namirmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nasusq",
                ChampionName = "nasus",
                Slot = SpellSlot.Q,
                CastRange = 450f,
                Delay = 500f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nasusw",
                ChampionName = "nasus",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nasuse",
                ChampionName = "nasus",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nasusr",
                ChampionName = "nasus",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nautilusanchordrag",
                ChampionName = "nautilus",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1080f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "nautilusanchordragmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nautiluspiercinggaze",
                ChampionName = "nautilus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nautilussplashzone",
                ChampionName = "nautilus",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nautilusgrandline",
                ChampionName = "nautilus",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "javelintoss",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1500f,
                Delay = 125f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "javelintoss",
                MissileSpeed = 1300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "takedown",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 150f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bushwhack",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pounce",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 375f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Initiator },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "primalsurge",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "swipe",
                ChampionName = "nidalee",
                FixedRange = true,
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "aspectofthecougar",
                ChampionName = "nidalee",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nocturneduskbringer",
                ChampionName = "nocturne",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1125f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nocturneshroudofdarkness",
                ChampionName = "nocturne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nocturneunspeakablehorror",
                ChampionName = "nocturne",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "nocturneparanoia",
                ChampionName = "nocturne",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "consume",
                ChampionName = "nunu",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bloodboil",
                ChampionName = "nunu",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "iceblast",
                ChampionName = "nunu",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "absolutezero",
                ChampionName = "nunu",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "olafaxethrowcast",
                ChampionName = "olaf",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "olafaxethrow",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "olaffrenziedstrikes",
                ChampionName = "olaf",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "olafrecklessstrike",
                ChampionName = "olaf",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 500f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "olafragnarok",
                ChampionName = "olaf",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "orianaizunacommand",
                ChampionName = "orianna",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "orianaizuna",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "orianadissonancecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "orianadissonancecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "orianaredactcommand",
                ChampionName = "orianna",
                Slot = SpellSlot.E,
                CastRange = 1095f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "orianaredact",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "orianadetonatecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 500f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileName = "orianadetonatecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pantheonq",
                ChampionName = "pantheon",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pantheonw",
                ChampionName = "pantheon",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pantheone",
                ChampionName = "pantheon",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pantheonrjump",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitTypes = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pantheonrfall",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitTypes = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "poppyq",
                ChampionName = "poppy",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 450f,
                Delay = 500f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "poppyw",
                ChampionName = "poppy",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "poppye",
                ChampionName = "poppy",
                Slot = SpellSlot.E,
                CastRange = 525f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "poppyrspell",
                ChampionName = "poppy",
                FixedRange = true,
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 300f,
                HitTypes = new HitType[] { },
                MissileName = "poppyrspellmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "poppyrspellinstant",
                ChampionName = "poppy",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 450f,
                Delay = 300f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "quinnq",
                ChampionName = "quinn",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "quinnqmissile",
                ExtraMissileNames = new[] { "quinnq" },
                MissileSpeed = 1550
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "quinnw",
                ChampionName = "quinn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "quinne",
                ChampionName = "quinn",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 775
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "quinnr",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "quinnrfinale",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "powerball",
                ChampionName = "rammus",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = 775
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "defensiveballcurl",
                ChampionName = "rammus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "puncturingtaunt",
                ChampionName = "rammus",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tremors2",
                ChampionName = "rammus",
                Slot = SpellSlot.R,
                CastRange = 300f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "renektoncleave",
                ChampionName = "renekton",
                Slot = SpellSlot.Q,
                CastRange = 225f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "renektonpreexecute",
                ChampionName = "renekton",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "renektonsliceanddice",
                ChampionName = "renekton",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "renektonreignofthetyrant",
                ChampionName = "renekton",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rengarq",
                ChampionName = "rengar",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rengarw",
                ChampionName = "rengar",
                Slot = SpellSlot.W,
                CastRange = 500f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rengare",
                ChampionName = "rengar",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "rengarefinal",
                ExtraMissileNames = new[] { "rengarefinalmax" },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rengarr",
                ChampionName = "rengar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksaiq",
                ChampionName = "reksai",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 275f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksaiqburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 1650f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "reksaiqburrowedmis",
                MissileSpeed = 1950
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksaiw",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 350f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksaiwburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksaie",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksaieburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 900f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "reksair",
                ChampionName = "reksai",
                Slot = SpellSlot.R,
                CastRange = 2.147484E+09f,
                Delay = 1000f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "riventricleave",
                ChampionName = "riven",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 270f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rivenmartyr",
                ChampionName = "riven",
                Slot = SpellSlot.W,
                CastRange = 260f,
                Delay = 100f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rivenfeint",
                ChampionName = "riven",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rivenfengshuiengine",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rivenizunablade",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1075f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileName = "rivenlightsabermissile",
                ExtraMissileNames = new[] { "rivenlightsabermissileside" },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rumbleflamethrower",
                ChampionName = "rumble",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rumbleshield",
                ChampionName = "rumble",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rumbegrenade",
                ChampionName = "rumble",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "rumblecarpetbomb",
                ChampionName = "rumble",
                Slot = SpellSlot.R,
                CastRange = 1700f,
                Delay = 400f,
                HitTypes = new HitType[] { },
                MissileName = "rumblecarpetbombmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ryzeq",
                ChampionName = "ryze",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "ryzeqmissile",
                ExtraMissileNames = new[] { "ryzeq" },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ryzew",
                ChampionName = "ryze",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ryzee",
                ChampionName = "ryze",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ryzer",
                ChampionName = "ryze",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sejuaniarcticassault",
                ChampionName = "sejuani",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 650f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl,HitType.Initiator },
                MissileName = "",
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sejuaninorthernwinds",
                ChampionName = "sejuani",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 1000f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sejuaniwintersclaw",
                ChampionName = "sejuani",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sejuaniglacialprisoncast",
                ChampionName = "sejuani",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileName = "sejuaniglacialprison",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "deceive",
                ChampionName = "shaco",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "jackinthebox",
                ChampionName = "shaco",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twoshivpoison",
                ChampionName = "shaco",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hallucinatefull",
                ChampionName = "shaco",
                Slot = SpellSlot.R,
                CastRange = 1125f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 395
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shenq",
                ChampionName = "shen",
                Slot = SpellSlot.Q,
                CastRange = 1650f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                FromObject = new[] { "ShenArrowVfxHostMinion" },
                MissileSpeed = 1350
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shenw",
                ChampionName = "shen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shene",
                ChampionName = "shen",
                Slot = SpellSlot.E,
                CastRange = 675f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "shene",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shenr",
                ChampionName = "shen",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanadoubleattack",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanadoubleattackdragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanaimmolationauraqw",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanaimmolateddragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanafireball",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "shyvanafireballmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanafireballdragon2",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "shyvanatransformcast",
                ChampionName = "shyvana",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 100f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.CrowdControl,
                        HitType.Ultimate, HitType.Initiator
                    },
                MissileName = "shyvanatransformcast",
                MissileSpeed = 1100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "poisentrail",
                ChampionName = "singed",
                Slot = SpellSlot.Q,
                CastRange = 250f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "megaadhesive",
                ChampionName = "singed",
                Slot = SpellSlot.W,
                CastRange = 1175f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "fling",
                ChampionName = "singed",
                Slot = SpellSlot.E,
                CastRange = 125f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "insanitypotion",
                ChampionName = "singed",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sionq",
                ChampionName = "sion",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sionwdetonate",
                ChampionName = "sion",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sione",
                ChampionName = "sion",
                Slot = SpellSlot.E,
                CastRange = 725f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "sionemissile",
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sionr",
                ChampionName = "sion",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "",
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sivirq",
                ChampionName = "sivir",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1165f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "sivirqmissile",
                ExtraMissileNames = new[] { "sivirqmissilereturn" },
                MissileSpeed = 1350
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sivirw",
                ChampionName = "sivir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sivire",
                ChampionName = "sivir",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sivirr",
                ChampionName = "sivir",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "skarnervirulentslash",
                ChampionName = "skarner",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "skarnerexoskeleton",
                ChampionName = "skarner",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "skarnerfracture",
                ChampionName = "skarner",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "skarnerfracturemissile",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "skarnerimpale",
                ChampionName = "skarner",
                Slot = SpellSlot.R,
                CastRange = 350f,
                Delay = 350f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sonaq",
                ChampionName = "sona",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sonaw",
                ChampionName = "sona",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sonae",
                ChampionName = "sona",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sonar",
                ChampionName = "sona",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileName = "sonar",
                MissileSpeed = 2400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sorakaq",
                ChampionName = "soraka",
                Slot = SpellSlot.Q,
                CastRange = 970f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "",
                MissileSpeed = 1100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sorakaw",
                ChampionName = "soraka",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sorakae",
                ChampionName = "soraka",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 1750f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "sorakar",
                ChampionName = "soraka",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "swaindecrepify",
                ChampionName = "swain",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "swainshadowgrasp",
                ChampionName = "swain",
                Slot = SpellSlot.W,
                CastRange = 1040f,
                Delay = 1100f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "swainshadowgrasp",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "swaintorment",
                ChampionName = "swain",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "swainmetamorphism",
                ChampionName = "swain",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1950
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "syndraq",
                ChampionName = "syndra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "syndraq",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "syndrawcast",
                ChampionName = "syndra",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "syndrawcast",
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "syndrae",
                ChampionName = "syndra",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 950f,
                Delay = 300f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "syndrae",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "syndrar",
                ChampionName = "syndra",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 450f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = 1250
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tahmkenchq",
                ChampionName = "tahmkench",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 2800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "talonnoxiandiplomacy",
                ChampionName = "talon",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "talonrake",
                ChampionName = "talon",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "talonrakemissileone",
                MissileSpeed = 2300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "taloncutthroat",
                ChampionName = "talon",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "talonshadowassault",
                ChampionName = "talon",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 260f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "taricq",
                ChampionName = "taric",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "taricw",
                ChampionName = "taric",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tarice",
                ChampionName = "taric",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 1000f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "taricr",
                ChampionName = "taric",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "blindingdart",
                ChampionName = "teemo",
                Slot = SpellSlot.Q,
                CastRange = 580f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "movequick",
                ChampionName = "teemo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 943
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "toxicshot",
                ChampionName = "teemo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bantamtrap",
                ChampionName = "teemo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "threshq",
                ChampionName = "thresh",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1175f,
                Delay = 500f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "threshqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "threshw",
                ChampionName = "thresh",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "threshe",
                ChampionName = "thresh",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "threshemissile1",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "threshrpenta",
                ChampionName = "thresh",
                Slot = SpellSlot.R,
                CastRange = 420f,
                Delay = 300f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1550
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tristanaq",
                ChampionName = "tristana",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tristanaw",
                ChampionName = "tristana",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = 1150
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tristanae",
                ChampionName = "tristana",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "tristanar",
                ChampionName = "tristana",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "trundletrollsmash",
                ChampionName = "trundle",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "trundledesecrate",
                ChampionName = "trundle",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "trundlecircle",
                ChampionName = "trundle",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "trundlepain",
                ChampionName = "trundle",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bloodlust",
                ChampionName = "tryndamere",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "mockingshout",
                ChampionName = "tryndamere",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "slashcast",
                ChampionName = "tryndamere",
                Slot = SpellSlot.E,
                CastRange = 660f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "slashcast",
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "undyingrage",
                ChampionName = "tryndamere",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twitchhideinshadows",
                ChampionName = "twitch",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 450f,
                HitTypes = new[] { HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twitchvenomcask",
                ChampionName = "twitch",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "twitchvenomcaskmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twitchvenomcaskmissle",
                ChampionName = "twitch",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twitchexpungewrapper",
                ChampionName = "twitch",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twitchexpunge",
                ChampionName = "twitch",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "twitchfullautomatic",
                ChampionName = "twitch",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "wildcards",
                ChampionName = "twistedfate",
                Slot = SpellSlot.Q,
                CastRange = 1450f,
                FixedRange = true,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "sealfatemissile",
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "pickacard",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "goldcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "redcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bluecardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "cardmasterstack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "destiny",
                ChampionName = "twistedfate",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "udyrtigerstance",
                ChampionName = "udyr",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "udyrturtlestance",
                ChampionName = "udyr",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "udyrbearstanceattack",
                ChampionName = "udyr",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "udyrphoenixstance",
                ChampionName = "udyr",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "urgotheatseekinglineqqmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "urgotheatseekingmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "urgotterrorcapacitoractive2",
                ChampionName = "urgot",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "urgotplasmagrenade",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "urgotplasmagrenadeboom",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "urgotplasmagrenadeboom",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "urgotswap2",
                ChampionName = "urgot",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1800
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "varusq",
                ChampionName = "varus",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1250f,
                Delay = 0f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "varusqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "varusw",
                ChampionName = "varus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "varuse",
                ChampionName = "varus",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "varuse",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "varusr",
                ChampionName = "varus",
                Slot = SpellSlot.R,
                FixedRange = true,
                CastRange = 1300f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileName = "varusrmissile",
                MissileSpeed = 1950
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vaynetumble",
                ChampionName = "vayne",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vaynesilverbolts",
                ChampionName = "vayne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vaynecondemnmissile",
                ChampionName = "vayne",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vayneinquisition",
                ChampionName = "vayne",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new[] { HitType.Stealth, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "veigarbalefulstrike",
                ChampionName = "veigar",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 950f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "veigarbalefulstrikemis",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "veigardarkmatter",
                ChampionName = "veigar",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 1200f,
                HitTypes = new HitType[] { },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "veigareventhorizon",
                ChampionName = "veigar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "veigarprimordialburst",
                ChampionName = "veigar",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "velkozq",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1250f,
                Delay = 100f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "velkozqmissile",
                MissileSpeed = 1300
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "velkozqsplitactivate",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "velkozqmissilesplit",
                MissileSpeed = 2100
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "velkozw",
                ChampionName = "velkoz",
                Slot = SpellSlot.W,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileName = "velkozwmissile",
                MissileSpeed = 1700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "velkoze",
                ChampionName = "velkoz",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 0f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "velkozemissile",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "velkozr",
                ChampionName = "velkoz",
                Slot = SpellSlot.R,
                CastRange = 1575f,
                Delay = 0f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "viqmissile",
                ChampionName = "vi",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl, HitType.Initiator },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "viw",
                ChampionName = "vi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vie",
                ChampionName = "vi",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vir",
                ChampionName = "vi",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "viktorpowertransfer",
                ChampionName = "viktor",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1050
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "viktorgravitonfield",
                ChampionName = "viktor",
                Slot = SpellSlot.W,
                CastRange = 815f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "viktordeathray",
                ChampionName = "viktor",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileName = "viktordeathraymis",
                ExtraMissileNames = new[] { "viktoreaugmissile" },
                MissileSpeed = 1210
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "viktorchaosstorm",
                ChampionName = "viktor",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.CrowdControl, HitType.Ultimate,
                        HitType.Danger, HitType.Initiator
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vladimirq",
                ChampionName = "vladimir",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vladimirw",
                ChampionName = "vladimir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vladimire",
                ChampionName = "vladimir",
                Slot = SpellSlot.E,
                CastRange = 610f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "vladimirr",
                ChampionName = "vladimir",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "volibearq",
                ChampionName = "volibear",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "volibearw",
                ChampionName = "volibear",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "volibeare",
                ChampionName = "volibear",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 825
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "volibearr",
                ChampionName = "volibear",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 825
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hungeringstrike",
                ChampionName = "warwick",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "hunterscall",
                ChampionName = "warwick",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "bloodscent",
                ChampionName = "warwick",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "infiniteduress",
                ChampionName = "warwick",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xeratharcanopulsechargeup",
                ChampionName = "xerath",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 750f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xeratharcanebarrage2",
                ChampionName = "xerath",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "xeratharcanebarrage2",
                MissileSpeed = 20
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xerathmagespear",
                ChampionName = "xerath",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1050f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger },
                MissileName = "xerathmagespearmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xerathlocusofpower2",
                ChampionName = "xerath",
                Slot = SpellSlot.R,
                CastRange = 5600f,
                Delay = 750f,
                HitTypes = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xenzhaothrust3",
                ChampionName = "xinzhao",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xenzhaobattlecry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xenzhaosweep",
                ChampionName = "xinzhao",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl, HitType.Danger, HitType.Initiator },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "xenzhaoparry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 250f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl
                    },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yasuoqw",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 475f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yasuoq2w",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 475f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yasuoq3",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 1000f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "yasuoq3mis",
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yasuowmovingwall",
                ChampionName = "yasuo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yasuodashwrapper",
                ChampionName = "yasuo",
                Slot = SpellSlot.E,
                CastRange = 475f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yasuorknockupcombow",
                ChampionName = "yasuo",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yorickspectral",
                ChampionName = "yorick",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yorickdecayed",
                ChampionName = "yorick",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yorickravenous",
                ChampionName = "yorick",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "yorickreviveally",
                ChampionName = "yorick",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zacq",
                ChampionName = "zac",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 550f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "zacq",
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zacw",
                ChampionName = "zac",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zace",
                ChampionName = "zac",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zacr",
                ChampionName = "zac",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.Danger, HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zedq",
                ChampionName = "zed",
                Slot = SpellSlot.Q,
                FixedRange = true,
                CastRange = 900f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "zedqmissile",
                FromObject = new[] { "Zed_Base_W_tar.troy", "Zed_Base_W_cloneswap_buf.troy" },
                ExtraMissileNames = new[] { "zedqmissiletwo", "zedqmissilethree" },
                MissileSpeed = 1700
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zedw",
                ChampionName = "zed",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zede",
                ChampionName = "zed",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zedr",
                ChampionName = "zed",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 450f,
                HitTypes = new[] { HitType.Danger, HitType.Initiator },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ziggsq",
                ChampionName = "ziggs",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "ziggsqspell",
                ExtraMissileNames = new[] { "ziggsqspell2", "ziggsqspell3" },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ziggsw",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "ziggsw",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ziggswtoggle",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ziggse",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "ziggse",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ziggse2",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "ziggsr",
                ChampionName = "ziggs",
                Slot = SpellSlot.R,
                CastRange = 2250f,
                Delay = 1800f,
                HitTypes = new[] { HitType.Danger, HitType.Ultimate },
                MissileName = "ziggsr",
                MissileSpeed = 1750
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zileanq",
                ChampionName = "zilean",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 300f,
                HitTypes = new HitType[] { },
                MissileName = "zileanqmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zileanw",
                ChampionName = "zilean",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zileane",
                ChampionName = "zilean",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zileanr",
                ChampionName = "zilean",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zyraq",
                ChampionName = "zyra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileName = "zyraqmissile",
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zyraw",
                ChampionName = "zyra",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitTypes = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zyrae",
                ChampionName = "zyra",
                Slot = SpellSlot.E,
                FixedRange = true,
                CastRange = 1100f,
                Delay = 250f,
                HitTypes = new[] { HitType.CrowdControl },
                MissileName = "zyraemissile",
                MissileSpeed = 1400
            });

            Spells.Add(new HeroAbilityData
            {
                SDataName = "zyrar",
                ChampionName = "zyra",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitTypes =
                    new[]
                    {
                        HitType.Danger, HitType.Ultimate,
                        HitType.CrowdControl, HitType.Initiator
                    },
                MissileSpeed = int.MaxValue
            });
        }

        public static List<HeroAbilityData> Spells = new List<HeroAbilityData>();
        public static List<HeroAbilityData> CachedSpells = new List<HeroAbilityData>();
        public static Dictionary<SpellDamageDelegate, SpellSlot> DamageLib = new Dictionary<SpellDamageDelegate, SpellSlot>();

        public static HeroAbilityData GetByMissileName(string missilename)
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