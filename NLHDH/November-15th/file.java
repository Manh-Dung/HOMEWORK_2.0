import java.io.File;
public class file {
 
    public static void main(String[] args) {
        int count = new File("C:\\Users\\dung5\\OneDrive\\HOMEWORK\\NLHDH\\November-15th").list().length;
        System.out.println("Number of file : " + count);
    }
}
// Dem so luong flie va folder con trong folder cha