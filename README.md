[![.NET](https://github.com/aimenux/DockerNetCoreDemo/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/aimenux/DockerNetCoreDemo/actions/workflows/ci.yml)

# DockerNetCoreDemo
```
Dockerizing .NET Core Apps
```

In this repo, i m using docker in order to build several types of .net core applications :

> :one: App_01 : Console application
>
> :two: App_02 : Worker application
>
> :three: App_03 : WebApi application

:rocket: To run code, type the following commands in your favorite terminal :
>
> :zap: For App_01 :
> - `docker build -t app01-image -f .\App_01\Dockerfile .`
> - `docker run --rm --name app01 -it app01-image`
>
> :zap: For App_02 :
> - `docker build -t app02-image -f .\App_02\Dockerfile .`
> - `docker run --rm --name app02 -it app02-image`
>
> :zap: For App_03 :
> - `docker build -t app03-image -f .\App_03\Dockerfile .`
> - `docker run --rm -p 5000:5000 -p 5001:5001 -e ASPNETCORE_ENVIRONMENT=Development -e ASPNETCORE_URLS="http://+:5000" --name app03 -it app03-image`
> - `go to https://localhost:5000/swagger/index.html`
>
>
:rocket: To clean docker resources, type the following commands :
> - `docker stop $(docker ps -aq)`
> - `docker rm -f $(docker ps -aq)`
> - `docker rmi -f $(docker images -aq)`

**`Tools`** : net 9.0, docker