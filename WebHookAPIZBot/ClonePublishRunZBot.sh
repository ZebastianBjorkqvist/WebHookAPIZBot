#!/bin/bash

pkill -f "dotnet /home/zebbe/sambashare/netcoreapp3.1/publish/ZBot/ZBot/bin/Release/netcoreapp2.1/linux-x64/publish/ZBot.dll"

rm -r -f /home/zebbe/sambashare/netcoreapp3.1/publish/ZBot

git clone https://github.com/ZebastianBjorkqvist/ZBot.git

dotnet publish /home/zebbe/sambashare/netcoreapp3.1/publish/ZBot/ZBot.sln -c Release -r linux-x64

cp /home/zebbe/sambashare/ZbotGit/ZBot.dll.config /home/zebbe/sambashare/netcoreapp3.1/publish/ZBot/ZBot/bin/Release/netcoreapp2.1/linux-x64/publish/

nohup dotnet /home/zebbe/sambashare/netcoreapp3.1/publish/ZBot/ZBot/bin/Release/netcoreapp2.1/linux-x64/publish/ZBot.dll > out.txt 2>&1 &

echo done
