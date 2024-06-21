# DESAFIO TÉCNICO - PASCHOALOTTO

Uma Api de Gestão de Usuários construído em Asp.Net Core e o Front em HTML e Javascript
com funcionalidades de Cadastrar, Editar e Listar todos os Usuários. Este projeto utiliza uma API externa para realizar operações Cadastro dos Usuários.


## Tecnologias Utilizadas

- Framework .NET 8
- Linguagem de programação C# e Javascript
- Linguagem de estilização CSS
- APIRest Asp.Net Web Api
- ORM EF Core
- Banco de dados PostgreSQL
- Biblioteca Jquery
- Biblioteca 2 Bootstrap 5


## Funcionalidades

### Interação

---

1. Cadastrar:
> Foi criado um botão para a funcionalidade de cadastro.
> Ao clicar no botão é feito uma requisição ajax à api https://randomuser.me/api/ que retorna  um JSON com todos os dados para criação do usuário.
> O Envio dos dados é feito automatizado, não é nessário preencher nenhum formulário.
>
> ![alt text](image-1.png)

2. Visualizar: 
> Foi adicionado um botão que abre um modal com os dados do usuário.
>
> ![alt text](image-2.png)


3. Editar: 
> Foi adicionado um botão para editar dados do usuário.
> Foi incluido apenas 1 campo com a finalidade de testar a funcionalidade.
>
> ![alt text](image-3.png)

---

## Instalação

1. Clone o repositório
```bash
git clone https://github.com/fmarcelomorais/TestePaschoalotto.git
cd TestePaschoalotto
```

2. Instale as dependências
```bash
.Net 8
```


## Configuração da API

## Uso

1. Inicie o servidor de desenvolvimento do backend
   1. Abra um terminal na pasta ..\TestePaschoalotto\src\TestePaschoalotto.Api e execulte o comando
```bash
dotnet watch
```
1. Inicie o servidor de desenvolvimento do frontend
   1. Abra um terminal na pasta ..\TestePaschoalotto\FrontEnd e execulte o comando
```bash
npm start
```

1. Abra o navegador e vá para `http://localhost:8085`.

## Contribuição

Se você quiser contribuir para este projeto, siga estas etapas:

1. Faça um fork do projeto.
2. Crie uma branch para a sua feature `git checkout -b feat/NomeDaSuaFeature`.
3. Faça commit das suas alterações `git commit -am "[add/edit/del]/feat: Descrição da feature"`.
4. Faça push para a branch `git push origin feat/NomeDaSuaFeature`.
5. Crie um novo Pull Request.


## Licença

Este projeto está licenciado sob a [Licença MIT](link-para-a-licenca).


## Contato

Se você tiver alguma dúvida ou sugestão, entre em contato através 
do email: [marcelomorais.program@gmail.com](mailto:marcelomorais.program@gmail.com).

## Links

