
using Scripture.Api.Exceptions;

namespace Scripture.Api.ValueObjects;
public class BookType : ValueObject
{
    public string Name { get; private set; }
    public string Code { get; private set; }
    private BookType(string name, string code)
    {
        Name = name;
        Code = code;
    }
    public static BookType From(string code)
    {
        var found = SupportedBookType().FirstOrDefault(t => t.Code == code);
        if (found is null) throw new ValueNotSupportedException(nameof(BookType), code);
        return found;
    }
    #region Old
    public static BookType Genesis => new BookType("Genesis", "01O");
    public static BookType Exodus => new BookType("Exodus", "02O");
    public static BookType Leviticus => new BookType("Leviticus", "03O");
    public static BookType Numbers => new BookType("Numbers", "04O");
    public static BookType Deuteronomy => new BookType("Deuteronomy", "05O");
    public static BookType Joshua => new BookType("Joshua", "06O");
    public static BookType Judges => new BookType("Judges", "07O");
    public static BookType Ruth => new BookType("Ruth", "08O");
    public static BookType _1_Samuel => new BookType("1 Samuel", "09O");
    public static BookType _2_Samuel => new BookType("2 Samuel", "10O");
    public static BookType _1_Kings => new BookType("1 Kings", "11O");
    public static BookType _2_Kings => new BookType("2 Kings", "12O");
    public static BookType _1_Chronicles => new BookType("1 Chronicles", "13O");
    public static BookType _2_Chronicles => new BookType("2 Chronicles", "14O");
    public static BookType Ezra => new BookType("Ezra", "15O");
    public static BookType Nehemiah => new BookType("Nehemiah", "16O");
    public static BookType Esther => new BookType("Esther", "17O");
    public static BookType Job => new BookType("Job", "18O");
    public static BookType Psalms => new BookType("Psalms", "19O");
    public static BookType Proverbs => new BookType("Proverbs", "20O");
    public static BookType Ecclesiastes => new BookType("Ecclesiastes", "21O");
    public static BookType Song_of_Songs => new BookType("Song of Songs", "22O");
    public static BookType SongOfSolomon => new BookType("Song of Solomon", "22O");
    public static BookType Isaiah => new BookType("Isaiah", "23O");
    public static BookType Jeremiah => new BookType("Jeremiah", "24O");
    public static BookType Lamentations => new BookType("Lamentations", "25O");
    public static BookType Ezekiel => new BookType("Ezekiel", "26O");
    public static BookType Daniel => new BookType("Daniel", "27O");
    public static BookType Hosea => new BookType("Hosea", "28O");
    public static BookType Joel => new BookType("Joel", "29O");
    public static BookType Amos => new BookType("Amos", "30O");
    public static BookType Obadiah => new BookType("Obadiah", "31O");
    public static BookType Jonah => new BookType("Jonah", "32O");
    public static BookType Micah => new BookType("Micah", "33O");
    public static BookType Nahum => new BookType("Nahum", "34O");
    public static BookType Habakkuk => new BookType("Habakkuk", "35O");
    public static BookType Zephaniah => new BookType("Zephaniah", "36O");
    public static BookType Haggai => new BookType("Haggai", "37O");
    public static BookType Zechariah => new BookType("Zechariah", "38O");
    public static BookType Malachi => new BookType("Malachi", "39O");
    #endregion
    #region New Testament
    public static BookType Matthew => new BookType("Matthew", "40N");
    public static BookType Mark => new BookType("Mark", "41N");
    public static BookType Luke => new BookType("Luke", "42N");
    public static BookType John_1 => new BookType("John 1", "43N");
    public static BookType John => new BookType("John", "43N");
    public static BookType Acts => new BookType("Acts", "44N");
    public static BookType Romans => new BookType("Romans", "45N");
    public static BookType _1_Corinthians => new BookType("1 Corinthians", "46N");
    public static BookType _2_Corinthians => new BookType("2 Corinthians", "47N");
    public static BookType Galatians => new BookType("Galatians", "48N");
    public static BookType Ephesians => new BookType("Ephesians", "49N");
    public static BookType Philippians => new BookType("Philippians", "50N");
    public static BookType Colossians => new BookType("Colossians", "51N");
    public static BookType _1_Thessalonians => new BookType("1 Thessalonians", "52N");
    public static BookType _2_Thessalonians => new BookType("2 Thessalonians", "53N");
    public static BookType _1_Timothy => new BookType("1 Timothy", "54N");
    public static BookType _2_Timothy => new BookType("2 Timothy", "55N");
    public static BookType Titus => new BookType("Titus", "56N");
    public static BookType Philemon => new BookType("Philemon", "57N");
    public static BookType Hebrews => new BookType("Hebrews", "58N");
    public static BookType James => new BookType("James", "59N");
    public static BookType _1_Peter => new BookType("1 Peter", "60N");
    public static BookType _2_Peter => new BookType("2 Peter", "61N");
    public static BookType _1_John => new BookType("1 John", "62N");
    public static BookType _2_John => new BookType("2 John", "63N");
    public static BookType _3_John => new BookType("3 John", "64N");
    public static BookType Jude => new BookType("Jude", "65N");
    public static BookType Revelation => new BookType("Revelation", "66N");
    #endregion
    #region New Style
    public static BookType NewGenesis => new BookType("Genesis", "Genesis");
    public static BookType NewExodus => new BookType("Exodus", "Exodus");
    public static BookType NewLeviticus => new BookType("Leviticus", "Leviticus");
    public static BookType NewNumbers => new BookType("Numbers", "Numbers");
    public static BookType NewDeuteronomy => new BookType("Deuteronomy", "Deuteronomy");
    public static BookType NewJoshua => new BookType("Joshua", "Joshua");
    public static BookType NewJudges => new BookType("Judges", "Judges");
    public static BookType NewRuth => new BookType("Ruth", "Ruth");
    public static BookType New_1_Samuel => new BookType("1 Samuel", "1 Samuel");
    public static BookType New_2_Samuel => new BookType("2 Samuel", "2 Samuel");
    public static BookType New_1_Kings => new BookType("1 Kings", "1 Kings");
    public static BookType New_2_Kings => new BookType("2 Kings", "2 Kings");
    public static BookType New_1_Chronicles => new BookType("1 Chronicles", "1 Chronicles");
    public static BookType New_2_Chronicles => new BookType("2 Chronicles", "2 Chronicles");
    public static BookType NewEzra => new BookType("Ezra", "Ezra");
    public static BookType NewNehemiah => new BookType("Nehemiah", "Nehemiah");
    public static BookType NewEsther => new BookType("Esther", "Esther");
    public static BookType NewJob => new BookType("Job", "Job");
    public static BookType NewPsalm => new BookType("Psalm", "Psalm");
    public static BookType NewPsalms => new BookType("Psalms", "Psalms");
    public static BookType NewProverbs => new BookType("Proverbs", "Proverbs");
    public static BookType NewEcclesiastes => new BookType("Ecclesiastes", "Ecclesiastes");
    public static BookType NewSong_of_Songs => new BookType("Song of Songs", "Song of Songs");
    public static BookType NewSongOfSolomon => new BookType("Song of Solomon", "Song of Solomon");
    public static BookType NewIsaiah => new BookType("Isaiah", "Isaiah");
    public static BookType NewJeremiah => new BookType("Jeremiah", "Jeremiah");
    public static BookType NewLamentations => new BookType("Lamentations", "Lamentations");
    public static BookType NewEzekiel => new BookType("Ezekiel", "Ezekiel");
    public static BookType NewDaniel => new BookType("Daniel", "Daniel");
    public static BookType NewHosea => new BookType("Hosea", "Hosea");
    public static BookType NewJoel => new BookType("Joel", "Joel");
    public static BookType NewAmos => new BookType("Amos", "Amos");
    public static BookType NewObadiah => new BookType("Obadiah", "Obadiah");
    public static BookType NewJonah => new BookType("Jonah", "Jonah");
    public static BookType NewMicah => new BookType("Micah", "Micah");
    public static BookType NewNahum => new BookType("Nahum", "Nahum");
    public static BookType NewHabakkuk => new BookType("Habakkuk", "Habakkuk");
    public static BookType NewZephaniah => new BookType("Zephaniah", "Zephaniah");
    public static BookType NewHaggai => new BookType("Haggai", "Haggai");
    public static BookType NewZechariah => new BookType("Zechariah", "Zechariah");
    public static BookType NewMalachi => new BookType("Malachi", "Malachi");
    public static BookType NewMatthew => new BookType("Matthew", "Matthew");
    public static BookType NewMark => new BookType("Mark", "Mark");
    public static BookType NewLuke => new BookType("Luke", "Luke");
    public static BookType NewJohn_1 => new BookType("John 1", "John 1");
    public static BookType NewJohn => new BookType("John", "John");
    public static BookType NewActs => new BookType("Acts", "Acts");
    public static BookType NewRomans => new BookType("Romans", "Romans");
    public static BookType New_1_Corinthians => new BookType("1 Corinthians", "1 Corinthians");
    public static BookType New_2_Corinthians => new BookType("2 Corinthians", "2 Corinthians");
    public static BookType NewGalatians => new BookType("Galatians", "Galatians");
    public static BookType NewEphesians => new BookType("Ephesians", "Ephesians");
    public static BookType NewPhilippians => new BookType("Philippians", "Philippians");
    public static BookType NewColossians => new BookType("Colossians", "Colossians");
    public static BookType New_1_Thessalonians => new BookType("1 Thessalonians", "1 Thessalonians");
    public static BookType New_2_Thessalonians => new BookType("2 Thessalonians", "2 Thessalonians");
    public static BookType New_1_Timothy => new BookType("1 Timothy", "1 Timothy");
    public static BookType New_2_Timothy => new BookType("2 Timothy", "2 Timothy");
    public static BookType NewTitus => new BookType("Titus", "Titus");
    public static BookType NewPhilemon => new BookType("Philemon", "Philemon");
    public static BookType NewHebrews => new BookType("Hebrews", "Hebrews");
    public static BookType NewJames => new BookType("James", "James");
    public static BookType New_1_Peter => new BookType("1 Peter", "1 Peter");
    public static BookType New_2_Peter => new BookType("2 Peter", "2 Peter");
    public static BookType New_1_John => new BookType("1 John", "1 John");
    public static BookType New_2_John => new BookType("2 John", "2 John");
    public static BookType New_3_John => new BookType("3 John", "3 John");
    public static BookType NewJude => new BookType("Jude", "Jude");
    public static BookType NewRevelation => new BookType("Revelation", "Revelation");
 
    #endregion
    protected static IEnumerable<BookType> SupportedBookType()
    {
        #region Old
        yield return Genesis;
        yield return Exodus;
        yield return Leviticus;
        yield return Numbers;
        yield return Deuteronomy;
        yield return Joshua;
        yield return Judges;
        yield return Ruth;
        yield return _1_Samuel;
        yield return _2_Samuel;
        yield return _1_Kings;
        yield return _2_Kings;
        yield return _1_Chronicles;
        yield return _2_Chronicles;
        yield return Ezra;
        yield return Nehemiah;
        yield return Esther;
        yield return Job;
        yield return Psalms;
        yield return Proverbs;
        yield return Ecclesiastes;
        yield return Song_of_Songs;
        yield return SongOfSolomon;
        yield return Isaiah;
        yield return Jeremiah;
        yield return Lamentations;
        yield return Ezekiel;
        yield return Daniel;
        yield return Hosea;
        yield return Joel;
        yield return Amos;
        yield return Obadiah;
        yield return Jonah;
        yield return Micah;
        yield return Nahum;
        yield return Habakkuk;
        yield return Zephaniah;
        yield return Haggai;
        yield return Zechariah;
        yield return Malachi;
        #endregion
        #region New 
        yield return Matthew;
        yield return Mark;
        yield return Luke;
        yield return John;
        yield return John_1;
        yield return Acts;
        yield return Romans;
        yield return _1_Corinthians;
        yield return _2_Corinthians;
        yield return Galatians;
        yield return Ephesians;
        yield return Philippians;
        yield return Colossians;
        yield return _1_Thessalonians;
        yield return _2_Thessalonians;
        yield return _1_Timothy;
        yield return _2_Timothy;
        yield return Titus;
        yield return Philemon;
        yield return Hebrews;
        yield return James;
        yield return _1_Peter;
        yield return _2_Peter;
        yield return _1_John;
        yield return _2_John;
        yield return _3_John;
        yield return Jude;
        yield return Revelation;
        #endregion
        #region New Style
        yield return NewGenesis;
        yield return NewExodus;
        yield return NewLeviticus;
        yield return NewNumbers;
        yield return NewDeuteronomy;
        yield return NewJoshua;
        yield return NewJudges;
        yield return NewRuth;
        yield return New_1_Samuel;
        yield return New_2_Samuel;
        yield return New_1_Kings;
        yield return New_2_Kings;
        yield return New_1_Chronicles;
        yield return New_2_Chronicles;
        yield return NewEzra;
        yield return NewNehemiah;
        yield return NewEsther;
        yield return NewJob;
        yield return NewPsalm;
        yield return NewPsalms;
        yield return NewProverbs;
        yield return NewEcclesiastes;
        yield return NewSong_of_Songs;
        yield return NewSongOfSolomon;
        yield return NewIsaiah;
        yield return NewJeremiah;
        yield return NewLamentations;
        yield return NewEzekiel;
        yield return NewDaniel;
        yield return NewHosea;
        yield return NewJoel;
        yield return NewAmos;
        yield return NewObadiah;
        yield return NewJonah;
        yield return NewMicah;
        yield return NewNahum;
        yield return NewHabakkuk;
        yield return NewZephaniah;
        yield return NewHaggai;
        yield return NewZechariah;
        yield return NewMalachi;
        yield return NewMatthew;
        yield return NewMark;
        yield return NewLuke;
        yield return NewJohn;
        yield return NewJohn_1;
        yield return NewActs;
        yield return NewRomans;
        yield return New_1_Corinthians;
        yield return New_2_Corinthians;
        yield return NewGalatians;
        yield return NewEphesians;
        yield return NewPhilippians;
        yield return NewColossians;
        yield return New_1_Thessalonians;
        yield return New_2_Thessalonians;
        yield return New_1_Timothy;
        yield return New_2_Timothy;
        yield return NewTitus;
        yield return NewPhilemon;
        yield return NewHebrews;
        yield return NewJames;
        yield return New_1_Peter;
        yield return New_2_Peter;
        yield return New_1_John;
        yield return New_2_John;
        yield return New_3_John;
        yield return NewJude;
        yield return NewRevelation;
        #endregion
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Code;
    }
}

