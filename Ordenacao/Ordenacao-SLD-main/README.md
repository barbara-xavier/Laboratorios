# Ordenacao-SLD
Método de Ordenação LSD

## Relatório
A função LSD recebe um vetor inteiro como parâmetro:

 - O for encontra o maior valor no vetor e incrementa da variável 'max';
 
 
A função 'CountingSort':

 - Inicializa um vetor countV de tamanho 10 com todos os elementos igual a zero, e um vetor 'vetorOrdenado' de tamanho igual ao array original.

 - Para cada elemento do vetor original, obtenha o dígito atual a ser ordenado usando % 10. Em seguida, adiciona 1 ao elemento countV[digito].

 - Percorre o vetor countV e atualiza cada elemento countV[i] com a soma dos valores de countV[i] e countV[i-1].

 - Percorre o vetor original na ordem inversa e, para cada elemento, obtém o dígito atual a ser ordenado usando o % 10. Em seguida, adicione o elemento atual ao array vetorOrdenado[count[digit] - 1] e subtraia 1 de countV[digito].

 - Copia o conteúdo do vetor vetorOrdenado para o vetor original.


No main: 
 - recebe um vetor inteiro desordenado
 - chama a função 'CountingSort' e exibe na tela o vetor ordenado.
 



## Resultado
![image](https://user-images.githubusercontent.com/124919761/229812970-44d52cf3-c4da-49c4-817d-b389a75f750b.png)
