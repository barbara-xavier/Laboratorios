# Ordenacao-Merge
Método de ordenação Merge

## Relatório

A função 'MergeSort' recebe como parâmetro um vetor de inteiros, um inteiro 'inicio '(o índice inicial do vetor) e um inteiro 'fim' (o índice final do vetor).

 - O if verifica se inicio é menor que fim. Se não for, retorne.
  - Incializa uma variável 'meio' recebendo inicio + fim /2.
  - Chama a função 'MergeSort' recursivamente para a metade esquerda do vetor, passando como parâmetros o vetor, o índice inicial e o índice do meio.

 - Chama a função MergeSort' recursivamente para a metade direita do vetor, passando como parâmetros o vetor, o índice do meio + 1 e o índice final.
 
 - Chama a função 'Merge' recursivamente.

Na função 'Merge' que recebe como parâmetro o vetor de inteiros, o índice inicial, o índice do meio e o índice final do vetor:

 - Inicializa duas variáveis interias 'v1' e 'v2' para receber os índices de dois vetores. 
 
  - Inicializa dois novos vetores 'esquerda' e 'direita' que contêm os elementos da primeira e segunda metade do vetor original.

 - A função percorre os dois novos vetores comparando seus elementos e adicionando o menor deles no vetor original. Continua até que um dos novos vetores acabe.

No main:
  - Inicializa um vetor desordenado.
  - Chama a função MergeSort e exibe o vetor ordernado na tela.

## Resultado
![image](https://user-images.githubusercontent.com/124919761/229797058-fea12698-ecd2-49c1-a3cb-47af234bdafd.png)
