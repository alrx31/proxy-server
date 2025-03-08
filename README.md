# Инструкция (отчет)
### проверялось на arch linux + firefox

### настройки FireFox:
![alt text](/Screenshots/image2.png)

для запуски прокси сервара необходимо вызвать команду <code>dotnet run</code> в папке с проектом
для того чтобы программа видела черный список <code>dotnet build</code> а затем в папке <code>bin/Debug/net9.0</code> запустить исполняемый файл, например: <code>./proxy-server</code> 

после запуска сервер начнет проксировать все входящие в него запросы:
![alt text](/Screenshots/image1.png)

если добавить домен в черный список, мы увидем следующее:
![alt text](/Screenshots/image3.png)
![alt text](/Screenshots/image4.png)

при попытки выполнить HTTPS запрос будет ошибка доверенности SSL сертификата