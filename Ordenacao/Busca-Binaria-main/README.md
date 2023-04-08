# Busca-Binaria
Método de Busca Binária

## Relatório
A função 'PesquisaBinaria' inicia recebendo como parâmetros um vetor, e um inteiro 'chave' que é o índice do elemento que quero bsucar.
 - Cria variáveis para representar o elemento do meio, do inicio e do fim do vetor.
 - O do while repete enquanto o valor do inicio for menor ou igual ao valor do fim do vetor.
    - Define a posição do meio.
	- Verifica se a posição do meio é igual ao valor procurado. Se sim, retorna o valor do meio.
	- Se não for igual, modifica a chave: se chave for maior que o valor do meio, inicio recebe meio mais 1, ignorando os valores menores do vetor.
    - Se a chave for maior que o valor do meio, final recebe meio mais 1, ignorando os valores maiores do vetor
	
- fora do do while: se o número procurado não existir no vetor, retorna -1.

No main:
 - recebe um vetor inteiro desordenado
 - chama a função 'PesquisaBinaria' e exibe na tela o vetor ordenado.
 

## Resultado
Entrada de dados:
 int[] V = new int[10]{1,2,3,4,5,6,7,8,9,10};
 
 índice recebendo 7.

![image](https://user-images.githubusercontent.com/124919761/229869744-4cac52fe-d1ab-4cac-8b23-f69742273972.png)
