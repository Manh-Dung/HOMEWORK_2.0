package messagingsoftware;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;
/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author manhd
 */
public class ReadWriteFile {
    public static String readFile(String fileName){
        String text = "";
        try {
            File myFile = new File(fileName);
            try (Scanner myReader = new Scanner(myFile)) {
                while (myReader.hasNextLine()) {
                    String data = myReader.nextLine();
                    System.out.println(data);
                    text += data;
                }
            }
        } catch (FileNotFoundException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
        return text;
    }
    
    public static void writeFile(String fileName, String text){
        try {
            try (FileWriter myWriter = new FileWriter(fileName)) {
                myWriter.write(text);
            }
            System.out.println("Successfully wrote to the file.");
        } catch (IOException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
    }
}
