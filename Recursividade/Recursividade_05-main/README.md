# Recursividade_05
Exercício Recursividade 5

  Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.
  
  ## Relatório
  
A função inteira Soma recebe dois parâmetros inteiros, um vetor 'Ele' e uma variável 'N'.
   - incicializa uma variável 'somar' recebendo 0;
   - o primeiro if diz q se N for igual a Ele.Length, irá retornar 0;
   - O if compara se o elemento na posição N tem resto 0 na divisão por 2. Conferindo se o número atual é par. 
   - O if retorna a soma mais ela mesma mais o vetor[N], somando com a função em si, chamando o 'Ele' e o 'N'+1. Para ir para o proximo número, enquanto soma até chegar ao fim do vetor.
   - O else retorna a função chamando Ele e N+1.
   
No main:
 - Recebe do usuário o tamanho do vetor.
 - cria um vetor com o tamanho especificado.
 - o for vai preencher o vetor com base nos números digitados pelo usuário.
 - chama a função 'Soma' e mostra na tela.
 
 ## Resultado
 
 ![image](https://user-images.githubusercontent.com/124919761/229642518-c877e859-1942-40e7-9b2a-1c0294ac4207.png)
