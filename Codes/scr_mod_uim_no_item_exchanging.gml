function scr_mod_uim_no_item_exchanging()
{
    with (owner)
    {
        var _item_for_exchange = scr_npc_get_global_info("item_for_exchange")
        var _target_for_exchange = scr_npc_get_global_info("target_for_exchange")
        var _uniqueItemExchangeCD = scr_npc_get_global_info("uniqueItemExchangeCD")

        return myfloor_counter == "T1" && (_item_for_exchange == 0 || _target_for_exchange == 0 || _uniqueItemExchangeCD == 0)
    }
}
