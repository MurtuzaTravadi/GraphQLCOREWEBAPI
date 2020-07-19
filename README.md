# GraphQLCOREWEBAPI
# DOTNETCORE
# DOTNETCORE3.1GRAPHQL
# GRAPHQLDOTNETCORE
# GRAPHQLSQLSERVERCONNECTIONSTRINGDOTNETCORE
# RepositoryDOTNETCORE

To view all schema

{
  __schema {
    types {
      name
    }
  }
}

verify SQL todo get / get all

GET ALL

query {
  todos{
    id
    name
    IsComplete
  }
}


GET

query {
  todo(id :1){
    id
    name
  }
}

Static json 

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


query {
  authors{
    id
    firstName
    lastName
  }
}


