function scr_mod_uim_accept_exchange()
{
    if (variable_global_exists("mod_uim_current_embed_name"))
    {
        var _discount = false
        if (global.mod_uim_current_embed_name == "embedded_mod_uim_exchange_accept_2")
            _discount = true

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

}