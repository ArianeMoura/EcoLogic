# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

<br>

## Diagrama de Classes

<div align="center">
 
![image](https://github.com/user-attachments/assets/654caea2-5054-464f-8cb2-0e49343ed5ba)

</div>

<h4 align="center">FIGURA 17</h4>


<br>

## Modelo ER (Projeto Conceitual)

Conforme a Especificação do Projeto EcoLogic, o Modelo ER, que apresenta as relações entre as entidades, está ilustrado nas figuras abaixo:

<img width="2308" alt="Modelo_ER-Ecologic" src="https://github.com/user-attachments/assets/07b8af5f-8d1f-446f-a9f2-bca420ae5219">
<h4 align="center">FIGURA 18</h4>

<br>

## Projeto da Base de Dados
 
![Projeto_Base_de_Dados-EcoLogic](https://github.com/user-attachments/assets/1d8c5fe9-55fb-449b-b4c5-cdaf6e54d5b1)
<br>
<h4 align="center">FIGURA 19</h4>

<br>

## Tecnologias Utilizadas no Projeto EcoLogic

Para o desenvolvimento do Projeto EcoLogic, diversas tecnologias foram utilizadas para criar uma solução robusta e eficiente para o gerenciamento de usinas de energia renovável. Abaixo estão listadas as principais ferramentas e tecnologias adotadas, que abrangem desde o design do front-end até a estrutura de banco de dados e o back-end da aplicação:

### Tecnologias Utilizadas
- **HTML e CSS:** Utilizados para a estrutura e estilo das páginas web. HTML define a estrutura e o conteúdo, enquanto CSS aplica o design visual, garantindo que o layout seja responsivo e atraente para diferentes tamanhos de tela.
  
- **JavaScript:** Responsável pela interatividade do site e pelas funcionalidades dinâmicas, como manipulação de eventos e validações de dados no lado do cliente.
  
- **C#:** Linguagem de programação principal utilizada no back-end para a lógica de negócio e controle da aplicação. C# é também empregado para a integração com o banco de dados e manipulação dos dados na aplicação.
  
- **ASP.NET Core 8.0:** Framework de desenvolvimento web utilizado para criar a API e gerenciar as interações do usuário com o back-end. ASP.NET Core oferece uma estrutura poderosa para desenvolvimento de aplicações modernas e escaláveis, permitindo a criação de rotas, serviços e controle de autenticação e autorização.
  
- **Entity Framework:** Utilizado como ORM (Object-Relational Mapping) para facilitar a comunicação entre o código C# e o banco de dados SQL Server. Entity Framework simplifica a criação de operações CRUD (Create, Read, Update, Delete) e garante uma maior flexibilidade na manipulação de dados.

- **SQL Server:** Banco de dados relacional utilizado para armazenamento persistente das informações da aplicação, como dados das usinas, produção de energia, relatórios, entre outros. SQL Server permite uma gestão eficiente dos dados, oferecendo segurança e integridade.
  
- **Bootstrap:** Utilizado no front-end para estilização e responsividade. Com seus componentes pré-desenhados, o Bootstrap facilita a criação de interfaces modernas e adaptáveis a dispositivos móveis, reduzindo o tempo de desenvolvimento do design.
  

### Ferramentas e IDEs
- **Visual Studio Code:** Utilizado para editar e organizar os arquivos HTML, CSS, JavaScript e IDE principal para desenvolvimento com C# e ASP.NET Core, facilitando o trabalho com o back-end e integração com o SQL Server.
  
- **Git e GitHub:** Plataforma para controle de versão e colaboração, onde o código é armazenado e versionado, facilitando o trabalho em equipe e a documentação do projeto.


### Interação e Fluxo de Dados
Abaixo, descrevemos como as tecnologias interagem no fluxo de uma operação do usuário:

— *Interação do Usuário:* O usuário acessa a interface da aplicação através de um navegador, interagindo com as telas de monitoramento, relatórios e gestão de usinas.

— *Front-End:* A interface HTML/CSS, com funcionalidades dinâmicas em JavaScript e elementos responsivos do Bootstrap, processa a interação do usuário e envia as requisições para o servidor.

— *Back-End:* O ASP.NET Core recebe as requisições do front-end e, por meio dos serviços e controladores, processa a lógica de negócios em C#.

— *Banco de Dados (SQL Server):* Através do Entity Framework, o ASP.NET Core interage com o SQL Server, realizando operações de consulta, atualização e exclusão conforme necessário. O Entity Framework facilita a conversão dos dados entre o banco e os objetos da aplicação, mantendo a integridade dos dados.

— *Resposta ao Usuário:* Após o processamento da requisição e obtenção dos dados, o back-end envia a resposta de volta ao front-end, que exibe os resultados ao usuário na interface da aplicação.

Essas tecnologias, trabalhando em conjunto, proporcionam uma aplicação escalável, segura e eficiente para o monitoramento e gestão de usinas de energia renovável no EcoLogic.

<br>

## Hospedagem do Sistema EcoLogic

A plataforma EcoLogic foi hospedada na **Microsoft Azure**, garantindo uma solução segura, escalável e de alta disponibilidade para os usuários. A escolha da **Azure** se deu pela sua capacidade de oferecer um ambiente robusto para o desenvolvimento, teste e disponibilização de aplicações web, além de suportar as tecnologias utilizadas no projeto, como ASP.NET Core e SQL Server.

O processo de hospedagem envolveu a configuração de um App Service na Azure, onde o aplicativo foi implantado diretamente a partir do repositório do GitHub, permitindo a integração contínua (CI/CD) e facilitando as atualizações automáticas. Essa abordagem garantiu que todas as alterações feitas no repositório fossem refletidas no ambiente de produção de forma ágil e controlada.

Além disso, a Azure proporcionou um ambiente seguro e protegido, com recursos de monitoramento e logs em tempo real, permitindo a análise de desempenho e a identificação de possíveis falhas. A hospedagem na Azure assegura que o EcoLogic esteja sempre acessível aos usuários, mantendo alta disponibilidade e desempenho consistente.

Com essa estratégia, o sistema passou a ser acessível via navegador, sem a necessidade de instalações locais, proporcionando praticidade e acessibilidade para as equipes que utilizam a plataforma para gerenciamento de usinas de energia renovável.


### Link da Hospedagem:

https://ecologic-adeqbxd2fuc8a8gm.eastus2-01.azurewebsites.net/

