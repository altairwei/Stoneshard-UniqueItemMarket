function scr_mod_uim_is_exchange_done()
{
    with (owner)
    {
        var _timestamp = scr_npc_get_global_info("uniqueItemExchangeCD")
        var _hoursPassed = scr_timeGetPassed(_timestamp, 2)
        var _item_for_exchange = scr_npc_get_global_info("item_for_exchange")
        var _target_for_exchange = scr_npc_get_global_info("target_for_exchange")

        if (_item_for_exchange != 0 && _target_for_exchange != 0 && _timestamp != 0 && _hoursPassed >= 12)
            return true
        else
            return false
    }
}
