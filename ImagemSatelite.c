// OBI 1999
//Imagens de Satelite
#include <stdio.h>
#include <stdlib.h>
#define MM 10
#define NN 10




int main()
{
    int imagemDigital[MM][NN];
    int M,N;

    int cont = 0, i, ii,  l, c;

    scanf("%d %d", &M, &N);


    for(i = 0; i < M; i++)
    {
        for(ii = 0; ii < N; ii++)
            scanf("%d", &imagemDigital[i][ii]);
    }



    for(i = 0; i < M; i++)
    {
        for(ii = 0; ii < N; ii++)
        {
            if(imagemDigital[i][ii] > cont)
            {
              cont++;
              imagemDigital[i][ii] = cont;

              //baixo
              if(i < M)
                if(imagemDigital[i + 1][ii] > 0)
                    imagemDigital[i + 1][ii] = cont;

              //cima
              if(i > 0)
                if(imagemDigital[i - 1][ii] > 0)
                    imagemDigital[i - 1][ii] = cont;


              //direita
              if(imagemDigital[i][ii + 1] < N)
                if(imagemDigital[i][ii + 1] > 0)
                    imagemDigital[i][ii] = cont;



              //diagonal baixo-esquerda
              if((i < M) && (ii < N))
                if(imagemDigital[i + 1][ii - 1] > 0)
                    imagemDigital[i + 1][ii - 1] = cont;

              //diagonal baixo-direita
              if((i < M) && (ii < N))
                if(imagemDigital[i][ii] > 0)
                    imagemDigital[i][ii] = cont;

            }
        }
    }

    printf("%d\n", cont);

    for(i = 0; i < M; i++)
    {
        for(ii = 0; ii < N; ii++)
            printf("[%d]",imagemDigital[i][ii]);
        printf("\n");
    }

    return 0;
}


