function scr_mod_uim_finish_exchange()
{
    with (owner)
    {
        var _item_for_exchange = ds_map_find_value(data, "item_for_exchange")
        var _target_for_exchange = ds_map_find_value(data, "target_for_exchange")

        ds_list_add(scr_atr("specialItemsPool"), _target_for_exchange)
        with (scr_guiCreateContainer(global.guiBaseContainerVisible, o_reward_container))
            scr_inventory_add_weapon(_target_for_exchange)

        ds_map_delete(data, "item_for_exchange")
        ds_map_delete(data, "target_for_exchange")
        scr_npc_set_global_info("uniqueItemExchangeCD", 0)
    }

    scr_close_dialog()
}