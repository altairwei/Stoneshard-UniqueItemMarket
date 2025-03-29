function scr_mod_uim_finish_exchange()
{
    with (owner)
    {
        var _item_for_exchange = scr_npc_get_global_info("item_for_exchange")
        var _target_for_exchange = scr_npc_get_global_info("target_for_exchange")

        with (scr_guiCreateContainer(global.guiBaseContainerVisible, o_reward_container))
            scr_inventory_add_weapon(_target_for_exchange)

        scr_npc_delete_global_info("item_for_exchange")
        scr_npc_delete_global_info("target_for_exchange")
        scr_npc_delete_global_info("uniqueItemExchangeCD")
    }
}