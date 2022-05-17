using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SendingTool.Data;
using SendingTool.Dtos;
using SendingTool.Models;

namespace SendingTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhvienTTController : ControllerBase
    {
        private readonly SinhvienTTDbContext _context;
        private readonly IMapper _mapper;

        public SinhvienTTController(SinhvienTTDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<SingvienTTReadDto> GetSinhvienTTsBycode(string tinh)
        {
            var sinhvien = _context.DataTuyenSinh2022.Where(s=>s.Tinh==tinh).FirstOrDefault();
            if (sinhvien == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<SingvienTTReadDto>(sinhvien));
        }
    }
}