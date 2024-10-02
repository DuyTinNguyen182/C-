import java.util.Scanner;
public class Date {
	private int Day, Month, Year;
	//constructor khong tham so
	public Date(){
	}
	Scanner ip = new Scanner(System.in);
	public void InputDate() {
		System.out.print("\nNhap vao ngay: ");
		this.Day = ip.nextInt();
		System.out.print("Nhap vao thang: ");
		this.Month = ip.nextInt();
		System.out.print("Nhap vao nam: ");
		this.Year = ip.nextInt();
		while(this.Day<0 || this.Day>31 || this.Month<0 || this.Month>12 || this.Year<1900 || this.Year>2100 || (this.Year%4!=0 && this.Month == 2 && this.Day >28)) {
			System.out.print("\nNhap sai, nhap lai!");
			System.out.print("\nNhap vao ngay: ");
			this.Day = ip.nextInt();
			System.out.print("Nhap vao thang: ");
			this.Month = ip.nextInt();
			System.out.print("Nhap vao nam: ");
			this.Year = ip.nextInt();
		}
	}
	public String OutputDate() {
		return this.Day+"/"+this.Month+"/"+this.Year;
	}
}
