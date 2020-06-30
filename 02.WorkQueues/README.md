# Work Queues

### Visão geral do projeto
Neste exemplo é apresentado o funcionamento de Work Queues. Basicamente temos um sistema enviando mensagens(NewTask.exe) e podemos conectar N serviços(Worker.exe) que estarão se revezando para receber estas mensagens, de modo a evitar demora no processamento destas. 

### Pré-requisitos
* RabbitMQ 
* VSCode

### Como utilizar
1. Abrir os projetos NewTask e Worker no VSCode
2. Abrir o prompt de comando do VSCode nas duas instâncias e compilar com o comando abaixo:
```
dotnet build
```
3. Abra duas janelas do PowerShell e navegue até o diretório com o executável do projeto Worker
4. Estando dentro do diretório, chame a arquivo Worker.exe nas duas janelas
5. Abra mais uma janela do PowerShell e navegue até o diretório com o executável do projeto NewTask
6. Estando dentro do diretório, faça algumas chamadas ao arquivo NewTask.exe informando parâmetros diferentes, observe que as janelas Worker vão recebendo as mensagem de modo alternado, exemplo:
```
.\NewTask.exe mensagem 1
.\NewTask.exe mensagem 2
.\NewTask.exe mensagem 3
.\NewTask.exe mensagem 4
.\NewTask.exe mensagem 5
```
**No você encontrará o arquivo exemplo.jpg demonstrando o funcionamento deste exemplo.**

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra máquina, é necessário alterar a configuração de HostName.