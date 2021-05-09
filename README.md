Simple example to implement generic service, controller and repository in ASP.NET CORE 3.1

## How to run it?
1 -  Yo have to spicify your server in `./script/db_Script` 

 2 - Run the script 

 3 - In  `./TodoGeneric.Api/appsettings` add your connection string ` "ConnectionStrings": {
    "TodoGenericDb": "Data Source=DESKTOP-6REK6D0;Initial Catalog=TodoGenericDb;Integrated Security=True;ApplicationIntent=ReadWrite;"
  }`  replace  "TodoGenericDb" connection string to your current connection.

</br>

## No importante

### - Architecture used?
#### A simple clean architecture (Onion)

</br>
</br>

<img src="https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/media/image5-7.png">


