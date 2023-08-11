using MeasurementsModels.Dtos;
using MeasurementsWebAPI.BusinessLogic.Models;

namespace MeasurementsWebAPI.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<AtmDto> ConvertToDto(this IEnumerable<Atm> atms)
        {
            return (from atm in atms
                    select new AtmDto
                    {
                        Id = atm.Id,
                        Description = atm.Description,
                        Height = atm.Height,
                        Length = atm.Length,
                        Width = atm.Width
                    }).ToList();
        }

        public static AtmDto ConvertToDto(this Atm atm)
        {
            return new AtmDto
            {
                Id = atm.Id,
                Description = atm.Description,
                Height = atm.Height,
                Length = atm.Length,
                Width = atm.Width
            };
        }
    }
}
