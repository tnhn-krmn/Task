public record VKN : KisiId
{
    public string value { get; init; }
    public VKN(string Vkn)
    {
        value = Vkn;
    }
    public bool IsValidVKN()
    {
        // VKN'ye özgü doğrulama işlemleri burada yapılır.
        // this.Id, VKN sınıfına gönderilen VKN değerini temsil eder.
        return true; // veya false
    }
}