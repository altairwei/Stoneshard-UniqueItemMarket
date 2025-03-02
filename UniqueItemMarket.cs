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
        string[] items = {
            // Weapon
            "Radiant Sword",        "Jarl Blade",                   "Royal Blade",          "Theurgist Blade",      "Guardsman Broadsword",
            "Ancient Scimitar",     "Decorated Saber",              "Exquisite Tabar",      "Gilded Axe",           "Baron Axe",
            "Voivod Mace",          "Decorated Flanged Mace",       "Decorated Warhammer",  "Ceremonial Dagger",    "Ducal Dagger",
            "Ornate Longsword",     "Blademaster Greatsword",       "Exquisite Twohander",  "Espadon",              "Faceless Spear",
            /*"Radiant Spear",      "Castellier Spear",*/           "Decorated Voulge",     "Ornate Longaxe",       "Exquisite Grandmace",
            "Ornate Polehammer",    "Gilded Polehammer",        /*"Ordermarshal Flail",*/   "Decorated Longbow",    "Relict Longbow",
            "Ornate Crossbow",      /*"Royal Huntmaster Crossbow",*/"Guardsman Crossbow",   /*"Ornate Sling",*/     "Farseer Staff",
            "Axonian Warstaff",     /*"Mage General Warstaff",      "Stargazer Warstaff",*/ "Hermit Staff",         "Vampiric Staff",
            "Orient Staff",
            // Armor & Jewelry
            "Uroboros Shield",      "Joust Shield",     "Sun Shield",               "Guardian Shield",          "Orient Tower Shield",
            "Decorated Barbute",    "Luxurious Sallet", "Ceremonial Sentinet",      "Vagabond Knight Sentinet", "Radiant Topfhelm",
            "Hermit Circlet",       "Hermit Garment",   "Royal Ranger Gambeson",    "Ceremonial Armor",         "Vagabond Knight Armor",
            /*"Antique Wristbands",*/   "Sardar Boots",     "Engraved Boots",           "Hermit Ring",              "Warding Hand Amulet",
            "Occult Cloak"
        };

        foreach (string it in items)
        {
            string funcname_1 = "scr_mod_uim_item_exists_" + it.Replace(" ", "_");
            Msl.AddFunction(
                name: funcname_1,
                codeAsString: $"function {funcname_1}() {{ return scr_instance_exists_item(\"{it}\") }}"
            );
            string funcname_2 = "scr_mod_uim_check_available_" + it.Replace(" ", "_");
            Msl.AddFunction(
                name: funcname_2,
                codeAsString: $"function {funcname_2}() {{ return ds_list_find_index(scr_atr(\"specialItemsPool\"), \"{it}\") == -1 }}"
            );
        }

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

        /*
        Msl.LoadAssemblyAsString("gml_GlobalScript_DialogueSystem")
            .MatchFromUntil("> gml_Script_fragment_eval_embedded_instruction (locals=2, argc=1)", "pushloc.v local._embed_name")
            .InsertBelow(@"pop.v.v global.mod_uim_current_embed_name
pushloc.v local._embed_name")
            .Save();
        */

        UndertaleGameObject ob = Msl.AddObject("unique_item_market_initializer", isPersistent: true);
        Msl.AddNewEvent(ob, ModFiles.GetCode("UpdateFenceDialogData.gml"), EventType.Create, 0);
        // initializer in START room
        UndertaleRoom room = Msl.GetRoom("START");
        room.AddGameObject("Instances", ob);

        Localization.DialogLinesPatching();

        // FIXME
        // DebugPatching();
    }

    private static void ExportTable(string table)
    {
        DirectoryInfo dir = new("ModSources/UniqueItemMarket/tmp");
        if (!dir.Exists) dir.Create();
        List<string>? lines = ModLoader.GetTable(table);
        if (lines != null)
        {
            File.WriteAllLines(
                Path.Join(dir.FullName, Path.DirectorySeparatorChar.ToString(), table + ".tsv"),
                lines.Select(x => string.Join('\t', x.Split(';')))
            );
        }
    }

    private void DebugPatching()
    {
        Msl.LoadGML("gml_GlobalScript_debug_print")
            .MatchFromUntil("function debug_print()", "{")
            .InsertBelow(@"
    var _str = ""debug_print: "";
    for (var i = 0; i < argument_count; i ++)
    {
        _str += "" "" + string(argument[i]);
    }
    scr_msl_log(_str)")
            .Save();

        Msl.LoadAssemblyAsString("gml_GlobalScript_neoconsole_api")
            .MatchFromUntil("> gml_Script_print (locals=3, argc=0)", ":[145]")
            .InsertBelow(@"push.s ""print: ""@121330
pop.v.s local._str
pushi.e 0
pop.v.i local.i

:[1002]
pushloc.v local.i
pushbltn.v builtin.argument_count
cmp.v.v LT
bf [1004]

:[1003]
push.v local._str
push.s "" ""@2874
pushi.e -15
pushloc.v local.i
conv.v.i
push.v [array]self.argument
call.i string(argc=1)
add.v.s
add.v.v
pop.v.v local._str
push.v local.i
push.e 1
add.i.v
pop.v.v local.i
b [1002]

:[1004]
pushloc.v local._str
call.i gml_Script_scr_msl_log(argc=1)
popz.v")
            .Save();


        Msl.LoadAssemblyAsString("gml_Object_o_console_controller_Draw_64")
            .MatchFromUntil(":[0]", "exit.i")
            .ReplaceBy("")
            .Save();
        
        // Msl.LoadAssemblyAsString("gml_GlobalScript_neoconsole_api")
        //     .MatchFrom("pop.v.b global.consoleEnabled")
        //     .InsertAbove("pushi.e 1")
        //     .Save();

        // Msl.LoadAssemblyAsString("gml_Object_o_dataLoader_Other_10")
        //     .MatchFrom("pop.v.b global.consoleEnabled")
        //     .InsertAbove("pushi.e 1")
        //     .Save();

        Msl.LoadGML("gml_Object_o_console_controller_KeyRelease_113")
            .MatchAll()
            .InsertBelow(@"
                global.consoleEnabled = !global.consoleEnabled
                if (global.consoleEnabled)
                    event_perform(ev_draw, ev_gui)")
            .Save();
    }
}
