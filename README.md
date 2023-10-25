# Salva Anexo Email
### Objetivo
 Este console tem como objetivo estudar o protocolo IMAP e POP para acesso de e-mail, aplicando na prática por meio da biblioteca OpenPop.

 ### Conexão 
  Para conectar a algum e-mail, primeiro é necessário procurar o servidor, porta e se requer SSL(Secure Sockets Layer) para aquele provedor. No caso do yahoo por exemplo:
* Servidor de entrada de e-mails (POP)
* * Servidor: pop.mail.yahoo.com
* * Porta: 995
* * Requer SSL: Sim

~~~c# 
client.Connect("pop.mail.yahoo.com", 995, true);
~~~
Estas informações estão disponíveis no link: https://br.ajuda.yahoo.com/kb/SLN4724.html

Também será necessário a criação de um app por meio da conta de quem irá se conectar ao servidor, esse app gerará uma senha que será trocada pela senha do user durante a autenticação.

Esta senha pode ser criada seguindo os passos do seguinte link: https://br.ajuda.yahoo.com/kb/Gerar-e-gerenciar-senhas-de-aplicativo-de-terceiros-sln15241.html

~~~c# 
client.Authenticate("user", "senhaApp", AuthenticationMethod.UsernameAndPassword);
~~~

Após estes passos a conexão estará pronta para funcionar!

### Mas afinal, o que é IMAP e POP!?
Ambos são protocolos de acesso de e-mail, ou seja eles ditam as regras para as conexões entre sistemas.

* IMAP	- Este protocolo possuí acesso a todas as pastas da conta e atualiza as informações dos e-mails, ou seja, se efetuarmos uma alteração, tanto via código quanto no servidor, será espelhado nos 2 destinos.

* POP	- Já o pop, possuí acesso somente a caixa de entrada e baixa as informações no PC do user, assim, não espelhando as atualizações feitas localmente ao servidor.

<img src="https://www.locahost.com.br/wp-content/uploads/2018/12/POP-vs-IMAP.png">

### Autor
<h3> Bruno Luiz</h3>

*  👨🏻‍💻 https://github.com/Zezao1224
*  🔗 https://www.linkedin.com/in/brunoluizdesouza/
*  📧 brunoluiz1809@gmail.com
