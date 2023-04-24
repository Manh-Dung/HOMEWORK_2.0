#include<stdio.h>

// Ham doi gia tri 2 bien
void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

void sapXepMang(int a[]){
    int left = 0;
    int right = 8; // 8 = n - 1 voi n la so phan tu trong mang
    int mid; // so 0 se o vi tri a[mid]
    int i, j, x;

    // 2 vong for long sap xep mang theo thu tu tang dan
    for (i = 0; i < 8; i++) {
        for (j = i + 1; j < 9; j++){
            if (a[i] > a[j]) {
                swap (&a[i], &a[j]);
            }
        }
    }

    mid = (right + left) / 2;

    // Tim kiem vi tri cua so 0 bang cach su dung binary search va chen so 0 vao a[mid] bang insertion sort
    if (a[mid] < 0) { // Neu gia tri a[mid] hien tai nho hon 0 thi so 0 o ben phai cua mang
        left = mid + 1;

        // Gan a[mid] = 0 va day cac phan tu con lai sang phai
        for (i = left; i <= right; i++) {
            if (a[i] == 0) {
                for (j = i - mid; j >= 1; j--){
                    a[mid + j] = a[mid + j - 1];
                }
                a[mid] = 0;
            }  
        }
    }

    // Tim kiem vi tri cua so 0 bang cach su dung binary search va chen so 0 vao a[mid] bang insertion sort
    else if(a[mid] > 0){ // Neu gia tri a[mid] hien tai lon hon 0 thi so 0 o ben trai cua mang
        right = mid - 1;

        // Gan a[mid] = 0 va day cac phan tu con lai sang trai
        for (i = right; i >= left; i--) {
            if (a[i] == 0) {
                for (j = mid - i; j >= 1; j--){
                    a[mid - j] = a[mid - j + 1];
                }
                a[mid] = 0;
            }  
        }
    }
    

    // Sap xep cac phan tu cua mang ben phai so 0 theo chieu giam dan
    left = mid + 1;
    right = 8;
    for (i = left; i < right; i++) {
        for (j = i + 1; j <= right; j++){
            if (a[i] < a[j]) {
                swap (&a[i], &a[j]);
            }
        }
    }

    // In mang
    for (x = 0; x < 9; x++){
        printf("%d ", a[x]);
    }

}

int main(){
    int a[9] = {3, 6, 1, -1, 0, 5, 8, 2, 4};
    sapXepMang(a);
    return 0;
}

