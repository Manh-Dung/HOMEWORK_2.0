#include <iostream>
#include <fstream>
using namespace std;

int gcdExtended(int a, int b, int &x, int &y)
{
    // Nếu a = 0 thì gán giá trị x = 0, y = 1 và return b
    if (a == 0)
    {
        x = 0;
        y = 1;
        return b;
    }

    int x1, y1;
    int gcd = gcdExtended(b % a, a, x1, y1);

    // Cập nhật giá trị của x và y
    x = y1 - (b / a) * x1;
    y = x1;

    return gcd;
}

int main()
{
    int a, b, x, y;
    cout << "Nhap vao hai so nguyen duong a va b: ";
    cin >> a >> b;

    int gcd = gcdExtended(a, b, x, y);

    ofstream outputFile("kq_euclid.txt");
    outputFile << "Uoc chung lon nhat cua " << a << " va " << b << " la " << gcd << endl;
    outputFile << "Hai so nguyen x va y thoa man phuong trinh " << a << "x + " << b << "y = gcd(" << a << ", " << b << ") la: " << endl;
    outputFile << "x = " << x << ", y = " << y << endl;
    outputFile.close();

    return 0;
}
