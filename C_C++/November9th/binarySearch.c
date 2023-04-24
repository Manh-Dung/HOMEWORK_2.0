#include<stdio.h>

void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

void sapXepMang(int arr[]) {   
    printf ("Mang sau khi sap xep la: ");
    for (int i = 0; i < 8; i++) {
        for (int j = i + 1; j < 8; j++) {
            if (arr[i] > arr[j]) {
                swap (&arr[i], &arr[j]);
            }
        }
        printf ("%d ", arr[i]);
    } 
}

void timKiem(int arr[], int x) {
    int right, left, mid, flag;
    flag = 0;
    left = 0;
    right = 7;
    for (; left <= right;) {
        mid = (left + right) / 2;
        printf ("\nXet mang voi Left = %d, Right = %d, Mid = %d", left, right, mid);
        if (arr[mid] == x) {
            printf ("\nX o vi tri arr[%d]", mid);
            flag = 1;
            break;
        }
        else if (arr[mid] < x) {
            left = mid + 1;
            printf ("\nX khong o vi tri arr[%d]", mid);
        }
        else {
            right = mid - 1;
            printf ("\nX khong o vi tri arr[%d]", mid);
        }
    }
    if (flag != 1) {
        printf ("\nX khong xuat hien trong mang!!");
    }
}

int main() {
    int arr[8] = {7, 9, 10, -4, 5, 8, 2, 1};
    int x = 5;
    sapXepMang(arr);
    timKiem(arr, x);
    return 0;
}
