//kiem tra so chinh phuong
#include <conio.h>
#include <stdio.h>
#include <math.h>
main(){
	int n;
	printf("\n nhap n = ");
	scanf("%d", &n);
	double i; 
	i = sqrt(n);
	if(n == i*i){
		printf("\n %d la so chinh phuong", n);
	}
	else {
		printf("\n %d khong la so chinh phuong",n);
	}
	getch();
}
