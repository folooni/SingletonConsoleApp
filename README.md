Singleton Pattern 
This is a console app

Scenario: We need to appropriately assign tables in a restaurant between servers so no server get more than one table before all others get one.
          So, we use singleton pattern for our data to be returned as a single source throughout our application. All functions, then, will use 
          the same source to obtain the order of assigning tables to servers.
          
main method calls TableServers class which has defined a private static variable as _instance (to initiate the class once for application life).
TableServer class has a "private" constructor so it cannot be instantiated directly; however, a method has been defined to create an instance of it.
