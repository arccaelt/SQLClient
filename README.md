# SQLClient
This application allows an user to manage databases(currently on mysql and sql server).
The app has syntax highlighting and autocomplete(using a trie data structure).

Also, the application is built on top of a DAO layer. In the dao layer there are abstract classes that are implemented by specific classes for MYSQL/SQL SERVER interaction.
In addition, the apllication itself is using polymorphism with the classes mentioned earlier.

Login window
![alt text](https://github.com/arkcaelt/SQLClient/blob/master/login.PNG)

In action
![alt text](https://github.com/arkcaelt/SQLClient/blob/master/inaction.PNG)
