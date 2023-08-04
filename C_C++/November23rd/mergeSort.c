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

void merge(int a[], int length, int l, int m, int r)
{
    int i, j, k;
    int n1 = m - l + 1;
    int n2 = r - m;

    int L[n1], R[n2];

    for (i = 0; i < n1; i++)
        L[i] = a[l + i];
    for (j = 0; j < n2; j++)
        R[j] = a[m + 1 + j];

    i = 0;
    j = 0;
    k = l;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            a[k] = L[i];
            i++;
        }
        else
        {
            a[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        a[k] = L[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        a[k] = R[j];
        j++;
        k++;
    }
    xuatMang(a, length);
    printf("\n");
}

void mergeSort(int a[], int length, int l, int r)
{
    if (l < r)
    {
        int m = l + (r - l) / 2;

        mergeSort(a, length, l, m);
        mergeSort(a, length, m + 1, r);

        merge(a, length, l, m, r);
        
    }
}

int main()
{
    int a[100];
    int n;

    printf("Nhap so phan tu cua mang: ");
    scanf("%d", &n);

    nhapMang(a, n);
    mergeSort(a, n, 0, n - 1);
    return 0;
}