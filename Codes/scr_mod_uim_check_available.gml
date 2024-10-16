function scr_mod_uim_check_available()
{
    return ds_list_find_index(scr_atr("specialItemsPool"), argument[0]) == -1
}