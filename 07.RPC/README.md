# RPC

### Visão geral do projeto
Esta funcionalidade permite fazer a chamada à uma função em outro computador e receber a resposta desta.

### Pré-requisitos
* RabbitMQ 
* VSCode

### Como utilizar
1. Abrir os projetos RPCServer e RpcClient no VSCode
2. Abrir o prompt de comando do VSCode nas duas instâncias e compilar com o comando abaixo:
```
dotnet build
```
3. Abra uma janela do PowerShell e navegue até o diretório com o executável do projeto RPCServer
4. Estando dentro do diretório, chame a arquivo RPCServer.exe
5. Abra mais uma janela do PowerShell e navegue até o diretório com o executável do projeto RpcClient
6. Estando dentro do diretório, faça algumas chamadas ao arquivo RpcClient.exe, observe que a janela RPCServer estará recebendo as chamadas

**No você encontrará o arquivo exemplo.jpg demonstrando o funcionamento deste exemplo.**

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra máquina, é necessário alterar a configuração de HostName.