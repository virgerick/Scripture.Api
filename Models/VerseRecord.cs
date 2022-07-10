namespace Scripture.Api.Models;

public class VerseRecord
{
    public int Number { get; set; }
    public string Text { get; set; }
    public VerseRecord(int id, string text)
    {
        Number = id;
        Text = text;
    }


}
