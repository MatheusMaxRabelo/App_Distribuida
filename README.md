# GetReady

Trabalho apresentado na disciplina Desenvolvimento de Aplicações Distribuídas como requisito parcial para obtenção de pontos; o projeto em questão foi desenvolvido ao longo do semestre letivo visando representar o processo de desenvolvimento de uma aplicação distribuída.

# Funcionalidades

Administrador
<br>• Ser capaz de incluir alunos e professores no sistema através de um arquivo estruturado;
<br>• Ser capaz de cadastrar disciplinas;
<br>• Ser capaz de vincular um professor a uma disciplina;
<br>• Ser capaz de vincular as disciplinas a um determinado período.
<br>• Ser capaz de tornar um aluno em monitor;
<br><br>Professor
<br>• Ser capaz de manter questões;
<br>• Ser capaz de incluir materiais de apoio de acordo com o tema proposto;

# Especificação de comunicação com aplicação back-end
Nas anotações que serão exibidas como exemplo abaixo, sempre que visualizado um JSON entre colchetes “[ ]” estamos indicando que pode ser uma lista de objetos, onde se vê o valor zero “0” estamos indicando que é um valor numérico não String, e onde houver apenas abre e fecha aspas “” o valor será uma String.

| Quando  |  O professor logar  |
| ------------------- | ------------------- |
|  Recurso |  turmas_professor (Get) |
|  Parâmetro |  matrícula do professor logado |
|Modelo do JSON aguardado|{ Professor:{professor},Turmas: [turmas,]}|

| Quando  |  O monitor logar  |
| ------------------- | ------------------- |
|  Recurso |  turmas_monitor (Get) |
|  Parâmetro |  matrícula do monitor logado |
|Modelo do JSON aguardado|{     Aluno: {aluno},Turmas: [turmas,]}|

Para visualização completa do documento acesse o link: https://docs.google.com/document/d/1Rqi6V0YPnUlYpbYD8mQZSC23WFmou_UzleARmUJuOHc/edit?usp=sharing
