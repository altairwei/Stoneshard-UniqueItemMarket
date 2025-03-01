function scr_mod_uim_is_exchange_done()
{
    with (owner)
    {
        var _timestamp = scr_npc_get_global_info("uniqueItemExchangeCD")
        var _hoursPassed = scr_timeGetPassed(_timestamp, "hours")
        if (ds_map_exists(data, "item_for_exchange") && ds_map_exists(data, "target_for_exchange") && _timestamp != 0 && _hoursPassed >= 12)
            return true
        else
            return false
    }
}
