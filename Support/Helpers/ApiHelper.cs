namespace ApiMayUnitTest24.Support.Helpers
{
    public class ApiHelper
    {
        public RestClient RestClient { get; set; }
        public RestRequest Request { get; set; }
        public string ContentType { get; set; }
        public string baseUrl = "https://reqres.in/";
        private string Endpoint => "api/users?page=1";
        public HttpStatusCode StatusCode { get; set; }
        //public AllUsersResponseModel allUsersResponse { get; set; }

        //public async Task<(T, HttpStatusCode)> SendRequest<T>(string resource,
        //    Method method, 
        //    object payload = null, 
        //    Dictionary<string, string> header = null,
        //    Dictionary<string, string> param = null)
        //{
        //    var options = new RestClientOptions()
        //    {
        //        BaseUrl = new baseUri(resource),
        //    };
        //    Client = new RestClient(options);
        //    Request = new RestRequest(Endpoint, method);

        //    if (payload != null) 
        //    {
        //        Request.AddBody(payload, ContentType);
        //    }

        //    if (header != null) 
        //    {
        //        header?.ToList().ForEach(kvp => Request.AddHeader(kvp.Key, kvp.Value));
        //    }

        //    if (param != null)
        //    {
        //        param?.ToList()
        //            .ForEach(kvp => Request.AddHeader(kvp.key, kvp.Value));
        //    }

        //    var Response = await ClientCertificateOption.ExecuteAsync<T>(Request);
        //    StatusCode = Response.StatusCode;
        //    return (Response.Data!, StatusCode);
        //}

        //public T DeserializeData<T>() 
        //{
        //    var data = ClientCertificateOption.Execute<T>(Request);
        //    return data!;
        //}
    }
}
