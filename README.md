# POO-Orientacao-Objetos
POO ( Programação Orientada a Objetos )

Objetivo desse Projeto é apenas mostrar a codificação de Orientação a Objetos utilizando Herança.
Inclui:
- Abstract
- Interfaces
- Class


Modelo de estudos foi baseado em Automóveis.
Um carro é um automóvel, uma moto é um automóvel, ônibus é um automóvel e entre outros que poderíamos mencionar.

Todas essas classes vão herdar de uma classe abstrata e essa classe abstrata herda da Interface IAutomóveis.
Mas porque utilizar a classe abstrata ?
É aqui você vai ver a diferença entre abstrata e interfaces.

Com a classe abstrata vou herdar os métodos da minha interface e seus métodos poderão ser reescrito.
Exemplo :
No método Freiar do carro não é o mesmo da moto.
Então a classe carro e moto, vão ter o método Freiar, mas a ação deles serão diferente. O carro vamos freiar com o pé, na moto freiamos com a mão e o pé. 
Então vou fazer um override do método Freiar da moto, pra ter uma execução diferente de carro.

