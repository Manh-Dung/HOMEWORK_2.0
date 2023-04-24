#include <stdio.h>

void sapXepMang(int a[])
{
    int count = 0;
    
    printf("%d. Mang khi chua sap xep la: ", count);
    for (int i = 0; i < 9; i++){
        printf("%d ", a[i]);
    }

    int left, right, mid, x;
    for (int i = 1; i < 9; i++){
        x = a[i];
        left = 0;
        right = i - 1;
        while (left <= right){
            mid = (left + right) / 2;

            if (x < a[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }
        for (int j = i - 1; j >= left; j--)

            a[j + 1] = a[j];

        a[left] = x;
        count++;
        printf("\n%d. Mang sau khi sap xep la: ", count);
        for (int i = 0; i < 9; i++){
            printf("%d ", a[i]);
        }
    }
}

int main()
{
    int a[9] = {3, 6, 1, -1, 0, 5, 8, 2, 4};
    sapXepMang(a);
    return 0;
}