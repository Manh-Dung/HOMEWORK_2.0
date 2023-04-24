#include <limits.h> 
#include <stdio.h> 
#include <stdlib.h> 
  
struct Stack { 
    int top; 
    unsigned capacity; 
    int *array; 
}; 

typedef struct Stack *stack;
  
stack createStack(unsigned capacity) 
{
    stack temp;
    temp = (stack)malloc(sizeof(struct Stack)); 
    temp->capacity = capacity; 
    temp->top = -1; 
    temp->array = (int*)malloc(temp->capacity * sizeof(int)); 
    return temp; 
} 
  
int isFull(stack stack) 
{ 
    return stack->top == stack->capacity - 1; 
} 
  
int isEmpty(stack stack) 
{ 
    return stack->top == -1; 
} 
  
void push(stack stack, int item) 
{ 
    if (isFull(stack)) 
        return; 
    stack->array[++stack->top] = item; 
    printf("%d pushed to stack\n", item); 
} 
  
void pop(stack stack) 
{ 
    if (isEmpty(stack)) 
        return INT_MIN; 
    stack->top--; 
    stack->capacity--;
} 
  
int peak(stack stack) 
{ 
    if (isEmpty(stack)) 
        return INT_MIN; 
    return stack->array[stack->top]; 
} 

void reverstPrint(int *a, int n){
    for (int i = n - 1; i >= 0; i--){
        printf("\na[%d] = %d", i, a[i]);
    }
}
  
int main() 
{ 
    stack stack = createStack(3); 
  
    push(stack, 10); 
    push(stack, 20); 
    push(stack, 30); 
  
    pop(stack);
    reverstPrint(stack->array, stack->capacity);
    
    return 0; 
} 