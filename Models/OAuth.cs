namespace eBEST.OpenApi.Models
{
    internal record OAuth(
           string access_token,
           //string scope,
           //string token_type,
           long expires_in
        );
}
