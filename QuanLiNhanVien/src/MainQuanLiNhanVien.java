import java.util.Scanner;
public class MainQuanLiNhanVien {
	public static void main(String[] args) {
		String ho,ten;
		
		Scanner ip = new Scanner(System.in);
		Date ngayvaolam = new Date();
		Date ngaysinh = new Date();
		int soluongnv;
		System.out.print("\nNhap vao so luong nhan vien: ");
		soluongnv = ip.nextInt();
		Employee[] A = new Employee[soluongnv];
		ip.nextLine();
		//Them thong tin vao n nhan vien:
		for(int i=0 ; i<soluongnv ; i++) {
			System.out.print("\nNhap vao thong tin nhan vien thu "+(i+1));
			System.out.print("\nNhap vao ho nhan vien: ");
			ho = ip.nextLine();
			System.out.print("Nhap vao ten nhan vien: ");
			ten = ip.nextLine();
			System.out.print("Nhap ngay sinh: ");
			ngaysinh.InputDate();
			System.out.print("Nhap ngay vao lam: ");
			ngayvaolam.InputDate();
		    A[i] = new Employee(ho, ten, ngaysinh, ngayvaolam);
		}
		//Xuat thong tin n nhan vien: 
		for(int i=0 ; i<soluongnv ; i++) {
			System.out.print("\nThong tin nhan vien thu "+(i+1));
			A[i].OutputEmployee();
		}
		
	}

}
