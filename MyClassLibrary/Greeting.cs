using Newtonsoft.Json;

namespace MyClassLibrary
{
    public class Greeting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        private readonly HttpClient client = new HttpClient();

        public Greeting()
        {
            Id = Guid.NewGuid();
            Name = RandomNamesAsync().GetAwaiter().GetResult();
        }

        private async Task<string> RandomNamesAsync()
        {
            string resp =  string.Empty;

            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.namefake.com/english-united-states/male/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                var obj = (dynamic)JsonConvert.DeserializeObject<object>(responseBody);
                resp = $"Hello {obj.name}";
            }
            catch (HttpRequestException e)
            {
                return "\nException Caught!" + "\nMessage : " + e.Message;
            }

            return resp;
        }
    }
}