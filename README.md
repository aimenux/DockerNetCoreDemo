[![.NET](https://github.com/aimenux/DockerNetCoreDemo/actions/workflows/ci.yml/badge.svg)](https://github.com/aimenux/DockerNetCoreDemo/actions/workflows/ci.yml)

# DockerNetCoreDemo
```
Dockerizing .NET Core Apps
```

In this repo, i m using docker in order to build several types of .net core applications :

> :one: `App_01` : Console application
> 
> :two: `App_02` : Worker application
> 
> :three: `App_03` : WebApi application

:rocket: To run code from visual studio, start docker profile (see LaunchSetting.json).

:rocket: To run code from you favorite terminal type the following commands :
>
> :zap: For `App_01` :
> - `docker build -t app01-image -f .\App_01\Dockerfile .`
> - `docker run --name app01 -it app01-image`
>
> :zap: For `App_02` :
> - `docker build -t app02-image -f .\App_02\Dockerfile .`
> - `docker run --name app02 -it app02-image`
>
> :zap: For `App_03` :
> - `docker build -t app03-image -f .\App_03\Dockerfile .`
> - `docker run --name app03 -it -p 8088:80 app03-image`
>
>
:rocket: To clean docker ressources, type the following commands :
> - `docker stop $(docker ps -aq)`
> - `docker rm -f $(docker ps -aq)`
> - `docker rmi -f $(docker images -aq)`

**`Tools`** : vs22, net 6.0, docker