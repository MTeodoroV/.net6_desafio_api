# .net6_desafio_api

<h3>Como rodar o desafio 1:</h3>
<br>
<p>No terminal do projeto deve-se utilizar o comando:</p>

```
dotnet run
```
<p>Após finalizado o start, abra o navegador e acesse o link a seguir: </p>

```
https://localhost:7294
```
<br>

<h3>Estrutura do projeto:</h3>

![image](https://user-images.githubusercontent.com/62817146/196940041-9222c815-5cf0-4b2a-94e8-b40863245e34.png)

<br>
<h3>End-point:</h3>

<br>

![image](https://user-images.githubusercontent.com/62817146/196940285-bc92299b-86a8-461b-a880-e791c3ee750e.png)

**Get list:**
https://localhost:7294/delivery

<br>

```

Saida:
[
  {
    "id": 1,
    "codeDelivery": "123",
    "dateDelivery": "2022-10-20T00:00:00"
  },
  {
    "id": 2,
    "codeDelivery": "456",
    "dateDelivery": "2022-10-20T00:00:00"
  },
  {
    "id": 3,
    "codeDelivery": "789",
    "dateDelivery": "2022-10-20T00:00:00"
  }
]

```
<br>

![image](https://user-images.githubusercontent.com/62817146/196942022-f68f0e85-e2e9-4c0c-a24f-86cae2d34422.png)

<br>

**Post:**
https://localhost:7294/delivery

<br>

```

Entrada(exemplo):
{
  "id": 4,
  "codeDelivery": "75315984620",
  "dateDelivery": "2022-10-20T08:51:31.448Z"
}

```

<br>

```

Retorno:
[
  {
    "id": 1,
    "codeDelivery": "123",
    "dateDelivery": "2022-10-20T00:00:00"
  },
  {
    "id": 2,
    "codeDelivery": "456",
    "dateDelivery": "2022-10-20T00:00:00"
  },
  {
    "id": 3,
    "codeDelivery": "789",
    "dateDelivery": "2022-10-20T00:00:00"
  },
  {
    "id": 4,
    "codeDelivery": "75315984620",
    "dateDelivery": "2022-10-20T08:51:31.448Z"
  }
]

```
<br>

![image](https://user-images.githubusercontent.com/62817146/196942351-c2b18be8-c61d-4c0d-8bf1-f414eb89f884.png)

<br>

<h3>Como rodar o desafio 2:</h3>
<br>
<p>No terminal do projeto deve-se utilizar o comando:</p>

```
dotnet run
```

<h3>Estrutura do projeto:</h3>

![image](https://user-images.githubusercontent.com/62817146/196949050-263b3938-1bed-4ab4-8281-316a77075453.png)

<br>

<h2>Obs:</h2>
<p>Decidi hospedar o banco Sql Server na Azure, deixei a conexão pública, então é para conseguir acessa-lo pelo projeto de qualquer Ip:</p>

![image](https://user-images.githubusercontent.com/62817146/196943260-e29a23d4-5bf5-4e98-8cf7-89c96a0ee788.png)

<p>É possivel tanto adicionar os nomes no banco como listar ele no proprio console, seguindo as orientações.</p>

![image](https://user-images.githubusercontent.com/62817146/196947294-a188ea0d-0687-424f-bf1e-ccef623a3804.png)

<br>

![image](https://user-images.githubusercontent.com/62817146/196947719-702e8ed3-4c8d-4568-97e6-8c4a31643a08.png)

