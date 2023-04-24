#include <stdio.h>
#include <stdlib.h>

struct TreeNode
{
    int data;
    struct TreeNode *left;
    struct TreeNode *right;
};

typedef struct TreeNode *node;

int LeftOf(node root, int value)
{
    return value < root->data;
}
 
int RightOf(node root, int value)
{
    return value > root->data;
}
 
node Insert(node root, int value)
{
    if (root == NULL)
    {
        node temp = (node)malloc(sizeof(struct TreeNode));
        temp->left = NULL;
        temp->right = NULL;
        temp->data = value;
        return temp;
    }
    if (LeftOf(root, value) == 1)
        root->left = Insert(root->left, value);
    else if (RightOf(root, value) == 1)
        root->right = Insert(root->right, value);
    return root;
}

int Search(node root, int value)
{
    if (root == NULL)
        return 0;
    if(root->data == value){
        return 1;
    }else if (LeftOf(root, value)){
        printf("\nTim o node ben trai.");
        return Search(root->left, value);
    }else if( RightOf(root, value)){
        printf("\nTim o node ben phai.");
        return Search(root->right, value);
    }
}

void NLR(node root){
    if(root != NULL)
    {
        printf("%d ", root->data);
        NLR(root->left);
        NLR(root->right);
    }
}

void Free(node root)
{
    if (root == NULL)
        return;
    Free(root->left);
    Free(root->right);
    free(root);
}

int main()
{
    node root = NULL;
    root = Insert(root, 5);
    root = Insert(root, 2);
    root = Insert(root, 51);
    root = Insert(root, 1);
    root = Insert(root, 25);
    root = Insert(root, 0);
    root = Insert(root, 3);
    root = Insert(root, 555);
    root = Insert(root, 35);
    root = Insert(root, 4);

    NLR(root);

    int n;
    printf("\nMoi nhap so can tim: ");
    scanf("%d", &n);
    if(n == root->data){
        printf("\nXuat hien so can tim trong cay tim kiem nhi phan!");
    }
    else{
        printf("So can tim khong xuat hien o root");
    }
    if(Search(root, n) == 1){
        printf("\nXuat hien so can tim trong cay tim kiem nhi phan!");
    }
    else{
        printf("\nKhong tim thay so can tim trong cay tim kiem nhi phan!");
    }
    free(root);
    return 0;
}
