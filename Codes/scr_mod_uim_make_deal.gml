function scr_mod_uim_make_deal()
{
    with (owner)
    {
        var _item_for_exchange = scr_npc_get_global_info("item_for_exchange")
        scr_delete_item(_item_for_exchange)

        var _target_for_exchange = scr_npc_get_global_info("target_for_exchange")
        ds_list_add(scr_atr("specialItemsPool"), _target_for_exchange)

        var _price = 1000
        if scr_dialogue_complete("ringVerrenFence02")
            _price = 600
        scr_gold_write_off(_price)
        scr_characterGoldSpend("spentDialogues", _price)

        var _timestamp = scr_timeGetTimestamp()
        scr_npc_set_global_info("uniqueItemExchangeCD", _timestamp)
    }
}