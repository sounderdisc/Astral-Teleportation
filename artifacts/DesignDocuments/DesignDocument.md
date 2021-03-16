# Design Documents Astral Teleportation






# System Design

## Program Organization
- ![low-level class diagrams](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/UML1.jpg)

The context of the system is minimal; a player and a game. The container is the Unity game engine the system is built in. The components are everything that you could name as a noun in our level mock up; a potal gun, character, obstacle, and the level.
The portal gun is a class used to contain the portal gun object. The portal gun object is responsible for allowing the player to teleport to different areas of a level in order to reach the goal. The portal gun object will be attached to the character object as an item.
The character is a class used to contain the character object. The character object is responsible for allowing the player to move, jump, and avoid obstacles. 
The obstacle is a class used to contain various obstacle objects. The obstacle objects are responsible for impeding the player on their quest to the goal. If the player object comes into contact with the obtacle object, the player object will be damaged.
Finally, the level is a class used to contain various level objects. The level objects are the bulk of the game, and will contain all the above classes as a means of creating puzzles for the player to navigate.

## Major Classes
- high-level diagrams:  
<br />  ![context](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/Context%20Diagram%202.jpg)
<br />  ![container](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/Container%20Diagram%202.jpg)
<br />  ![component](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/Component%20Diagram%203.jpg)

The major classes are the potal gun, character, obstacle, and the level itself.
The portal gun is a class used to contain the portal gun object. The portal gun object is responsible for allowing the player to teleport to different areas of a level in order to reach the goal. The portal gun object will be attached to the character object as an item. The portal gun object will also have two modes, blue mode, and red mode, which differentiate the two character objects and provides a way for multiple portal paths throughout the level.
The character is a class used to contain the character object. The character object is responsible for allowing the player to move, jump, and avoid obstacles. The character object will have to navigate through the level objects to reach a goal, while avoiding obstacle objects along the way.
The obstacle is a class used to contain various obstacle objects. The obstacle objects are responsible for impeding the player on their quest to the goal. If the player object comes into contact with the obtacle object, the player object will be damaged. The obstacle objects will be placed throughout the level objects.
Finally, the level is a class used to contain various level objects. The level objects are the bulk of the game, and will contain all the above classes as a means of creating puzzles for the player to navigate.

## Data Design
- ![data ER diagram](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/ERD.png)
The figure above shows all the long term data to store between sessions of running the game, namely level completeion status and user preferences like visual, control, and audio settings. This is in compliance with requirements RID 3, 4, and 19-22. The majority of the data this system uses is stored in memory and resets any time a level is started or restarted.

Looking at the ER diagram on the left of the visual aid above, you can see that level completion data will be stored in a table, and will keep track of a level ID number in the form of an integer, and a T/F boolean flag marking level completion.

If the player always starts at the first level and can only play levels they have previously completed, this information could be stored in a single integer indicating the most recently completed level. However, this requires the player to play through the game in squence starting at level 1. The flexibility from storing a small amount of additional data is worth the cost of storing that data, which is why a list instead of a single integer was the chosen method.

The box on the right of the visual aid does not represent a table, but instead simply lists what needs to be saved. The player's settings preferences will be stored in a .txt file that will control all of the settings mentioned. Since we will likely have very few things to store between play sessions, we do not need anything fancy. Additionally, text files are easily accessible for debugging.

On a technical level, the game will read from the text file on startup to know what values to set the variables in memory that control certain user preferences and tracks level completion. Durring gameplay, players can change their settings or complete levels for the first time and this will change the values of the repective varibles which will stay in memory for as long as our game runs. Then before the user closes the program using our UI element, we will write the values of the varaibles in memory to the text file.

## Business Rules
The goal of this sytem is to make a professional looking game. As such, the game will aim to run at an optimal frame rate of 30-60 frames per second or higher. Any game assets will also aim to be high quality and matching the aesthetic of our setting. There will be no user information taken, and users are free to download the game on as many devices as they wish. 

## User Interface Design
- ![UI mock-up](https://cdn.discordapp.com/attachments/805891497286959175/821475813534072922/ui-mockup.png)
- ![UI diagram](https://cdn.discordapp.com/attachments/672319862902751232/817527744907968542/ui-diagram.png)

The first image is the UI mock-up. The second image is the UI diagram, which explains the mock-up more in depth. The user interface is catagorized into two groups: settings and in-game. Both use commonly used conventions that are familiar to players. The settings button is clickable and leads to more specific screens, such as controlling music volume. In game, the player will use the WAS keys to move to the left and right as well as jump, and mouse buttons to shoot a red or blue portal at the location which the mouse cursor is at. There will also be a levels button, which will show the player the levels that they have completed and can go to replay those levels again. The last button that the user interface will have is the quit button to allow the user to quit the game.


## Resource Management
In the system, the largest drain on system resources is from the number of draw calls made in Unity. This can be reduced by packaging sprites together, as well as static parts of a level, into one larger file instead of each sprite having their own file. As the game will not have complex graphics and will load a small static level at a time, resource management will not be a big concern for this project. Unity handles all of the garbage collection in the system, so memory will only ever be an issue if Unity fails.

## Security
Since the system will be run only locally, security measures are not required. Unity will handle all data and error logging, as well as any incident of crashing/ failing of the system.

## Performance
The performance of the system will be stable due to the 2D nature of the game and Unity's optimization. Every precaution will be taken to make sure the game is heavily optimized, and will not be resource intensive. The game will be prioritized for speed, since memory is not an issue for the system a gamer will likely have.

## Scalability
The system should never need explicit scaling since it is a single player game. The number of users will never impact the experience, or availability, of any individual player. Likewise, there is no need for a server or network nodes since everything will be handled locally. 

## Interoperability
The system will not share data, resources, or personal information about the user with other software or hardware.

## Internationalization/ Localization
This system is privately owned and will not be exported outside of the United States. No string modification will be required in the system since the only supported language is English.

## Input/ Output
C# code runs on either Mono or the Microsoft .NET Framework, which is Just-In-Time compiled. Unity has built in functions for input events in the Input class. The Input class has functionality to detect input down, input up, and input press, and the inputs known to the Input class can be configured in the project settings of Unity. Unity also provides support for graphics in game, and an interface to design scenes. These tools will be used to handle input and output for the game.

## Error processing
Unity will be handling any errors that happen during runtime. When coding the game, Unity will also handle any errors that occur from incorrect code. For non-coding related errors, all developers will be thoroughly testing each feature in a testing scene in Unity, and reporting any bugs that require fixing. A corrective error processing method will be used. Likewise, an active error detection method will be used. If an error is considered harmful to the existence of the program, such as a memory leak, the program will close itself. All errors that happen during runtime will be logged via Unity. Unity will also handle all exceptions.

## Fault Tolerance
Unity will handle all fault tolerance. If the system fails, the process will be killed, and forced to restart. It will resume during the last save the player made. Any catastrophic failure will be logged by Unity.

## Architectural Feasibility
The biggest threat this archetecture proposal presents at construction time is the knowledge base required to implement all the things proposed, and the time it takes to make it all. A 2D game is a simple and popular system. As a result there are a lot of resources to learn and free assets to use. The game engine, however, was designed to handle more complex systems than the one being built so it will not have any trouble meeting the needs of the developers or clients.

## Overengineering
Due to the nature of the system, any error that is detected will lead to a system crash. Because of this, taking the simplest possible route to make the coding as optimized as possile will prevent the majority of errors. The smaller and more concise each piece of code is, the easier it is to test and maintain.

## Buy-VS.-Build Decisions
The Unity engine is the heart of the system, and was available for free. This provides a framework to focus on the actual mechanics of the game, rather than building an engine from scratch. All the art, sound, and animations will be sought out from a free, or cheap, source.

## Reuse decisions
The system will use existing art, sound, and animations. By choosing assets that closely match the theme of the game, they will conform to the archiectural goals. Likewise, scripts will be referenced for any mechanic too advanced for the scope of the system, and implemented in a unique way.

## Change Strategy
The system will be highly adaptable to any change that is needed. Unity is designed around compartmentalization, which in turn causes any change to an individual piece quite simple. If anything is added into the game, it will not affect anything that is already in place. We will develop with change as the main strategy. With the use of Git and Github we will be able to implement new scripts and ideas without having to worry about loosing progress if the changes are not beneficial.

## General Architectural Quality
No architecture is perfect, especially one that is made by students with little archetural experience. However, the architectural team is also the development team, so if we learn something during construction, we can apply it to updating our architecture. This sort of real time learning should more than make up for any unforeseen shortcomings in our design. The key is to think about why we are doing what we are doing, think critically at all times, and communicate among ourselves. The overall goal of the system is for modifiability and quick iterations. 
