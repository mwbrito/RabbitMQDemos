# Topics

### Visão geral do projeto
Neste exemplo é apresentado a funcionalidade Topic. Aqui temos um cenário onde o sistema(EmitLogTopic.exe) enviará a mensagem com uma routing key definida, de modo que os sistemas subscritos(ReceiveLogsTopic.exe) poderão definir quais mensagem eles receberão, mas não necessariamente apontando para uma routing key exata, quando estamos usando tópico é possível usar os carácter '*' e '#' para fazer uma pesquisa na routing key. Neste caso o serviço conectado a um fila pode definir quais mensagens vai receber de um modo mais dinâmico, tornando o uso de topicos mais flexivel.

### Pré-requisitos
* RabbitMQ 
* VSCode

### Como utilizar
1. Abrir os projetos EmitLogTopic e ReceiveLogsTopic no VSCode
2. Abrir o prompt de comando do VSCode nas duas instâncias e compilar com o comando abaixo:
```
dotnet build
```
3. Abra três janelas do PowerShell e navegue até o diretório com o executável do projeto ReceiveLogsTopic
4. Estando dentro do diretório, chame a arquivo ReceiveLogsTopic.exe na *primeira* janelas com o seguinte parâmetro:
```
.\ReceiveLogsTopic.exe "#"
```
5. Estando dentro do diretório, chame a arquivo ReceiveLogsTopic.exe na *segunda* janelas com o
seguinte parâmetro:
```
.\ReceiveLogsTopic.exe "kern.*"
```
6. Estando dentro do diretório, chame a arquivo ReceiveLogsTopic.exe na *segunda* janelas com o
seguinte parâmetro:
```
.\ReceiveLogsTopic.exe "*.critical"
```
7. Abra mais uma janela do PowerShell e navegue até o diretório com o executável do projeto EmitLogTopic
8. Estando dentro do diretório, faça três chamadas ao arquivo EmitLogTopic.exe informando os parâmetros abaixo e observe que cada janela de ReceiveLogsTopic recebe apenas as mensagens da rota em que está subscrito.
```
.\EmitLogTopic.exe "kern.basic" "alguma coisa basica no kern"
.\EmitLogTopic.exe "local.critical" "problema local critico"
.\EmitLogTopic.exe "kern.critical" "erro critico no kern"
.\EmitLogTopic.exe "mudar.canal" "assistindo tv"
```
**No você encontrará o arquivo exemplo.jpg demonstrando o funcionamento deste exemplo.**

**Importante:** recomendo fortemente que seja utilizado o RabbitMQ localmente através de um container Docker, caso você for utilizar uma instalação em outra máquina, é necessário alterar a configuração de HostName.



