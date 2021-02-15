# Design Documents Astral Teleportation

- high-level diagrams [context](https://cdn.discordapp.com/attachments/672319862902751232/810361571570090020/unknown.png) [container](https://cdn.discordapp.com/attachments/672319862902751232/810362380278038558/unknown.png) [component](https://cdn.discordapp.com/attachments/672319862902751232/810367995658108968/unknown.png)
- [low-level UML diagrams](https://cdn.discordapp.com/attachments/477667900111454218/810734970061455440/unknown.png)
- [data ER diagram](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/ERD.png)
- [UI diagram](https://drive.google.com/file/d/1Eqcxoi1_-u2WgieiP-B5B0fkeOvHUEI7/view?usp=sharing)
- [UI mock-up](https://drive.google.com/file/d/1dMAj4dYYyvTMJUVLegpz6Mg5TUY13SVJ/view?usp=sharing)


# System Design

## Program Organization
The context of our system is simple; there is a player and a game. The container is simply the Unity game engine we are using. The components are everything that you could name as a noun in our level mock up; namely a potal gun, character, obsticle, and the level itself as a whole.

## Major Classes
The component diagram makes designing the major classes easy. The major classes are the potal gun, character, obsticle, and the level itself.

## Data Design
The majority of the data this system uses resets any time a level is started or restarted. The data that requires saving are the number of levels that have been completed, and the player's settings preferences which will include visual, control, and audio settings. 
Level completion data will be stored in a table, and will keep track of a level ID number in the form of an integer, and a T/F boolean flag marking level completion.
The player's settings preferences will be stored in a .cs file that will control all of the settings mentioned. Since Unity is focused around components created with .cs scripts, this will be the best way to have the settings stored and will be easily accessible for debugging. 
If the player always starts at the first level and can only play levels they have previously completed, this information could be stored in a single integer indicating the most recently completed level. However, this requires the player to play through the game in squence starting at level 1. The flexibility from storing a small amount of additional data is worth the cost of storing that data, which is why a list instead of a single integer was the chosen method.
User settings are a single set of data that could be saved across game sessions in a variety of ways. The visual aid does not represent a table, but instead simply lists what needs to be saved.

## Business Rules
Unity requires any business that makes over $100,000 on a program made from their engine to buy the software. Because the system is not being sold for profit, this is not a concern.

## User Interface Design
The user interface is catagorized into two groups: settings and in-game. Both use commonly used conventions that will be familiar to players. The settings button is clickable and leads to more specific screens, such as controlling music volume. In game, the player will use the WAS keys to move to the left and right as well as jump, and mouse buttons to shoot a red or blue portal at the location which the mouse cursor's location is at. There will also be a levels button, which will show the player the levels that they have completed and can go to replay those levels again. The last button that the user interface will have is the quit button to allow the user to quit the game.

## Resource Management
In the system, the largest drain on system resources is from the number of draw calls made in Unity. This can be reduced by packaging sprites together, as well as static parts of a level, into one larger file instead of each sprite having their own file. Unity handles all of the garbage collection in the system, so memory will only ever be an issue if Unity fails.

## Security
Since the system will be run entirely locally, security measures are not required. Unity will handle all data and error logging, as well as any incident of crashing/ failing of the system.

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
The system will use existing art, sound, and animations. By choosing assets that closely match the theme of the game, they will conform to the archiectural goals. Likewise, scrips will be referenced for any mechanic too advanced for the scope of the system, and implemented in a unique way.

## Change Strategy
The system will be highly adaptable to any change that is needed. Unity is designed around compartmentalization, which in turn causes any change to an individual piece quite simple. If anything is added into the game, it will not affect anything that is already in place.

## General Architectural Quality
No archetecture is perfect, especially one that is made by students with little archetural experience. However, the archetectural team is also the development team, so if we learn something durring construction, we can apply it to updating our archetecture. This sort of real time learning should more than make up for any unforeseen shortcomings in our design. The key is to think about why we are doing what we are doing, think critically at all times, and communicate among ourselves.
