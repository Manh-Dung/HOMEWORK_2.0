#include<stdio.h>

void nhapMang(int a[], int n) {
    printf("Nhap mang: ");
    for (int i = 0; i < n; i++) {
        printf("\na[%d] = ", i);
        scanf("%d", &a[i]);
    }
}

void xuatMang(int a[], int n){
    printf("Xuat mang: ");

    for (int i = 0; i < n; i++) {
        printf("%d ", a[i]);
    }
}

void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

void heapify(int a[], int n, int i) 
{ 
    int largest = i; 
    int l = 2*i + 1; 
    int r = 2*i + 2; 
  
    if (l < n && a[l] > a[largest]) 
        largest = l; 
  
    if (r < n && a[r] > a[largest]) 
        largest = r; 
  
    if (largest != i) 
    { 
        swap(&a[i], &a[largest]); 
  
        heapify(a, n, largest); 
        xuatMang(a, n);
        printf("\n");
    } 
} 
  
void heapSort(int a[], int n) 
{ 
    for (int i = n / 2 - 1; i >= 0; i--) 
        heapify(a, n, i); 
    
    for (int i = n - 1; i > 0; i--) 
    { 
        swap(&a[0], &a[i]); 
  
        heapify(a, i, 0); 
        xuatMang(a, n);
        printf("\n");
    } 
} 

int main() {
    int a[100];
    int n;

    printf("Nhap so phan tu cua mang: ");
    scanf("%d", &n);

    nhapMang(a, n);
    heapSort(a, n); 
    xuatMang(a, n);
    return 0;
}

