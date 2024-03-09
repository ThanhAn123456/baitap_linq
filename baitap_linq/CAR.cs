using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_linq
{
    internal class CAR : VEHICLE
    {
        public string ten {  get; set; }
        public CAR(string nSX, int namSX, int gia, string ten) : base(nSX, namSX, gia)
        {
            this.ten = ten;
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine($"| Ten: {this.ten}");
        }
    }
}
