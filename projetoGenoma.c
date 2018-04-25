// OBI 1999
//Projeto Genoma
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char cadeiaDNA[30];
    char p[30]; //cadeia que será procurado
    char t;     //cadeia inversa
    int i, ii, cont, contInv;
    ii = cont = contInv = 0;

    scanf("%s %s", &cadeiaDNA, &p);


    //gera a cadeia invertida
    //Entrada não esta funcionando
    for(i = strlen(p); i >= 0; i--)
    {
        if(p[i] == 'A')
        {
            t[ii] = 'T';
        }
        else if(p[i] == 'T')
        {
            t[ii] = 'A';
        }
        else if(p[i] == 'C')
        {
            t[ii] = 'G';
        }
        else if (p[i] == 'G')
        {
           t[ii] = 'C';
        }
    }

    for(i = 0; cadeiaDNA[i] != '\0', i++)
    {
        if(cadeiaDNA[i] == p[0])
        {
           for( ii = i + 1; p[ii] != cadeiaDNA[i];
                i++, ii++)
           {
              break;
           }
           cont++;
        }
        else if(cadeiaDNA[i] == t[0])
        {
           for( ii = i + 1; t[ii] != cadeiaDNA[i];
                i++, ii++)
           {
              break;
           }
           contInv++;
        }
    }

    printf("Cont: %d\n", cont);

    printf("ContInv: %d\n", contInv);

    return 0;
}


