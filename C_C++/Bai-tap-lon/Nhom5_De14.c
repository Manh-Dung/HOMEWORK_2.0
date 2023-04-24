#include <stdio.h>
#include <math.h>

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

void swap(int *a, int *b)
{
    int temp = *a;
    *a = *b;
    *b = temp;
}

void quickSort(int a[], int n, int left, int right)
{
    int i, j, x;
    x = a[(left + right) / 2];
    i = left;
    j = right;
    do
    {
        while (a[i] < x)
            i++;
        while (a[j] > x)
            j--;
        if (i <= j)
        {
            swap(&a[i], &a[j]);
            i++;
            j--;
        }
    } while (i <= j);
    if (left < j)
        quickSort(a, n, left, j);
    if (i < right)
        quickSort(a, n, i, right);
}

int kiemTraSNT(int n)
{
    if (n < 2)
    {
        return 1;
    }

    int flag = 0;
    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
        {
            flag++;
        }
    }
    return flag;
}

void inViTriSNT(int a[], int n)
{
    printf("Cac so nguyen to trong mang o cac vi tri: ");
    for (int i = 0; i < n; i++)
    {
        if (kiemTraSNT(a[i]) == 0)
        {
            printf("%d ", i);
        }
    }
}

void inSNT(int a[], int n)
{
    printf("Cac so nguyen to trong mang: ");
    for (int i = 0; i < n; i++)
    {
        if (kiemTraSNT(a[i]) == 0)
        {
            printf("%d ", a[i]);
        }
    }
}

void xoaPhanTu(int a[], int *n, int pos)
{
    if (*n <= 0)
    {
        return;
    }
    for (int i = pos; i < *n - 1; i++)
    {
        a[i] = a[i + 1];
    }
    --(*n);
}

void xoa0(int a[], int n)
{
    printf("Xuat mang: ");

    for (int i = 0; i < n; i++)
    {
        if (a[i] == 0)
        {
            xoaPhanTu(a, &n, i);
        }
    }
    xuatMang(a, n);
}

int main()
{
    int a[100];
    int n;

    printf("Nhap so phan tu cua mang: ");
    scanf("%d", &n);

    nhapMang(a, n);
    xuatMang(a, n);
    printf("\n\n");

    int choice;
    printf("Danh sach lua chon: ");
    printf("\n1. Tao danh sach moi.");
    printf("\n2. Kiem tra so nguyen to.");
    printf("\n3. Liet ke so nguyen to.");
    printf("\n4. Xoa tat ca so 0 trong danh sach.");
    printf("\n5. Sap xep danh sach theo thu tu tang dan.");
    printf("\n6. Thoat chuong trinh.");
    do
    {
        printf("\nNhap lua chon: ");
        scanf("%d", &choice);
        switch (choice)
        {
        case 1:
        {
            nhapMang(a, n);
            xuatMang(a, n);
            printf("\n\n");
            break;
        }

        case 2:
        {
            inViTriSNT(a, n);
            break;
        }

        case 3:
        {
            inSNT(a, n);
            break;
        }

        case 4:
        {
            xoa0(a, n);
            break;
        }

        case 5:
        {
            int left = 0;
            int right = n - 1;
            quickSort(a, n, left, right);
            xuatMang(a, n);
            break;
        }
        case 6:
            break;
        }
    } while (choice != 6);
    return 0;
}
