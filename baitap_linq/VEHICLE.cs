using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace baitap_linq
{
    internal class VEHICLE
    {
        public string NSX {  get; set; }
        public int namSX { get; set; }
        public int gia {  get; set; }

        public VEHICLE(string nSX, int namSX, int gia)
        {
            NSX = nSX;
            this.namSX = namSX;
            this.gia = gia;
        }

        public virtual void hienThi()
        {
            Console.Write($"  Nha san xuat: {this.NSX} | Nam san xuat: {this.namSX} | Gia: {this.gia} ");
        }
    }
}
