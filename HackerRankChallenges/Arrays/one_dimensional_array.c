/* Problem: https://www.hackerrank.com/challenges/arrays-ds */

#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

void one_dimensional_array(void) 
{
    int n;    
    // Input n as number of input integers
    scanf("%d", &n);
    int *arr = malloc(sizeof(int) * n);

    // Store n space-separated integers to array
    for (int arr_i = 0; arr_i < n; arr_i++) 
    {
        scanf("%d", &arr[arr_i]);
    }

    // Print the output array in reverse order
    for (int arr_i = n - 1; arr_i >= 0; arr_i--)
    {
        printf("%d ", arr[arr_i]);
    }
    printf("\n");
}
