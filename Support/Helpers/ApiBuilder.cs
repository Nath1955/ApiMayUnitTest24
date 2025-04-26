namespace ApiMayUnitTest24.Support.Helpers
{
    public class ApiBuilder
    {
        private RestClient _restClient;
        private RestRequest _restRequest;
        private readonly string baseUrl = "";

        public RestClient SetUrl()
        {
            var url = Path.Combine(baseUrl);
            _restClient = new RestClient(url);
            return _restClient;
        }

        public RestRequest GetRequest(string endPoint, Method method)
        {
            _restRequest = new RestRequest(endPoint, method);
            _restRequest.AddHeader("Accept", "Application/json");
            return _restRequest;
        }

        public RestRequest DeleteRequest(string endPoint)
        {
            _restRequest = new RestRequest(endPoint);
            _restRequest.AddHeader("Accept", "Application/json");
            return _restRequest;
        }

        //public RestRequest PostRequest<T>(T payload, string endPoint, string apivalue)
        //{
        //    _restRequest = new RestRequest(endPoint, Method.Post);
        //    _restRequest.AddHeader("Accept", "Application/json");
        //    _restRequest.AddHeader("X-Api-Key", "apivalue");
        //    _restRequest.AddParameter("application/json", _restRequest.AddJsonBody(payload), ParameterType.RequestBody);
        //    return _restRequest;
        //}

        //public RestRequest PutRequest<T>(T payload)
        //{
        //    _restRequest = new RestRequest(Method.Post);
        //    _restRequest.AddHeader("Accept", "Application/json");
        //    _restRequest.AddParameter("application/json", _restRequest.AddJsonBody(payload), ParameterType.RequestBody);
        //    return _restRequest;
        //}

        //public RestRequest PatchRequest<T>(T payload, string apivalue)
        //{
        //    _restRequest = new RestRequest(endPoint, Method.PATCH);
        //    _restRequest.AddHeader("Accept", "Application/json");
        //    _restRequest.AddHeader("X-Api-Key", "apivalue");
        //    _restRequest.AddParameter("application/json", _restRequest.AddJsonBody(payload), ParameterType.RequestBody);
        //    return _restRequest;
        //}

        //public IRestResponse GetResponse(RestClient client, RestRequest request)
        //{
        //    return client.Execute(request);
        //}

        //public DTO GetContent<DTO>(IRestResponse response)
        //{
        //    var content = response.Content;
        //    DTO contentobject = JsonConvert.DeserializeObject<DTO>(content);
        //    return client.Execute(request);
        //}


        //public string Serialiaze(dynamic content)
        //{
        //    string serializeObject = JsonConvert.SerializeObject(content, Formating.Indented);
        //    return serializeObject;
        //}

    }
}
