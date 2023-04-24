/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package messagingsoftware;

import java.io.*;
import java.net.*;
import java.util.ArrayList;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

/**
 *
 * @author manhd
 */
public class FileTransfer {

    public static void fileSend(String host) throws IOException {
        Socket socket = new Socket(host, 8888); // địa chỉ IP của máy tính chia sẻ file
        System.out.println("Connected to server");

        OutputStream outputStream = socket.getOutputStream();
        DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

        String fileName = "example.txt";
        dataOutputStream.writeUTF(fileName);

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

    public static void fileReveiced() throws IOException {
        boolean checkIp = false;
        ServerSocket serverSocket = new ServerSocket(8888);
        System.out.println("Waiting for connection...");

        ArrayList<String> ipList = new ArrayList<String>();
        ipList.add("192.168.1.11");

        Socket clientSocket = serverSocket.accept();
        for (String str : ipList) {
            if (clientSocket.getInetAddress().getHostAddress().equals(str)) {
                checkIp = true;
                break;
            }
        }
        if (checkIp) {
            System.out.println("Connected to " + clientSocket.getInetAddress().getHostAddress());
            InputStream inputStream = clientSocket.getInputStream();
            DataInputStream dataInputStream = new DataInputStream(inputStream);

            String fileName = dataInputStream.readUTF();
            FileOutputStream fileOutputStream = new FileOutputStream(fileName);

            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = inputStream.read(buffer)) != -1) {
                fileOutputStream.write(buffer, 0, bytesRead);
            }

            System.out.println("File received: " + fileName);

            fileOutputStream.close();
            dataInputStream.close();
            clientSocket.close();
            serverSocket.close();
        } else {
            JFrame frame = new JFrame("JOptionPane showMessageDialog example");
            JOptionPane.showMessageDialog(frame,
                    "Strange ip address is trying to send file to your device",
                    "Warning! Strange IP address",
                    JOptionPane.WARNING_MESSAGE);
        }
    }
}
