# MANUAL TESTS:
## Restart Button Test:
* Step 1: Load into a playable scene with a player and an obstacle.
   - This can be done by selecting the "Play" button when you open the game.
* Step 2: Move your player towards the left or right
   - This will allow you to move and see if the restart button works properly because your player should be in the same spot when you restart the game.
* Step 3: Move your mouse to be on the restart button which is at the bottom right of the screen.
* Step 4: Click once on the restart button.
* Step 5: Game should have reloaded, and your players should be in the same place they were when you started the game.

## Linked Movement Test:

* Step 1: Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity.
   - This can be done by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes
* Step 2: select play on the top middle of Unity
* Step 3: change to game view
* Step 4: Press 'A'
   - Both characters should move to the left
* Step 5: Press 'W'
   - Both characters should jump
* Step 6: Press 'D'
   - Both characters should move to the right

## Obstacle Test:
* Step 1: Load into a playable scene with a player and an obstacle.
   - This can be done by selecting the "Play" button when you open the game.
* Step 2: Move your player towards the obstacle by moving right with the "D" key.
* Step 3: Upon collision with the obstacle the player should die. 
* Step 4: Repeat for other player.

## Objective Test:
* Step 1: Load into a playable scene with a player and an obstacle.
   - This can be done by selecting the "Play" button when you open the game.
* Step 2: Move your player towards the objectives of their respective colors by pressing the 'A' and 'D' keys until they collide with the objectives.
   - The objectives will be picked up by the players until level completion or death
* Step 3: One the objectives are collected the game will proceed to the next level. If a player dies before all objectives are collected the game will have to be restarted.