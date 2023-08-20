#include<stdio.h>
#include<string.h>
#include<locale.h>
int x, y, num;
float fat = 1;
char resp[2];
main(){
setlocale(LC_ALL, "portuguese");
printf(" ==CALCULADORA DE FATORIAL==\n\n");
while(x<1){
	printf("Digite o número:\n");
	scanf("%d",&num);
	for(x=1;x<=num;x++){
		fat=fat*x;
	}
	printf("\n%d! = %0.0f\n\n",num,fat);
	printf("Deseja calcular outro número? S ou N\n\n");
	while(y<1){
		getchar(resp);
		if(strcmp(resp,"N")!=0 && strcmp(resp,"S")!=0){
			printf("!!!Digite S ou N! Letra Maiúscula!!!\n");
		}else{
			y=1;
		}
	}
	if(strcmp(resp,"N")==0){
		x=1;
	}
}
}
