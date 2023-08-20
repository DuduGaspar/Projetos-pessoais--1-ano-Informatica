#include<stdio.h> 
#include<string.h> 
#include<locale.h> 
int x, y, z, num; 
float fat; 
char resp[2]; 
main(){ 
	 setlocale(LC_ALL, "portuguese"); 
 	printf(" ==CALCULADORA DE FATORIAL==\n\n"); 
 	while(x<1){
 		x=0;y=0;
     	printf("Digite o número:\n"); 
        scanf("%d",&num);
		fat=1;
        for(z=1;z<=num;z++){ 
         	fat=fat*z; 
         } 
        printf("\n%d! = %0.0f\n\n",num,fat,"Deseja calcular outro número? S ou N\n\n"); 
        printf("Deseja calcular outro número? S ou N\n\n"); 
        while(y<1){ 
            gets(resp); 
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
