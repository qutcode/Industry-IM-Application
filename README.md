# Industry-IM-Application
The aim of this repository is to design a feature rich IM application which is aimed at Math/Science/IT people.

###Overview
The focus of this project is to build an instant messaging application designed specifically for people in Math/Science/IT. Since this application will be connecting users together, a server will need to be coded for this (preferably in C or C++). The server implementation at its core will need to:


-  Securely connect users to the network with an authentification layer (only connect clients if they are users of this service).

-  Handle client requests (i.e. send message from 1 client to another client)

-  Store client requests for later use of the client (save conversations so clients can talk at a later date with their previous conversation there).

-  and more


The client side of the application should be written in Java or C# (preferably Java for easier portabiliy) and will soon thereafter support clients on mobile and web applications using other languages. For now though, the clients should be able to:


-  Securely connect to the server with as little hassle as possible.

-  Be able to connect to anyone in their "Friends list".

-  Be able to Instant message anyone of their peers or do group chats.

-  Be able to write maths equations and make it appear in the proper format.

-  Be able to have a shared REPL.

-  and more


The features listed above are the ones we are focusing on at the moment and will add further features to enhance the application.

###Platform Implementations
Opinion [that means tell me if I am wrong please :)]: 

Linux/MacOSX/Windows version first -> Java client will allow for easy porting 

Android version second -> Java client again making it easier but not as easy as desktop

iOS version third -> Will require conversion of Java code to Obj-C code either by someone writing it straight or a conversion tool such as Google's [J2ObjC](https://github.com/google/j2objc)

###Mock-Up GUI
![alt gui-mockup](https://raw.github.com/qutcode/Industry-IM-Application/master/IndustryIM-MockUp.png)

C# Working mockup in csharp-fuctional-mock-up branch
