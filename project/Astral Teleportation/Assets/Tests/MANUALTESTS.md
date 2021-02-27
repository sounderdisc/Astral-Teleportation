# MANUAL TESTS:
## Restart Button Test:
* Step 1: Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity. The game should be displayed.
   - This can be done by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes.
* Step 2: Select play on the top middle of Unity. This will allow the game to be playable.
* Step 3: Change to game view by clicking the Game tab. Clicking the game tab should display the game in game view.
* Step 4: Move your player towards the left by pressing 'A' or right by pressing 'D'. Pressing one of the buttons should move your player.
* Step 5: Click once on the restart button which is at the bottom right of the screen. Clicking the button should reload the game and your players should be in the same place they were when you started the game.

## Linked Movement Test:

* Step 1: Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity. The game should be displayed.
   - This can be done by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes
* Step 2: Select play on the top middle of Unity. This will allow the game to be playable.
* Step 3: Change to game view by clicking the Game tab. Clicking the game tab should display the game in game view.
* Step 4: Press 'A'. Pressing this button should move both characters to the left.
* Step 5: Press 'W'. Pressing this button should make both characters jump.
* Step 6: Press 'D'. Pressing this button should move both characters to the right.

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

## Visually Different Characters Test:
* Step 1: Load into a playable scene with two characters.
   - This can be done by selecting the "Play" button when you open the game.
* Step 2: The characters should be visually different. One being blue and the other red.

## Level Select Test
* Step 1: Load into the main menu. This is done by double clicking the approriate scene in Unity, then pressing the play button at the top of the viewport.
* Step 2: Hover over the "Level Select" button and press it. A new screen with "Select A Level" and ten numbered buttons should appear.
* Step 3: Hover over the "Return" button and press it. Confirm that the main menu reappears, then click the "Level Select" button again to return to the level select screen.
* Step 4: Click one of the numbered buttons. Expect either a level to load or red error text at the bottom of the terminal saying no level of that number exists yet. At the time of writting, for "1" and "2" a level should load and clicking all other numbered buttons should produce an error.
* Step 5: After a level loads or an error is issued, click the play button at the top of the viewport that you clicked in step 1 in order to reset your session. Then click that button again, then the level select button, then test another numbered button. Repeat until you have tried every button.

## Background Test
* Step 1: Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity. Clicking this file should take the user to the scene which will display the background.
   - This can be done by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes.
