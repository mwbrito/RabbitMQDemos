# Hello World

### Visão geral do projeto
Primeiro passo com no RabbitMQ, neste projeto temos um aplicativo de linha de comando em C#.NET que faz o simples envio e o recebimento de uma mensagem.

### Pré-requisitos
* RabbitMQ 
* VSCode
* dotnet add package RabbitMQ.Client --version 6.0.0

### Como utilizar
1. Abrir o projeto no VSCode
2. Abrir o prompt de comando e executar o comando abaixo:
```
dotnet run
```

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra máquina, é necessário alterar a configuração de HostName.
