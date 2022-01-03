[![.NET](https://github.com/aimenux/DockerNetCoreDemo/actions/workflows/ci.yml/badge.svg)](https://github.com/aimenux/DockerNetCoreDemo/actions/workflows/ci.yml)

# DockerNetCoreDemo
```
Dockerizing .NET Core Apps
```

> In this repo, i m using docker in order to build several types of .net core applications.
>
> To run code, there are multiple ways :
>
> :one: start visual studio docker profile in debug or release mode.
>
> :two: type the following commands in your favorite terminal :
> - `docker build -t docker-net-core-demo-image -f .\App_01\Dockerfile .`
> - `docker run -it docker-net-core-demo-image`
>
> :three: type the following commands in your favorite terminal :
> - `docker build -t docker-net-core-demo-image -f .\App_01\Dockerfile .`
> - `docker create docker-net-core-demo-image
> - `docker start -i [container-id]`

> To clean docker ressources, type the following commands :
> - docker stop $(docker ps -aq)
> - docker rm $(docker ps -aq)
> - docker rmi -f $(docker images -aq)

**`Tools`** : vs22, net 6.0, docker