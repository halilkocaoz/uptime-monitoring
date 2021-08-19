<center> 

![dotnet build](https://github.com/halilkocaoz/upsmo-server/actions/workflows/dotnet.yml/badge.svg)

</center>

# upsmo-server

Web api for cloning an uptime monitoring saas.

## Instalation

### Prerequisites

[Docker](https://www.docker.com/)  
OR  
[Dotnet 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) & [Postgres](https://www.postgresql.org/)  

## Run & Instalation

* `git clone https://github.com/halilkocaoz/upsmo-server/`
* `cd upsmo-server && docker-compose up --build`  
OR  
* `cd upsmo-server/UpsMo.WebAPI && dotnet restore && dotnet run`

## Related repositories

* [upsmo-checker](https://github.com/halilkocaoz/upsmo-checker)

## Status

In progress

## Swagger

![swagger](/assets/swagger.png "Swagger")