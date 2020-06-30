# Publish/Subscribe

### Visão geral do projeto
Neste exemplo é apresentado a funcionalidade Publish/Subscribe. Aqui temos um cenário onde o sistema(EmitLog.exe) publicará a mensagem e todos os sistemas subscritos(ReceiveLogs.exe) receberão a mensagem. Neste caso a intenção é que todos os serviços subscritos possam receber a mensagem e cada um faça a sua tarefa específica.

### Pré-requisitos
* RabbitMQ 
* VSCode

### Como utilizar
1. Abrir os projetos EmitLog e ReceiveLogs no VSCode
2. Abrir o prompt de comando do VSCode nas duas instâncias e compilar com o comando abaixo:
```
dotnet build
```
3. Abra duas janelas do PowerShell e navegue até o diretório com o executável do projeto ReceiveLogs
4. Estando dentro do diretório, chame a arquivo ReceiveLogs.exe nas duas janelas
5. Abra mais uma janela do PowerShell e navegue até o diretório com o executável do projeto EmitLog
6. Estando dentro do diretório, faça algumas chamadas ao arquivo EmitLog.exe e observe como que as duas janelas ReceiveLogs recebem a mensagem praticamente ao mesmo tempo.

**No você encontrará o arquivo exemplo.jpg demonstrando o funcionamento deste exemplo.**

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra máquina, é necessário alterar a configuração de HostName.