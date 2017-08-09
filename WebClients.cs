using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VertoExcercise.POCO;

namespace VertoExcercise
{
    public class WebClients
    {
        private string rootUrl = "https://en.wikipedia.org/w/api.php?action=query&";

        public async Task<WikiGeoSearchRoot> GetWikiGeoSearchAsync()
        {
            WikiGeoSearchRoot geoSearch = null;
            try
            {
                using (var client = new HttpClient())
                {
                    var queryParams =
                        "format=json&list=geosearch&gscoord=37.786952%7C-122.399523&gsradius=10000&gslimit=10";
                    // 
                    var response =
                        await client.GetStringAsync(rootUrl + queryParams);
                    Console.WriteLine(response.ToString());
                    if (response != null)
                        geoSearch = JsonConvert.DeserializeObject<WikiGeoSearchRoot>(response);
                    return geoSearch;
                }
            }
            catch (WebException exception)
            {
                throw new WebException(
                    "An error has occurred while calling GetSampleClass method: " + exception.Message);
            }
        }

        public async Task<WikiImagesRoot> GetWikiImages(string pageid)
        {
            WikiImagesRoot images = null;
            try
            {
                using (var client = new HttpClient())
                {
                    var queryParams =
                        "prop=images&pageids=" + pageid + "&format=json";
                    // 
                    var response =
                        await client.GetStringAsync(rootUrl + queryParams);
                    if (response != null)
                        images = JsonConvert.DeserializeObject<WikiImagesRoot>(response);
                    return images;
                }
            }
            catch (WebException exception)
            {
                throw new WebException(
                    "An error has occurred while calling GetSampleClass method: " + exception.Message);
            }
        }
    }
}