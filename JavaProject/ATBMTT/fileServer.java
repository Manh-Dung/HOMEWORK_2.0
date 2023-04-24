import java.io.*;
import java.net.*;

public class fileServer {
    public static void main(String[] args) throws IOException {
        // Server sẽ tạo một đối tượng ServerSocket và lắng nghe kết nối đến cổng 8888
        ServerSocket serverSocket = new ServerSocket(8887);
        System.out.println("Waiting for connection...");

        // Khi có một kết nối được thiết lập, server sẽ chấp nhận kết nối đó bằng cách gọi phương thức accept() của ServerSocket 
        Socket clientSocket = serverSocket.accept();
        System.out.println("Connected to " + clientSocket.getInetAddress().getHostAddress());

        // Tạo một đối tượng Socket để truyền dữ liệu với client
        InputStream inputStream = clientSocket.getInputStream();
        DataInputStream dataInputStream = new DataInputStream(inputStream);

        // Server sẽ nhận tên tệp từ client bằng cách đọc một chuỗi UTF từ luồng đầu vào của client bằng phương thức readUTF() của DataInputStream
        String fileName = dataInputStream.readUTF();
        // Server sẽ tạo một đối tượng FileOutputStream để ghi dữ liệu của tệp được truyền đến từ client
        FileOutputStream fileOutputStream = new FileOutputStream(fileName);

        byte[] buffer = new byte[4096];
        int bytesRead;
        // Vòng lặp while được sử dụng để đọc dữ liệu từ luồng đầu vào của client và ghi nó vào tệp đích
        // Khi không còn dữ liệu nào được truyền đến, vòng lặp sẽ kết thúc
        while ((bytesRead = inputStream.read(buffer)) != -1) {
            fileOutputStream.write(buffer, 0, bytesRead);
        }
        
        System.out.println("File received: " + fileName);

        fileOutputStream.close();
        dataInputStream.close();
        clientSocket.close();
        serverSocket.close();
    }
}
