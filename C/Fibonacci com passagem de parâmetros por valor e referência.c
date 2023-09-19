#include<stdio.h>
int n, ant, prox, atual;

void fibonacci(int x){
	int ant,atual =1;
	for(int y = 1; y<=x; y++){
		printf("%d ,",atual);
		int pos=ant+atual;
		ant=atual;
		atual=pos;
	}
}

void fibonacci_ref(int &x, int &y, int &z){
	z=y+x;
	y=x;
	x=z;
}

main(){
	printf("Digite um número: ");
	scanf("%d",&n);
	fibonacci(n);
	printf("\n");
	ant, atual = 1;
	for(int x = 1; x<=n; x++){
		printf("%d ,",atual);
		fibonacci_ref(atual, ant, prox);	
	}
}
