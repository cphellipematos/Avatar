# Avatar
My own avatar website.

This is a place where I decided to show my skills and development basis web concepts. Here You can find some concepts as SOLID, OOP, Clean Code and Repository Pattern. 

# Technologies
- .Net Core C#
- EF Core
- Simple Injector
- Restfull API
- And a person that really loves to look for new stuff.

# How it's going to be done!
### FrontEnd
```
Future ReactJS application with Redux
```
### BackEnd
```
Four layers solution (API, Application, Domain, Infra)
```


#### API 
- Here you can find some endpoints to get, update and post information.
- Swagger documentation provider. www.localhost/swagger
```
www.localhost/api/v1/users/company (GET)
www.localhost/api/v1/users/company/{id} (GET)
www.localhost/api/v1/users/company (POST) - Json object on body request
www.localhost/api/v1/users/company (UPDATE) - Json object on body request
www.localhost/api/v1/users/company (PATCH) - Json object on body request
```

#### APPLICATION 
- Responsable to convert a ViewModel to a Domain and Domain to ViewModel.
-  This layer can be compared with a quarterback football player or a number 10 soccer player. Application calls behavours and reponsabilities of each "Domain Service".

#### DOMAIN SERVICES 
- At this point, can be finded each business rule. If a post can be done, or not. If a get is able go to the next steps.

#### INFRA 
- This is more than a DAL. At this step we can find CROSS CUTTING information as IoC with Simple Injector or a MAPPING Fluent API, also we have a REPOSITORY PATTERN and Unit of Work (UoW).

As Object Relational Mapping (ORM) is going to be used DAPPER and EnityFramework Core.
