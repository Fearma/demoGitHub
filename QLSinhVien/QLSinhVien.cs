
namespace QLSinhVien;

class QLSinhVien
{
    private List<SinhVien> ListSinhVien = null;
 
    public QLSinhVien() {
        ListSinhVien = new List<SinhVien>();
    }
    
    
    // id tu tang
    private int GenerateID()
    {
        int max = 1;
        if (ListSinhVien != null && ListSinhVien.Count > 0)
        {
            max = ListSinhVien[0].maSv;
            foreach (SinhVien sv in ListSinhVien)
            {
                if (max < sv.maSv)
                {
                    max = sv.maSv;
                }
            }
            max++;
        }
        return max;
    }
    
    public int SoLuongSinhVien()
    {
        int Count = 0;
        if (ListSinhVien != null)
        {
            Count = ListSinhVien.Count;
        }
        return Count;
    }
    // nhap sv
    public void insertSV()
    {
        // Khởi tạo một sinh viên mới
        SinhVien sv = new SinhVien();
        sv.maSv = GenerateID();
        Console.Write("Nhap ten sinh vien: ");
        sv.name = Console.ReadLine();
 
        Console.Write("Nhap ngay sinh sinh vien: ");
        sv.date = Console.ReadLine();
 
        Console.Write("Nhap dia chi sinh vien: ");
        sv.address = Console.ReadLine();
 
        Console.Write("Nhap so dien thoai : ");
        sv.phone = Console.ReadLine();
        
        Console.Write("Nhap lop : ");
        sv.classSV = Console.ReadLine().ToUpper();
        
        ListSinhVien.Add(sv);
    }
    
 // update   
    public void UpdateSinhVien(int maSV)
{
    SinhVien sv = FindByID(maSV);
    if (sv != null)
    {
        Console.Write("Nhap ten sinh vien: ");
        string name = Console.ReadLine();
        if (name != null && name.Length > 0)
        {
            sv.name = name;
        }
 
        Console.Write("Nhap ngay sinh sinh vien: ");
        string date = Console.ReadLine();
        if (date != null && date.Length > 0)
        {
            sv.date = date;
        }
 
        Console.Write("Nhap dia chi sinh vien: ");
        string address = Console.ReadLine();
        if (address != null && address.Length > 0)
        {
            sv.address = address;
        }
 
        Console.Write("Nhap so dien thoai Sinh Vien: ");
        string phone = Console.ReadLine();
        if (phone != null && phone.Length > 0)
        {
            sv.phone = phone;
        }
 
        Console.Write("Nhap lop cua Sinh Vien: ");
        string classSV = Console.ReadLine();
        if (classSV != null && classSV.Length > 0)
        {
            sv.classSV = classSV;
        }
    }
    else
    {
        Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", maSV);
    }
}
    // xoa sinh vien
    public bool DeleteById(int maSv)
    {
        bool IsDeleted = false;
        SinhVien sv = FindByID(maSv);
        if (sv != null)
        {
            IsDeleted = ListSinhVien.Remove(sv);
        }
        return IsDeleted;
    }
    // hien thi ds sinh vien   
    public void ShowSinhVien(List<SinhVien> listSV)
    {
        Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} ",
            "MaSV", "Name", "Date", "Address", "Phone", "Class");
        if (listSV != null && listSV.Count > 0)
        {
            foreach (SinhVien sv in listSV)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} ",
                    sv.maSv, sv.name, sv.date, sv.address, sv.phone, sv.classSV);
            }
        }
        Console.WriteLine();
    }
    
    public void ShowByClass(List<SinhVien> ListSV)
    {
        Console.Write("Nhap lop can hien thi: ");
        string classSV = Console.ReadLine().ToUpper();
        
        Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5}",
            "MaSV", "Name", "Date", "Address", "Phone");
        for (int i = 0; i < ListSinhVien.Count; i++)
        {
            if (classSV.CompareTo(ListSinhVien[i].classSV) == 0)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} ", 
                    ListSinhVien[i].maSv, ListSinhVien[i].name, ListSinhVien[i].date, ListSinhVien[i].address, ListSinhVien[i].phone);
            }
        }
    }
    public List<SinhVien> getListSinhVien()
    {
        return ListSinhVien;
    }
    
    

    public SinhVien FindByID(int ID)
    {
        SinhVien searchResult = null;
        if (ListSinhVien != null && ListSinhVien.Count > 0)
        {
            foreach (SinhVien sv in ListSinhVien)
            {
                if (sv.maSv == ID)
                {
                    searchResult = sv;
                }
            }
        }
        return searchResult;
    }
}