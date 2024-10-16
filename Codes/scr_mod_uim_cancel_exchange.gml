function scr_mod_uim_cancel_exchange()
{
    for (var i = 0; i < argument_count; i++)
        with (owner)
        {
            ds_map_delete(data, argument[i])
        }
}