using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PinYin
{
    internal class ChineseLib
    {
        internal List<Chinese> ChineseWordList { get; set; }
        internal List<Chinese> ChineseTermList { get; set; }

        internal ChineseLib()
        {
            ChineseWordList = new List<Chinese>();
            ChineseTermList = new List<Chinese>();

            #region 一笔字

            ChineseWordList.Add(new Chinese("一", "yi", "Y"));
            ChineseWordList.Add(new Chinese("乙", "yi", "Y"));

            #endregion

            #region 二笔字

            ChineseWordList.Add(new Chinese("了", "liao", "L"));
            ChineseWordList.Add(new Chinese("人", "ren", "R"));
            ChineseWordList.Add(new Chinese("又", "you", "Y"));
            ChineseWordList.Add(new Chinese("儿", "er", "E"));
            ChineseWordList.Add(new Chinese("十", "shi", "S"));
            ChineseWordList.Add(new Chinese("二", "er", "E"));
            ChineseWordList.Add(new Chinese("力", "li", "L"));
            ChineseWordList.Add(new Chinese("几", "ji", "J"));
            ChineseWordList.Add(new Chinese("入", "ru", "R"));
            ChineseWordList.Add(new Chinese("八", "ba", "B"));
            ChineseWordList.Add(new Chinese("九", "jiu", "J"));
            ChineseWordList.Add(new Chinese("七", "qi", "Q"));
            ChineseWordList.Add(new Chinese("刀", "dao", "D"));
            ChineseWordList.Add(new Chinese("乃", "nai", "N"));
            ChineseWordList.Add(new Chinese("厂", "chang", "C"));
            ChineseWordList.Add(new Chinese("丁", "ding", "D"));
            ChineseWordList.Add(new Chinese("卜", "bu", "B"));

            #endregion

            #region 三笔字

            ChineseWordList.Add(new Chinese("个", "ge", "G"));
            ChineseWordList.Add(new Chinese("上", "shang", "S"));
            ChineseWordList.Add(new Chinese("大", "da", "D"));
            ChineseWordList.Add(new Chinese("子", "zi", "Z"));
            ChineseWordList.Add(new Chinese("也", "ye", "Y"));
            ChineseWordList.Add(new Chinese("之", "zhi", "Z"));
            ChineseWordList.Add(new Chinese("下", "xia", "X"));
            ChineseWordList.Add(new Chinese("么", "mo", "M"));
            ChineseWordList.Add(new Chinese("小", "xiao", "X"));
            ChineseWordList.Add(new Chinese("于", "yu", "Y"));
            ChineseWordList.Add(new Chinese("已", "yi", "Y"));
            ChineseWordList.Add(new Chinese("与", "yu", "Y"));
            ChineseWordList.Add(new Chinese("三", "san", "S"));
            ChineseWordList.Add(new Chinese("女", "nu", "N"));
            ChineseWordList.Add(new Chinese("己", "ji", "J"));
            ChineseWordList.Add(new Chinese("门", "men", "M"));
            ChineseWordList.Add(new Chinese("工", "gong", "G"));
            ChineseWordList.Add(new Chinese("口", "kou", "K"));
            ChineseWordList.Add(new Chinese("才", "cai", "C"));
            ChineseWordList.Add(new Chinese("山", "shan", "S"));
            ChineseWordList.Add(new Chinese("马", "ma", "M"));
            ChineseWordList.Add(new Chinese("及", "ji", "J"));
            ChineseWordList.Add(new Chinese("义", "yi", "Y"));
            ChineseWordList.Add(new Chinese("万", "wan", "W"));
            ChineseWordList.Add(new Chinese("干", "gan", "G"));
            ChineseWordList.Add(new Chinese("士", "shi", "S"));
            ChineseWordList.Add(new Chinese("飞", "fei", "F"));
            ChineseWordList.Add(new Chinese("千", "qian", "Q"));
            ChineseWordList.Add(new Chinese("久", "jiu", "J"));
            ChineseWordList.Add(new Chinese("广", "guang", "G"));
            ChineseWordList.Add(new Chinese("习", "xi", "X"));
            ChineseWordList.Add(new Chinese("土", "tu", "T"));
            ChineseWordList.Add(new Chinese("乡", "xiang", "X"));
            ChineseWordList.Add(new Chinese("丈", "zhang", "Z"));
            ChineseWordList.Add(new Chinese("凡", "fan", "F"));
            ChineseWordList.Add(new Chinese("卫", "wei", "W"));
            ChineseWordList.Add(new Chinese("亡", "wang", "W"));
            ChineseWordList.Add(new Chinese("亿", "yi", "Y"));
            ChineseWordList.Add(new Chinese("川", "chuan", "C"));
            ChineseWordList.Add(new Chinese("尸", "shi", "S"));
            ChineseWordList.Add(new Chinese("亏", "kui", "K"));
            ChineseWordList.Add(new Chinese("寸", "cun", "C"));
            ChineseWordList.Add(new Chinese("夕", "xi", "X"));
            ChineseWordList.Add(new Chinese("巾", "jin", "J"));
            ChineseWordList.Add(new Chinese("叉", "cha", "C"));
            ChineseWordList.Add(new Chinese("弓", "gong", "G"));
            ChineseWordList.Add(new Chinese("乞", "qi", "Q"));
            ChineseWordList.Add(new Chinese("刃", "ren", "R"));
            ChineseWordList.Add(new Chinese("丸", "wan", "W"));
            ChineseWordList.Add(new Chinese("勺", "shao", "S"));

            #endregion

            #region 四笔字

            ChineseWordList.Add(new Chinese("不", "bu", "B"));
            ChineseWordList.Add(new Chinese("中", "zhong", "Z"));
            ChineseWordList.Add(new Chinese("为", "wei", "W"));
            ChineseWordList.Add(new Chinese("以", "yi", "Y"));
            ChineseWordList.Add(new Chinese("心", "xin", "X"));
            ChineseWordList.Add(new Chinese("天", "tian", "T"));
            ChineseWordList.Add(new Chinese("见", "jian", "J"));
            ChineseWordList.Add(new Chinese("方", "fang", "F"));
            ChineseWordList.Add(new Chinese("无", "wu", "W"));
            ChineseWordList.Add(new Chinese("手", "shou", "S"));
            ChineseWordList.Add(new Chinese("开", "kai", "K"));
            ChineseWordList.Add(new Chinese("分", "fen", "F"));
            ChineseWordList.Add(new Chinese("日", "ri", "R"));
            ChineseWordList.Add(new Chinese("文", "wen", "W"));
            ChineseWordList.Add(new Chinese("从", "cong", "C"));
            ChineseWordList.Add(new Chinese("什", "shi", "S"));
            ChineseWordList.Add(new Chinese("长", "chang", "C"));
            ChineseWordList.Add(new Chinese("公", "gong", "G"));
            ChineseWordList.Add(new Chinese("气", "qi", "Q"));
            ChineseWordList.Add(new Chinese("太", "tai", "T"));
            ChineseWordList.Add(new Chinese("月", "yue", "Y"));
            ChineseWordList.Add(new Chinese("少", "shao", "S"));
            ChineseWordList.Add(new Chinese("今", "jin", "J"));
            ChineseWordList.Add(new Chinese("内", "nei", "N"));
            ChineseWordList.Add(new Chinese("计", "ji", "J"));
            ChineseWordList.Add(new Chinese("水", "shui", "S"));
            ChineseWordList.Add(new Chinese("夫", "fu", "F"));
            ChineseWordList.Add(new Chinese("王", "wang", "W"));
            ChineseWordList.Add(new Chinese("化", "hua", "H"));
            ChineseWordList.Add(new Chinese("书", "shu", "S"));
            ChineseWordList.Add(new Chinese("比", "bi", "B"));
            ChineseWordList.Add(new Chinese("风", "feng", "F"));
            ChineseWordList.Add(new Chinese("五", "wu", "W"));
            ChineseWordList.Add(new Chinese("云", "yun", "Y"));
            ChineseWordList.Add(new Chinese("认", "ren", "R"));
            ChineseWordList.Add(new Chinese("元", "yuan", "Y"));
            ChineseWordList.Add(new Chinese("车", "che", "C"));
            ChineseWordList.Add(new Chinese("反", "fan", "F"));
            ChineseWordList.Add(new Chinese("双", "shuang", "S"));
            ChineseWordList.Add(new Chinese("父", "fu", "F"));
            ChineseWordList.Add(new Chinese("办", "ban", "B"));
            ChineseWordList.Add(new Chinese("区", "qu", "Q"));
            ChineseWordList.Add(new Chinese("切", "qie", "Q"));
            ChineseWordList.Add(new Chinese("火", "huo", "H"));
            ChineseWordList.Add(new Chinese("友", "you", "Y"));
            ChineseWordList.Add(new Chinese("引", "yin", "Y"));
            ChineseWordList.Add(new Chinese("六", "liu", "L"));
            ChineseWordList.Add(new Chinese("片", "pian", "P"));
            ChineseWordList.Add(new Chinese("户", "hu", "H"));
            ChineseWordList.Add(new Chinese("队", "dui", "D"));
            ChineseWordList.Add(new Chinese("支", "zhi", "Z"));
            ChineseWordList.Add(new Chinese("巴", "ba", "B"));
            ChineseWordList.Add(new Chinese("专", "zhuan", "Z"));
            ChineseWordList.Add(new Chinese("仍", "reng", "R"));
            ChineseWordList.Add(new Chinese("木", "mu", "M"));
            ChineseWordList.Add(new Chinese("止", "zhi", "Z"));
            ChineseWordList.Add(new Chinese("历", "li", "L"));
            ChineseWordList.Add(new Chinese("仅", "jin", "J"));
            ChineseWordList.Add(new Chinese("艺", "yi", "Y"));
            ChineseWordList.Add(new Chinese("氏", "shi", "S"));
            ChineseWordList.Add(new Chinese("斗", "dou", "D"));
            ChineseWordList.Add(new Chinese("毛", "mao", "M"));
            ChineseWordList.Add(new Chinese("互", "hu", "H"));
            ChineseWordList.Add(new Chinese("凤", "feng", "F"));
            ChineseWordList.Add(new Chinese("介", "jie", "J"));
            ChineseWordList.Add(new Chinese("午", "wu", "W"));
            ChineseWordList.Add(new Chinese("厅", "ting", "T"));
            ChineseWordList.Add(new Chinese("牛", "niu", "N"));
            ChineseWordList.Add(new Chinese("孔", "kong", "K"));
            ChineseWordList.Add(new Chinese("牙", "ya", "Y"));
            ChineseWordList.Add(new Chinese("升", "sheng", "S"));
            ChineseWordList.Add(new Chinese("贝", "bei", "B"));
            ChineseWordList.Add(new Chinese("仁", "ren", "R"));
            ChineseWordList.Add(new Chinese("丹", "dan", "D"));
            ChineseWordList.Add(new Chinese("尤", "you", "Y"));
            ChineseWordList.Add(new Chinese("巨", "ju", "J"));
            ChineseWordList.Add(new Chinese("仇", "chou", "C"));
            ChineseWordList.Add(new Chinese("丰", "feng", "F"));
            ChineseWordList.Add(new Chinese("匹", "pi", "P"));
            ChineseWordList.Add(new Chinese("尺", "chi", "C"));
            ChineseWordList.Add(new Chinese("乌", "wu", "W"));
            ChineseWordList.Add(new Chinese("瓦", "wa", "W"));
            ChineseWordList.Add(new Chinese("凶", "xiong", "X"));
            ChineseWordList.Add(new Chinese("劝", "quan", "Q"));
            ChineseWordList.Add(new Chinese("仆", "pu", "P"));
            ChineseWordList.Add(new Chinese("予", "yu", "Y"));
            ChineseWordList.Add(new Chinese("忆", "yi", "Y"));
            ChineseWordList.Add(new Chinese("扎", "zha", "Z"));
            ChineseWordList.Add(new Chinese("允", "yun", "Y"));
            ChineseWordList.Add(new Chinese("井", "jing", "J"));
            ChineseWordList.Add(new Chinese("幻", "huan", "H"));
            ChineseWordList.Add(new Chinese("勾", "gou", "G"));
            ChineseWordList.Add(new Chinese("订", "ding", "D"));
            ChineseWordList.Add(new Chinese("丑", "chou", "C"));
            ChineseWordList.Add(new Chinese("乏", "fa", "F"));
            ChineseWordList.Add(new Chinese("欠", "qian", "Q"));
            ChineseWordList.Add(new Chinese("斤", "jin", "J"));
            ChineseWordList.Add(new Chinese("币", "bi", "B"));
            ChineseWordList.Add(new Chinese("仓", "cang", "C"));
            ChineseWordList.Add(new Chinese("勿", "wu", "W"));
            ChineseWordList.Add(new Chinese("爪", "zhua", "Z"));
            ChineseWordList.Add(new Chinese("犬", "quan", "Q"));
            ChineseWordList.Add(new Chinese("冈", "gang", "G"));
            ChineseWordList.Add(new Chinese("匀", "yun", "Y"));
            ChineseWordList.Add(new Chinese("屯", "tun", "T"));

            #endregion

            #region 五笔字

            ChineseWordList.Add(new Chinese("他", "ta", "T"));
            ChineseWordList.Add(new Chinese("们", "men", "M"));
            ChineseWordList.Add(new Chinese("出", "chu", "C"));
            ChineseWordList.Add(new Chinese("可", "ke", "K"));
            ChineseWordList.Add(new Chinese("去", "qu", "Q"));
            ChineseWordList.Add(new Chinese("对", "dui", "D"));
            ChineseWordList.Add(new Chinese("生", "sheng", "S"));
            ChineseWordList.Add(new Chinese("用", "yong", "Y"));
            ChineseWordList.Add(new Chinese("只", "zhi", "Z"));
            ChineseWordList.Add(new Chinese("发", "fa", "F"));
            ChineseWordList.Add(new Chinese("头", "tou", "T"));
            ChineseWordList.Add(new Chinese("本", "ben", "B"));
            ChineseWordList.Add(new Chinese("主", "zhu", "Z"));
            ChineseWordList.Add(new Chinese("正", "zheng", "Z"));
            ChineseWordList.Add(new Chinese("外", "wai", "W"));
            ChineseWordList.Add(new Chinese("打", "da", "D"));
            ChineseWordList.Add(new Chinese("处", "chu", "C"));
            ChineseWordList.Add(new Chinese("民", "min", "M"));
            ChineseWordList.Add(new Chinese("白", "bai", "B"));
            ChineseWordList.Add(new Chinese("由", "you", "Y"));
            ChineseWordList.Add(new Chinese("业", "ye", "Y"));
            ChineseWordList.Add(new Chinese("四", "si", "S"));
            ChineseWordList.Add(new Chinese("加", "jia", "J"));
            ChineseWordList.Add(new Chinese("平", "ping", "P"));
            ChineseWordList.Add(new Chinese("立", "li", "L"));
            ChineseWordList.Add(new Chinese("边", "bian", "B"));
            ChineseWordList.Add(new Chinese("叫", "jiao", "J"));
            ChineseWordList.Add(new Chinese("目", "mu", "M"));
            ChineseWordList.Add(new Chinese("它", "ta", "T"));
            ChineseWordList.Add(new Chinese("东", "dong", "D"));
            ChineseWordList.Add(new Chinese("世", "shi", "S"));
            ChineseWordList.Add(new Chinese("必", "bi", "B"));
            ChineseWordList.Add(new Chinese("让", "rang", "R"));
            ChineseWordList.Add(new Chinese("记", "ji", "J"));
            ChineseWordList.Add(new Chinese("务", "wu", "W"));
            ChineseWordList.Add(new Chinese("且", "qie", "Q"));
            ChineseWordList.Add(new Chinese("电", "dian", "D"));
            ChineseWordList.Add(new Chinese("市", "shi", "S"));
            ChineseWordList.Add(new Chinese("未", "wei", "W"));
            ChineseWordList.Add(new Chinese("北", "bei", "B"));
            ChineseWordList.Add(new Chinese("令", "ling", "L"));
            ChineseWordList.Add(new Chinese("功", "gong", "G"));
            ChineseWordList.Add(new Chinese("术", "shu", "S"));
            ChineseWordList.Add(new Chinese("示", "shi", "S"));
            ChineseWordList.Add(new Chinese("半", "ban", "B"));
            ChineseWordList.Add(new Chinese("写", "xie", "X"));
            ChineseWordList.Add(new Chinese("乎", "hu", "H"));
            ChineseWordList.Add(new Chinese("失", "shi", "S"));
            ChineseWordList.Add(new Chinese("母", "mu", "M"));
            ChineseWordList.Add(new Chinese("玉", "yu", "Y"));
            ChineseWordList.Add(new Chinese("石", "shi", "S"));
            ChineseWordList.Add(new Chinese("布", "bu", "B"));
            ChineseWordList.Add(new Chinese("句", "ju", "J"));
            ChineseWordList.Add(new Chinese("议", "yi", "Y"));
            ChineseWordList.Add(new Chinese("代", "dai", "D"));
            ChineseWordList.Add(new Chinese("司", "si", "S"));
            ChineseWordList.Add(new Chinese("台", "tai", "T"));
            ChineseWordList.Add(new Chinese("龙", "long", "L"));
            ChineseWordList.Add(new Chinese("乐", "le", "L"));
            ChineseWordList.Add(new Chinese("包", "bao", "B"));
            ChineseWordList.Add(new Chinese("节", "jie", "J"));
            ChineseWordList.Add(new Chinese("兄", "xiong", "X"));
            ChineseWordList.Add(new Chinese("古", "gu", "G"));
            ChineseWordList.Add(new Chinese("汉", "han", "H"));
            ChineseWordList.Add(new Chinese("号", "hao", "H"));
            ChineseWordList.Add(new Chinese("礼", "li", "L"));
            ChineseWordList.Add(new Chinese("另", "ling", "L"));
            ChineseWordList.Add(new Chinese("史", "shi", "S"));
            ChineseWordList.Add(new Chinese("左", "zuo", "Z"));
            ChineseWordList.Add(new Chinese("兰", "lan", "L"));
            ChineseWordList.Add(new Chinese("归", "gui", "G"));
            ChineseWordList.Add(new Chinese("右", "you", "Y"));
            ChineseWordList.Add(new Chinese("击", "ji", "J"));
            ChineseWordList.Add(new Chinese("皮", "pi", "P"));
            ChineseWordList.Add(new Chinese("讨", "tao", "T"));
            ChineseWordList.Add(new Chinese("永", "yong", "Y"));
            ChineseWordList.Add(new Chinese("尼", "ni", "N"));
            ChineseWordList.Add(new Chinese("仙", "xian", "X"));
            ChineseWordList.Add(new Chinese("丝", "si", "S"));
            ChineseWordList.Add(new Chinese("旧", "jiu", "J"));
            ChineseWordList.Add(new Chinese("印", "yin", "Y"));
            ChineseWordList.Add(new Chinese("圣", "sheng", "S"));
            ChineseWordList.Add(new Chinese("叹", "tan", "T"));
            ChineseWordList.Add(new Chinese("闪", "shan", "S"));
            ChineseWordList.Add(new Chinese("叶", "ye", "Y"));
            ChineseWordList.Add(new Chinese("田", "tian", "T"));
            ChineseWordList.Add(new Chinese("卡", "ka", "K"));
            ChineseWordList.Add(new Chinese("奶", "nai", "N"));
            ChineseWordList.Add(new Chinese("付", "fu", "F"));
            ChineseWordList.Add(new Chinese("宁", "ning", "N"));
            ChineseWordList.Add(new Chinese("刊", "kan", "K"));
            ChineseWordList.Add(new Chinese("占", "zhan", "Z"));
            ChineseWordList.Add(new Chinese("犯", "fan", "F"));
            ChineseWordList.Add(new Chinese("央", "yang", "T"));
            ChineseWordList.Add(new Chinese("巧", "qiao", "Q"));
            ChineseWordList.Add(new Chinese("厉", "li", "L"));
            ChineseWordList.Add(new Chinese("讯", "xun", "X"));
            ChineseWordList.Add(new Chinese("训", "xun", "X"));
            ChineseWordList.Add(new Chinese("扑", "pu", "P"));
            ChineseWordList.Add(new Chinese("灭", "mie", "M"));
            ChineseWordList.Add(new Chinese("鸟", "niao", "N"));
            ChineseWordList.Add(new Chinese("召", "zhao", "Z"));
            ChineseWordList.Add(new Chinese("末", "mo", "M"));
            ChineseWordList.Add(new Chinese("仪", "yi", "Y"));
            ChineseWordList.Add(new Chinese("甲", "jia", "J"));
            ChineseWordList.Add(new Chinese("冬", "dong", "D"));
            ChineseWordList.Add(new Chinese("申", "shen", "S"));
            ChineseWordList.Add(new Chinese("奴", "nu", "N"));
            ChineseWordList.Add(new Chinese("匆", "cong", "C"));
            ChineseWordList.Add(new Chinese("甘", "gan", "G"));
            ChineseWordList.Add(new Chinese("旦", "dan", "D"));
            ChineseWordList.Add(new Chinese("仔", "zai", "Z"));
            ChineseWordList.Add(new Chinese("汇", "hui", "H"));
            ChineseWordList.Add(new Chinese("穴", "xue", "X"));
            ChineseWordList.Add(new Chinese("幼", "you", "Y"));
            ChineseWordList.Add(new Chinese("仗", "zhang", "Z"));
            ChineseWordList.Add(new Chinese("丛", "cong", "C"));
            ChineseWordList.Add(new Chinese("瓜", "gua", "G"));
            ChineseWordList.Add(new Chinese("矛", "mao", "M"));
            ChineseWordList.Add(new Chinese("帅", "shuai", "S"));
            ChineseWordList.Add(new Chinese("丘", "qiu", "Q"));
            ChineseWordList.Add(new Chinese("册", "ce", "C"));
            ChineseWordList.Add(new Chinese("纠", "jiu", "J"));
            ChineseWordList.Add(new Chinese("扔", "reng", "R"));
            ChineseWordList.Add(new Chinese("斥", "chi", "C"));
            ChineseWordList.Add(new Chinese("辽", "liao", "L"));
            ChineseWordList.Add(new Chinese("饥", "ji", "J"));
            ChineseWordList.Add(new Chinese("甩", "shuai", "S"));
            ChineseWordList.Add(new Chinese("叮", "ding", "D"));
            ChineseWordList.Add(new Chinese("孕", "yun", "Y"));
            ChineseWordList.Add(new Chinese("汁", "zhi", "Z"));
            ChineseWordList.Add(new Chinese("叨", "dao", "D"));
            ChineseWordList.Add(new Chinese("丙", "bing", "B"));
            ChineseWordList.Add(new Chinese("扒", "ba", "B"));
            ChineseWordList.Add(new Chinese("禾", "he", "H"));
            ChineseWordList.Add(new Chinese("轧", "ya", "Y"));
            ChineseWordList.Add(new Chinese("叼", "diao", "D"));

            #endregion

            #region 六笔字

            ChineseWordList.Add(new Chinese("在", "zai", "Z"));
            ChineseWordList.Add(new Chinese("有", "you", "Y"));
            ChineseWordList.Add(new Chinese("她", "ta", "T"));
            ChineseWordList.Add(new Chinese("地", "di", "D"));
            ChineseWordList.Add(new Chinese("地", "di", "D"));
            ChineseWordList.Add(new Chinese("那", "na", "N"));
            ChineseWordList.Add(new Chinese("会", "hui", "H"));
            ChineseWordList.Add(new Chinese("过", "guo", "G"));
            ChineseWordList.Add(new Chinese("自", "zi", "Z"));
            ChineseWordList.Add(new Chinese("好", "hao", "H"));
            ChineseWordList.Add(new Chinese("而", "er", "E"));
            ChineseWordList.Add(new Chinese("后", "hou", "H"));
            ChineseWordList.Add(new Chinese("多", "duo", "D"));
            ChineseWordList.Add(new Chinese("如", "ru", "R"));
            ChineseWordList.Add(new Chinese("行", "xing", "X"));
            ChineseWordList.Add(new Chinese("成", "cheng", "C"));
            ChineseWordList.Add(new Chinese("年", "nian", "N"));
            ChineseWordList.Add(new Chinese("此", "ci", "C"));
            ChineseWordList.Add(new Chinese("当", "dang", "D"));
            ChineseWordList.Add(new Chinese("同", "tong", "T"));
            ChineseWordList.Add(new Chinese("老", "lao", "L"));
            ChineseWordList.Add(new Chinese("回", "hui", "H"));
            ChineseWordList.Add(new Chinese("动", "dong", "D"));
            ChineseWordList.Add(new Chinese("问", "wen", "W"));
            ChineseWordList.Add(new Chinese("全", "quan", "Q"));
            ChineseWordList.Add(new Chinese("因", "yin", "Y"));
            ChineseWordList.Add(new Chinese("向", "xiang", "X"));
            ChineseWordList.Add(new Chinese("关", "guan", "G"));
            ChineseWordList.Add(new Chinese("先", "xian", "X"));
            ChineseWordList.Add(new Chinese("再", "zai", "Z"));
            ChineseWordList.Add(new Chinese("机", "ji", "J"));
            ChineseWordList.Add(new Chinese("名", "ming", "M"));
            ChineseWordList.Add(new Chinese("并", "bing", "B"));
            ChineseWordList.Add(new Chinese("合", "he", "H"));
            ChineseWordList.Add(new Chinese("西", "xi", "X"));
            ChineseWordList.Add(new Chinese("次", "ci", "C"));
            ChineseWordList.Add(new Chinese("安", "an", "A"));
            ChineseWordList.Add(new Chinese("件", "jian", "J"));
            ChineseWordList.Add(new Chinese("死", "si", "S"));
            ChineseWordList.Add(new Chinese("光", "guang", "G"));
            ChineseWordList.Add(new Chinese("色", "se", "S"));
            ChineseWordList.Add(new Chinese("则", "ze", "Z"));
            ChineseWordList.Add(new Chinese("至", "zhi", "Z"));
            ChineseWordList.Add(new Chinese("字", "zi", "Z"));
            ChineseWordList.Add(new Chinese("设", "she", "S"));
            ChineseWordList.Add(new Chinese("任", "ren", "R"));
            ChineseWordList.Add(new Chinese("各", "ge", "G"));
            ChineseWordList.Add(new Chinese("式", "shi", "S"));
            ChineseWordList.Add(new Chinese("许", "xu", "X"));
            ChineseWordList.Add(new Chinese("场", "chang", "C"));
            ChineseWordList.Add(new Chinese("产", "chan", "C"));
            ChineseWordList.Add(new Chinese("吗", "ma", "M"));
            ChineseWordList.Add(new Chinese("交", "jiao", "J"));
            ChineseWordList.Add(new Chinese("似", "si", "S"));
            ChineseWordList.Add(new Chinese("师", "shi", "S"));
            ChineseWordList.Add(new Chinese("吃", "chi", "C"));
            ChineseWordList.Add(new Chinese("论", "lun", "L"));
            ChineseWordList.Add(new Chinese("传", "chuan", "C"));
            ChineseWordList.Add(new Chinese("决", "jue", "J"));
            ChineseWordList.Add(new Chinese("军", "jun", "J"));
            ChineseWordList.Add(new Chinese("衣", "yi", "Y"));
            ChineseWordList.Add(new Chinese("华", "hua", "H"));
            ChineseWordList.Add(new Chinese("早", "zao", "Z"));
            ChineseWordList.Add(new Chinese("百", "bai", "B"));
            ChineseWordList.Add(new Chinese("红", "hong", "H"));
            ChineseWordList.Add(new Chinese("江", "jiang", "J"));
            ChineseWordList.Add(new Chinese("收", "show", "S"));
            ChineseWordList.Add(new Chinese("达", "da", "D"));
            ChineseWordList.Add(new Chinese("众", "zhong", "Z"));
            ChineseWordList.Add(new Chinese("存", "cun", "C"));
            ChineseWordList.Add(new Chinese("尽", "jin", "J"));
            ChineseWordList.Add(new Chinese("爷", "ye", "Y"));
            ChineseWordList.Add(new Chinese("网", "wang", "W"));
            ChineseWordList.Add(new Chinese("兴", "xing", "X"));
            ChineseWordList.Add(new Chinese("共", "gong", "G"));
            ChineseWordList.Add(new Chinese("杀", "sha", "S"));
            ChineseWordList.Add(new Chinese("约", "yue", "Y"));
            ChineseWordList.Add(new Chinese("刚", "gang", "G"));
            ChineseWordList.Add(new Chinese("观", "guan", "G"));
            ChineseWordList.Add(new Chinese("欢", "huan", "H"));
            ChineseWordList.Add(new Chinese("忙", "mang", "M"));
            ChineseWordList.Add(new Chinese("伤", "shang", "S"));
            ChineseWordList.Add(new Chinese("农", "nong", "N"));
            ChineseWordList.Add(new Chinese("阳", "yang", "Y"));
            ChineseWordList.Add(new Chinese("导", "dao", "D"));
            ChineseWordList.Add(new Chinese("妈", "ma", "M"));
            ChineseWordList.Add(new Chinese("阵", "zhen", "Z"));
            ChineseWordList.Add(new Chinese("企", "qi", "Q"));
            ChineseWordList.Add(new Chinese("亚", "ya", "Q"));
            ChineseWordList.Add(new Chinese("妇", "fu", "F"));
            ChineseWordList.Add(new Chinese("权", "quan", "Q"));
            ChineseWordList.Add(new Chinese("异", "yi", "Y"));
            ChineseWordList.Add(new Chinese("列", "lie", "L"));
            ChineseWordList.Add(new Chinese("讲", "jiang", "J"));
            ChineseWordList.Add(new Chinese("级", "ji", "J"));
            ChineseWordList.Add(new Chinese("团", "tuan", "T"));
            ChineseWordList.Add(new Chinese("州", "zhou", "Z"));
            ChineseWordList.Add(new Chinese("争", "zheng", "Z"));
            ChineseWordList.Add(new Chinese("纪", "ji", "J"));
            ChineseWordList.Add(new Chinese("亦", "yi", "Y"));
            ChineseWordList.Add(new Chinese("考", "kao", "K"));

            


            #endregion




            #region 词语和成语

            ChineseTermList.Add(new Chinese("拿了", "na le", "NL"));
            ChineseTermList.Add(new Chinese("萝卜", "luo bo", "LB"));
            ChineseTermList.Add(new Chinese("大夫", "dai fu", "DF"));
            ChineseTermList.Add(new Chinese("大王", "dai wang", "DW"));
            ChineseTermList.Add(new Chinese("万俟", "mo qi", "MQ"));
            ChineseTermList.Add(new Chinese("什么", "shen me", "SM"));
            ChineseTermList.Add(new Chinese("生长", "sheng zhang", "SZ"));
            ChineseTermList.Add(new Chinese("成长", "chegn zhang", "CZ"));
            ChineseTermList.Add(new Chinese("长疮", "zhang chuang", "ZZ"));
            ChineseTermList.Add(new Chinese("长知识", "zhang zhi shi", "ZZS"));
            ChineseTermList.Add(new Chinese("长子", "zhang zi", "ZZ"));
            ChineseTermList.Add(new Chinese("长兄", "zhang xiong", "ZX"));
            ChineseTermList.Add(new Chinese("长孙", "zhang sun", "ZS"));
            ChineseTermList.Add(new Chinese("长辈", "zhang bei", "ZB"));
            ChineseTermList.Add(new Chinese("长者", "zhang zhe", "ZZ"));
            ChineseTermList.Add(new Chinese("家长", "jia zhang", "JZ"));
            ChineseTermList.Add(new Chinese("部长", "bu zhang", "BZ"));
            ChineseTermList.Add(new Chinese("校长", "xiao zhang", "XZ"));
            ChineseTermList.Add(new Chinese("六安", "lu an", "LA"));
            ChineseTermList.Add(new Chinese("六合", "lu he", "LH"));
            ChineseTermList.Add(new Chinese("阏氏", "yan zhi", "YZ"));
            ChineseTermList.Add(new Chinese("月氏", "yue zhi", "YZ"));
            ChineseTermList.Add(new Chinese("扎辫", "za bian", "ZB"));
            ChineseTermList.Add(new Chinese("扎腿", "za tui", "ZT"));
            ChineseTermList.Add(new Chinese("扎线", "za xian", "ZX"));
            ChineseTermList.Add(new Chinese("趾端有爪", "zhi duan you zhao", "ZDYZ"));
            ChineseTermList.Add(new Chinese("鹰爪", "yin zhao", "YZ"));
            ChineseTermList.Add(new Chinese("爪牙", "zhao ya", "ZY"));
            ChineseTermList.Add(new Chinese("一鳞半爪", "yi lin ban zhao", "YLBZ"));
            ChineseTermList.Add(new Chinese("屯蹇", "zhun jian", "ZJ"));
            ChineseTermList.Add(new Chinese("有萋有且", "you qi you ju", "YQYJ"));
            ChineseTermList.Add(new Chinese("白术", "bai zhu", "BZ"));
            ChineseTermList.Add(new Chinese("苍术", "cang zhu", "CZ"));
            ChineseTermList.Add(new Chinese("一石", "yi dan", "YD"));
            ChineseTermList.Add(new Chinese("高句骊", "gao gou li", "GGL"));
            ChineseTermList.Add(new Chinese("音乐", "yin yue", "YY"));
            ChineseTermList.Add(new Chinese("声乐", "sheng yue", "SY"));
            ChineseTermList.Add(new Chinese("乐池", "yue chi", "YC"));
            ChineseTermList.Add(new Chinese("乐音", "yue yin", "YY"));
            ChineseTermList.Add(new Chinese("乐歌", "yue ge", "YG"));
            ChineseTermList.Add(new Chinese("乐正", "yue zheng", "YZ"));
            ChineseTermList.Add(new Chinese("乐官", "yue guan", "YG"));
            ChineseTermList.Add(new Chinese("乐府", "yue fu", "YF"));
            ChineseTermList.Add(new Chinese("乐曲", "yue qu", "YQ"));
            ChineseTermList.Add(new Chinese("乐器", "yue qi", "YQ"));
            ChineseTermList.Add(new Chinese("乐亭", "lao tin", "LT"));
            ChineseTermList.Add(new Chinese("乐陵", "lao ling", "LL"));
            ChineseTermList.Add(new Chinese("叶韵", "xie yun", "XY"));
            ChineseTermList.Add(new Chinese("关卡", "guan qia", "GQ"));
            ChineseTermList.Add(new Chinese("卡子", "qia zi", "QZ"));
            ChineseTermList.Add(new Chinese("领带卡", "ling dai qia", "LDQ"));
            ChineseTermList.Add(new Chinese("卡壳", "qia ke", "QK"));
            ChineseTermList.Add(new Chinese("仔肩", "zi jian", "ZJ"));
            ChineseTermList.Add(new Chinese("仔细", "zi xi", "ZX"));
            ChineseTermList.Add(new Chinese("仔鸡", "zi ji", "ZJ"));
            ChineseTermList.Add(new Chinese("仔猪", "zi zhu", "ZX"));
            ChineseTermList.Add(new Chinese("叨光", "tao guang", "TG"));
            ChineseTermList.Add(new Chinese("叨扰", "tao rao", "TR"));
            ChineseTermList.Add(new Chinese("叨陪", "tao pei", "TP"));
            ChineseTermList.Add(new Chinese("扒草", "pa cao", "PC"));
            ChineseTermList.Add(new Chinese("扒痒", "pa yang", "PY"));
            ChineseTermList.Add(new Chinese("扒羊肉", "pa yang rou", "PYR"));
            ChineseTermList.Add(new Chinese("慢慢地", "man man de", "MMD"));
            ChineseTermList.Add(new Chinese("会计", "kuai ji", "KJ"));
            ChineseTermList.Add(new Chinese("行列", "hang lie", "HL"));
            ChineseTermList.Add(new Chinese("排行", "pai hang", "PH"));
            ChineseTermList.Add(new Chinese("两行", "liang hang", "LH"));
            ChineseTermList.Add(new Chinese("商行", "shang hang", "SH"));
            ChineseTermList.Add(new Chinese("银行", "yin hang", "YH"));
            ChineseTermList.Add(new Chinese("花行", "hua hang", "HH"));
            ChineseTermList.Add(new Chinese("各行各业", "ge hang ge ye", "GHGY"));
            ChineseTermList.Add(new Chinese("同行", "tong hang", "TH"));
            ChineseTermList.Add(new Chinese("小传", "xiao zhuan", "XZ"));
            ChineseTermList.Add(new Chinese("自传", "zi zhuan", "ZZ"));
            ChineseTermList.Add(new Chinese("纪传", "ji zhuan", "JZ"));
            ChineseTermList.Add(new Chinese("传记", "zhuan ji", "ZJ"));
            ChineseTermList.Add(new Chinese("传略", "zhuan lve", "ZL"));
            ChineseTermList.Add(new Chinese("左传", "zuo zhuan", "ZZ"));
            ChineseTermList.Add(new Chinese("水浒传", "shui hu zhuan", "SHZ"));
            
            #endregion


        }

        /// <summary>
        /// 将词语替换为拼音和拼音首字母
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="type">替换类型</param>
        /// <returns></returns>
        internal string ReplaceTermsAndIdiom(string text, PinYinType type)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            ChineseTermList.ForEach(x =>
            {
                if (text.Contains(x.Text))
                {
                    switch (type)
                    {
                        case PinYinType.拼音:
                            text = text.Replace(x.Text, string.Concat(" ", x.PinYin));
                            break;
                        case PinYinType.拼音首字母:
                            text = text.Replace(x.Text, x.PinYinFirstLetter);
                            break;
                        default:
                            break;
                    }
                }
            });
            return text.Trim();
        }

        /// <summary>
        /// 将字替换为拼音和拼音首字母
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="type">替换类型</param>
        /// <returns></returns>
        internal string ReplaceWord(string text, PinYinType type)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            ChineseWordList.ForEach(x =>
            {
                if (text.Contains(x.Text))
                {
                    switch (type)
                    {
                        case PinYinType.拼音:
                            text = text.Replace(x.Text, string.Concat(" ", x.PinYin));
                            break;
                        case PinYinType.拼音首字母:
                            text = text.Replace(x.Text, x.PinYinFirstLetter);
                            break;
                        default:
                            break;
                    }
                }
            });
            return text.Trim();
        }
    }
}
