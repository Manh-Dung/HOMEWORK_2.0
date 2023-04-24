#include <stdio.h>

int giaiThua(int n){
    if (n == 0 || n == 1) return 1;
    else return n * giaiThua (n - 1);
}

// 0 1 1 2 3 5 8

int fibonacci(int n){
    if (n == 0) return 0;
    if (n == 1) return 1;
    if (n == 2) return 1;
    if (n >= 3) return fibonacci(n - 1) + fibonacci(n - 2);
}

int main(){
    int n;
    printf ("Nhap n: ");
    scanf ("%d", &n);
    printf ("n giai thua  = %d", giaiThua(n));
    printf ("\nSo o vi tri thu n cua day fibonacci la: %d", fibonacci(n));
}