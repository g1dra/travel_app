using System.Collections;
using System.Collections.Generic;

namespace Travel.Application.Dtos.Tour
{
    public class TourListDto
    {
        public TourListDto()
        {
            Items = new List<TourListDto>();
        }
        
        public IList<TourListDto> Items { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
        public string About { get; set; }
    }
}