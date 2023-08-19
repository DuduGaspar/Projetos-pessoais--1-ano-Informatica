#include <stdio.h>
#include <string.h>
#include<locale.h>
char resp1[1];
int resp2;
float num, resultado;
int main(){
setlocale(LC_ALL, "portuguese");
printf(" !CONVERSOR DE UNIDADES!\n\n");
printf("Escolha o tipo de unidades:\nC = Comprimento\nV = Capacidade\nM = Massa\n\n");
gets(resp1);
printf("\nDigite o número:\n\n");
scanf("%f", &num);
printf("\nEscolha a Conversão:\n");
    if(strcmp(resp1,"C")==0){
        printf("1 = Centímetro para Metro\n2 = Metro para Centímetro\n3 = Metro para Quilômetro\n4 = Quilômetro para Metro\n\n");
        scanf("%d", &resp2);
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
        printf("1 = Mililitro para Litro\n2 = Litro para Mililitro\n\n");
        scanf("%d", &resp2);
        if(resp2 == 1){
            resultado = num/1000;
        }else if(resp2 == 2){
            resultado = num*1000;
        }
    }
    if(strcmp(resp1,"M")==0){
        printf("1 = Miligrama para Grama\n2 = Grama para Miligrama\n3 = Grama para Kilograma\n4 = Kilograma para Grama\n\n");
        scanf("%d", &resp2);
        if(resp2 == 1 || resp2 == 3){
            resultado = num/1000;
        }
        if(resp2 == 2 || resp2 == 4){
            resultado = num*1000;
        }
    }
printf("\nRESULTADO = %0.2f", resultado);
}
    

