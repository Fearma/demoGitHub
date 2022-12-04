namespace QuanLySinhVien;

public class SinhVien : lop
{
    public string maSinhVien;
    public string tenSinhVien;
    public string ngaySinh;
    public string diaChi;
    public string soDienThoai;

    public void nhap(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Nhap thong tin");
        Console.Write("Ma sinh vien: ");
        this.maSinhVien = Console.ReadLine().ToUpper();
        Console.Write("Ho ten: ");
        this.tenSinhVien = Console.ReadLine();
        Console.Write("Ngay sinh: ");
        this.ngaySinh = Console.ReadLine();
        Console.Write("Dia chi: ");
        this.diaChi = Console.ReadLine();
        Console.Write("So dien thoai: ");
        this.soDienThoai = Console.ReadLine();
        Console.Write("Ten lop");
        this.tenLop = Console.ReadLine().ToUpper();
        danhSachSinhVien.Add(this);
    }

    public void hienThi(List<SinhVien> danhSachSinhVien)
    {
        for (int i = 0; i < danhSachSinhVien.Count; i++)
        {
            Console.WriteLine("Thong tin cac sinh vien:");
            Console.WriteLine("Sinh vien " + (i + 1) + " :");
            Console.WriteLine("Ma sinh vien: " + danhSachSinhVien[i].tenSinhVien);
            Console.WriteLine("Ho ten: " + danhSachSinhVien[i].tenSinhVien);
            Console.WriteLine("Ngay sinh" + danhSachSinhVien[i].ngaySinh);
            Console.WriteLine("Dia chi" + danhSachSinhVien[i].diaChi);
            Console.WriteLine("So dien thoai" + danhSachSinhVien[i].soDienThoai);
        }
    }
    
    public void hienThiTheoLop(List<SinhVien> danhSachSinhVien)
    {
        Console.Write("Nhap lop can hien thi: ");
        string tenlop = Console.ReadLine().ToUpper();
        for (int i = 0; i < danhSachSinhVien.Count; i++)
        {
            if (tenlop.CompareTo(danhSachSinhVien[i].tenLop) == 0)
            {
                Console.WriteLine("Thong tin cac sinh vien:");
                Console.WriteLine("Sinh vien " + (i + 1) + " :");
                Console.WriteLine("Ma sinh vien: " + danhSachSinhVien[i].tenSinhVien);
                Console.WriteLine("Ho ten: " + danhSachSinhVien[i].tenSinhVien);
                Console.WriteLine("Ngay sinh" + danhSachSinhVien[i].ngaySinh);
                Console.WriteLine("Dia chi" + danhSachSinhVien[i].diaChi);
                Console.WriteLine("So dien thoai" + danhSachSinhVien[i].soDienThoai);
            }
        }
    }
    
    public void suaSinhVien(List<SinhVien> danhSachSinhVien)
    {
        int n;
        Console.Write("Nhap ma sinh vien can sua: ");
        string maSV = Console.ReadLine().ToUpper();
        for (int i = 0; i < danhSachSinhVien.Count; i++)
        {
            if (maSV.CompareTo(danhSachSinhVien[i].maSinhVien) == 0)
            {
                do
                {
                    Console.Write("Chon thong tin muon sua: ");
                    Console.WriteLine("1. Ho ten");
                    Console.WriteLine("2. Ngay sinh");
                    Console.WriteLine("3. Dia chi");
                    Console.WriteLine("4. So dien thoai");
                    Console.WriteLine("5. Lop");
                    Console.Write("Ban se chon: ");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            danhSachSinhVien[i].tenSinhVien = Console.ReadLine();
                            break;
                        case 2:
                            danhSachSinhVien[i].ngaySinh = Console.ReadLine();
                            break;
                        case 3:
                            danhSachSinhVien[i].diaChi = Console.ReadLine();
                            break;
                        case 4:
                            danhSachSinhVien[i].soDienThoai = Console.ReadLine();
                            break;
                        case 5:
                            danhSachSinhVien[i].tenLop = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Chon sai");
                            break;
                    }
                } while (n != 6);
            }
        }
    }
    
    public void xoaSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.Write("Nhap ma sinh vien can xoa: ");
        string maSV = Console.ReadLine().ToUpper();
        for (int i = 0; i < danhSachSinhVien.Count; i++)
        {
            if (maSV.CompareTo(danhSachSinhVien[i].maSinhVien) == 0)
            {
                danhSachSinhVien.RemoveAt(i);
            }
        }
    }
}