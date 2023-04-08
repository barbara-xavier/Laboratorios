# Ordenacao-com-busca-Binaria
Ordenação usando Busca Binária

## Relatório

A função BuscaBinariaOrdenada recebe que
 - se o início for menor que o fim, a varável meio recebe inicio + fim/2.
 - Chama a função 'BuscaBinariaOrdenada' recursivamente para a metade esquerda do vetor, passando como parâmetros o vetor, o índice inicial e o índice do meio.

 - Chama a função 'BuscaBinariaOrdenada' recursivamente para a metade direita do vetor, passando como parâmetros o vetor, o índice do meio + 1 e o índice final.

 - Chama a função 'Intercalação' recursivamente.

Implementa a função MergeSort no 'Intercalação' para ordernar o vetor.

No main:
  - recebe um vetor inteiro desordenado
 - chama a função 'BuscaBinariaOrdenada' e exibe na tela o vetor ordenado.
 

## Resultado

![image](https://user-images.githubusercontent.com/124919761/229870507-8500451e-0600-421f-9456-2dbdede6753b.png)
