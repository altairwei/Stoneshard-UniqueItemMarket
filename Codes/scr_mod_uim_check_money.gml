function scr_mod_uim_check_money()
{
    if (scr_mod_uim_has_discount())
        scr_dialogue_set_option_lock("mod_uim_exchange_accept_2", !scr_npc_check_gold(600))
    else
        scr_dialogue_set_option_lock("mod_uim_exchange_accept_1", !scr_npc_check_gold(1000))
}