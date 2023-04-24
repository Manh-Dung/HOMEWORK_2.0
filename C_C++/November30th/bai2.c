#include <stdio.h>
#include <stdlib.h>

struct LinkedList
{
    int data;
    struct LinkedList *next;
};

typedef struct LinkedList *node;

node CreateNode(int value)
{
    node temp;
    temp = (node)malloc(sizeof(struct LinkedList));
    temp->next = NULL;
    temp->data = value;
    return temp;
}

node AddTail(node head, int value)
{
    node temp, p;
    temp = CreateNode(value);
    if (head == NULL)
    {
        head = temp;
    }
    else
    {
        p = head;
        while (p->next != NULL)
        {
            p = p->next;
        }
        p->next = temp;
    }
    return head;
}

node AddHead(node head, int value)
{
    node temp = CreateNode(value);
    if (head == NULL)
    {
        head = temp;
    }
    else
    {
        temp->next = head;
        head = temp;
    }
    return head;
}

node AddAt(node head, int value, int position)
{
    if (position == 0 || head == NULL)
    {
        head = AddHead(head, value);
    }
    else
    {
        int k = 1;
        node p = head;
        while (p != NULL && k != position)
        {
            p = p->next;
            ++k;
        }

        if (k != position)
        {
            head = AddTail(head, value);
        }
        else
        {
            node temp = CreateNode(value);
            temp->next = p->next;
            p->next = temp;
        }
    }
    return head;
}

node DelHead(node head)
{
    if (head == NULL)
    {
        printf("\nCha co gi de xoa het!");
    }
    else
    {
        head = head->next;
    }
    return head;
}

node DelTail(node head)
{
    if (head == NULL || head->next == NULL)
    {
        return DelHead(head);
    }
    node p = head;
    while (p->next->next != NULL)
    {
        p = p->next;
    }
    p->next = p->next->next;
    return head;
}

node DelAt(node head, int position)
{
    if (position == 0 || head == NULL || head->next == NULL)
    {
        head = DelHead(head);
    }
    else
    {
        int k = 1;
        node p = head;
        while (p->next->next != NULL && k != position)
        {
            p = p->next;
            ++k;
        }

        if (k != position)
        {
            head = DelTail(head);
        }
        else
        {
            p->next = p->next->next;
        }
    }
    return head;
}

int Search(node head, int value)
{
    int position = 0;
    for (node p = head; p != NULL; p = p->next)
    {
        if (p->data == value)
        {
            return position;
        }
        ++position;
    }
    return -1;
}

node DelByVal(node head, int value)
{
    int position = Search(head, value);
    while (position != -1)
    {
        head = DelAt(head, position);
        position = Search(head, value);
    }
    return head;
}

void Output(node head)
{
    printf("\n");
    for (node p = head; p != NULL; p = p->next)
    {
        printf("%5d", p->data);
    }
}

node Input()
{
    node head = NULL;
    int n, value;
    do
    {
        printf("\nNhap so luong phan tu n = ");
        scanf("%d", &n);
    } while (n <= 0);

    for (int i = 0; i < n; ++i)
    {
        printf("\nNhap gia tri can them: ");
        scanf("%d", &value);
        head = AddTail(head, value);
    }
    return head;
}

int main()
{
    printf("\nTao 1 danh sach lien ket: ");
    node head = Input();
    Output(head);

    // printf("\n\nThem 1 phan tu vao dau danh sach: ");
    // head = AddHead(head, 20);
    // Output(head);

    // printf("\n\nThem 1 phan tu vao vi tri thu 2 cua danh sach: ");
    // head = AddAt(head, 100, 2);
    // Output(head);

    // printf("\n\nXoa phan tu o dau danh sach: ");
    // head = DelHead(head);
    // Output(head);

    // printf("\n\nXoa phan tu o cuoi danh sach: ");
    // head = DelTail(head);
    // Output(head);

    // printf("\n\nXoa phan tu o vi tri 2 khoi danh sach: ");
    // head = DelAt(head, 2);
    // Output(head);

    // printf("\n\nTim kiem phan tu co gia tri bang 3 trong danh sach: ");
    // int index = Search(head, 3);
    // if (index != -1)
    //     printf("\nTim thay tai chi so %d", index);
    // else
    //     printf("Khong tim thay phan tu trong danh sach!");

    printf("\n\nXoa phan tu co gia tri bang 1 khoi danh sach: ");
    head = DelByVal(head, 1);
    Output(head);
}