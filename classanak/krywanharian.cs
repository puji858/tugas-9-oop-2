using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassInduk;

namespace TugasLab8.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public int jumlahjamkerja { get; set; }
        public int upahperJam { get; set; }
        public override double Gaji()
        {
            return jumlahjamkerja * UpahPerJam;
        }
    }
}
