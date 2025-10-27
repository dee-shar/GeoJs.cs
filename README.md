# GeoJs.cs
Web-API for [geojs.io](https://www.geojs.io) which is an highly available REST/JSON/JSONP IP Geolocation lookup API

## Example
```cs
using GeoJsApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new GeoJs();
            string currentIp = await api.GetCurrentIp();
            Console.WriteLine(currentIp);
        }
    }
}
```
