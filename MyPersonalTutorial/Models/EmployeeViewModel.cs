using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalTutorial.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string BirthDate { get; set; }

        public class Automappings : AutoMapper.Profile
        {
            public Automappings()
            {
                CreateMap<Employee, EmployeeViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                    .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.HasValue ?
                    src.BirthDate.Value.Date.ToString() : ""))
                    ;
                CreateMap<EmployeeViewModel, Employee>();
            }
        }
    }
}