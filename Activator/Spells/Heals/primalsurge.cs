﻿using System;
using Activator.Base;
using LeagueSharp.Common;

namespace Activator.Spells.Heals
{
    class primalsurge : CoreSpell
    {
        internal override string Name => "primalsurge";
        internal override string DisplayName => "Primal Surge | E";
        internal override float Range => 600f;
        internal override MenuType[] Category => new[] { MenuType.SelfLowHP, MenuType.SelfMinMP };
        internal override int DefaultHP => 90;
        internal override int DefaultMP => 55;
        internal override int Priority => 4;

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            if (Activator.Player.CharData.BaseSkinName != "Nidalee")
                return;

            if (Player.Mana/Player.MaxMana * 100 <
                Menu.Item("selfminmp" + Name + "pct").GetValue<Slider>().Value)
                return;

            foreach (var hero in Activator.Allies())
            {
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.NetworkId).GetValue<bool>())
                    continue; 

                if (hero.Player.Distance(Player.ServerPosition) <= Range)
                {
                    if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                        UseSpellOn(hero.Player);
                }
            }
        }
    }
}
