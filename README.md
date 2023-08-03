
# Logging in Asp.net Core

Logging is the process of recording events that occur at runtime of an application. These events can include error conditions, user interactions, system state, process steps or any significant event. Logs provide valuable information for monitoring the performance of the application, detecting errors, troubleshooting problems and performing analysis.

## Provider

Structures that save logging somewhere.

## Buid-in Logging Provider

* Console Provider: A provider that allows you to write your logs to the console. 

* Debug Provider: A provider that writes the logs we have written to debug

* Azure Application Insights Provider: It is a service offered on the Microsoft Azure cloud platform and is used to monitor the performance, usage, and errors of applications.

>     When we create an Asp.net Core project, 3 providers are provided by Microsoft.
>     Console Provider
>     Debug Provider
>     Azure Application Insights Provider

### Third-party Loggin Provider

> NLog (We will use this in the project!!)
> 
> SerialLog
> 
> elmah.io
>
> Gelf
> 
> JSNLog
> 
> KissLog.net
> 
> Loggr

### Logging Levels

* ***Trace(0):*** Uses information that is valuable for debugging... Application up, IES running, shutting down... The most trivial logging

* ***Debug(1):*** We can see information that can be useful in debug when we are doing development. Method went to method, method exited, file saved.

* ***Informaiton(2):*** Used to follow the general flow of the application. A request was received from the API, a request was sent, etc.

* ***Warning(3):*** Can be used for anomalous behavior from the application flow. There is a problem, my application is running but it won't let it explode. When I log in Warning, I need to look at them carefully, otherwise it may cause a problem in the future. 

* ***Error(4):*** There is an error, you can log to see this error in the future. This directly explodes the project.

* ***Critical(5):*** Indicates serious errors in which the application cannot continue.

## Logging with ILogger interface

It is the interface responsible for logging in our Asp.net Core applications. Thanks to this interface, we perform logging. Thanks to Dependency Injections, we can also use it by adding Constructor. 

      private readonly ILogger<HomeController> _logger;

If you want to clear all existing Providers in the project, you can add the following code to the Program.cs page.  

    builder.Logging.ClearProviders();

If you want to write custom logging in Program.cs in .Net 6-7, just add the following code to Program.cs

    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("The application is standing up...");
