#include <stdio.h>

void sapXepMang(int a[]){
	int count = 0;

	printf ("%d. Mang khi chua sap xep la: ", count);
    for (int i = 0; i < 9; i++){
        printf ("%d ", a[i]);
    }

    for (int i = 1; i < 9; i++){
		int temp = a[i];
		int j = i;
		while (j > 0 && a[j - 1] > temp){
			a[j] = a[j - 1];
			j--;
		}
		a[j] = temp;
		count++;
		printf ("\n%d. Mang sau khi sap xep la: ", count);
        for (int x = 0; x < 9; x++){
            printf ("%d ", a[x]);
        }
	}
}

int main(){
    int a[] = {3, 6, 1, -1, 0, 5, 8, 2, 4};
	int n = sizeof(a);
    sapXepMang(a);
    return 0;
}