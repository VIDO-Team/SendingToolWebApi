using SendingTool.Models;
using SendingTool.Dtos;
using AutoMapper;

namespace SendingTool.Profiles
{
    public class SinhvienTTProfile :Profile
    {
        public SinhvienTTProfile()
        {
            CreateMap<SingvienTTReadDto,SinhvienTT>();
        }
    }
}