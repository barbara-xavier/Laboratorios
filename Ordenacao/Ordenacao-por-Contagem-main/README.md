# Ordenacao-por-Contagem
Método de Ordenação por Contagem

## Relatório
 A função 'CountingSort' que recebe como parâmetro um vetor de inteiros: 
 
 - inicializa um vetor de inteiros que será o vetor de entrada não ordenado.

 - Inicializa um vetor de contagem 'max' recebendo o tamanho 0 do vetor original.

 - O for Percorre o vetor de entrada e incrementa o valor do índice correspondente no vetor de contagem.

 - O vetor 'countV' percorre o vetor de contagem e acumula a contagem em cada posição com a contagem da posição anterior.
 
 - Percorre o vetor de entrada da direita para a esquerda e, para cada elemento, coloca no vetor de saída na posição correta, de acordo com o valor acumulado no vetor de contagem.

 - Retorna o vetor de saída, que estará ordenado.
 
 No main: 

 - recebe um vetor inteiro desordenado
 - chama a função 'CountingSort' e exibe na tela o vetor ordenado.
 

## Resultado
![image](https://user-images.githubusercontent.com/124919761/229809359-4f8a4e3b-5a05-43cd-a5a9-efb8ec1740b1.png)
