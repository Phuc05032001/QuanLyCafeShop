using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeShop
{
    class TimKiem
    {
        public void TKSanPham()
        {
            DSSanPham sp = new DSSanPham();
            sp.DocTep();
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 3); Console.WriteLine(" _______________TÌM KIẾM SẢN PHẨM_____________ ");
                Console.SetCursorPosition(20, 4); Console.WriteLine("|     1. Tìm Kiếm Theo Mã Sản Phẩm            |");
                Console.SetCursorPosition(20, 5); Console.WriteLine("|     2. Tìm Kiếm Theo Tên Sản Phẩm           |");
                Console.SetCursorPosition(20, 6); Console.WriteLine("|     3. Tìm Kiếm Theo Giá Sản Phẩm           |");
                Console.SetCursorPosition(20, 7); Console.WriteLine("|     4. Quay Lại                             |");
                Console.SetCursorPosition(20, 8); Console.WriteLine("|_____________________________________________|");
                Console.SetCursorPosition(20, 10); Console.Write("Nhập công việc bạn muốn thực hiện: ");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(10, 3); Console.WriteLine("*---------------TÌM KIẾM SẢN PHẢM THEO MÃ-----------------*");
                        Console.SetCursorPosition(10, 5); Console.Write("Nhập mã sản phẩm cần tìm kiếm: ");
                        string ma = Console.ReadLine();
                        sp.TKMa(ma); Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(10, 3); Console.WriteLine("*---------------TÌM KIẾM SẢN PHẢM THEO TÊN SP-----------------*");
                        Console.SetCursorPosition(10, 5); Console.Write("\n\t\tNhập tên sản phẩm cần tìm kiếm: ");
                        string b = Console.ReadLine();
                        sp.TKTen(b); Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(10, 3); Console.WriteLine("*---------------TÌM KIẾM SẢN PHẢM THEO GiÁ SP-----------------*");
                        sp.TKGia(); Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        MenuTK(); break;
                }
            }
        }
        public void TKPhieuNhap()
        {
            DSPhieuNhap pn = new DSPhieuNhap();
            pn.DocTepPN();
            pn.DocTepCT();
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 3); Console.WriteLine(" _________TÌM KIẾM HÓA ĐƠN NHẬP HÀNG__________ ");
                Console.SetCursorPosition(20, 4); Console.WriteLine("|     1. Tìm kiếm theo mã                     |");
                Console.SetCursorPosition(20, 5); Console.WriteLine("|     2. Tìm kiếm theo tên nhà cung cấp       |");
                Console.SetCursorPosition(20, 6); Console.WriteLine("|     3. Tìm kiếm theo ngày nhập sản phẩm     |");
                Console.SetCursorPosition(20, 7); Console.WriteLine("|     4. Quay Lại                             |");
                Console.SetCursorPosition(20, 8); Console.WriteLine("|_____________________________________________|");
                Console.SetCursorPosition(20, 10); Console.Write("     Chọn công việc: ");
                int b = int.Parse(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(20, 3); Console.WriteLine("*---------------TÌM KIẾM PHIẾU NHẬP THEO MÃ----------------*");
                        pn.TKMa(); Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(20, 3); Console.WriteLine("*---------------TÌM KIẾM PHIẾU NHẬP THEO NGÀY----------------*");
                        pn.TKNgay();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(20, 3); Console.WriteLine("*---------------TÌM KIẾM PHIẾU NHẬP THEO TÊN NCC----------------*");
                        pn.TKTen(); Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        MenuTK(); break;
                }
            }
        }
        public void TKHoaDon()
        {
            DSHoaDon hd = new DSHoaDon();
            hd.DocTepHD();
            hd.DocTepCT();
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 3); Console.WriteLine(" __________TÌM KIẾM HÓA ĐƠN BÁN HÀNG__________ ");
                Console.SetCursorPosition(20, 4); Console.WriteLine("|     1. Tìm kiếm theo mã hóa đơn             |");
                Console.SetCursorPosition(20, 5); Console.WriteLine("|     2. Tìm kiếm theo tên khách hàng         |");
                Console.SetCursorPosition(20, 6); Console.WriteLine("|     3. Tìm kiếm theo ngày bán sản phẩm      |");
                Console.SetCursorPosition(20, 7); Console.WriteLine("|     4. Quay lại                             |");
                Console.SetCursorPosition(20, 8); Console.WriteLine("|_____________________________________________|");
                Console.SetCursorPosition(20, 10); Console.Write(" Chọn công việc bạn muốn thực hiện: ");
                int b = int.Parse(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(20, 3); Console.WriteLine("*-----------------TÌM KIẾM HÓA ĐƠN BÁN HÀNG THEO MÃ HD-----------------*");
                        hd.TKMa(); Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(20, 3); Console.WriteLine("*-----------------TÌM KIẾM HÓA ĐƠN BÁN HÀNG THEO TÊN KH-----------------*");
                        hd.TKTen(); Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(20, 3); Console.WriteLine("*-----------------TÌM KIẾM HÓA ĐƠN BÁN HÀNG THEO NGÀY-----------------*");
                        hd.TKNgay();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        MenuTK(); break;
                }
            }
        }
        public void MenuTK()
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 5); Console.WriteLine("*----------------TÌM KIẾM------------------*");
                Console.SetCursorPosition(20, 6); Console.WriteLine("*     1. Tìm Kiếm Hóa Đơn Nhập             *");
                Console.SetCursorPosition(20, 7); Console.WriteLine("*     2. Tìm Kiếm Sản Phẩm                 *");
                Console.SetCursorPosition(20, 8); Console.WriteLine("*     3. Tìm Kiếm Hóa Đơn Bán Hàng         *");
                Console.SetCursorPosition(20, 9); Console.WriteLine("*     4. Quay Lại                          *");
                Console.SetCursorPosition(20, 10); Console.WriteLine("*     5. Thoát                             *");
                Console.SetCursorPosition(20, 11); Console.WriteLine("*------------------------------------------*");
                Console.SetCursorPosition(20, 12); Console.Write("  Mời Bạn Chọn Công Việc (1-5): ");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.Clear();
                        TKPhieuNhap(); Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        DSSanPham sp = new DSSanPham();
                        sp.DocTep();
                        TKSanPham();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        TKHoaDon(); Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        MenuQL a = new MenuQL();
                        a.MenuChinh();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
    class MenuQL
    {

        public void MenuChinh()
        {

            Console.SetCursorPosition(20, 5); Console.WriteLine(" =============================================================================");
            Console.SetCursorPosition(20, 6); Console.WriteLine(" ||               =======>  QUẢN LÝ CAFE SHOP  <=======               ||");
            Console.SetCursorPosition(20, 7); Console.WriteLine(" ||                                                                          ||");
            Console.SetCursorPosition(20, 8); Console.WriteLine(" ||   1. Quản Lý Sản Phẩm            ||       4. Tìm Kiếm Thông Tin          ||");
            Console.SetCursorPosition(20, 9); Console.WriteLine(" ||                                  ||                                      ||");
            Console.SetCursorPosition(20, 10); Console.WriteLine(" ||   2. Quản Lý Hóa Đơn Nhập        ||       5. Thống Kê Doanh Thu          ||");
            Console.SetCursorPosition(20, 11); Console.WriteLine(" ||                                  ||                                      ||");
            Console.SetCursorPosition(20, 12); Console.WriteLine(" ||   3. Quản Lý Hóa Đơn Bán Hàng    ||       6. Thoát Khỏi Chương Trình     ||");
            Console.SetCursorPosition(20, 13); Console.WriteLine(" ||                                                                          ||");
            Console.SetCursorPosition(20, 14); Console.WriteLine(" =============================================================================");
            Console.SetCursorPosition(20, 16); Console.Write(" Mời Bạn Chọn Công Việc (1-6): ");
            int t = int.Parse(Console.ReadLine());
            do
            {
                switch (t)
                {
                    case 1:
                        Console.Clear();
                        DSSanPham dssp = new DSSanPham();
                        dssp.MenuSP(); Console.ReadKey();
                        Console.ReadKey();
                        break;
                    case 2:
                        DSPhieuNhap dspn = new DSPhieuNhap();
                        dspn.MenuPhieuNhap(); Console.ReadKey();
                        Console.ReadKey();
                        break;
                    case 3:
                        DSHoaDon dshd = new DSHoaDon();
                        dshd.MenuHD(); Console.ReadKey();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        TimKiem tk = new TimKiem();
                        tk.MenuTK();
                        Console.ReadKey();
                        break;
                    case 5:
                       DoanhThu dt = new DoanhThu();
                        dt.MenuDT(); Console.ReadKey();
                        Console.ReadKey();
                        break;
                    case 6: Environment.Exit(0); break;
                }
            } while (true);
        }
    }
    class Program
    {
        static void TaiKhoan()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            // Console.Clear();
            string tk;
            string mk = "";
            int d = 0;
            ConsoleKeyInfo[] pas = new ConsoleKeyInfo[20];
            do
            {
                Console.Clear();
                Console.WriteLine("                         ********************************************************");
                Console.WriteLine("                         *                       ĐỒ ÁN 1                        *");
                Console.WriteLine("                         *      XÂY DỰNG HỆ THỐNG QUẢN LÝ CỬA HÀNG MỸ PHẨM      *");
                Console.WriteLine("                         *......................................................*");
                Console.WriteLine("                         *                                                      *");
                Console.WriteLine("                         *   Giáo Viên Hướng Dẫn: Ths: Trần Đỗ Thu Hà           *");
                Console.WriteLine("                         *      Sinh Viên Thực Hiện  : Nguyễn Thu Hằng          *");
                Console.WriteLine("                         *                                                      *");
                Console.WriteLine("                         ********************************************************");
                Console.WriteLine("             \n");
                Console.SetCursorPosition(30, 11); Console.Write(" _________________________________________");
                Console.SetCursorPosition(30, 12); Console.Write("|                 ĐĂNG NHẬP               |");
                Console.SetCursorPosition(30, 13); Console.Write("|-----------------------------------------|");
                Console.SetCursorPosition(30, 14); Console.Write("|                                         |");
                Console.SetCursorPosition(30, 15); Console.Write("|  Tài Khoản:");
                Console.SetCursorPosition(67, 15); Console.Write("|");
                Console.SetCursorPosition(30, 15); Console.Write("|");
                Console.SetCursorPosition(30, 16); Console.Write("|");
                Console.SetCursorPosition(43, 14); Console.Write(" ____________________");
                Console.SetCursorPosition(43, 15); Console.Write("|                    |       |");
                Console.SetCursorPosition(43, 16); Console.Write("|____________________|       |");
                Console.SetCursorPosition(30, 17); Console.Write("|                                         |");
                Console.SetCursorPosition(30, 18); Console.Write("|                                         |");
                Console.SetCursorPosition(30, 19); Console.Write("|  Mật Khẩu:");
                Console.SetCursorPosition(67, 19); Console.Write("|");
                Console.SetCursorPosition(30, 18); Console.Write("|");
                Console.SetCursorPosition(30, 19); Console.Write("|");
                Console.SetCursorPosition(30, 20); Console.Write("|");
                Console.SetCursorPosition(43, 18); Console.Write(" ____________________");
                Console.SetCursorPosition(43, 19); Console.Write("|                    |       |");
                Console.SetCursorPosition(43, 20); Console.Write("|____________________|       |");
                Console.SetCursorPosition(30, 21); Console.Write("|                                         |");
                Console.SetCursorPosition(30, 22); Console.Write("|_________________________________________|");
                Console.SetCursorPosition(44, 15); tk = Console.ReadLine();
                Console.SetCursorPosition(44, 20);
                int i = 0, j = 44;
                do
                {
                    Console.SetCursorPosition(j, 19);//Đặt giao diện vị trí con trỏ (trái sang, trên)
                    pas[i] = Console.ReadKey();

                    if (pas[i].Key != ConsoleKey.Backspace)//Kiểm tra có phải là phím Backspace hay không
                    {
                        Console.SetCursorPosition(j, 19);
                        Console.Write("*");
                        mk = mk + pas[i].KeyChar.ToString();
                        j++;
                        i++;
                    }
                    else
                    {
                        if (i != 0)
                        {
                            j--;
                            Console.SetCursorPosition(j, 19);
                            Console.Write(" ");
                            mk = mk.Remove(mk.Length - 1, 1);
                            Console.SetCursorPosition(j, 19);
                        }
                    }

                }
                while (pas[i - 1].Key != ConsoleKey.Enter);//Kiểm tra có phải là phím Enter hay không


                Console.WriteLine("\n");

                mk = mk.Remove(mk.Length - 1, 1);

                if (tk != "hang" || mk != "10117312")
                {
                    Console.SetCursorPosition(24, 25);
                    Console.WriteLine("Tên tài khoản hoặc mật khẩu đăng nhập không chính xác! Vui lòng nhập lại.");
                    d = d + 1;
                    Console.SetCursorPosition(26, 27);
                    Console.Write("Bạn Có Muốn Đăng Nhập Lại Không?(C/K)");
                    string kt = Console.ReadLine();
                    if (kt == "c" || kt == "C")
                    {
                        Console.Clear();
                    }
                    else
                        Environment.Exit(0);// Thoát khỏi chương trình
                }

            } while ((tk != "hang" || mk != "10117312") && (d != 3));
            if (d == 3)
            {
                Console.SetCursorPosition(25, 15);
                Console.Write("*** BẠN ĐÃ ĐĂNG NHẬP QUÁ BA LẦN VUI LÒNG QUAY LẠI SAU !***");
            }
            else
            {
                if (tk == "hang" && mk == "10117312")
                {
                    Console.Clear();
                    MenuQL ql = new MenuQL();
                    ql.MenuChinh();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MenuQL ql = new MenuQL();
            ql.MenuChinh();
            Console.ReadKey();//lệnh này dùng với mục đích dừng màn hình để xem kết quả.
        }
    }
}