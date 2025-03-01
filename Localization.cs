
using ModShardLauncher;
using ModShardLauncher.Mods;

namespace UniqueItemMarket;
public class Localization
{
    public static void DialogLinesPatching()
    {
        List<(string, string, string)> tupleList = new List<(string, string, string)>
        {
            ("Radiant_Sword",           "Radiant Sword",            "光辉纹剑"),
            ("Jarl_Blade",              "Jarl Blade",               "亚尔剑"),
            ("Royal_Blade",             "Royal Blade",              "皇家配剑"),
            ("Theurgist_Blade",         "Theurgist Blade",          "圣宗剑"),
            ("Guardsman_Broadsword",    "Guardsman Broadsword",     "护卫刀"),
            ("Ancient_Scimitar",        "Ancient Scimitar",         "古代弯刀"),
            ("Decorated_Saber",         "Ornate Saber",             "铭纹马刀"),
            ("Exquisite_Tabar",         "Exquisite Tabar",          "精致塔巴斧"),
            ("Gilded_Axe",              "Gilded Axe",               "镀金斧"),
            ("Baron_Axe",               "Baron Axe",                "男爵手斧"),
            ("Voivod_Mace",             "Voivod Mace",              "沃伊沃德钉头锤"),
            ("Decorated_Flanged_Mace",  "Ornate Flanged Mace",      "饰纹凸缘钉头锤"),
            ("Decorated_Warhammer",     "Ornate Warhammer",         "鎏金战锤"),
            ("Ceremonial_Dagger",       "Ceremonial Dagger",        "仪礼匕首"),
            ("Ducal_Dagger",            "Ducal Dagger",             "公爵匕首"),
            ("Ornate_Longsword",        "Ornate Longsword",         "饰纹长剑"),
            ("Blademaster_Greatsword",  "Blademaster Greatsword",   "剑客大剑"),
            ("Exquisite_Twohander",     "Exquisite Two-Hander",     "精致双手剑"),
            ("Espadon",                 "Espadon",                  "耶斯巴顿"),
            ("Faceless_Spear",          "Spear of the Faceless",    "无面矛"),
            ("Decorated_Voulge",        "Ornate Voulge",            "鎏金弗日"),
            ("Ornate_Longaxe",          "Exquisite Longaxe",        "华纹长斧"),
            ("Exquisite_Grandmace",     "Exquisite Polemace",       "鎏金长柄锤"),
            ("Ornate_Polehammer",       "Honorary Polehammer",      "嘉奖长柄锤"),
            ("Gilded_Polehammer",       "Ornate Polehammer",        "精致长柄锤"),
            ("Decorated_Longbow",       "Carved Longbow",           "雕纹长弓"),
            ("Relict_Longbow",          "Relict Longbow",           "遗古长弓"),
            ("Ornate_Crossbow",         "Carved Crossbow",          "雕纹弩"),
            ("Guardsman_Crossbow",      "Guardsman Crossbow",       "护卫弩"),
            ("Farseer_Staff",           "Farseer Staff",            "先见长杖"),
            ("Axonian_Warstaff",        "Axonian Warstaff",         "亚克逊战杖"),
            ("Hermit_Staff",            "Hermit Staff",             "隐士长杖"),
            ("Vampiric_Staff",          "Vampiric Staff",           "吸血长杖"),
            ("Orient_Staff",            "Orient Staff",             "东方长杖"),
            ("Uroboros_Shield",         "Brotherhood of Ouroboros' Shield",     "衔尾蛇兄弟会盾"),
            ("Joust_Shield",            "Jousting Shield",          "长枪比武盾"),
            ("Sun_Shield",              "Shield of the Truth's Eternal Sun",    "真理永恒之日盾"),
            ("Guardian_Shield",         "Guardsman Shield",         "护卫大盾"),
            ("Orient_Tower_Shield",     "Orient Tower Shield",      "东方巨盾"),
            ("Decorated_Barbute",       "Ornate Barbute",           "华美巴布特盔"),
            ("Luxurious_Sallet",        "Luxurious Sallet",         "豪华夏雷尔"),
            ("Ceremonial_Sentinet",     "Ceremonial Sentinet",      "仪礼森提亚盔"),
            ("Vagabond_Knight_Sentinet",    "Vagabond Knight's Sentinet",       "流浪骑士森提亚盔"),
            ("Radiant_Topfhelm",        "Radiant Topfhelm",         "光辉桶盔"),
            ("Hermit_Circlet",          "Hermit Wreath",            "隐士头箍"),
            ("Hermit_Garment",          "Hermit Garment",           "隐士衣服"),
            ("Royal_Ranger_Gambeson",   "Royal Ranger Gambeson",    "皇苑守卫夹棉软铠"),
            ("Ceremonial_Armor",        "Ceremonial Armor",         "盛装盔甲"),
            ("Vagabond_Knight_Armor",   "Vagabond Knight's Armor",  "流浪骑士盔甲"),
            ("Sardar_Boots",            "Sardar Boots",             "萨达尔靴"),
            ("Engraved_Boots",          "Engraved Greaves",         "纹金胫甲"),
            ("Hermit_Ring",             "Hermit Ring",              "隐士戒指"),
            ("Warding_Hand_Amulet",     "Warding Hand Amulet",      "手掌护身符"),
            ("Occult_Cloak",            "Occult Cloak",             "玄秘斗篷")
        };

        LocalizationSentence[] sentences = tupleList
            .Select(t => new LocalizationSentence(
                "mod_uim_" + t.Item1,
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, t.Item2},
                    {ModLanguage.Chinese, t.Item3}
                }))
            .ToArray();

        Msl.InjectTableDialogLocalization(sentences);

        sentences = tupleList
            .Select(t => new LocalizationSentence(
                "mod_uim_target_" + t.Item1,
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, t.Item2},
                    {ModLanguage.Chinese, t.Item3}
                }))
            .ToArray();

        Msl.InjectTableDialogLocalization(sentences);

        Msl.InjectTableDialogLocalization(
            new LocalizationSentence(
                "mod_uim_exchange_pc",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I'd like you to help me broker a deal."},
                    {ModLanguage.Chinese, "我想请你帮我促成一项交易。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "That's fine. What kind of weaponry would you trade for it?"},
                    {ModLanguage.Chinese, "哦？你想要找人交换武器装备？我可以帮忙。你要拿什么去做交易？"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_cancel_1",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Forget it, next time."},
                    {ModLanguage.Chinese, "算了，下次吧。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_cancel_2",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Forget it, next time."},
                    {ModLanguage.Chinese, "算了，下次吧。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_cancel_3",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Forget it, next time."},
                    {ModLanguage.Chinese, "算了，下次吧。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_cancel_no_money",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Forget it, next time. I didn't bring enough money."},
                    {ModLanguage.Chinese, "算了，下次吧。我钱没带够。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_confirm",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Are you sure you want to sell this stuff?"},
                    {ModLanguage.Chinese, "你确定要出售这个东西？"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_confirm_pc",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Yes, I'm sure."},
                    {ModLanguage.Chinese, "是的，我确定。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_change_one",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I changed my mind."},
                    {ModLanguage.Chinese, "我改主意了。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_change_one_2",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "I changed my mind."},
                    {ModLanguage.Chinese, "我改主意了。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_target",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "What item would you like to exchange for?"},
                    {ModLanguage.Chinese, "你想要换取什么物品？"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_target_confirm",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Are you sure you want to exchange this?"},
                    {ModLanguage.Chinese, "你确定要换取这个吗？"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_target_confirm_pc",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Yeah, that's what I want."},
                    {ModLanguage.Chinese, "是的，我就想要这个。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_intro",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Good. I'll take note of your needs. Come back to me in a day. #You know, it's a dangerous business. I'm going to be dealing with bandits, occultists and mercenaries, all of whom are insane. Of course, I'm not talking about you. #So I'm gonna need some time to make this exchange happen, and I'm gonna charge you a hefty fee."},
                    {ModLanguage.Chinese, "很好，你的需求我记下了，一天后再来找我。#你知道，这是一个很危险的生意。我要去与强盗、密教徒和雇佣兵打交道，这些人都是疯子。当然，我不是在说你。#所以我需要一些时间来促成这次交换，而且我要收你一笔不菲的手续费。"}
                }
            ),           
            new LocalizationSentence(
                "mod_uim_exchange_accept_1",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Deal. ~y~[1000 crowns]~/~"},
                    {ModLanguage.Chinese, "成交。~y~[1000冠]~/~"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_accept_2",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Deal. ~y~[600 crowns]~/~"},
                    {ModLanguage.Chinese, "成交。~y~[600冠]~/~"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_done",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "You're here? Someone just happened to be selling that equipment recently, so I rushed to get it for you. Here you go."},
                    {ModLanguage.Chinese, "你来了？最近刚好有人要出手那件装备，我赶紧给你弄来了。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_done_pc",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "It's fantastic!"},
                    {ModLanguage.Chinese, "真是太棒了！"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_exchange_next_time_pc",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Wait a minute. I've got other things to do."},
                    {ModLanguage.Chinese, "先不急，我有其他事找你。"}
                }
            )
        );
    }
}