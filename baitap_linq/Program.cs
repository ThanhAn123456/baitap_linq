using System.Diagnostics;

namespace baitap_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CAR> listAllCar = new List<CAR>
            {
                new CAR("Toyota", 1985, 150000,"Toyota A"),
                new CAR("Toyota", 2000, 270000, "Toyota B"),
                new CAR("Ford", 1998, 180000, "Ford A1"),
                new CAR("Ford", 2005, 300000, "Ford A22"),
                new CAR("BMW", 1892, 220000, "BMW V1"),
                new CAR("Mercedes", 1999, 240000, "Mercedes S3"),
                new CAR("Audi", 1996, 90000,"Audi M1")
            };

            Console.WriteLine("Cac xe co gia tu 100.000 den 250.000: ");
            var listCarA = listAllCar.Where(car => car.gia >= 100000 && car.gia <= 250000);
            foreach (var car in listCarA)
            {
                car.hienThi();
            }

            Console.WriteLine("Cac xe co nam san xuat > 1990: ");
            var listCarB = listAllCar.Where(car => car.namSX > 1990);
            foreach (var car in listCarB)
            {
                car.hienThi();
            }

            Console.WriteLine("Tong theo nhom hang san xuat: ");
            var listGroupCarC = listAllCar.GroupBy(car => car.NSX).Select(group => new
            {
                nSX = group.Key,
                tong = group.Sum(car => car.gia)
            });
            foreach (var group in listGroupCarC)
            {
                Console.WriteLine($"  Nha san xuat: {group.nSX} | Tong tien: {group.tong}");
            }


            List<TRUCK> listAllTruck = new List<TRUCK>
            {
            new TRUCK("Volvo", 2010, 500000, "Volvo Trucks"),
            new TRUCK("Mercedes", 2015, 600000, "Mercedes-Benz Trucks"),
            new TRUCK("MAN", 2012, 550000, "MAN Truck & Bus")
            };

            Console.WriteLine("Danh sach Truck theo thu tu nam san xuat moi nhat:");
            var listTruckA = listAllTruck.OrderByDescending(truck => truck.namSX);
            foreach (var truck in listTruckA)
            {
                truck.hienThi();
            }

            Console.WriteLine("Ten cong ty chu quan cua truck:");
            foreach (var truck in listAllTruck)
            {
                Console.WriteLine($"  Nha san xuat: {truck.NSX} | Cong ty: {truck.tenCongTy}");
            }
            Console.ReadKey();
        }
    }
}
