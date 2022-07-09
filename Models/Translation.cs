namespace Scripture.Api.Models;
public class TranslationDto
{
    public int Id { get; set; }
    public string Language { get; set; }
    public string Translation { get; set; }
    public string Abbreviation { get; set; }
    public string Textdirection { get; set; }
    public string Filename { get; set; }
    public string Hash { get; set; }

}
public class TranslationRecord
{
    public int Id { get; set; }
    public string Language { get; set; }
    public string Translation { get; set; }
    public string Abbreviation { get; set; }
    public string Textdirection { get; set; }

    public TranslationRecord From(TranslationDto translationDto) => new TranslationRecord
    {
        Abbreviation = translationDto.Abbreviation,
        Id = translationDto.Id,
        Language = translationDto.Language,
        Textdirection = translationDto.Textdirection,
        Translation = translationDto.Translation
    };

}


public class Translations
{
    public TranslationDto aov { get; set; }
    public TranslationDto albanian { get; set; }
    public TranslationDto amharic { get; set; }
    public TranslationDto hsab { get; set; }
    public TranslationDto arabicsv { get; set; }
    public TranslationDto peshitta { get; set; }
    public TranslationDto easternarmenian { get; set; }
    public TranslationDto westernarmenian { get; set; }
    public TranslationDto basque { get; set; }
    public TranslationDto breton { get; set; }
    public TranslationDto bulgarian1940 { get; set; }
    public TranslationDto chamorro { get; set; }
    public TranslationDto cns { get; set; }
    public TranslationDto cnt { get; set; }
    public TranslationDto cus { get; set; }
    public TranslationDto cut { get; set; }
    public TranslationDto bohairic { get; set; }
    public TranslationDto coptic { get; set; }
    public TranslationDto sahidic { get; set; }
    public TranslationDto croatia { get; set; }
    public TranslationDto bkr { get; set; }
    public TranslationDto cep { get; set; }
    public TranslationDto kms { get; set; }
    public TranslationDto nkb { get; set; }
    public TranslationDto danish { get; set; }
    public TranslationDto statenvertaling { get; set; }
    public TranslationDto akjv { get; set; }
    public TranslationDto asv { get; set; }
    public TranslationDto basicenglish { get; set; }
    public TranslationDto darby { get; set; }
    public TranslationDto douayrheims { get; set; }
    public TranslationDto kjv { get; set; }
    public TranslationDto wb { get; set; }
    public TranslationDto weymouth { get; set; }
    public TranslationDto web { get; set; }
    public TranslationDto ylt { get; set; }
    public TranslationDto esperanto { get; set; }
    public TranslationDto estonian { get; set; }
    public TranslationDto finnish1776 { get; set; }
    public TranslationDto pyharaamattu1933 { get; set; }
    public TranslationDto pyharaamattu1992 { get; set; }
    public TranslationDto ls1910 { get; set; }
    public TranslationDto martin { get; set; }
    public TranslationDto ostervald { get; set; }
    public TranslationDto georgian { get; set; }
    public TranslationDto elberfelder { get; set; }
    public TranslationDto elberfelder1905 { get; set; }
    public TranslationDto luther1545 { get; set; }
    public TranslationDto luther1912 { get; set; }
    public TranslationDto schlachter { get; set; }
    public TranslationDto gothic { get; set; }
    public TranslationDto moderngreek { get; set; }
    public TranslationDto byzantine { get; set; }
    public TranslationDto majoritytext { get; set; }
    public TranslationDto textusreceptus { get; set; }
    public TranslationDto text { get; set; }
    public TranslationDto tischendorf { get; set; }
    public TranslationDto westcotthort { get; set; }
    public TranslationDto westcott { get; set; }
    public TranslationDto lxx { get; set; }
    public TranslationDto lxxpar { get; set; }
    public TranslationDto lxxunaccents { get; set; }
    public TranslationDto lxxunaccentspar { get; set; }
    public TranslationDto aleppo { get; set; }
    public TranslationDto modernhebrew { get; set; }
    public TranslationDto bhs { get; set; }
    public TranslationDto bhsnovowels { get; set; }
    public TranslationDto codex { get; set; }
    public TranslationDto wlc { get; set; }
    public TranslationDto wlcnovowels { get; set; }
    public TranslationDto karoli { get; set; }
    public TranslationDto giovanni { get; set; }
    public TranslationDto riveduta { get; set; }
    public TranslationDto kabyle { get; set; }
    public TranslationDto korean { get; set; }
    public TranslationDto newvulgate { get; set; }
    public TranslationDto vulgate { get; set; }
    public TranslationDto latvian { get; set; }
    public TranslationDto lithuanian { get; set; }
    public TranslationDto manxgaelic { get; set; }
    public TranslationDto maori { get; set; }
    public TranslationDto judson { get; set; }
    public TranslationDto bibelselskap { get; set; }
    public TranslationDto almeida { get; set; }
    public TranslationDto potawatomi { get; set; }
    public TranslationDto cornilescu { get; set; }
    public TranslationDto rom { get; set; }
    public TranslationDto makarij { get; set; }
    public TranslationDto synodal { get; set; }
    public TranslationDto zhuromsky { get; set; }
    public TranslationDto gaelic { get; set; }
    public TranslationDto valera { get; set; }
    public TranslationDto rv1858 { get; set; }
    public TranslationDto sse { get; set; }
    public TranslationDto swahili { get; set; }
    public TranslationDto swedish { get; set; }
    public TranslationDto tagalog { get; set; }
    public TranslationDto tamajaq { get; set; }
    public TranslationDto thai { get; set; }
    public TranslationDto tnt { get; set; }
    public TranslationDto turkish { get; set; }
    public TranslationDto ukranian { get; set; }
    public TranslationDto uma { get; set; }
    public TranslationDto vietnamese { get; set; }
    public TranslationDto wolof { get; set; }
    public TranslationDto xhosa { get; set; }
}
