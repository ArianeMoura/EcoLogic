# Plano de Testes de Software

| **Caso de Teste** | **CT-01 – Login** |
|:---:	|:---:	|
| **Requisito Associado** | RF-001 - A aplicação deve permitir que os usuários realizem login. |
| **Objetivo do Teste** | Verificar se o usuário consegue realizar login na aplicação. |
| **Passos** | 01-Acessar a Página de Login. <br> 02-Preencher os campos _E-mail_ e _Senha_ com os respectivos dados de acesso. <br> 03-Clicar no botão _Login_. |
| **Critério de Êxito** | - Logar. |
|  	|  	|
| **Caso de Teste** | **CT-02 – Recuperação de Senha** |
| **Requisito Associado** | RF-002 - A aplicação deve fornecer uma página de recuperação de senha que permita o envio de um link de redefinição para o email do usuário cadastrado. |
| **Objetivo do Teste** | Verificar se o usuário consegue solicitar a recuperação de senha. |
| **Passos** | 01-Acessar a _Página de Login_. <br> 02-Clicar no botão _"Esqueceu a senha?"_ <br> 03-Inserir o email cadastrado para receber o link de recuperação. <br> 04-Clicar no botão _Enviar link de Recuperação_. |
| **Critério de Êxito** | - Mensagem _Link de recuperação enviado para email_. |
|  	|  	|
| **Caso de Teste** | **CT-03 – Página de Contato** |
| **Requisito Associado** | RF-003 - A aplicação deve disponibilizar uma página de contato que permita ao usuário enviar mensagens diretamente ao administrador, com campos para nome, empresa, localização, email, telefone e mensagem. |
| **Objetivo do Teste** | Verificar se o usuário consegue enviar uma mensagem de contato. |
| **Passos** | 01-Acessar a Página de Contato. <br> 02-Preencher os campos obrigatórios. <br> 03-Clicar em _Enviar_. |
| **Critério de Êxito** | - Mensagem _Recebemos sua solicitação de contato! Retornaremos em breve_. |
|  	|  	|
| **Caso de Teste** | **CT-04 – Cadastro de Clientes** |
| **Requisito Associado** | RF-004 - O administrador deve ser capaz de cadastrar novos clientes e editá-los no sistema. |
| **Objetivo do Teste** | Verificar se o administrador consegue cadastrar clientes no sistema. |
| **Passos** | 01-O administrador deverá estar logado. <br> 02-Acessar a página _Clientes_. <br> 03-Clicar em _Adicionar Cliente_. <br> 04-Preencher os dados do cliente. <br> 05-Clicar em _Cadastrar_. |
| **Critério de Êxito** | - Cliente aparece cadastrado na página. |
|  	|  	|
| **Caso de Teste** | **CT-05 – Gerenciamento** |
| **Requisito Associado** | RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
| **Objetivo do Teste** | Verificar se o administrador consegue gerenciar usinas ou fontes de energia no sistema. |
| **Passos** | 01-O administrador deverá estar logado. <br> 02-Acessar a página _Usinas_ ou _Fontes de Energia_. <br> 03-Clicar em _Adicionar Nova Usina_ ou _Adicionar Fontes de Energia_. <br> 04-Preencher os dados obrigatórios. <br> 05-Clicar no botão _Cadastrar_. |
| **Critério de Êxito** | - Número de usinas ou fontes de energia cadastradas é atualizado. |
|  	|  	|
| **Caso de Teste** | **CT-06 – Relatórios** |
| **Requisito Associado** | RF-006 - O sistema deve gerar relatórios detalhados e gráficos sobre o desempenho energético. |
| **Objetivo do Teste** | Verificar se o usuário consegue visualizar os relatórios gerados. |
| **Passos** | 01-O usuário deverá estar logado. <br> 02-Acessar a página _Relatórios_. |
| **Critério de Êxito** | - Relatório está visível e detalhado na página. |
|  	|  	|
| **Caso de Teste** | **CT-07 – Alertas** |
| **Requisito Associado** | RF-007 - O sistema deve emitir alertas e notificações em tempo real sobre acontecimentos importantes na produção, eficiência energética e outros eventos. |
| **Objetivo do Teste** | Verificar se o administrador recebe alertas gerados no sistema. |
| **Passos** | 01-O usuário deverá estar logado como _Administrador_. <br> 02-Acessar a página _Produção_. <br> 03-Clicar no botão _Gerar Evento_. <br> 04-Monitorar se o alerta foi recebido. |
| **Critério de Êxito** | - Alerta recebido. |
|  	|  	|
| **Caso de Teste** | **CT-08 – Melhorias** |
| **Requisito Associado** | RF-008 - O sistema deve fornecer recomendações de melhorias na eficiência energética com base na análise de dados registrados e desempenho atual. |
| **Objetivo do Teste** | Verificar se o sistema gera recomendações de melhorias com base nos dados. |
| **Passos** | 01-O usuário deverá estar logado. <br> 02-Acessar a página _Produção_. <br> 03-Analisar os dados apresentados. <br> 04-Verificar as recomendações geradas. |
| **Critério de Êxito** | - Recomendações são geradas com base nos dados. |
|  	|  	|
| **Caso de Teste** | **CT-09 – Exportar Relatórios** |
| **Requisito Associado** | RF-009 - O sistema deve permitir que os clientes visualizem e exportem relatórios de produção e eficiência energética. |
| **Objetivo do Teste** | Verificar se o usuário consegue exportar relatórios do sistema. |
| **Passos** | 01-O usuário deverá estar logado. <br> 02-Acessar a página _Relatórios_. <br> 03-Clicar no botão _Exportar Relatório_. |
| **Critério de Êxito** | - Relatório gerado em PDF. |
|  	|  	|
