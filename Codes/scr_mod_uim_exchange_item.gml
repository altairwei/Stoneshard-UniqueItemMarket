function scr_mod_uim_exchange_item()
{
    var _item = string_replace_all(string_replace(answer_fragment, "mod_uim_target_", ""), "_", " ")
    with (owner)
        ds_map_replace(data, "target_for_exchange", _item)
}