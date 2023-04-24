#include<stdio.h>

void swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

void sapXepMang(int arr[]) {
    int stt = 0;
    for (int i = 0; i < 7; i++){
        for (int j = 7; j > i; j --) {
            if (arr[j] < arr[j-1]){
                swap(&arr[j], &arr[j-1]);
                stt++;
                printf ("\n%d. Mang sau khi sap xep la: ", stt);
                for (int x = 0; x < 8; x++) {
                    printf ("%d ", arr[x]);
                }
            }
        }
    }
}
int main() {
    int arr[8] = {7, 9, 10, -4, 5, 8, 2, 1};
    printf ("0. Mang ban dau la: ");
    for (int i = 0; i < 8; i++) {
        printf ("%d ", arr[i]);
    }
    sapXepMang(arr);
    return 0;
}