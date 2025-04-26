namespace ApiMayUnitTest24.TestModule
{
    public class ApiPostRequest : ApiRequest
    {
        [Test]
        public void CreateNewUser() 
        {
            var payload = new PostNewRequestUser
            {
                name = "morpheus",
                job = "leader",
            };
            var response = PostRequest<PostCreateModel>(PostNewUserEndpoint, payload, RestSharp.Method.Post)
                .DeserializeData<PostCreateModel>();
            Assert.That(response.name.Equals("morpheus"), Is.EqualTo(true));
            Assert.That(response.job, Is.EqualTo("leader"));
            Assert.That(response.createdAt != null);
            Assert.That(response.id != null);

        }
    }
}
