var _unique_items = [
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
]

var _Fragments = variable_struct_get(global.DialogueData_val.npc_fence, "Fragments")
var _Scripts = variable_struct_get(global.DialogueData_val.npc_fence, "Scripts")
var _Specs = variable_struct_get(global.DialogueData_val.npc_fence, "Specs")

array_insert(_Fragments.hub, array_length(_Fragments.hub) - 1, "mod_uim_exchange_pc")
_Fragments.mod_uim_exchange_pc = "mod_uim_exchange"
_Scripts.embedded_mod_uim_exchange_pc = asset_get_index("scr_mod_uim_no_item_exchanging")

_Fragments.mod_uim_exchange = []

for (var i = 0; i < array_length(_unique_items); i++)
{
    var _item = _unique_items[i]
    var _key = "mod_uim_" + string_replace_all(_item, " ", "_")
    array_push(_Fragments.mod_uim_exchange, _key)
    variable_struct_set(_Fragments, _key, "instruction_INS_giveItem")
    variable_struct_set(_Scripts, "embedded_" + _key, asset_get_index("scr_mod_uim_item_exists"))
}

array_push(_Fragments.mod_uim_exchange, "mod_uim_cancel_1")
_Fragments.mod_uim_cancel_1 = "instruction_INS_cancel"
_Fragments.instruction_INS_cancel = "greeting"
_Scripts.instruction_INS_cancel = asset_get_index("scr_mod_uim_cancel_exchange")
_Specs.instruction_INS_cancel = {}
variable_struct_set(_Specs.instruction_INS_cancel, "action", true)

_Fragments.instruction_INS_giveItem = "mod_uim_exchange_confirm"
_Scripts.instruction_INS_giveItem = asset_get_index("scr_mod_uim_give_item")
_Specs.instruction_INS_giveItem = {}
variable_struct_set(_Specs.instruction_INS_giveItem, "action", true)

_Fragments.mod_uim_exchange_confirm = ["mod_uim_exchange_confirm_pc", "mod_uim_exchange_change_one"]
_Fragments.mod_uim_exchange_change_one = "mod_uim_exchange"
_Fragments.mod_uim_exchange_confirm_pc = "mod_uim_exchange_target"

_Fragments.mod_uim_exchange_target = []
for (var i = 0; i < array_length(_unique_items); i++)
{
    var _item = _unique_items[i]
    var _key = "mod_uim_target_" + string_replace_all(_item, " ", "_")
    array_push(_Fragments.mod_uim_exchange_target, _key)
    variable_struct_set(_Fragments, _key, "instruction_INS_exchangeItem")
    variable_struct_set(_Scripts, "embedded_" + _key, asset_get_index("scr_mod_uim_check_available"))
}

array_push(_Fragments.mod_uim_exchange_target, "mod_uim_cancel_2")
_Fragments.mod_uim_cancel_2 = "instruction_INS_cancel"

_Fragments.instruction_INS_exchangeItem = "mod_uim_exchange_target_confirm"
_Scripts.instruction_INS_exchangeItem = asset_get_index("scr_mod_uim_exchange_item")
_Specs.instruction_INS_exchangeItem = {}
variable_struct_set(_Specs.instruction_INS_exchangeItem, "action", true)

_Fragments.mod_uim_exchange_target_confirm = ["mod_uim_exchange_target_confirm_pc", "mod_uim_exchange_change_one_2"]
_Fragments.mod_uim_exchange_target_confirm_pc = "mod_uim_exchange_intro"
_Fragments.mod_uim_exchange_change_one_2 = "mod_uim_exchange_target"

_Fragments.mod_uim_exchange_intro = ["mod_uim_exchange_accept_1", "mod_uim_exchange_accept_2", "mod_uim_cancel_no_money"]
_Scripts.embedded_mod_uim_exchange_accept_1 = asset_get_index("scr_mod_uim_accept_exchange")
_Scripts.embedded_mod_uim_exchange_accept_2 = asset_get_index("scr_mod_uim_accept_exchange")
_Fragments.mod_uim_exchange_accept_1 = "instruction_INS_makedeal"
_Fragments.mod_uim_exchange_accept_2 = "instruction_INS_makedeal"
_Fragments.instruction_INS_makedeal = "@dialogue_end"
_Scripts.instruction_INS_makedeal = asset_get_index("scr_mod_uim_make_deal")
_Specs.instruction_INS_makedeal = {}
variable_struct_set(_Specs.instruction_INS_makedeal, "action", true)
_Fragments.mod_uim_cancel_no_money = "instruction_INS_cancel"

_Fragments.HUB_Cnd_3620F0FE_negative = "condition_CND_checkExchangeDone"
_Scripts.condition_CND_checkExchangeDone = asset_get_index("scr_mod_uim_is_exchange_done")
_Fragments.condition_CND_checkExchangeDone = ["MOD_Cnd_checkExchangeDone_positive", "MOD_Cnd_checkExchangeDone_negative"]
_Fragments.MOD_Cnd_checkExchangeDone_negative = "greeting"
_Specs.MOD_Cnd_checkExchangeDone_positive = {}
_Specs.MOD_Cnd_checkExchangeDone_negative = {}
variable_struct_set(_Specs.MOD_Cnd_checkExchangeDone_positive, "hub", true)
variable_struct_set(_Specs.MOD_Cnd_checkExchangeDone_negative, "hub", true)

_Fragments.MOD_Cnd_checkExchangeDone_positive = "mod_uim_exchange_done"
_Fragments.mod_uim_exchange_done = ["mod_uim_exchange_done_pc", "mod_uim_exchange_next_time_pc"]
_Fragments.mod_uim_exchange_next_time_pc = "greeting"
_Fragments.mod_uim_exchange_done_pc = "instruction_INS_finishExchange"
_Fragments.instruction_INS_finishExchange = "@dialogue_end"
_Scripts.instruction_INS_finishExchange = asset_get_index("scr_mod_uim_finish_exchange")
_Specs.instruction_INS_finishExchange = {}
variable_struct_set(_Specs.instruction_INS_finishExchange, "action", true)
