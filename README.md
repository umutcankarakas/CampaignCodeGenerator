# Campaign Code Generator

This API project aims to be used for a list of campaign codes and verify them if needed.

One can easily try the api with swagger after running the solution.


## API Usage

#### Create "CodeCount" number of campaign codes

```http
  GET /CodeGenerator/GetCodeList
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `CodeCount` | `long` | The number of codes you want. |

#### Create "CodeCount" number of campaign codes and return them with their "Ids"

```http
  GET /CodeGenerator/GetCodeListWithId
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `CodeCount` | `long` | The number of codes you want. |

#### Check Code Validity

```http
  GET /CodeVerification/CheckCodeValidity
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `Code` | `string` | The code itself to be checked. |


#### Get code id back from the code

```http
  GET /CodeVerification/GetCodeIdFromCode
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `Code` | `string` | The code itself to be checked. |
| `CodeCount` | `long` | The number count of codes. |

#### Verify the code

```http
  GET /CodeVerification/VerifyCode
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `Code` | `string` | The code itself to be checked. |
| `CodeCount` | `long` | The number count of codes. |

