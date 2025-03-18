// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using ModShardLauncher;
using ModShardLauncher.Mods;
using ModShardLauncher.Extensions;

using UndertaleModLib;
using UndertaleModLib.Models;

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
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_is_exchange_done.gml"), "scr_mod_uim_is_exchange_done");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_check_available.gml"), "scr_mod_uim_check_available");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_item_exists.gml"), "scr_mod_uim_item_exists");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_give_item.gml"), "scr_mod_uim_give_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_exchange_item.gml"), "scr_mod_uim_exchange_item");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_make_deal.gml"), "scr_mod_uim_make_deal");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_no_item_exchanging.gml"), "scr_mod_uim_no_item_exchanging");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_finish_exchange.gml"), "scr_mod_uim_finish_exchange");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_cancel_exchange.gml"), "scr_mod_uim_cancel_exchange");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_has_discount.gml"), "scr_mod_uim_has_discount");
        Msl.AddFunction(ModFiles.GetCode("scr_mod_uim_check_money.gml"), "scr_mod_uim_check_money");
        Msl.AddFunction(ModFiles.GetCode("UpdateFenceDialogData.gml"), "UpdateFenceDialogData");

        Localization.DialogLinesPatching();
        PatchWeaponArmor();
    }

    private List<string[]> GetEquipTableRange(string start, string end)
    {
        List<string> lines = Msl.ThrowIfNull(ModLoader.GetTable("gml_GlobalScript_table_equipment"));
        int startIndex = lines.FindIndex(item => item.Contains(start));
        int endIndex = lines.FindIndex(item => item.Contains(end));
        return lines
            .Skip(startIndex + 1)
            .Take(endIndex - startIndex - 1)
            .Select(x => x.Split(";")).ToList();
    }

    private void PatchWeaponArmor()
    {
        DirectoryInfo dir = new("ModSources/UniqueItemMarket/tmp");

        List<string[]> weapon_name = GetEquipTableRange("weapon_name;weapon_name;", "weapon_name_end;weapon_name_end;");                                        
        List<string[]> armor_name = GetEquipTableRange("armor_name;armor_name;", "armor_name_end;armor_name_end;");

        List<string> lines = Msl.ThrowIfNull(ModLoader.GetTable("gml_GlobalScript_table_weapons"));
        List<string> weapons = lines.Select(x => x.Split(';'))
            .Where(x => x.Length == 80 && x[1] == "5" && x[76] == "unique")
            .Select(x => x[0])
            .ToList();

        lines = Msl.ThrowIfNull(ModLoader.GetTable("gml_GlobalScript_table_armor"));
        List<string> armors = lines.Select(x => x.Split(';'))
            .Where(x => x.Length == 100 && x[1] == "5" && x[82] == "unique")
            .Select(x => x[0])
            .ToList();

        List<string[]> unique_weapon_name = weapon_name
            .Where(x => weapons.Contains(x[0]))
            .ToList();

        List<string[]> unique_armor_name = armor_name
            .Where(x => armors.Contains(x[0]))
            .ToList();

        // Insert Localization

        List<string> weapon_name_localization = unique_weapon_name
            .Select(x => string.Format("{0};;;;;;{1}", "mod_uim_" + x[0].Replace(" ", "_"), string.Join(";", x.Skip(1))))
            .ToList();
        List<string> armor_name_localization = unique_armor_name
            .Select(x => string.Format("{0};;;;;;{1}", "mod_uim_" + x[0].Replace(" ", "_"), string.Join(";", x.Skip(1))))
            .ToList();

        List<string> loc_table = Msl.ThrowIfNull(ModLoader.GetTable("gml_GlobalScript_table_lines"));
        loc_table.InsertRange(loc_table.FindIndex(x => x.Contains("[NPC] GREETINGS;")), weapon_name_localization);
        loc_table.InsertRange(loc_table.FindIndex(x => x.Contains("[NPC] GREETINGS;")), weapon_name_localization.Select(x => x.Replace("mod_uim_", "mod_uim_target_")));
        loc_table.InsertRange(loc_table.FindIndex(x => x.Contains("[NPC] GREETINGS;")), armor_name_localization);
        loc_table.InsertRange(loc_table.FindIndex(x => x.Contains("[NPC] GREETINGS;")), armor_name_localization.Select(x => x.Replace("mod_uim_", "mod_uim_target_")));
        ModLoader.SetTable(loc_table, "gml_GlobalScript_table_lines");

        // Insert GML codes
        UndertaleGameObject ob = Msl.AddObject("unique_item_market_initializer", isPersistent: true);
        Msl.AddNewEvent(ob, "", EventType.Create, 0);
        UndertaleRoom room = Msl.GetRoom("START");
        room.AddGameObject("Instances", ob);

        string codes = ModFiles.GetCode("UpdateFenceDialogData.gml");
        List<string> items = weapons.Concat(armors).ToList();
        foreach (string itm in items)
        {
            string key = itm.Replace(" ", "_");
            codes += @$"
array_push(_Fragments.mod_uim_exchange, ""mod_uim_{key}"")
variable_struct_set(_Fragments, ""mod_uim_{key}"", ""instruction_INS_giveItem"")
variable_struct_set(_Scripts, ""embedded_mod_uim_{key}"", function () {{ return scr_instance_exists_item(""{itm}"") }})

array_push(_Fragments.mod_uim_exchange_target, ""mod_uim_target_{key}"")
variable_struct_set(_Fragments, ""mod_uim_target_{key}"", ""instruction_INS_exchangeItem"")
variable_struct_set(_Scripts, ""embedded_mod_uim_target_{key}"", function () {{ return ds_list_find_index(scr_atr(""specialItemsPool""), ""{itm}"") == -1 }})
            ";
        }

        codes += @"
array_push(_Fragments.mod_uim_exchange, ""mod_uim_cancel_1"")
array_push(_Fragments.mod_uim_exchange_target, ""mod_uim_cancel_2"")
";

        Msl.LoadGML(Msl.EventName("unique_item_market_initializer", EventType.Create, 0))
            .MatchAll()
            .InsertBelow(codes)
            .Save();
    }
}
