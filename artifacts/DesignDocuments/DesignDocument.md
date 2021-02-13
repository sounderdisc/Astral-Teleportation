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
Most of the data that this game has resets any time a level is started or restarted. We expect the average player to restart a level or finish and move on to the next level fairly quickly. The only data we need to save is which levels have been completed in order to fulfil RID 3 and RID 24, and the player's setting preferences which will include visual settings, control settings and audio in order to fulfil RID 19, 20, 21, and 22.

Level completion data will be stored in a table that will keep track of a level ID number which is an integer a value tracking wether or not that level has been copleted, which is a boolean. While in theory, if the player always starts at the first level and can only play levels for which they have completed the previous level, we could store this information in a single integer indicating the most recently completed level, this requires the player to play through the game in squence starting at level 1. The flexability from storing a small amount of additional data is worth the cost of storing that data, which is why we have chosen a list instead of a single integer.

Player preferences is a single set of data that could be saved across game sessions in a variety of ways. The visual aid does not represent a table, but instead simply lists what needs to be saved. Specifics on how to implement this can be determined when we know more about the Unity game engine.

## Business Rules
Unity requires any business that makes over $100,000 on a program made from their engine to buy the software. Since the system is not being sold for profit, this is of no concern.

## User Interface Design

## Resource Management
In a 2D game, the biggest drain on system resources is from the number of draw calls. This can be reduced by packaging certain sprites together into one file larger file instead of each sprite having their own file, and tinkering with the static parts of a given level and packaging them together can help reduce draw calls in the same way. Optimization is a very expensive in terms of developer time, and considering that when a user starts a game they don't tend to have much else running on their computer, we can likely save optimization for the later weeks of development.

## Security
Since the system will be run entirely locally, security measures are not required. The Unity engine will handle all data and error logging, as well as any incident of crashing/ failing of the system.

## Performance
The performance of the system will be relatively stable due to the 2D nature of the game. As mentioned in Resource Management, draw calls are a large contributor to performance problems, and we will learn more about how to optimize a game in Unity in the later weeks of development as development time allows. The game will be prioritized for speed, since memory is not an issue for the system a gamer will likely have.

## Scalability
The system should never need explicit scaling since it's a single player game. The number of users will never impact the experience or availability of any individual player. Likewise, there is no need for a server or network nodes since everything will be handled locally. 

## Interoperability
The system is not expected to share data, resources, or personal information about the user(s) with other software or hardware. The only data that will be saved to the game 
will be the completed level and the user's setting preferences, such as visual, audio, and control settings. However, that data will be saved in the game, not shared to an 
outer source.

## Internationalization/ Localization
No member of the development team speaks another language besides English at such a proficency to translate all of the game's text into another language. Addtionally, it is unlikely that anyone besides the members of the development team and the grader of the project for which this game is being made will ever play this game or watch it being played. As such, internationalization and localization are outside the scope of this project.

This game does follow the conventions of other games that are played on keyboard and mouse. The topmost option in the title screen is "Play" as per convention. The WASD and the mouse left and right buttons are common controls. Someone who does not read english who launches the game is likely to stumble across all they need to know in order to play the game.

## Input/ Output
The Unity game engine has built in functions for input events such as key press, key down, key up, mouse button press, mouse button down, and mouse button up. Unity also provides support for graphics in game and an interface to design scenes. These tools will be used to handle input and output for the game.

## Fault Tolerance

## Architectural Feasibility

## Overengineering

## Buy-VS-Build Decisions
The biggest thing we have decided to get off the shelf is the Unity game engine. As mentioned in prior section, this gives us a framework to start working on the things a normal person would think of being in a game instead of having to start off figuring out how to draw to the screen, or accept keyboard inputs. Art, visual aspects, and music are areas where we are more likely to look for free ready made assets as opposed to trying to make it ourselves.

## Reuse decisions
The system will end up using preexisting music since we will be adding that to the game. 
The system also does use a couple files for Unity itself for the game. However, we will be adding our own code on top of the Unity files to make it match what we are trying to accomplish in the game.

## Change Strategy

## General Architectural Quality
