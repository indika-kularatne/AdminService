dotnet publish -c Release -o published
docker build -t adminservice .
docker tag adminservice:latest 192.168.213.50:5000/micro-zeus/adminservice:v1
docker push 192.168.213.50:5000/micro-zeus/adminservice:v1

putty.exe -ssh admin@192.168.213.50 -pw "Qwer!234" -m "docker_remote.sh"