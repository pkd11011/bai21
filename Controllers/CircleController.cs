using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircleController : ControllerBase
    {
        [HttpGet("cv_dt")]
        public IActionResult tinh_chuvi_dientich_duongkinh(double rr) // rr là bán kính
        {
            if (rr <= 0)
            {
                return BadRequest("Bán kính phải dương");
            }

            double cv = 3.14 * 2 * rr;   // Chu vi
            double dt = 3.14 * rr * rr; // Diện tích
            double dk = 2 * rr;         // Đường kính

            var json_str = new { dien_tich = dt, chu_vi = cv, duong_kinh = dk };
            return Ok(json_str);
        }
    }
}