# Magazine Website

Coming soon...

# Getting Started

## Download / Clone

Clone the repo using Git:

`git@github.com:DannyMonge/DotNET_Microservices-app-.git`

## Boot up the whole system

> The development environment on Windows (not on Linux or MacOS)

> Make sure you installed .NET Core, Powershell and Docker Toolbox for Windows to make it work 

> Make sure you `cd` into the magazine-website root folder to run all commands below

`docker-machine create --driver virtualbox default`

`FOR /f "tokens=*" %i IN ('docker-machine env default') DO %i`

`powershell -f deploy/build-all.ps1`

`docker-compose -f deploy/docker-compose.yml up -d`

`docker-compose logs`

## Run each service

`docker build -f deploy/Dockerfile.MagazineService -t thangchung/magazine_service .`

`docker run -d -p 5000:5000 -t thangchung/magazine_service`
