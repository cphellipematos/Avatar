# Avatar
My own avatar website.
### IN PROGRESS ###

This is a place where I decided to show my skills and development basis web concepts. Here You can find some concepts as SOLID, OOP, Clean Code, Domain Notification, Fluent Mapping and Repository Pattern. 

Domain Notification reference - https://github.com/andrebaltieri/DomainNotificationHelperCore

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
- Swagger documentation provider.
```
api/v1/user/company (GET)
api/v1/user/company/{id} (GET)
api/v1/user/company (POST) - Json object on body request
api/v1/user/company (UPDATE) - Json object on body request
api/v1/user/company (PATCH) - Json object on body request
```

#### APPLICATION 
- Responsable to call Commands and Services.
    - Each command is a request information that composes a Service Validation.
    
-  This layer can be compared with a quarterback football player or a number 10 soccer player. Application calls behavours and reponsabilities of each "Domain Service".

#### DOMAIN SERVICES 
- At this point, can be finded each business rule. If a post can be done, or not. If a get is able go to the next steps.

#### INFRA 
- This is more than a DAL. At this step we can find CROSS CUTTING information as IoC with Simple Injector or a MAPPING Fluent API, also we have a REPOSITORY PATTERN and Unit of Work (UoW).

As Object Relational Mapping (ORM) is going to be used DAPPER and EnityFramework Core.


<br><br>

C Phellipe Matos <br>
<img src="https://calendarmedia.blob.core.windows.net/assets/3867334a-8bcc-4f44-9684-3fe63020ec24.png" data-canonical-src="https://calendarmedia.blob.core.windows.net/assets/3867334a-8bcc-4f44-9684-3fe63020ec24.png" width="80"/>
