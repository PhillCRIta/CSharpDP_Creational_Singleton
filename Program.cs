/*
 Singleton pattern is used for provide a unique and global point of access to a instance
 In this case we instantiate a only one class to connect to database and reuse that class many times as needed
 The singleton pattern ensure that the data saved into it remain the same in all app
 */
using Creational_Singleton;

AppSettingsBAD _settings = new AppSettingsBAD();
_settings.Set("AppName", "Singleton design patter");
_settings.Set("app_creator", "Phill");
Console.WriteLine(_settings.Get("AppName"));
TestingConfClassBAD.Run();

Console.WriteLine("********USING SINGLETON");

AppSettingSingleton settings2 = AppSettingSingleton.GetInstance();
settings2.Set("AppName", "Singleton design patter");
settings2.Set("app_creator", "Phill");
Console.WriteLine(settings2.Get("app_creator"));
TestingConfClass.Run();