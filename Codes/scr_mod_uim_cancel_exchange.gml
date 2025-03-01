function scr_mod_uim_cancel_exchange()
{
    switch (topic)
    {
        case "mod_uim_cancel_1":
            with (owner)
                ds_map_delete(data, "item_for_exchange")
        break;
        case "mod_uim_cancel_2":
            with (owner)
                ds_map_delete(data, "target_for_exchange")
        break;
        case "mod_uim_cancel_no_money":
            with (owner)
            {
                ds_map_delete(data, "item_for_exchange")
                ds_map_delete(data, "target_for_exchange")
            }
        break;
    }
}