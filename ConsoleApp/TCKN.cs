public record TCKN : KisiId
{
    public string value { get; init; }

    public TCKN(string tckn)
    {
        if (string.IsNullOrWhiteSpace(tckn))
        {
            throw new ArgumentException("TC Kimlik Numartası boş olamaz");
        }

        if (tckn.Trim().Length != 11)
        {
            throw new ArgumentException("Geçerli uzunlukta giriniz");
        }
        value = tckn;
    }
}