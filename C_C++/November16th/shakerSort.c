#include <stdio.h>

void swap(int *a, int *b){
    int temp = *a;
    *a = *b;
    *b = temp;
}

void sapXepMang(int a[]){
    int left = 0;
    int right = 8;
    int flag = 0;
    int count = 0;

    printf ("%d. Mang khi chua sap xep la: ", count);
    for (int i = 0; i < 9; i++){
        printf ("%d ", a[i]);
    }

    while (left < right) {
        for (int i = left; i < right; i++) {
        if (a[i] > a[i + 1]) {
            swap (&a[i], &a[i + 1]);
            flag = i;
            count++;
            printf ("\n%d. Mang sau khi sap xep la: ", count);
            for (int i = 0; i < 9; i++){
                printf ("%d ", a[i]);
            }
        }
    }
    right = flag;
    for (int i = right; i > left; i--) {
        if (a[i] < a[i - 1]) {
            swap (&a[i], &a[i - 1]);
            flag = i;
            count++;
            printf ("\n%d. Mang sau khi sap xep la: ", count);
            for (int i = 0; i < 9; i++){
                printf ("%d ", a[i]);
            }
        }
    }
    left = flag;
    }
}

int main(){
    int a[9] = {3, 6, 1, -1, 0, 5, 8, 2, 4};
    sapXepMang(a);
    return 0;
}