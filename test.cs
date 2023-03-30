using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ApproveDriverDTO
    {
        public int Id { get; set; }
        public string LicenseFront { get; set; }
        public string LicenseBack { get; set; }
        public string Contract { get; set; }
        public string UserImage { get; set; }
        public BusinessDTO Business { get; set; }
        public ApproveVehiculoDTO Vehicle { get; set; }
    }
}
