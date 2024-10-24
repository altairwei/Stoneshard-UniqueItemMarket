function scr_mod_uim_accept_exchange()
{
    var _discount = argument[0]
    if (_discount)
    {
        if scr_dialogue_complete("ringVerrenFence02") && scr_npc_check_gold(600)
            return true
        else
            return false
    }
    else
    {
        if scr_dialogue_uncomplete("ringVerrenFence02") && scr_npc_check_gold(1000)
            return true
        else
            return false
    }
}