# Recursividade_04
Exercício Recursividade 4

Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase. */


## Relatório
A função inteira 'ContarLetras' inicia com uma string 'frase' e um char 'letra'.
 - O if diz que se o Length da frase for 0, retorna 0. 
 - O else recebe um int 'ocorrenciasRestantes' que recebe a função com frase.Substring para ler letra por letra.
    - um if q diz que se a frase na posição 0 for igual a letra, irá retornar a 'ocorrenciasRestantes' + 1.
	- se não, irá retornar apenas 'ocorrenciasRestantes';
 
 No main:
  - recebe do usuário a frase e a letra desejada.
  - chama a função 'ContarLetras' com a frase e letra escolhidas.
  - Exibe na tela a função.

## Resultado
![image](https://user-images.githubusercontent.com/124919761/229619766-5bd23766-c984-4243-a1d2-75f44b35a921.png)
