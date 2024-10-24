// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;

namespace UniqueItemMarket;
public class UniqueItemMarket : Mod
{
    public override string Author => "Altair";
    public override string Name => "Unique Item Market";
    public override string Description => "You can entrust your precious unique weaponry to Skinflint Homs in exchange for other weaponry from bandits, occultists, or mercenaries.";
    public override string Version => "1.0.0";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_give_item.gml"), "scr_mod_uim_give_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_exchange_item.gml"), "scr_mod_uim_exchange_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_check_available.gml"), "scr_mod_uim_check_available");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_make_deal.gml"), "scr_mod_uim_make_deal");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_no_item_exchanging.gml"), "scr_mod_uim_no_item_exchanging");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_finish_exchange.gml"), "scr_mod_uim_finish_exchange");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_cancel_exchange.gml"), "scr_mod_uim_cancel_exchange");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_accept_exchange.gml"), "scr_mod_uim_accept_exchange");

        Msl.LoadGML("gml_Object_o_npc_Fence_Create_0")
            .MatchFrom(@"scr_npc_dialogue_init(""Fence"")")
            .ReplaceBy(@"scr_npc_dialogue_init(""Fence_Mod_UIM"")")
            .Save();

        Msl.LoadGML("gml_Object_o_npc_Fence_Other_23")
            .MatchFrom("event_inherited()")
            .InsertAbove(@"
var _timestamp = scr_npc_get_global_info(""uniqueItemExchangeCD"")
var _hoursPassed = scr_timeGetPassed(_timestamp, ""hours"")
if (ds_map_exists(data, ""item_for_exchange"") && ds_map_exists(data, ""target_for_exchange"") && _timestamp != 0 && _hoursPassed >= 12)
    topic = ""topicUnique""
")
            .Save();

        Localization.DialogLinesPatching();
    }
}
