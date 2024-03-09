using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_linq
{
    internal class TRUCK : VEHICLE
    {
        public string tenCongTy {  get; set; }
        public TRUCK(string nSX, int namSX, int gia, string tencongty) : base(nSX, namSX, gia)
        {
            this.tenCongTy = tencongty;
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine($"| Cong ty: {this.tenCongTy}");
        }
    }
}
