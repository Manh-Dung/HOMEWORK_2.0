#include <stdio.h>
#define MAX 5

void nhapMang(int a[], int n)
{
    printf("Nhap mang: ");
    for (int i = 0; i < n; i++)
    {
        printf("\na[%d] = ", i);
        scanf("%d", &a[i]);
    }
}

void xuatMang(int a[], int n)
{
    printf("Xuat mang: ");

    for (int i = 0; i < n; i++)
    {
        printf("%d ", a[i]);
    }
}

void radixSort(int a[], int n)
{
    int b[MAX], max = a[0], exp = 1;

    for (int i = 0; i < n; i++)
        if (a[i] > max)
            max = a[i];

    while (max / exp > 0)
    {
        int bucket[10] = {0};
        for (int i = 0; i < n; i++)
            bucket[a[i] / exp % 10]++;
        for (int i = 1; i < 10; i++)
            bucket[i] += bucket[i - 1];
        for (int i = n - 1; i >= 0; i--)
            b[--bucket[a[i] / exp % 10]] = a[i];
        for (int i = 0; i < n; i++)
            a[i] = b[i];
        exp *= 10;
        xuatMang(a, n);
        printf("\n");
    }
}

int main()
{
    int a[100];
    int n;

    printf("Nhap so phan tu cua mang: ");
    scanf("%d", &n);
    nhapMang(a, n);
    radixSort(a, n);
    xuatMang(a, n);
    return 0;
}