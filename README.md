# Acessando Dados Com Dotnet

- ``SqlConnection`` é reponsável por fazer a conexão com o banco de dados
- ``SqlCommand`` é usado para construir as consultas. Ele requer uma conexão aberta!
- Ao executar um comando o resultado é um objeto do tipo ``SqlDataReader``. Ele é um cursor e é preciso ler em um while para recuperar as informações/linhas.