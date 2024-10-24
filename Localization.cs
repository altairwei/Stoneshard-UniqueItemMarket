
using ModShardLauncher;
using ModShardLauncher.Mods;

namespace UniqueItemMarket;
public class Localization
{
    public static void DialogLinesPatching()
    {
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
                "mod_uim_cancel",
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

            // Unique Items
            new LocalizationSentence(
                "mod_uim_Jarl_Blade",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Jarl Blade."},
                    {ModLanguage.Chinese, "亚尔剑。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Royal_Sword",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Royal Sword."},
                    {ModLanguage.Chinese, "皇家配剑。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Relict_Blade",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Relict Blade."},
                    {ModLanguage.Chinese, "古剑。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Guard_Broadsword",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Guardsman Broadsword."},
                    {ModLanguage.Chinese, "护卫刀。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Saber",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Saber."},
                    {ModLanguage.Chinese, "铭纹马刀。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Ancient_Scimitar",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ancient Scimitar."},
                    {ModLanguage.Chinese, "古代弯刀。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Gilded_Axe",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Gilded Axe."},
                    {ModLanguage.Chinese, "镀金手斧。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Feudal_Axe",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Lordly Axe."},
                    {ModLanguage.Chinese, "领主手斧。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Flanged_Mace",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Flanged Mac."},
                    {ModLanguage.Chinese, "饰纹凸缘钉头锤。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Warhammer",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Warhammer."},
                    {ModLanguage.Chinese, "鎏金战锤。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Ornate_Greatsword",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Two-Hander."},
                    {ModLanguage.Chinese, "饰纹双手剑。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Espadon",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Espadon."},
                    {ModLanguage.Chinese, "耶斯巴顿。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Faceless_Spear",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Spear of the Faceless."},
                    {ModLanguage.Chinese, "无面矛。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Voulge",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Voulge."},
                    {ModLanguage.Chinese, "鎏金弗日。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Ornate_Longaxe",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Exquisite Longaxe."},
                    {ModLanguage.Chinese, "华纹长斧。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Exquisite_Grandmace",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Exquisite Polemace."},
                    {ModLanguage.Chinese, "鎏金长柄锤。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Relict_Polehammer",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Relict Hammer."},
                    {ModLanguage.Chinese, "古钉头锤。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Longbow",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Carved Longbow."},
                    {ModLanguage.Chinese, "雕纹长弓。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Relic_Bow",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Relict Bow."},
                    {ModLanguage.Chinese, "古弓。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Guard_Crossbow",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Guardsman Crossbow."},
                    {ModLanguage.Chinese, "护卫弩。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Orient_Staff",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Orient Staff."},
                    {ModLanguage.Chinese, "东方长杖。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Relict_Staff",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Relict Staff."},
                    {ModLanguage.Chinese, "古杖。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Guardian_Shield",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Guardsman Shield."},
                    {ModLanguage.Chinese, "护卫大盾。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Sun_Shield",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Shield of the Truth's Eternal Sun."},
                    {ModLanguage.Chinese, "真理永恒之日盾。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Uroboros_Shield",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Brotherhood of Ouroboros' Shield."},
                    {ModLanguage.Chinese, "衔尾蛇兄弟会盾。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Engraved_Boots",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Engraved Greaves."},
                    {ModLanguage.Chinese, "纹金胫甲。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Barbute",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Barbute."},
                    {ModLanguage.Chinese, "华美巴布特盔。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Joust_Bascinet",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Jousting Bascinet."},
                    {ModLanguage.Chinese, "长枪比武头盔。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Joust_Topfhelm",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Jousting Topfhelm."},
                    {ModLanguage.Chinese, "长枪比武桶盔。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Pigfaced_Bascinet",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Pig-Faced Bascinet."},
                    {ModLanguage.Chinese, "猪面盔。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Decorated_Sallet",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ornate Sallet."},
                    {ModLanguage.Chinese, "饰纹轻盔。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Mastercrafted_Sallet",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Mastercrafted Sallet."},
                    {ModLanguage.Chinese, "精锻轻盔。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Royal_Ranger_Gambeson",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Royal Ranger Gambeson."},
                    {ModLanguage.Chinese, "皇苑守卫夹棉软铠。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Ceremonial_Cuirass",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Ceremonial Cuirass."},
                    {ModLanguage.Chinese, "盛装胸甲。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Vagabond_Knight_Armor",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Vagabond Knight's Armor."},
                    {ModLanguage.Chinese, "流浪骑士盔甲。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Druid_Robe",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Hermit Garment."},
                    {ModLanguage.Chinese, "隐士上衣。"}
                }
            ),
            new LocalizationSentence(
                "mod_uim_Hermit_Ring",
                new Dictionary<ModLanguage, string>() {
                    {ModLanguage.English, "Hermit Ring."},
                    {ModLanguage.Chinese, "隐士戒指。"}
                }
            )
        );
    }
}