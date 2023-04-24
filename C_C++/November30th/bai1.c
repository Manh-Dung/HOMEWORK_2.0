#include<stdio.h>
#include<stdlib.h>

struct LinkedList{
    int coSo; 
    int soMu;
    struct LinkedList *next; 
 };
 
typedef struct LinkedList *node; 
 
node CreateNode(int a, int b){
    node temp;
    temp = (node)malloc(sizeof(struct LinkedList)); 
    temp->next = NULL;
    temp->coSo = a; 
    temp-> soMu = b;
    return temp;
}

node AddTail(node head, int a, int b){
    node temp,p;
    temp = CreateNode(a, b);
    if(head == NULL){
        head = temp;     
    }
    else{
        p  = head;
        while(p->next != NULL){
            p = p->next;
        }
        p->next = temp;
    }
    return head;
}

void Output(node head){
    printf("\n");
    for(node p = head; p != NULL; p = p->next){
        printf("(%d, %d) ", p->coSo, p->soMu);
    }
}
 
node Input(){
    node head = NULL;
    int n, a, b;
    do{
        printf("\nNhap so luong phan tu n = ");
        scanf("%d", &n);
    }while(n <= 0);
 
    for(int i = 0; i < n; ++i){
        printf("\nNhap co so: ");
        scanf("%d", &a);
        printf("\nNhap so mu: ");
        scanf("%d", &b);
        head = AddTail(head, a, b);
    }
    return head;
}

int main(){
    printf("\nTao 1 danh sach lien ket: "); 
    node head = Input();
    Output(head);
}