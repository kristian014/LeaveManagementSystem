using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Configurations
{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {
            // what is a mapping configuration 
            // this is what tells auto mapper that it is legal to convert from config A to config B 
            // which is LeaveType to LeaveTypeVM 
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}

// read about auto mapper // 