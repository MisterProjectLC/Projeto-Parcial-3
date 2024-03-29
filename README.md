# Projeto-Parcial-3
Trabalho de PG no Unity

<h2>Danilo:</h2>
Criamos o projeto na ferramenta Unity, versão 2021.1.26f1. Antes de tudo, gerei um material especial para adicionar um skybox (o fundo da cena) de espaço sideral, tanto para quesitos estéticos quanto para criar um melhor ponto de referência para os demais objetos.

Depois disso, criei um plano na cena e posicionei-o na origem do mundo, com posição (0, 0, 0) e escala (2, 1, 2), deixando-o com o dobro do tamanho original. 

Como extra, um objeto de personagem foi adicionado. Ele pode ser controlado com o mouse e os botões W, A, S e D do teclado, e foi colocado para uso futuro no PP4


<h2>Giovanni:</h2>
Eu criei um objeto na cena chamado Arvore. O objeto consistem em um cubo, que representa o tronco da árvore e uma esfera, esta que representa a copa da árvore. A Arvore está na posição (3.09, 1.79, 2.68) e  escala de (1, 3.9829, 1) em relação a origem, enquanto a esfera tem sua posição em (0, 0.612, 0) e escala em (4.517175, 0,6978658, 4.527797) em relação ao cubo.

<h2>Luís:</h2>
Crie o obstaclo 1.
Em seguida apliquei, apliquei uma translação nele(0.64, 7.3, -5.61), depois disso apliquei uma rotação de 30º em relação ao eixo Z (0,0,30).
E em seguida criei os obstaculos filhos, que usam o sistema de coordenadas do Pai. Então, o ostaculo 1(1) foi criado e ele é uma cópia do pai.
O obstaculo 1(2) foi criado e foi aplicado uma escala(-0.2754666, 0.461992, 1) e uma translação de (-0.363, -0.722, 0) em relação ao pai(obstaculo 1).

<h2>Douglas:</h2>	
Minha ideia foi adicionar uma casinha no projeto. Para isso, eu adicionei um cubo na cena e mudei sua escala para ficar do tamanho de uma casa. Infelizmente, no Unity não há formato de pirâmide como objeto padrão, então, para fazer o teto, eu dupliquei o cubo da casa e o rotacionei. Após alguns ajustes de posição(-1.83, 1.03, 2.7) e escala(3.98149, 2.1173, 2.885666), a "casinha" ficou pronta.


<h1> Projeto Parcial 4 </h4>

Uma build do jogo se encontra na pasta: https://drive.google.com/file/d/1ZB_9zJZopU3SbTNbkAQo2SZ-tQI4BGUH/view?usp=sharing

Quando iniciamos esta fase do projeto, percebemos que já havíamos feito uma parte dele na entrega anterior. Com o movimento da câmera mudando conforme o jogador se move na cena, fizemos o requisito da cena possuir um objeto com movimentos dependentes. 

Então, adicionamos uma nova câmera na cena. Esta câmera está localizada na mesma posição que a câmera anterior,  e ela é ativada e desativada através da tecla "E". A nova câmera possui uma perspectiva de projeção paralela. 

Adicionamos textos explicando os comandos que o jogador utiliza para interagir com a cena, além de mudar a posição de alguns objetos , como a casa e a árvore, para demonstrar a diferença de perspectiva entre as duas câmeras. Além disso, adicionamos cubos na cena, e fizemos um pequeno puzzle que o jogador tem que resolver para finalizar o jogo.

Encorajamos que qualquer um que for testar o jogo, que tente resolver a puzzle, já que faz parte da experiência. Caso você não consiga resolver a puzzle, aqui está a resolução:
<details>
  <summary>Resolução do Jogo</summary>
    Para finalizar o jogo e resolver a puzzle, basta apontar a câmera para cima e apertar e segurar a tecla "W", até que o jogo fique com a tela completamente branca. Depois de um tempo com a tela em branco, uma mensagem de finalização de jogo vai aparecer, e o jogo cregará ao seu fim.
  
</details>
