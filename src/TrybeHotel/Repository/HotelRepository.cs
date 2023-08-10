using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class HotelRepository : IHotelRepository
    {
        protected readonly ITrybeHotelContext _context;
        public HotelRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 4. Desenvolva o endpoint GET /hotel
        public IEnumerable<HotelDto> GetHotels()
        {
            var content = from h in _context.Hotels
                          join c in _context.Cities on h.CityId equals c.CityId
                          select new HotelDto
                          {
                              hotelId = h.HotelId,
                              name = h.Name,
                              address = h.Address,
                              cityId = c.CityId,
                              cityName = c.Name
                          };
            return content;
        }

        // 5. Desenvolva o endpoint POST /hotel
        public HotelDto AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}