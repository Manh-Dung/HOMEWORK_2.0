#include <iostream>
#include <string>

using namespace std;

string caesarDecipher(string text, int shift)
{
    string result = "";
    for (int i = 0; i < text.length(); i++)
    {
        char c = text[i];
        if (isalpha(c))
        {
            c = toupper(c);                     
            c = (((c - 65) - shift + 26) % 26) + 65; 
        }
        result += c;
    }
    return result;
}

int main()
{
    string text;
    cout << "Nhap van ban da duoc ma hoa: ";
    getline(cin, text);

    int shift;
    cout << "Nhap so buoc dich vong: ";
    cin >> shift;

    string decrypted = caesarDecipher(text, shift);
    cout << "Van ban da giai ma: " << decrypted << endl;

    return 0;
}

