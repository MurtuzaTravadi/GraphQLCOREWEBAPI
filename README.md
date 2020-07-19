# GraphQLCOREWEBAPI
## DOTNETCORE
## DOTNETCORE3.1GRAPHQL
## GRAPHQLDOTNETCORE
## GRAPHQLSQLSERVERCONNECTIONSTRINGDOTNETCORE
## RepositoryDOTNETCORE

## Prerequisite

### VS2019 - 16.6.4
### CORE   - 3.1

## 3 simple steps to run this program

1. Clone code
2. ctrl + f5 to run this program
3. in browser ~/graphql and verify with below query schema



### To view all schema

```
{
  __schema {
    types {
      name
    }
  }
}

```

### verify SQL todo get / get all

### GET ALL

```
query {
  todos{
    id
    name
    IsComplete
  }
}
```

### GET

```
query {
  todo(id :1){
    id
    name
  }
}

```

### Static json 

```
query {
  author (id: 1){
    id
    Fname
    lastName
  }
   blogs
    {
      id
      title
      content
    }
}

```

```
query {
  authors{
    id
    firstName
    lastName
  }
}
```

