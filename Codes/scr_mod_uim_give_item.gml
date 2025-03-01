function scr_mod_uim_give_item()
{
    var _item = string_replace_all(string_replace(answer_fragment, "mod_uim_", ""), "_", " ")
    with (owner)
        ds_map_replace(data, "item_for_exchange", _item)
}