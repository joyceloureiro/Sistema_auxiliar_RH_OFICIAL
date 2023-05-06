# sistema_auxiliar_RH

![Espécies-de-Trabalhadores](https://user-images.githubusercontent.com/128190811/236585355-656daf86-aea6-4a5a-8e14-c60045759e46.jpg)

Inicio do sistema auxiliar de RH
===============================

  Esse sistema foi voltado para atender tanto as necessidades do empregador, como do empregado. Calculando de maneira eficiente descontos e adicionais que veem ser somados ao salario do trabalhador. já para a instituição, o programa calcula diversos adicionais e descontos que possam recair sobre o sálario final do funcionario, como por exemplo as horas extras trabalhadas no mes, com esse sistema integrado a margem de erro é reduzida,pois um software que calcula o percentual a ser pago ao trabalhador. Calcula tambem o extrato do funcionario e consta com um sistema de banco de dados para guarda dados do trabalhador e facilitar a vida do empregador.

  
  
  
  
  
**Abaixo segue uma tabela especificando as funcões que constam no programa sistema do RH:**

| FUNÇÕES                   | EXEMPLO 
| --------------------------|:----------------------------------------------------------------------------------------------------------------------------:|
| **INSS**                  | Calcula o percentual do INSS a ser descontado em cima do salario bruto do funcionario;                                       |
| **IRRF**                  | Calcula o percentual do IRRF a ser descontado em cima do salario bruto do funcionario;                                       |
| **VALE TRANSPORTE**       | Calcula quanto do VT trasnporte do funcionario será descontado, e se vale apena adiquiri-lo;                                 |          
| **MULTA FGTS**            | Calcula se o funcionario tem direito de receber a multa do FGTS e qual a porcentagem da multa;                               |
| **PERICULOSIDADE**        | Calcula se o funcionario recebe adicional de periculosidade, o valor do adicional e horas extras;                            |
| **ADICIONAL NOTURNO**     | Calcula qual valor de horas extras noturnas trabalhadas pelo funcionario a receber;                                          |
| **SEGURO DESEMPREGO**     | Simula se o usuario tem direito ou não a receber seguro desemprego;                                                          |
| **PIS**                   | Simula se o usuario tem direito ou não a receber o PIS e o valor;                                                            |
| **ADICIONAL HORAS EXTRAS**| Calcula o valor do adicional por horas extras trabalhadas a receber;                                                         |  
| **BONIFICAÇÃO FÉRIAS**    | Calcula o valor do adicional bonificação férias a receber;                                                                   |
| **FGTS**                  | Calcula o valor do depósito do FGTS a ser adicionado na conta;                                                               |
| **DESCONTOS**             | Simula e entrega o valor dos descontos a serem subtraidos no valor do sálario bruto fomando assim o salario líquido, EX:inss;|
| **ADICINAIS**             | Simula e entrega o valor dos adicionais a serem somados ao sálario bruto fomando assim o salario líquido, EX:periculosidade; |
| **SÁLARIO LÍQUIDO**       | E a junção do sálario bruto + adicionais, descontado os descontos, é o real valor do sálario que o empregado receberá;       |




#### *FUNÇÃO MENU* ####
****************************

- Essa é a primeira parte do programa, é nessa função que será executado a escolha de qual calculo o programa deve fazer, EX:inss,Bonificação férias,FGTS et...

- Está enumerado de 1 a 14 as operações disponiveis no programa, o usuario deve digitar uma das opções disponiveis e em seguida fornecer os dados necessarios;


#### *FUNÇÃO TRACINHO* ####
****************************

- Essa função é responsavel por adicionar uma linha no programa, foi criada para separar as funções e deixar o programa mais belo.

#### *FUNÇÃO TÌTULO* ####
****************************

- Está função faz aparecer o nome do programa na tela do usuario 

#### *FUNÇÃO SIMULADOR* ####
****************************

-  Depois que o usuario já escolheu a operação desejada no espaço **menu** do programa, a função **simulador** entra perguntando todos os dados necessarios para realização do calculo. exemplo: Quantas horas extras foram trabalhadas este mes?, Digite o sálario bruto do usuario:, recebe adicional por periculosidade ? 

- É nessa função que aparecerá tambem o **resultado**, exibindo o sálario líquido, proventos e valor do calculo escolhido (EX: valor do inss $$ 356.99) etc...

- Essa função tambem realiza calculos menores como: sário liquido, e algumas operaçãoes não tem necessidade de haver uma "função equação" para realizar o calculo, sendo todo realizado na propria função simulador, EX: PIS;

- **RESUMO** = Essa função é responsavel por mostrar na tela os "escrevas", fazer as perguntas necessarias para o calculo do programa e exibir o resultado.

#### *FUNÇÃO EQUAÇÂO* ####
****************************

- Essa função que realiza o calculo necessario em cada operação escolhida no menu, a função simulador "chama" a função equação, para exibir o resultado já calculado na mesma;

- A função coleta os dados necessarios para o calculo EX: salario_bruto, horas_extras_trabalhadas_mes, s_ou_n_numero etc.., na função simulador e em seguida inicia o calculo, depois do calculo já realizado ela atribui esse valor a uma variavél e retorna o valor a função simulador;

- **RESUMO** = Essa função é responsavel por calcular o valor das operações escolhidas no menu e retornar o valor das mesmas.

#### *FUNÇÃO MENSAGEM ERRO* ####
****************************

-Essa função aparece no codigo sempre que o usuario digitar uma informação errada, EX: letras aonde só numeros são validos

#### *FUNÇÃO TESTADOR SIM OU NÃO * ####
****************************

- Recebe uma pergunta sim ou não, e caso aconteça algum erro ela retorna para ser inserido valor (S ou N)

#### *FUNÇÃO TESTADOR DE NUMEROS* ####
****************************

- Recebe uma cadeia e verifica se a cadeia digitada é numero ou não, caso seja numero retorna "verdadeiro", caso contrario retorna "falso".

#### *FUNÇÃO CADASTRO DE DADOS* ####
************************************

- Pergunta os dados dos funcionarios como: email, CEP, nome etc... e em seguida os guarda no arquivo "banco de dados.txt" 

#### *REFERÊNCIAS* ####
************************************

[Calculo INSS](https://meutudo.com.br/blog/calculo-inss/)

[Calculo INSS](https://www.coalize.com.br/calculadora-de-inss-resultado)

[Calculo IRRF](https://www.calcule.net/trabalhista/calculo-imposto-de-renda-irrf/#topnav)

[Calculo MULTA FGTS](https://www.pontotel.com.br/multa-fgts/)

https://www.youtube.com/watch?v=Jjo0PvauNJg

[Calculo ADICIONAL PERICULOSIDADE](https://folhacerta.com/o-que-e-adicional-de-periculosidade-e-como-calcular/#:~:text=Na%20pr%C3%A1tica%2C%20se%20um%20colaborador,salarial%2C%20n%C3%A3o%20de%20car%C3%A1ter%20indenizat%C3%B3rio.)

https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet

[Calculo FERIAS](https://www.idinheiro.com.br/calculadoras/calculadora-de-ferias/)

[Calculo INSS](https://nicoliadvogados.adv.br/previdenciario/inss-e-aplicado-sobre-horas-extras/#:~:text=Em%20suma%2C%20deve%20ser%20feito,STJ%20%C3%A9%20favor%C3%A1vel%20aos%20segurados)

[Calculo INSS](https://ibdec.net/geral/inss-instituto-nacional-da-seguridade-social#:~:text=O%20desconto%20do%20INSS%20incide,em%20lei%20pela%20previd%C3%AAncia%20social.)

[Calculo IRRF](https://economia.uol.com.br/imposto-de-renda/noticias/redacao/2023/04/06/tabela-do-imposto-de-renda-2023-veja-faixas-aliquotas-e-como-calcular.htm)

[Calculo irrf](https://www.calcule.net/trabalhista/calculo-imposto-de-renda-irrf/#topnav)

https://www.calcule.net/trabalhista/calculo-de-inss/

[Calculo FGTS](https://tangerino.com.br/blog/calculo-do-fgts-passo-a-passo/#:~:text=FGTS%20em%202022%3F-,O%20que%20%C3%A9%20o%20C%C3%A1lculo%20do%20FGTS%3F,a%20al%C3%ADquota%20%C3%A9%20de%202%25.)

[Calculo FGTS](https://calculomania.com/calculo-de-adicional-noturno/)

[Calculos GERAIS](https://www.calcule.net/)






 

