# Iniciando Com AspNetCore
Este reposit�rio cont�m um projeto criado a partir de um curso da plataforma desenvolvedor.io, 
focado em ASP.NET Core. O objetivo deste projeto � apresentar uma introdu��o completa ao 
framework ASP.NET, desde sua configura��o inicial at� o entendimento do que acontece "por baixo dos panos" 
durante o ciclo de vida de uma aplica��o.

## Ambiente Visual Studio Community:
- Com double-click em demoVS em "Solution Explorer" voc� ve as informa��es de vers�es, pacotes utilizados e 
configura��es de seu projeto.

- Program.cs seria o codigo inicial executado de seu projeto.

- Em properties launchsettings.json seria as configura��es de dominio http(s) de seu projeto.

## Pacotes Nuget
- Em search(lupa) no visual studio code e pesquisar por Package Manager Console sera o terminal para fazer 
instala��es de pacote(NuGet)

- Clicando com o bot�o direto do mouse em demoVS em "Solution Explorer" e "manage NuGet Packages" sera poss�vel 
adicionar as bibliotecas. 

- Para ver mais bibliotecas basta acessar o site: https://www.nuget.org/packages/ 

- E terminal Package Manager Console insera o comando de instala��o por exemplo: 
	```bash
	Install-Package Serilog.AspNetCore -Version 8.0.2

## Middlewares
O que � um Middleware?

- Middlewares s�o componentes de software em uma aplica��o ASP.NET. Estes componentes manipulam dados entre 
os requests e responses.

- Um middleware possui uma responsabilidade definida e pode trabalhar lado a lado com outros middlewares. 
Quando falamos do pipeline do ASP.NET estamos falando basicamente de Middlewares.

- No programa meuMiddleWare.cs vera um exemplo pr�tico.

### Executar HTTPS
- Para poder executar o projeto com https(uma vers�o segura do HTTP) sera necess�rio seguir os seguintes passos:
    
1. Saber se possui um certificado valido para utilizar nos comando http:
    ```bash
    dotnet dev-certs https --check
    
2. Fazer uma limpeza no certificado:
    ```bash
    dotnet dev-certs https --clean


3. Criar um novo certificado:
    ```bash
    dotnet dev-certs https

4. Confirmar que o novo certificado � confi�vel:
    ```bash
    dotnet dev-certs https --trust

## Execu��o
![Execu��o](imgs/Exec1.png)



