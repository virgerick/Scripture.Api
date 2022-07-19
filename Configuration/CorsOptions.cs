namespace Scripture.Api.Configuration;

public class CorsOptions
{
    public bool AllowCredentials { get; set; }
    public string[] Methods { get; set; }
    public string[] Origins { get; set; }
}
