# Ordenacao-Shell
Ordenação ShellSort

## Relatório

Função void 'ShellSort' recebe como parâmetro um vetor de inteiros.

 - Iinicializa a variável n recebendo o tamanho do vetor. E uma variável 'aux' com n/2, que começa com metade do tamanho do vetor e vai dividindo por 2 até chegar em 1.

 - Chama a função 'ShellRecursivo' para criar um loop que percorre o vetor de posição até o final.
 
Na função 'ShellRecursivo' recebe como parâmetros  o vetor de inteiros e o valor de aux:

 A função 'ShellSortRecursivo' chama a si mesma com aux dividido por 2 até que aux seja igual a 1, quando então chama a função ShellSort normal para ordenar o vetor.

  
No main:
   - recebe um vetor desordenado.
   - chama a função 'ShellSort' e imprime na tela o vetor ordenado.

## Resultado
![image](https://user-images.githubusercontent.com/124919761/229792476-efaa43ad-30cd-4bc1-9ad1-2fb3bc1d1e16.png)
