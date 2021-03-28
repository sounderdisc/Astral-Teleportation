# MANUAL TESTS:

## Restart Button Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the left by pressing 'A' or right by pressing 'D'. | When pressing 'A' you should see the player move left. When pressing 'D' you should see the player move right. |
| Step 5 | Click once on the restart button which is at the bottom right of the screen. | Clicking the button should reload the game and you should see the scene reset and the players should be in the same place they were when you started the game. |

## Linked Movement Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the left by pressing 'A'. | When pressing 'A' you should see the player move left. |
| Step 5 | Make your player jump by pressing 'W'. | When pressing 'W' you should see the player jump. |
| Step 6 | Move your player towards the right by pressing 'D'. | When pressing 'D' you should see the player move right. |

## Obstacle Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the obstacle by moving right with the 'D' key. | When pressing 'D' you should see the player move right and upon collision with the obstacle the player should die. |
| Step 5 | Repeat for the other player by moving right with the 'D' key. | When pressing 'D' you should see the player move right and upon collision with the obstacle the player should die as well. |

## Objective Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the objectives of their respective colors (red goes to red and blue goes to blue) by pressing the 'A' and 'D' keys. | When pressing 'A' you should see the player move left. When pressing 'D' you should see the player move right. They should collide with the objectives. |

## Visually Different Characters Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view and you should be able to visually see that one character is red and one character is blue. |

## Level Select Test

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Hover over the "Level Select" button and press it. | A new screen with "Select A Level" and ten numbered buttons should appear. |
| Step 5 | Hover over the "Return" button and press it. | A screen with the main menu should reappear. |
| Step 6 | Click the "Level Select" button again | A screen returning to the level select screen should appear. |
| Step 7 | Click one of the numbered buttons. Expect either a level to load or red error text at the bottom of the terminal saying no level of that number exists yet. | At the time of writting, for level "1" and level "2" a level should load and clicking all other numbered buttons should produce an error. |
| Step 8 | After a level loads or an error is issued, click the play button at the top of the viewport that you clicked in step 2 in order to reset your session. | Your session should have reset and you should be in game view again. |
| Step 9 | Then click the play button again, then the level select button, then test another numbered button. Repeat until you have tried every button. | This should allow you to check the ten levels that are displayed in the "Select A Level" screen. |

## Background Test

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view and you should be able to see that the background is visible. |

## Obstacle Animation Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the obstacle by moving right with the 'D' key. | When pressing 'D' you should see the player move right and the animation should animate/move. |

## Pause Button Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Press the Pause button that is at the top right OR press ESC key. | When pressing the Pause button, the game should pause. When pressing the 'ESC' key the game should pause. |
| Step 5 | Press the 'ESC' key to unpause. | Pressing the 'ESC' key again should unpause the game. |

## Timer Test

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view and you should be able to see the timer starting counting in the top right corner. |

## Space Themed Characters Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view and you should be able to visually see that both red and blue characters are space themed characters. |

## Sound Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the obstacle by moving right with the 'D' key. | When pressing 'D' you should see the player move right and a sound should be heard when player comes in contact with obstacle. |

## Portal Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "PortalTest" file in Assests->Scenes->testingScenes. | This will open up the scene in unity, and you should see the scene in the viewport. |
| Step 2 | Select play on the top middle of Unity. This will make the game begin to play. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | There is a portal above the blue character's head in this scene. Jump with the 'W' key. | When pressing 'W' you should see the blue character move up and intersect the portal above its head. When this overlap happens, the character should be teleported instantly to the other, red, portal. |

## Decoration Test:
| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load any scene at Assets/Scenes/ by double clicking a scene in Unity | This should open the scene of choice inside of Unity |
| Step 2 | Navigate to the decoration prefab folder at Assets/Prefabs/Decoration_Prefabs/ | This should list all available decoration prefabs available |
| Step 3 | Click and drag any decoration prefab into the editor window | The decoration should appear where the prefab was placed inside the editor |
| Step 4 | Check that the prefab has been placed successfully and has the proper components | Each decoration prefab should have a rigidbody 2D component and a box collider 2D component fit to the sprite |
| Step 5 | Continue checking each decoration prefab in the same way as steps 1 - 4 | This should confirm that all prefabs are working correctly and have the correct components |

## Hint Button Test:

| No | Steps to Reproduce | Expected Behavior |
|--- |--------------------|-------------------|
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Press the Hint button that is at the top right. | When pressing the Hint button, the game should show a hint in the top center region of the game screen. After 5 seconds the hint should disappear. |

