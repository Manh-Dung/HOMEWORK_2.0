#include<stdio.h>
#include<stdlib.h>
 
struct LinkedList {
    int data;
    struct LinkedList *next;
    struct LinkedList *prev;
};
 
typedef struct LinkedList *node; 
node head, tail;
 
node CreateNode(int value) {
    node temp;
    temp = (node)malloc(sizeof(struct LinkedList));
    temp->data = value;
    temp->prev = NULL;
    temp->next = NULL;
    return temp;
}
 
void AddTail(int value) {
    node temp = CreateNode(value);
    if(head == NULL) {
        head = temp;
        tail = temp;
        return;
    }
    tail->next = temp;
    temp->prev = tail;
    tail = temp;
}

void AddHead(int value){
    node temp = CreateNode(value); 
    if(head == NULL){
        head = temp; 
        tail = temp;
    }else{
        head->prev = temp;
        temp->next = head;
        tail = head;
        head = temp; 
    }
}

void AddAt(int value, int position){
    if(position == 0 || head == NULL){
        AddHead(value);
    }else{
        int k = 1;
        node p = head;
        while(p != NULL && k != position){
            p = p->next;
            ++k;
        }
 
        if(k != position){
            AddTail(value);
        }else{
            node temp = CreateNode(value);
            temp->next = p->next;
            p->next = temp;
            temp->prev = p;
            p->next->prev = temp;
        }
    }
}

void DelHead(){
    if(head == NULL){
        printf("\nCha co gi de xoa het!");
    }else{
        head = head->next;
        head->prev = NULL;
    }
}

void DelTail(){
    if (head == NULL || head->next == NULL){
         return DelHead();
    }
    tail = tail->prev;
    tail->next = NULL;
}

int Length(){
    int length = 0;
    for(node p = head; p != tail->next; p = p->next){
        ++length;
    }
    return length;
}

void DelAt(int position){
    if(position == 0 || head == NULL || head->next == NULL){
        DelHead(); 
    }
    else if (position == Length(head) - 1){
        DelTail();
    }
    else{
        int k = 1;
        node p = head;
        while(p->next->next != NULL && k != position){
            p = p->next;
            ++k;
        }
 
        if(k != position){
            DelTail();
        }else{
            p->next = p->next->next;
            p->next->prev = p;
        }
    }
}

int Search(int value){
    int position = 0;
    for(node p = head; p != tail->next; p = p->next){
        if(p->data == value){
            return position;
        }
        ++position;
    }
    return -1;
}

void DelByVal(int value){
    int position = Search(value);
    while(position != -1){
        DelAt(position);
        position = Search(value);
    }
}

void Output() {
    printf("\nXuat danh sach theo chieu xuoi: \n");
    for(node p = head; p != NULL; p = p->next){
        printf("%5d ", p->data);
    }
    printf("\n");
}
 
void ReverseOutput() {
    printf("\nXuat danh sach theo chieu nguoc: \n");
    for(node p = tail; p != NULL; p = p->prev){
        printf("%5d ", p->data);
    }
    printf("\n");
}

void Input(){
    head = NULL;
    tail = NULL;
    int n, value;
    do{
        printf("\nNhap so luong phan tu n = ");
        scanf("%d", &n);
    }while(n <= 0);
 
    for(int i = 0; i < n; ++i){
        printf("\nNhap gia tri can them: ");
        scanf("%d", &value);
        AddTail(value);
    }
}
 
int main() {
    printf("\nTao 1 danh sach lien ket: "); 
    Input();
    Output();
    ReverseOutput();

    printf("\nXoa phan tu dau day: \n");
    DelHead();
    Output();
    
    printf("\nXoa phan tu cuoi day: \n");
    DelTail();
    Output();

    printf("\nXoa phan tu o vi tri thu 2: \n");
    DelAt(2);
    Output();

    printf("\nXoa phan tu co gia tri 1: \n");
    DelByVal(1);
    Output();
}