using System;
using Activator.Handlers;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    internal class boost : CoreSum
    {
        internal override string Name => "summonerboost";
        internal override string DisplayName => "Cleanse";
        internal override string[] ExtraNames => new[] { "" };
        internal override float Range => float.MaxValue;
        internal override int Duration => 3000;

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (!Parent.Item(Parent.Name + "useon" + hero.Player.NetworkId).GetValue<bool>())
                        return;

                    if (hero.Player.Distance(Player.ServerPosition) > Range)
                        return;

                    if (hero.Player.Position.Z > Activator.PlayerZ + 200)
                    {
                        return;
                    }

                    Buffs.CheckCleanse(hero.Player);

                    var d = Convert.ToDouble(Menu.Item("use" + Name + "time").GetValue<StringList>().SelectedValue);
                    if (hero.CleanseBuffCount >= Menu.Item("use" + Name + "number").GetValue<Slider>().Value &&
                        hero.CleanseHighestBuffTime >= d * 1000)
                    {
                        //if (!Menu.Item("use" + Name + "od").GetValue<bool>())
                        //{
                            Utility.DelayAction.Add(
                                Game.Ping + Menu.Item("use" + Name + "delay").GetValue<Slider>().Value, delegate
                                {
                                    UseSpell(Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                                    hero.CleanseBuffCount = 0;
                                    hero.CleanseHighestBuffTime = 0;
                                });
                        //}
                    }
                }
            }
        }
    }
}
