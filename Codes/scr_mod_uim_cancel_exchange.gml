function scr_mod_uim_cancel_exchange()
{
    switch (topic)
    {
        case "mod_uim_cancel_1":
            with (owner)
                scr_npc_delete_global_info("item_for_exchange")
        break;
        case "mod_uim_cancel_2":
            with (owner)
                scr_npc_delete_global_info("target_for_exchange")
        break;
        case "mod_uim_cancel_no_money":
            with (owner)
            {
                scr_npc_delete_global_info("item_for_exchange")
                scr_npc_delete_global_info("target_for_exchange")
            }
        break;
    }
}