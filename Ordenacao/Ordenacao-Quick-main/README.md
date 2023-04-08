# Ordenacao-Quick
Método de Ordenação QuickSort

## Relaório

A função QuickSort que recebe como parâmetro um vetor de inteiros e os índices do início e do fim do vetor.

 - O if verifica se o índice do início é menor que o índice do fim. Caso contrário, o vetor já está ordenado e a função pode retornar.

 - Se o vetor ainda não estiver ordenado, escolhe um elemento como pivô. Posição final.
 
 
 - Chama a função QuickSort recursivamente para as duas partições do vetor, uma do início até pivo-1 e outra de pivo+1 até o fim.

 
 Na função 'Quick':

 - Inicializa dois índices inteiros, 'pivo' e 'part', onde i começa no início do vetor e j começa no fim.

 - Enquanto pivo for menor que part, faça o seguinte:
Avance o índice pivo até encontrar um elemento maior ou igual ao pivô.

 - Retrocede o índice part até encontrar um elemento menor ou igual ao pivô.

 - Se pivo for menor que part, troca os elementos nas posições pivo e part do vetor.

 - Quando pivo for maior ou igual a part, coloca o pivô na posição part e retorna part.
 
No main: 

 - recebe um vetor inteiro desordenado
 - chama a função 'QuickSort' e exibe na tela o vetor ordenado.

## Resultado
![image](https://user-images.githubusercontent.com/124919761/229799292-7c255ebd-99a4-4d48-8b81-f304f22cfaae.png)
