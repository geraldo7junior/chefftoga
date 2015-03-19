|<a href='http://code.google.com/p/chefftoga'>Home</a>|<a href='http://code.google.com/p/chefftoga/wiki/DescricaoDoProjeto'>Descrição Do Sistema</a>|<a href='http://code.google.com/p/chefftoga/wiki/Requisitos'>Requisitos</a>|<a href='http://code.google.com/p/chefftoga/wiki/CasosDeUso'>Casos de Uso</a>|<a href='http://code.google.com/p/chefftoga/wiki/DiagramasDeCasosDeUso'>Diagramas</a>|<a href='http://code.google.com/p/chefftoga/wiki/ModeloDeEntidadeRelacional'>Modelo de Entidade Relacional</a>|<a href='http://code.google.com/p/chefftoga/wiki/Desenvolvedores'>Desenvolvedores</a>|<a href='http://code.google.com/p/chefftoga/wiki/Bibliografia'>Bibliografia</a>|<a href='http://code.google.com/p/chefftoga/wiki/video'>Vídeos</a>| |
|:----------------------------------------------------|:----------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------|:----------------------------------------------------------------------------|:------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------|:------------------------------------------------------------------------------|:------------------------------------------------------------------|:|


<h2><b>

<FONT FACE="TIMES" SIZE="1">

<p align='right'>Detalhamento dos Casos de Uso Cheff Toga System</p>

Unknown end tag for </font>

<br>
<br>
Unknown end tag for </b><br>
<br>
<br>
<br>
Unknown end tag for </h2><br>
<br>
<br>
<br>
<br>
<hr><br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0001</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Autenticação</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Controle dos usuários do sistema, aumentando a segurança, e filtrando o acesso de distintos usuários deste.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O usuário acessa o sistema por meio de um ID e Senha e a partir destes é direcionado para sua devida área de acesso.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Operador de caixa, Operador de cadastro e Gerente.</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>Estar cadastrado no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Acessar áreas diversas do sistema.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O usuário fornece ao sistema seu ID e senha e acessa este.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. O usuário não cadastrado deve procurar o gerente do projeto ou o operador de cadastro.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0002</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Cadastro</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Cadastrar, recadastrar e excluir alunos do sistema.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O aluno entrará em contato com o operador de cadastro, onde este poderá realizar o cadastro de tal aluno no sistema. Este também pode realizar recadastro de alunos no sistema, onde por meio deste poderá alterar informações e confirmar a matricula dos universitários a cada período. Também haverá a possibilidade de visualizar dados bem como imprimi-los, como forma de comprovação de cadastramento no sistema.</td></tr>
<tr><td><i>O cadastro do aluno ocorrerá frente ao fornecimento das informações:</i></td></tr>
<tr><td>•	ID Card (obrigatório);</td></tr>
<tr><td>•	Nome (obrigatório);</td></tr>
<tr><td>•	Identidade (obrigatório);</td></tr>
<tr><td>•	Data de nascimento (obrigatório);</td></tr>
<tr><td>•	CPF (obrigatório);</td></tr>
<tr><td>•	Curso (obrigatório);</td></tr>
<tr><td>•	Período (obrigatório);</td></tr>
<tr><td>•	Endereço(Rua; Número; Bairro; Cidade; UF e CEP)(obrigatório);</td></tr>
<tr><td>•	Foto (obrigatório);</td></tr>
<tr><td>•	Fone (obrigatório);</td></tr>
<tr><td>•	Bolsista/Gratuidade (obrigatório);</td></tr>
<tr><td>•	Senha (obrigatório);</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Operador de cadastro</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O operador está cadastrado no sistema. E o aluno esta devidamente matriculado na universidade.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Após confirmadas as informações e realizado o processo de cadastro, o aluno é tido como cadastrado no sistema.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O aluno é cadastrado com sucesso no sistema.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso as informações fornecidas pelo aluno não forem similares ao padrão, por exemplo, cpf, o qual mantém um padrão, o programa informará a falta de dígitos;</td></tr>
<tr><td>2. Caso o aluno não esteja como matriculado na instituição deverá procurar os órgãos cabíveis para confirmação de tal matrícula.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0003</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciamento de Crédito Financeiro do Usuário</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Recarga de saldo e Visualização</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O aluno entrará em contato com o operador de crédito, onde este poderá realizar a recarga de saldo do mesmo no sistema. Este também pode verificar saldo com sentido informativo e imprimir comprovante de recarga. </td></tr>
<tr><td><i>A recarga de saldo do aluno ocorrerá frente ao fornecimento das informações:</i></td></tr>
<tr><td>•	ID (“Smart card”) (obrigatório);</td></tr>
<tr><td>•	Pagamento (obrigatório).</td></tr>
<tr><td>•	Identidade (obrigatório);</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Operador de cadastro e aluno</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O operador de recarga está cadastrado no sistema e o aluno esta devidamente matriculado na universidade e no sistema do restaurante.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Após confirmado o ID(“Smart Card”)  e o pagamento a recarga é realizada com sucesso.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O aluno consegue efetuar a recarga.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso haja algum problema com o ID(“Smart Card”) o aluno deverá procurar os órgãos responsáveis;</td></tr>
<tr><td>2. Caso o aluno não esteja como matriculado na instituição deverá procurar os órgãos cabíveis para confirmação de tal matrícula.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0004</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Entrada no Restaurante</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Controle da entrada dos alunos no restaurante, bem como a autenticação destes para entrar no estabelecimento.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O operador de caixa já autenticado no sistema poderá ter acesso à uma página de autenticação, nesta quando o aluno fazer a entrada com seu Smart Card(Com um ID implícito) o operador de caixa terá algumas informações avista como, por exemplo, Nome, Curso, Período e foto, Confirmada estas informações este poderá permitir ou não a entrada do aluno no restaurante.</td></tr>
<tr><td><i>O Operador de entrada poderá visualizar as seguintes informações do aluno:</i></td></tr>
<tr><td>•	ID Card;</td></tr>
<tr><td>•	Nome;</td></tr>
<tr><td>•	CPF;</td></tr>
<tr><td>•	Curso;</td></tr>
<tr><td>•	Período;</td></tr>
<tr><td>•	Saldo;</td></tr>
<tr><td>•	Foto;</td></tr>
<tr><td>•	Fone;</td></tr>
<tr><td>•	Bolsista/Gratuidade;</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Operador de caixa e Aluno</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O operador de recarga está cadastrado no sistema e o aluno esta devidamente matriculado na universidade e no sistema do restaurante.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Obter algumas informações do aluno, e a partir destas permiti acesso ao restaurante.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O operador de caixa vê as informações do aluno e permiti a entrada deste no restaurante.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o cartão esteja sem crédito, a mensagem saldo insuficiente será exibida;</td></tr>
<tr><td>2. Caso o cartão esteja cadastrado como aluno não matriculado, tal ação também será informada;</td></tr>
<tr><td>3. Se o aluno perder o Smart  Card (ID implícito) terá um prazo para acessar o sistema com login e senha, dados no cadastramento, até adquirir o novo cartão;</td></tr>
<tr><td>4. Se o aluno não for cadastrado no sistema deverá procurar o operador de cadastro.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0005</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Informações</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Analisar, alterar enfim  gerenciar as informações dos estudantes e funcionários.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O gerente do restaurante poderá ter acesso e controlar informações referentes aos alunos cadastrados e funcionários do sistema. Tal gerente possui acesso privilegiado ao sistema, podendo atuar com as mesmas funções dos demais operadores. Este ainda possui acessos exclusivos, como o cadastro de operadores nas demais atividades do sistema, como também um sistema inteligente de busca de informações, estas referentes a movimentações, datas e horários cabíveis aos tipos de entradas dos alunos, como também, funcionando como ferramenta de controle e segurança, onde se sabe quem era o operador em determinada ação no sistema. Tal caso de uso visa o estabelecimento da organização e gerencia do restaurante por parte de seu operador. </td></tr>
<tr><td><i>O cadastro dos operadores ocorrerá frente ao fornecimento das informações:</i></td></tr>
<tr><td>•	ID Card (obrigatório);</td></tr>
<tr><td>•	Nome (obrigatório);</td></tr>
<tr><td>•	Identidade (obrigatório);</td></tr>
<tr><td>•	Data de nascimento (obrigatório);</td></tr>
<tr><td>•	CPF (obrigatório);</td></tr>
<tr><td>•	Endereço(Rua; Número; Bairro; Cidade; UF e CEP)(obrigatório);</td></tr>
<tr><td>•	Foto (obrigatório);</td></tr>
<tr><td>•	Fone (obrigatório);</td></tr>
<tr><td>•	Tipo de Operador (obrigatório);</td></tr>
<tr><td>•	Senha (obrigatório);</td></tr>
<tr><td><i>A geração de relatórios será realizada frente aos filtros:</i></td></tr>
<tr><td>•	Id da movimentação;</td></tr>
<tr><td>•	Data da movimentação;</td></tr>
<tr><td>•	Hora da movimentação;</td></tr>
<tr><td>•	Tipo de movimentação;</td></tr>
<tr><td>•	Campos alterados;</td></tr>
<tr><td>•	Observações;</td></tr>
<tr><td>•	Valores;</td></tr>
<tr><td>•	Card Operador/Aluno;</td></tr>
<tr><td>•	Cpf Operador/Aluno;</td></tr>
<tr><td>•	Nome Operador/Aluno;</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Gerente</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O gerente está no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O gerente pode realizar ações no sistema.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O gerente pode realizar ações no sistema.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o gerente não esteja conseguindo acessar o sistema deverá procurar os desenvolvedores;</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0006</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Finanças</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Relatar movimentações financeiras periódicas ao gerente.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O gerente do restaurante poderá gerenciar os ganhos do estabelecimento a partir de diversos filtros, poderá analisar ganhos por aluno, por dia, mês, dentre outros.Este caso de uso visa um controle de porte financeiro, informando ao gerente quais os horários de maior arrecadação, quais os alunos com maiores e menores gastos, enfim um sistema inteligente de relatórios financeiros.  </td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Gerente</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O gerente está no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O gerente pode realizar o gerenciamento das finanças.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O gerente pode realizar o gerenciamento das finanças.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o gerente não esteja conseguindo acessar o sistema deverá procurar os desenvolvedores.</td></tr>
<br>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>



<h2><b>

<FONT FACE="TIMES" SIZE="1">

<p align='right'>Detalhamento dos Casos de Uso Cheff Toga.com</p>

Unknown end tag for </font>

<br>
<br>
Unknown end tag for </b><br>
<br>
<br>
<br>
Unknown end tag for </h2><br>
<br>
<br>
<br>
<br>
<hr><br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0001</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Cardápios</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Informar o cardápio aos clientes.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O aluno poderá acessar o site e ter informações sobre o cardápio da semana, este atualizado semanalmente pela nutricionista.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno e Nutricionista</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O aluno ter acesso à internet;</td></tr>
<tr><td>A nutricionista ter atualizado as informações do cardápio.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O aluno consegue visualizar os cardápios.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O aluno consegue visualizar os cardápios.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso a nutricionista não esteja cadastrada no sistema, deve procurar o gerente do restaurante.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0002</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Sugestões</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>O aluno poder opinar diretamente ao gerente.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O Aluno poderá dar sugestões e opiniões sobre distintos aspectos referentes ao restaurante, tendo contato direto como o gerente.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno, Gerente.</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O Aluno fornecer alguns dados, não necessariamente se identificar, e o gerente ter acesso ao sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O gerente pode ter acesso à sugestão e analisar esta.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O gerente recebe a sugestão com sucesso.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o gerente não esteja cadastrado no sistema deve procurar o desenvolvedor.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0003</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Questionário</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Fazer uma pesquisa referente ao restaurante.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>Questionário elaborado pelo gerente do restaurante com fins de pesquisas e analises frente às respostas dos alunos.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno, Gerente.</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O Questionário está elaborado e o gerente ter acesso ao sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O gerente recebe as respostas dos questionários.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O gerente recebe as respostas dos questionários.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o gerente não esteja cadastrado no sistema deve procurar o desenvolvedor.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0004</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Login</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Controle dos usuários do sistema, aumentando a segurança e caracterizando distintos gêneros de acesso.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O usuário acessa o sistema por meio de um ID e Senha e a partir destes é direcionado para distintas atividades.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O aluno está cadastrado no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Acessar áreas diversas do sistema.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O usuário fornece ao sistema seu ID e senha e acessa este.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o aluno digite o login e senha errados,  o erro será relatado e eles terão a possibilidade de tentar outra vez;</td></tr>
<tr><td>2. O usuário não cadastrado deve procurar o operador de cadastro.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0005</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Saldo</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Conferir o saldo do Smart Card.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O aluno ,após feito o login, poderá observar o saldo atual de seu Smart Card.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O aluno está no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O aluno poderá observar seu saldo.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O aluno poderá observar seu saldo.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso haja alguma alteração o aluno deverá entrar em contato com o gerente;</td></tr>
<tr><td>2. Caso o aluno não esteja cadastrado, deverá procurar o operador de cadastro.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0006</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Recarga</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Realizar recargas no Smart Card.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O aluno poderá recarregar seu smart card online ou imprimir boleto para pagar em algum estabelecimento cadastrado.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O aluno está devidamente cadastrado no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O aluno consegue realizar sua operação de recarga.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>É possível realizar sua operação de recarga</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o gerente não esteja conseguindo acessar o sistema deverá procurar os desenvolvedores.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0007</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Dados Pessoais</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>O aluno poderá observar seus dados pessoais.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O aluno poderá observar seus dados pessoais e analisar se estes estão corretos.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O aluno está devidamente cadastrado no sistema.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O aluno conseguirá observar os seus dados.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O aluno conseguirá observar os seus dados.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o aluno não esteja cadastrado, ou informações estejam incorretas, este deverá procurar o operador de cadastro.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0008</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Contato</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Espaço para contato com o gerente e o operador de cadastro.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>Neste estágio o aluno poderá entrar em contado com o operador de cadastro, por exemplo, para pedir retificações em seus dados ou informar algum defeito do sistema.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Aluno, Gerente, Operador de cadastro.</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>O aluno está devidamente cadastrado no sistema, bem como o gerente e o operador de cadastro.</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>O aluno conseguirá entrar em contado com o gerente ou o operador de cadastro.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O aluno conseguirá entrar em contado com o gerente ou o operador de cadastro.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. Caso o aluno não esteja cadastrado, deverá procurar o operador de cadastro. Caso este ultimo ou o gerente não estejam cadastrados no sistema devem procurar o desenvolvedor.</td></tr>
<br>
<br>
<br>
<br>
<hr><br>
<br>
</tbody></table>



<h2><b>

<FONT FACE="TIMES" SIZE="5">

<p align='CENTER'>Cheff Toga Aplicativo: Cardápio</p>

Unknown end tag for </font>

<br>
<br>
Unknown end tag for </b><br>
<br>
<br>
<br>
Unknown end tag for </h2><br>
<br>
<br>
<br>
<hr><br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0001</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar cardapio</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Informar e controlar o cardapio da semana no restaurante.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O operador responsável por atualizar o cardápio deve atualizar este no final de semana e assim este ser atualizado e visualizado pelos usuários do aplicativo.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Operador do Cardápio, Usuário.</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>1. Para o operador de cardapio; está cadastrado no sistema</td></tr>
<tr><td>2. Para o usuário; Ter o aplicativo instalado no seu smartphone </td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Acessar o cardápio.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O usuário consegue visualizar o cardápio</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td>1. O operador não cadastrado deve procurar o gerente.</td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>

<h2><b>

<FONT FACE="TIMES" SIZE="5">

<p align='CENTER'>Cheff Toga Aplicativo: Gerente</p>

Unknown end tag for </font>

<br>
<br>
Unknown end tag for </b><br>
<br>
<br>
<br>
Unknown end tag for </h2><br>
<br>
<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>
<b><h3>Número do caso de uso: UC0001</h3></b><br>
<table><thead><th><b>Nome do caso de uso:</b></th></thead><tbody>
<tr><td>Gerenciar Geração de Relatório</td></tr>
<tr><td><b>Objetivos:</b></td></tr>
<tr><td>Informar as movimentações do dia.</td></tr>
<tr><td><b>Descrição:</b></td></tr>
<tr><td>O gerente poderá por meio do aplicativo ter acesso a todas as movimentações ocorridas no dia por meio de relatório em seu smartphone.</td></tr>
<tr><td><b>Ator:</b></td></tr>
<tr><td>Gerente.</td></tr>
<tr><td><b>Prioridade:</b></td></tr>
<tr><td>Alta</td></tr>
<tr><td><b>Pré-condição:</b></td></tr>
<tr><td>1. o gerente ter o aplicativo instalado no seu smartphone</td></tr>
<tr><td><b>Pós-condição:</b></td></tr>
<tr><td>Visualizar o relatório.</td></tr>
<tr><td><b>Cenários Principais dos casos de uso:</b></td></tr>
<tr><td>O gerente consegue Visualizar o relatório.</td></tr>
<tr><td><b>Fluxos Alternativos:</b></td></tr>
<tr><td> - </td></tr>
<br></tbody></table>

<br>
<br>
<hr><br>
<br>
<br>
<br>
<br>