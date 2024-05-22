#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p c239c668-327a-4e34-bf07-f7bf5bfcf92b -t
    fi
    cd ../
fi

docker-compose up -d
