#include <stdio.h>

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

void swap(int *a, int *b) {
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
            xuatMang(a, n);
            printf("\n");
            i++;
            j--;
        }
    } while (i <= j);
    if (left < j)
        quickSort(a, n, left, j);
    if (i < right)
        quickSort(a, n, i, right);
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

    int left = 0;
    int right = n - 1;
    quickSort(a, n, left, right);

    xuatMang(a, n);
    return 0;
}
