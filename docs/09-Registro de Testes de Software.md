# Registro de Testes de Software


**Data do Registro:** 27 de novembro 2024

**Versão do Software:** 4.0

<div align="center">

<br>

| **Registro de Teste** | **CT-01 – Login** |
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve permitir que os usuários realizem login com credenciais válidas. |
|Objetivo | Verificar se os usuários conseguem acessar o sistema com credenciais válidas. |
|Critérios de Aceitação | Usuários devem conseguir logar com e-mail e senha válidos, bem como acessar o sistema com as permissões definidas. |
|Método | Teste funcional. |
|Resultado | Usuários conseguem logar com as permissões definidas. |

<br>

| **Registro de Teste** | **CT-02 – Recuperação de Acesso**	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - O sistema deve disponibilizar uma página de recuperação de acesso. |
|Objetivo | Garantir que os usuários possam recuperar suas senhas. |
|Critérios de Aceitação | Usuários devem conseguir solicitar a recuperação de acesso e recuperá-lo. |
|Método | Teste funcional. |
|Resultado | Usuários conseguem acessar a recuperação e efetuar a ação. |

<br>

| **Registro de Teste**	| **CT-03 – Gerenciamento de Usinas** |
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - O sistema deve permitir ao administrador o gerenciamento completo das informações sobre as usinas cadastradas. / RF-007 - O sistema deve permitir a consulta e o monitoramento das usinas cadastradas e de sua respectiva produção de energia. |
|Objetivo |Verificar se o administrador consegue cadastrar, editar, excluir e visualizar informações das usinas. |
|Critérios de Aceitação | Administradores devem conseguir realizar todas as operações de CRUD (Create, Read, Update, Delete) para as usinas. |
|Método | Teste funcional. |
|Resultado | As operações de cadastro, edição, exclusão e visualização de usinas estão funcionando corretamente. |

<br>

| **Registro de Teste**	| **CT-04 – Gerenciamento de Fontes de Energia** |
|:---:	|:---:	|
|	Requisito Associado | RF-005 - O sistema deve permitir ao administrador o gerenciamento completo das informações sobre as fontes de energia. |
|Objetivo | Testar as funcionalidades relacionadas ao gerenciamento de fontes de energia. |
|Critérios de Aceitação | Administradores devem conseguir realizar todas as operações de CRUD (Create, Read, Update, Delete) para as fontes de energia. |
|Método | Teste funcional. |
|Resultado | As operações de CRUD para fontes de energia estão funcionando conforme o esperado. |

<br>

| **Registro de Teste** 	| **CT-05 – Gerenciamento de Produção de Energia** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006 - O sistema deve permitir ao administrador o gerenciamento completo das informações sobre a produção de energia. / RF-007 - O sistema deve permitir a consulta e o monitoramento das usinas cadastradas e de sua respectiva produção de energia.|
|Objetivo |	Verificar se o sistema permite o gerenciamento de produção de energia. |
|Critérios de Aceitação | Administradores devem conseguir realizar todas as operações de CRUD (Create, Read, Update, Delete) para os registros de produção de energia. |
|Resultado | As operações de cadastro, edição, exclusão e visualização de produção de energia estão funcionando corretamente. |

<br>

| **Registro de Teste** 	| **CT-06 – Gerenciamento de Clientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008 - O sistema deve permitir o gerenciamento completo dos clientes cadastrados, incluindo cadastro, edição, visualização e exclusão de informações. |
|Objetivo |	Verificar se o sistema permite o gerenciamento de clientes/empresas. |
|Critérios de Aceitação | Administradores devem conseguir cadastrar, editar, excluir e visualizar clientes. |
|Resultado | As operações de CRUD para clientes estão operacionais, mas ajustes de layout estão sendo feitos para melhorar a experiência do usuário. |

<br>


| **Registro de Teste** 	| **CT-07 – Gerenciamento de Usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-009 - O sistema deve permitir o gerenciamento completo dos usuários, incluindo cadastro, edição, visualização e exclusão de informações. |
|Objetivo |	Verificar se o sistema permite o gerenciamento de usuários cadastrados. |
|Critérios de Aceitação | Administradores devem conseguir cadastrar, editar, excluir e visualizar usuários. |
|Resultado | As operações de CRUD para usuários estão funcionando conforme o esperado. |

<br>

| **Registro de Teste** 	| **CT-08 – Tela de Dashboard Principal** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
|Objetivo |	Verificar se o dashboard exibe as principais informações e indicadores. |
|Critérios de Aceitação | A dashboard deve exibir dados de produção de energia, usinas cadastradas e indicadores gerais de forma clara e atualizada em tempo real. |
|Resultado | A dashboard principal foi finalizada e apresenta corretamente todas as imagens e a marca do EcoLogic. |

<br>

| **Registro de Teste** 	| **CT-09 – Gerenciamento de Permissões** |
|:---:	|:---:	|
|	Requisito Associado 	| RF-010 - O sistema deve permitir o gerenciamento de permissões e grupos de permissões, possibilitando a criação, edição e atribuição de permissões a usuários. |
|Objetivo | Verificar se o sistema permite o gerenciamento de permissões para usuários. |
|Critérios de Aceitação | Administradores devem conseguir adicionar, editar, excluir e visualizar permissões atribuídas aos usuários. |
|Resultado | A funcionalidade de gerenciamento de permissões está funcionando corretamente, permitindo a criação de grupos de permissões e a atribuição a usuários específicos. |

<br>

| **Registro de Teste** 	| **CT-10 – Gerenciamento de Grupos de Permissões** |
|:---:	|:---:	|
|	Requisito Associado 	| RF-010 - O sistema deve permitir o gerenciamento de permissões e grupos de permissões, possibilitando a criação, edição e atribuição de permissões a usuários. |
|Objetivo | Verificar se o sistema permite a criação e gerenciamento de grupos de permissões. |
|Critérios de Aceitação | Administradores devem conseguir criar, editar, excluir e visualizar grupos de permissões. |
|Resultado | O sistema permite a criação e edição de grupos de permissões, mas está em fase de ajustes para a exclusão de grupos.|

<br>

</div>

## Avaliação Final

Os testes de software realizados no sistema EcoLogic mostram que as funcionalidades principais estão operacionais e em conformidade com os requisitos definidos. O sistema já permite o login, recuperação de senha e o gerenciamento completo de usinas, fontes de energia, produção de energia, clientes, usuários, permissões e grupos de permissões. O dashboard exibe corretamente os principais indicadores de desempenho. Alguns ajustes de layout e melhorias de usabilidade estão em andamento para proporcionar uma experiência de usuário mais intuitiva e eficiente.


