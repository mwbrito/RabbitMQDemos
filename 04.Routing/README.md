# Routing

### Visão geral do projeto
Neste exemplo é apresentado a funcionalidade Routing. Aqui temos um cenário onde o sistema(EmitLogDirect.exe) enviará a mensagem com uma routing key específica, de modo que os sistemas subscritos(ReceiveLogsDirect.exe) poderão definir quais mensagem eles receberão. Neste caso o serviço conectado a um fila pode definir quais mensagens vai receber, evitando receber todo o fluxo de mensagens das filas em que está subscrito.

### Pré-requisitos
* RabbitMQ 
* VSCode

### Como utilizar
1. Abrir os projetos EmitLogDirect e ReceiveLogsDirect no VSCode
2. Abrir o prompt de comando do VSCode nas duas instâncias e compilar com o comando abaixo:
```
dotnet build
```
3. Abra duas janelas do PowerShell e navegue até o diretório com o executável do projeto ReceiveLogsDirect
4. Estando dentro do diretório, chame a arquivo ReceiveLogsDirect.exe na *primeira* janelas com o seguinte parâmetro:
```
.\ReceiveLogsDirect.exe info error
```
5. Estando dentro do diretório, chame a arquivo ReceiveLogsDirect.exe na *segunda* janelas com o
seguinte parâmetro:
```
.\ReceiveLogsDirect.exe warning error
```
6. Abra mais uma janela do PowerShell e navegue até o diretório com o executável do projeto EmitLogDirect
7. Estando dentro do diretório, faça três chamadas ao arquivo EmitLogDirect.exe informando os parâmetros abaixo e observe que cada janela de ReceiveLogsDirect recebe apenas as mensagens da rota em que está subscrito.
```
.\EmitLogDirect.exe info "tá estranho"
.\EmitLogDirect.exe warning "sirene tocando"
.\EmitLogDirect.exe error "coooooorre"
```
**No você encontrara o arquivo exemplo.jpg demonstrando o funcionamento deste exemplo.**

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra maquina, é necessário alterar a configuração de HostName.



