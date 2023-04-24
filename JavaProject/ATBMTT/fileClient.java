import java.io.*;
import java.net.*;

public class fileClient {
    public static void main(String[] args) throws IOException {
        // Tạo đối tượng Socket với địa chỉ IP và cổng của máy tính nhận file
        Socket socket = new Socket("192.168.62.98", 8888); // Với tùy máy và tùy ứng dụng, đa số 1 ứng dụng chỉ có thể sử dụng 1 cổng
        System.out.println("Connected to server");

        // Lấy đối tượng OutputStream từ socket để ghi dữ liệu đến máy tính nhận file.
        OutputStream outputStream = socket.getOutputStream();
        // Tạo đối tượng DataOutputStream từ outputStream để ghi dữ liệu định dạng
        DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

        // Gửi tên file tới máy tính nhận file bằng cách sử dụng phương thức writeUTF của đối tượng DataOutputStream.
        String fileName = "example.txt";
        dataOutputStream.writeUTF(fileName);

        // Mở file và đọc từng phần dữ liệu từ file và ghi vào đối tượng OutputStream để gửi đi.
        FileInputStream fileInputStream = new FileInputStream(fileName);
        byte[] buffer = new byte[4096];
        int bytesRead;
        while ((bytesRead = fileInputStream.read(buffer)) != -1) {
            outputStream.write(buffer, 0, bytesRead);
        }

        System.out.println("File sent: " + fileName);

        fileInputStream.close();
        dataOutputStream.close();
        outputStream.close();
        socket.close();
    }
}

