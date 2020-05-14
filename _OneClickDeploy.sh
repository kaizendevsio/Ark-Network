#!/bin/bash
echo "The current working directory: ${PWD##*/}"

while true; do
    read -p "Deploy ${PWD##*/}?" yn
    case $yn in
        [Yy]* )         
        echo "Building Release.Ark.API ...";
        dotnet publish Ark.API.sln -o /home/xeon/Documents/Projects/Published/Release.Ark/Ark.Api.Published/;
        read -p  "Deployment done. Have a good day :)";

        break;;
        [Nn]* ) exit;;
        * ) echo "Please answer yes or no.";;
    esac
done