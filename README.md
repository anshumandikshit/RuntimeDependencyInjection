# RuntimeDependencyInjection
This application will register all the dependency in run time .So The actual client side project does not need to inject anything from the class library statically . This will automatically register the classes and its interfaces dynamically in the application but the application will inject most of the dependency in the class libraries .So the dependency injected class files cant be invoked directly in the clientide(here ConsoleUI) ,adding further security feature to the application .

This application is using "Autofac" for dependency injection and "Automapper" for mapping .
