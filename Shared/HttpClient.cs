using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientExample
{
    class Client
    {
        static HttpClient client = new HttpClient();

        public static async Task GetImageAsync(string url)
        {

            Uri uri = null;

            try
            {
                uri = new Uri(url);
            }
            catch (System.Exception)
            {
                Console.WriteLine($"{url} is an invalid Uri");
            }

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {

                var image = await response.Content.ReadAsByteArrayAsync();
                var imagePath = uri.AbsolutePath.Split("/")[2];
                await File.WriteAllBytesAsync($"dest_folder/{imagePath}", image);
            }
        }
    }
}