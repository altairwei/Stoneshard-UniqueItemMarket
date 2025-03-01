function scr_mod_uim_check_available()
{
    if (variable_global_exists("mod_uim_current_embed_name"))
    {
        var _item_name = string_replace_all(
            string_replace(global.mod_uim_current_embed_name, "embedded_mod_uim_target_", ""),
            "_", " ")
        return ds_list_find_index(scr_atr("specialItemsPool"), _item_name) == -1
    }
}