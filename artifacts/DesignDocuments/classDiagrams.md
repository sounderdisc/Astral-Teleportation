| Portal Gun |
| --- |
| + int xPosition  + int yPosition  + int characterID |
| Shoot()Aim() |

| Character Status |
| --- |
| + int characterID+ int health  + int xPosition  + int yPosition  + int xVelocity  + int yVelocity |
| Move( keyInput )Jump() |

| Obstacle |
| --- |
| + int type+ int xPosition  + int yPosition  + int damageAmount |
| getGraphic(type)lowerHealth(damageAmount, characterID) |

| Game Status |
| --- |
| + int goalXPos  + int goalYPos  + boolean levelPassed |
| passLevel()updateFile() |

| Save File Controller |
| --- |
| Int[] unlockedLevels |
| saveFile(unlockedLevels) |
