namespace TurismoApp.ApiServiceIA.Controller
{
    using System.Net.Http.Json;
    using TurismoApp.ApiServiceIA.Models;

    public class BusquedasController
    {
        private readonly IHttpClientFactory _httpFactory;

        public BusquedasController(IHttpClientFactory httpFactory)
        {
            _httpFactory = httpFactory;
        }

        public async Task<HotelDto?> ObtenerHotelMasBaratoAsync(string destino)
        {
            var client = _httpFactory.CreateClient("ApiService");
            try
            {
                var hotels = await client.GetFromJsonAsync<List<HotelDto>>("/hoteles");
                if (hotels == null || hotels.Count == 0) return null;

                // Filtrar por destino si se proporciona
                var filtered = string.IsNullOrWhiteSpace(destino)
                    ? hotels
                    : hotels.Where(h => !string.IsNullOrEmpty(h.Ubicacion) && h.Ubicacion.Contains(destino, StringComparison.OrdinalIgnoreCase)).ToList();

                var listToConsider = (filtered != null && filtered.Count > 0) ? filtered : hotels;

                var cheapest = listToConsider.OrderBy(h => h.PrecioPorNoche).FirstOrDefault();
                return cheapest;
            }
            catch
            {
                return null;
            }
        }
    }

}