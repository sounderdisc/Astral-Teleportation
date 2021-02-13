# Design Documents Astral Teleportation

- [high-level diagrams](https://inserthere.com)
- [low-level UML diagrams](https://inserthere.com)
- [data ER diagram](https://github.com/sounderdisc/POOPproject/blob/main/artifacts/DesignDocuments/ERD.png)
- [UI diagram](https://drive.google.com/file/d/1Eqcxoi1_-u2WgieiP-B5B0fkeOvHUEI7/view?usp=sharing)
- [UI mock-up](https://drive.google.com/file/d/1dMAj4dYYyvTMJUVLegpz6Mg5TUY13SVJ/view?usp=sharing)
- [Create system design document](https://inserthere.com)


# System Design

## Program Organization

## Major Classes

## Data Design
That majority of the data this system uses resets any time a level is started or restarted. The data that requires saving are the number of levels that have been completed, and the player's settings preferences which will include visual, control, and audio settings. 
Level completion data will be stored in a table, and will keep track of a level ID number in the form of an integer, and a T/F flag marking level completion.
The player's settings preferences will be stored in a cs file that will control all of the settings mentioned. Since Unity is focused around components created with cs scripts, this will be the best way to have the settings stored and will be easily accessible for debugging.

**Do we keep this?**
--
While in theory, if the player always starts at the first level and can only play levels for which they have completed the previous level, we could store this information in a single integer indicating the most recently completed level, this requires the player to play through the game in squence starting at level 1. The flexibility from storing a small amount of additional data is worth the cost of storing that data, which is why we have chosen a list instead of a single integer.
--

**Needs concrete plan**
--
Player preferences is a single set of data that could be saved across game sessions in a variety of ways. The visual aid does not represent a table, but instead simply lists what needs to be saved. Specifics on how to implement this can be determined when we know more about the Unity game engine.
--


## Business Rules
Unity requires any business that makes over $100,000 on a program made from their engine to buy the software. Because the system is not being sold for profit, this is not a concern.

## User Interface Design
The user interface is catagorized into two groups: menus and in-game. Above you will find the visual aid for the menus by clicking on UI diagram, and the visual aid for the in-game UI by clicking on UI mock-up. Both use commonly used conventions that will be familiar to most players. Menu buttons are clickable and lead to more specific screens. In game, the player will use WASD or the arrow keys to move and the left and right mouse buttons to shoot a red or blue portal at the location the mouse cursor's location.

## Resource Management
In the system, the biggest drain on system resources is from the number of draw calls made in Unity. This can be reduced by packaging sprites together, as well as static parts of a level, into one larger file instead of each sprite having their own file. Optimization is a very expensive in terms of developer time, and considering that when a user starts a game they don't tend to have much else running on their computer, we can likely save optimization for the later weeks of development.

## Security
Since the system will be run entirely locally, security measures are not required. Unity will handle all data and error logging, as well as any incident of crashing/ failing of the system.

## Performance
The performance of the system will be stable due to the 2D nature of the game. Every precaution will be taken to make sure the game is heavily optimized, and will not be resource intensive. The game will be prioritized for speed, since memory is not an issue for the system a gamer will likely have.

## Scalability
The system should never need explicit scaling since it is a single player game. The number of users will never impact the experience, or availability, of any individual player. Likewise, there is no need for a server or network nodes since everything will be handled locally. 

## Interoperability
The system will not share data, resources, or personal information about the user with other software or hardware.

## Internationalization/ Localization
This system is privately owned and will not be exported outside of the United States. No string modification will be required in the system since the only supported language is English.

**Keep all this?**
--
No member of the development team speaks another language besides English at such a proficency to translate all of the game's text into another language. Addtionally, it is unlikely that anyone besides the members of the development team and the grader of the project for which this game is being made will ever play this game or watch it being played. As such, internationalization and localization are outside the scope of this project.

This game follows the conventions of other games that are played on keyboard and mouse. The topmost option in the title screen is "Play" as per convention. The WASD and the mouse left and right buttons are common controls. Someone who does not read english who launches the game is likely to stumble across all they need to know in order to play the game.
--

## Input/ Output
Unity has built in functions for input events in the Input class. The Input class has functionality to detect input down, input up, and input press, and the inputs known to the Input class can be configured in the project settings of Unity. Unity also provides support for graphics in game, and an interface to design scenes. These tools will be used to handle input and output for the game.

## Error processing
Unity will be handling any errors that happen during runtime. When coding the game, Unity will also handle any errors that occur from incorrect code. For non-coding related errors, all developers will be thoroughly testing each feature in a testing scene in Unity, and reporting any bugs that require fixing. 

## Fault Tolerance
Unity has a large libary in C#. C# has custom exceptions, and the libraries of Unity do have custom exceptions included. These exceptions are logged, and dealt with by the game engine. Because a simple 2D game has a limited range of input, we do not expect to run into exceptions, but unintended behavior. Beyond this, the team will have to learn, and experience, the Unity environment to make a more concrete plan for dealing with exceptions. Some unintended behaviors can be ignored if they are hard to find or perform.

## Architectural Feasibility
The biggest threat this archetecture proposal presents at construction time is the knowledge base required to implement all the things proposed, and the time it takes to make it all. A 2D platformer game is often the first thing people new to creating games will make, and as a result there are a lot of resources to learn and free assets to use. The five members of the team should be able to create at least the core features proposed by the user stories, and will likely be able to create more.

## Overengineering
Overengineering should be avoided in this project. The smaller and more concise each piece of code is, the easier it is to test and maintain. We should air on the side of more simple components rather than fewer more complex components.

## Buy-VS.-Build Decisions
The biggest thing we have decided to get off the shelf is the Unity game engine. As mentioned in prior section, this gives us a framework to start working on the things a normal person would think of being in a game instead of having to start off figuring out how to draw to the screen, or accept keyboard inputs. Art, visual aspects, and music are areas where we are more likely to look for free ready made assets as opposed to trying to make it ourselves.

## Reuse decisions
The system will end up using preexisting music since we will be adding that to the game. 
The system also does use a couple files for Unity itself for the game. However, we will be adding our own code on top of the Unity files to make it match what we are trying to accomplish in the game.

## Change Strategy
RID 5 requires obstacles in the game. RID 23 requires enemies in the game. The requirements are intentionally open ended to allow a decision to be made about more specific aspects of obstacles and enemies like appearance, behavior, and difficulty to be made later when more is known about the needs of the game and context in which these elements appear. The code of these elements are also designed in such a way to allow different speciation through inheritance should such a need arise.

## General Architectural Quality
