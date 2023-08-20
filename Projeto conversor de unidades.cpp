#include <stdio.h>
#include <string.h>
#include<locale.h>
char resp1[1];
int resp, resp2, x, y, z;
float num, resultado;
main(){
setlocale(LC_ALL, "portuguese");
printf(" !CONVERSOR DE UNIDADES!\n\n");
while(z<1){
y=0; x=0; z=0;
	printf("Escolha o tipo de unidades:\nC = Comprimento\nV = Capacidade\nM = Massa\n\n");
		while(x<=2){
			gets(resp1);
			if(strcmp(resp1,"C")!=0 && strcmp(resp1,"V")!=0 && strcmp(resp1,"M")!=0){
				printf("\nLetra digitada incorretamente! Tente digitar em letra maiúscula!\n\n");
			}else {
				x=3;
			}
		}
	printf("\nDigite o número:\n\n");
	scanf("%f", &num);
	printf("\nEscolha a Conversão:\n");
    	if(strcmp(resp1,"C")==0){
        	printf("1 = Centímetro para Metro\n2 = Metro para Centímetro\n3 = Metro para Quilômetro\n4 = Quilômetro para Metro\n\n");
        	while(y<=2){
        		scanf("%d", &resp2);
        		if(resp2 != 1 && resp2 != 2 && resp2 != 3 && resp2 != 4){
        			printf("\nDigito incorreto! Digite um número de 1 a 4\n\n");
				}else{
					y=3;
				}
    	}
        if(resp2 == 1){
            resultado = num/100;
        }else if(resp2 == 2){
            resultado = num*100;
        }else if(resp2 == 3){
            resultado = num/1000;
        }else if(resp2 == 4){
            resultado = num*1000;
        }
    }
    if(strcmp(resp1,"V")==0){
        printf("1 = Mililitro para Litro\n2 = Litro para Mililitro\n\n"); y=1;
        while(y<=2){
        scanf("%d", &resp2);
        	if(resp2 != 1 && resp2 != 2){
        		printf("\nDigito incorreto! Digite um número de 1 a 2\n\n");
			}else{
				y=3;
			}
    	}
        if(resp2 == 1){
            resultado = num/1000;
        }else if(resp2 == 2){
            resultado = num*1000;
        }
    }
    if(strcmp(resp1,"M")==0){
        printf("1 = Miligrama para Grama\n2 = Grama para Miligrama\n3 = Grama para Kilograma\n4 = Kilograma para Grama\n\n"); y=1;
        while(y<=2){
        scanf("%d", &resp2);
        if(resp2 != 1 && resp2 != 2 && resp2 != 3 && resp2 != 4){
        		printf("\nDigito incorreto! Digite um número de 1 a 4\n\n");
			}else{
				y=3;
			}
    	}
        if(resp2 == 1 || resp2 == 3){
            resultado = num/1000;
        }
        if(resp2 == 2 || resp2 == 4){
            resultado = num*1000;
        }
    }
	printf("\nRESULTADO = %0.3f\n\n", resultado);
	printf("Deseja converter outro número?\n 1 = Sim ou 2 = Não\n");
	while(x<5){
		scanf("%d",&resp);
		if(resp != 1 && resp != 2){
			printf("!Digite 1 ou 2!\n");
		}else{
			x=5;
		}
	}
	if(resp==2){
		z=1;
	}
}
}
