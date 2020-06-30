# Publicher Confirm

### Visão geral do projeto
Neste projeto é implementada a confirmação de mensagem, deste modo o serviço que envia a mensagem tem a garantia que o broker recebeu a mensagem. Neste exemplo são implementadas três estratégias de confirmação:
1. Individual: as mensagens são confirmadas individualmente de modo síncrono, uma a uma
2. Batch: é enviado um lote de mensagens e recebe-se ao final uma confirmação para todo o lote
3. Assíncrono: as confirmações são enviadas individualmente, mas de modo assíncrono.

### Pré-requisitos
* RabbitMQ 
* VSCode

### Como utilizar
1. Abrir o projeto no VSCode
2. Abrir o prompt de comando e executar o comando abaixo:
```
dotnet run
```
**Neste exemplo são enviadas muitas mensagens, um demora no processamento é esperada.**

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra máquina, é necessário alterar a configuração de HostName.