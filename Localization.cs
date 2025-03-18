
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