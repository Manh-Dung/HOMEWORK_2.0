#include<stdio.h>
#include<stdlib.h>
 
struct Node {
    int coSo;
    int soMu;
    struct Node *next;
    struct Node *prev;
};
 
struct Node *head, *tail; 
 
struct Node *CreateNode(int x, int y) {
    struct Node *temp;
    temp = (struct Node*)malloc(sizeof(struct Node));
    temp->coSo = x;
    temp->soMu = y;
    temp->prev = NULL;
    temp->next = NULL;
    return temp;
}
 
void AddTail(int x, int y) {
    struct Node *temp = CreateNode(x, y);
    if(head == NULL) {
        head = temp;
        tail = temp;
        return;
    }
    tail->next = temp;
    temp->prev = tail;
    tail = temp;
}
 
void Output() {
    printf("\nXuat danh sach theo chieu xuoi: \n");
    for(struct Node *p = head; p != NULL; p = p->next){
        printf("(%d, %d) ", p->coSo, p->soMu);
    }
    printf("\n");
}
 
void ReverseOutput() {
    printf("\nXuat danh sach theo chieu nguoc: \n");
    for(struct Node *p = tail; p != NULL; p = p->prev){
        printf("(%d, %d) ", p->coSo, p->soMu);
    }
    printf("\n");
}

struct Node *Input(){
    head = NULL;
    tail = NULL;
    int coSo;
 
    for(int i = 2; i >= 0; i--){
        printf("\nNhap co so ung voi so mu %d: ", i);
        scanf("%d", &coSo);        
        AddTail(coSo, i);
    }
    return head;
}
 
int main() {
    printf("\nTao 1 danh sach lien ket: "); 
    head = Input();
    Output();
    ReverseOutput();
}