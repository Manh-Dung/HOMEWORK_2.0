#include<stdio.h>

void timKiem(int arr[], int x) {
    int flag = 0;
    for (int i = 0; i < 8; i++) {
        printf ("\nXet phan tu a[%d]: ", i);
        if (arr[i] == x) {
            printf ("X xuat hien  trong mang o vi tri arr[%d]\n", x, i);
            flag = 1;
            break;
        }
        else {
            printf ("X khong o vi tri arr[%d]", i);
            printf ("\nMang gom nhung phan tu chua xet la: ");
            for (int j = i + 1; j < 8; j++) {
                printf ("%d ", arr[j]);
            }
        }
    }
    if (flag == 0) {
        printf ("\nKhong tim thay gia tri X trong mang!!");
    }
}

int main() {
    int arr[8] = {7, 9, 10, -4, 5, 8, 2, 1};
    int x = 5;
    timKiem(arr, x);
    return 0;
}

