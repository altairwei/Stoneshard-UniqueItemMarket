function scr_mod_uim_no_item_exchanging()
{
    with (owner)
        return myfloor_counter == "T1" && (!ds_map_exists(data, "item_for_exchange") || !ds_map_exists(data, "target_for_exchange") || scr_npc_get_global_info("uniqueItemExchangeCD") == 0)
}
