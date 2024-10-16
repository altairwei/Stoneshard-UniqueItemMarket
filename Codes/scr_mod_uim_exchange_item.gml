function scr_mod_uim_exchange_item()
{
    var _item = argument[0]
    with (owner)
        ds_map_replace(data, "target_for_exchange", _item)
}