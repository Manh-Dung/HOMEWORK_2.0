#include<stdio.h>

void nhapMang(int a[], int n) {
    printf("Nhap mang: ");
    for (int i = 0; i < n; i++) {
        printf("\na[%d] = ", i);
        scanf("%d", &a[i]);
    }
}

void xuatMang(int a[], int n){
    printf("\nXuat mang: ");

    for (int i = 0; i < n; i++) {
        printf("%d ", a[i]);
    }
}

// Ham doi gia tri 2 bien
void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}


// Ham sap xep giam dan mang a[]
void descending(int a[], int n){
    for (int i = 0; i < n - 1; i++) {
        for (int j = i + 1; j < n; j++){
            if (a[i] < a[j]) {
                swap (&a[i], &a[j]);
            }
        }
    }
}

// Ham sap xep tang dan cac phan tu nam sau so 0
void ascending(int a[], int n) {
    int flag;

    descending(a, n);

    for (int i = 0; i < n; i++) {
        if (a[i] == 0) {
            flag = i + 1;
            for (int x = flag; x < n - 1; x++) {
                for (int y = x + 1; y < n; y++){
                    if (a[x] > a[y]) {
                        swap (&a[x], &a[y]);
                    }
                }
            }
        }
    } 
}

int main() {
    int a[100];
    int n;

    printf("Nhap so phan tu cua mang: ");
    scanf("%d", &n);

    nhapMang(a, n);
    ascending(a, n);
    xuatMang(a, n);
    return 0;
}
