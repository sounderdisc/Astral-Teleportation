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

## Security
Since the system will be run entirely locally, security measures are not required. The Unity engine will handle all data and error logging, as well as any incident of crashing/ failing of the system.

## Performance
The performance of the system will be relatively stable due to the 2D nature of the game. Every precaution will be taken to make sure the game is heavily optimized, and thus will not be resource intensive. The game will be prioritized for speed, since cost is not an issue for this particular system.

## Scalability
The system should never need explicit scaling since it's a single player game. The number of users will never impact the experience or availability of any individual player. Likewise, there is no need for a server or network nodes since everything will be handled locally. 

## Interoperability
The system is not expected to share data, resources, or personal information about the user(s) with other software or hardware. The only data that will be saved to the game 
will be the completed level and the user's setting preferences, such as visual, audio, and control settings. However, that data will be saved in the game, not shared to an 
outer source.

## Internationalization/ Localization

## Input/ Output

## Fault Tolerance

## Architectural Feasibility

## Overengineering

## Buy-VS-Build Decisions

## Reuse decisions
The system will end up using preexisting music since we will be adding that to the game. 
The system also does use a couple files for Unity itself for the game.

## Change Strategy

## General Architectural Quality
