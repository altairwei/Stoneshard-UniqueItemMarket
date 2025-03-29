function scr_mod_uim_give_item()
{
    var _item = string_replace_all(string_replace(answer_fragment, "mod_uim_", ""), "_", " ")
    with (owner)
        scr_npc_set_global_info("item_for_exchange", _item)
}