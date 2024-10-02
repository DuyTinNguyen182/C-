
public class Employee {
	private String Ho, Ten;
	private Date NgaySinh, NgayVaoLam;
	public Employee(String ho, String ten, Date ngaySinh, Date ngayVaoLam) {
		this.Ho = ho;
		this.Ten = ten;
		this.NgaySinh = ngaySinh;
		this.NgayVaoLam = ngayVaoLam;
	}
	public void OutputEmployee() {
		System.out.print("\nHo ten nhan vien: "+this.Ho+" "+this.Ten);
		System.out.print("\nNgay Sinh: "+this.NgaySinh.OutputDate());
		System.out.print("\nNgay vao lam: "+this.NgayVaoLam.OutputDate());
	}
}
