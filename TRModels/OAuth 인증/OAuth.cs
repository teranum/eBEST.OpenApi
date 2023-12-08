namespace eBEST.OpenApi.TRModels
{
    internal record OAuth(
           string access_token,
           //string scope,
           string token_type,
           long expires_in
        );
}
