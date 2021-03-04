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

| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the left by pressing 'A'. | When pressing 'A' you should see the player move left. |
| Step 5 | Make your player jump by pressing 'W'. | When pressing 'W' you should see the player jump. |
| Step 6 | Move your player towards the right by pressing 'D'. | When pressing 'D' you should see the player move right. |

## Obstacle Test:
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the obstacle by moving right with the 'D' key. | When pressing 'D' you should see the player move right and upon collision with the obstacle the player should die. |
| Step 5 | Repeat for the other player by moving right with the 'D' key. | When pressing 'D' you should see the player move right and upon collision with the obstacle the player should die as well. |

## Objective Test:
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 4 | Move your player towards the objectives of their respective colors (red goes to red and blue goes to blue) by pressing the 'A' and 'D' keys. | When pressing 'A' you should see the player move left. When pressing 'D' you should see the player move right. They should collide with the objectives. |
| Step 5 | One the objectives are collected the game will proceed to the next level. If a player dies before all objectives are collected the game will have to be restarted.

## Visually Different Characters Test:
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view and you should be able to visually see that one character is red and one character is blue. |

## Level Select Test
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view. |
| Step 2 | Hover over the "Level Select" button and press it. | A new screen with "Select A Level" and ten numbered buttons should appear. |
| Step 3 | Hover over the "Return" button and press it. | A screen with the main menu should reappear. |
| Step 6 | Click the "Level Select" button again | A screen returning to the level select screen should appear. |
| Step 4 | Click one of the numbered buttons. Expect either a level to load or red error text at the bottom of the terminal saying no level of that number exists yet. | At the time of writting, for level "1" and level "2" a level should load and clicking all other numbered buttons should produce an error. |
| Step 5 | After a level loads or an error is issued, click the play button at the top of the viewport that you clicked in step 1 in order to reset your session. | Your session should have reset and you should be in game view again. |
| Step 9 | Then click the play button again, then the level select button, then test another numbered button. Repeat until you have tried every button.

## Background Test
| Step 1 | Load the scene at "Assets/Scenes/testingScenes/LinkedScene.unity" into unity by double clicking the "LinkedScene" file in Assests->Scenes->testingScenes. | This will open up unity, and you should see the editor. |
| Step 2 | Select play on the top middle of Unity. This will allow the game to be playable. | The Unity editor should get darker at this time, notifying you that the game is now playing. |
| Step 3 | Change to game view by clicking the Game tab. | This should display the game in game view and you should be able to see that the background is visible. |
