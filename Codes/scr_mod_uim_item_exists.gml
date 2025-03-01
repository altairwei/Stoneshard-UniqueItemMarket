function scr_mod_uim_item_exists()
{
    if (variable_global_exists("mod_uim_current_embed_name"))
    {
        var _item_name = string_replace_all(
            string_replace(global.mod_uim_current_embed_name, "embedded_mod_uim_", ""),
            "_", " ")
        return scr_instance_exists_item(_item_name)
    }
}
