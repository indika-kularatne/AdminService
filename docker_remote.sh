
echo 'Qwer!234' | sudo -S docker pull localhost:5000/micro-zeus/adminservice:v1
sudo -S docker stop adminservice
sudo -S docker rm adminservice
sudo -S docker run -d -p 41323:80 --name adminservice --restart always localhost:5000/micro-zeus/adminservice:v1


