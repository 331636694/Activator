using System;
using System.Linq;
using Activator.Base;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    class teleport : CoreSum
    {
        internal override string Name => "summonerteleport";
        internal override string DisplayName => "Teleport";
        internal override string[] ExtraNames => new[] { "" };
        internal override float Range => float.MaxValue;
        internal override int Duration => 3500;

        static bool IsLethal(Champion hero)
        {
            return hero.Player.Health/hero.Player.MaxHealth * 100 <= 35 && hero.IncomeDamage > 0 ||
                   hero.HitTypes.Contains(HitType.Ultimate) && hero.IncomeDamage > 0;
        }

        public override void AttachMenu(Menu menu)
        {
            menu.AddItem(new MenuItem("teleblank", "Disclaimer: Camera Position are Beta! :^)"));
            menu.AddItem(new MenuItem("teleqq", "Show Recent Event (Lock to Me)"))
                .SetTooltip("Move camera between you and the most recent event")
                .SetValue(new KeyBind(192, KeyBindType.Press))
                .ValueChanged += (sender, e) =>
                {
                    if (e.GetNewValue<KeyBind>().Active == e.GetOldValue<KeyBind>().Active) return;
                    if (!e.GetNewValue<KeyBind>().Active) Camera.Position = Player.Position;
                };
            menu.AddItem(new MenuItem("teleqq2", "Show Only Recent Event"))
                .SetTooltip("Move camera to the most recent event")
                .SetValue(new KeyBind('Z', KeyBindType.Press));
            menu.AddItem(new MenuItem("teledraw", "Outline Ally in Danger (Minimap)")).SetValue(true);

            Utility.DelayAction.Add(2000,
                () => Game.PrintChat("<b><font color=\"#FF3366\">Activator#</font></b> - New Teleport Camera API :^)"));
        }

        public override void OnTick(EventArgs args)
        {
            if (Menu.Item("teleqq").GetValue<KeyBind>().Active || Menu.Item("teleqq2").GetValue<KeyBind>().Active)
            {
                var priority =
                    Activator.Allies().Where(h => !h.Player.IsMe)
                        .OrderByDescending(h => h.IncomeDamage)
                        .ThenByDescending(h => h.Player.CountEnemiesInRange(1450))
                        .ThenBy(h => h.Player.Health/h.Player.MaxHealth*100);

                if (priority.FirstOrDefault() != null)
                {
                    Camera.Position = priority.First().Player.Position;
                }
            }
        }

        public override void OnDraw(EventArgs args)
        {                       
            if (IsReady() && Menu.Item("teledraw").GetValue<bool>())
            {
                foreach (var hero in Activator.Allies())
                {
                    if (hero.Player.IsValid && !hero.Player.IsZombie && !hero.Player.IsDead)
                    {
                        if (IsLethal(hero) && !hero.Player.IsMe)
                        {
                            Utility.DrawCircle(hero.Player.Position, 850f, System.Drawing.Color.Crimson, 3, 30, true);
                        }
                    }
                }
            }          
        }
    }
}
