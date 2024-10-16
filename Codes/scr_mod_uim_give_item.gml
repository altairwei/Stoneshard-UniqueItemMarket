function scr_mod_uim_give_item()
{
    var _item = argument[0]
    with (owner)
        ds_map_replace(data, "item_for_exchange", _item)
}