using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassInduk;

namespace TugasLab8.ClassAnak
{
    public class Sales : Karyawan
    {
        public int jumlahpenjualan { get; set; }
        public int komisi { get; set; }
        public override double Gaji()
        {
            return jumlahpenjualan * Komisi;
        }
    }
}
