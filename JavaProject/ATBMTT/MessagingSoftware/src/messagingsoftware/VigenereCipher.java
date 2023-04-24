/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package messagingsoftware;


/**
 *
 * @author manhd
 */
public class VigenereCipher {

    public static String encrypt(String plainText, String key) {
        String encryptedText = "";
        plainText = plainText.toUpperCase();
        key = key.toUpperCase();
        int plainTextLength = plainText.length();
        int keyLength = key.length();
        for (int i = 0, j = 0; i < plainTextLength; i++) {
            char c = plainText.charAt(i);
            if (c < 'A' || c > 'Z') {
                continue;
            }
            encryptedText += (char) ((c + key.charAt(j) - 2 * 'A') % 26 + 'A');
            j = ++j % keyLength;
        }
        return encryptedText;
    }

    public static String decrypt(String encryptedText, String key) {
        String plainText = "";
        encryptedText = encryptedText.toUpperCase();
        key = key.toUpperCase();
        int encryptedTextLength = encryptedText.length();
        int keyLength = key.length();
        for (int i = 0, j = 0; i < encryptedTextLength; i++) {
            char c = encryptedText.charAt(i);
            if (c < 'A' || c > 'Z') {
                continue;
            }
            plainText += (char) ((c - key.charAt(j) + 26) % 26 + 'A');
            j = ++j % keyLength;
        }
        return plainText;
    }
}
