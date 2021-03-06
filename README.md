# Floppy Bird

Made by Saunak Karnati and Vihaan Siramdas

## Video Demo:
https://www.youtube.com/watch?v=hCLvE9RtSCE

## Description:
  This project is Flappy Bird but in 3D and with powerups. You can press space to jump and power ups have a 25% chance of spawning every 20 seconds. As the bird flies, you have to go through each pair of pipes by jumping. The pipes will spawn forever with varying heights and because of that the gaps between each pipe will vary in vertical height. 

  This project is developed in the Unity game engine; scripts were made using C#; player, pipe, and power up models were made in blender; and other assets were downloaded from Unity Asset Store.

#### Best Score

Displays the best score you got onto the text in the game over scene, it also saves the score on the local disk.

#### Game Management

Starts the game every time you play and contains the functions to stop and reset the game. It controls the start, stop, and overall gameplay.


#### Music Player

Plays the music at the start of the game.


#### Pipe Generation

Generates pipes every 5 seconds on a random y value. It also deletes the pipes after you pass through them.
  

#### Pipes

Moves the pipes forward
  

#### Play Button

Calls the reset function from the Game Management script when you click the play button, allowing the player to play the game again
  

#### Player

Handles the dying of the player and the player movement. The 'immortal' and 'mortal' state makes it so that the player can be immune to the pipes for some time.
  

#### Power Up

Spawns random power ups with a 25% chance of spawning every 20 seconds. This script is really close to the Pipe Generation script.
  

#### Power Up Bar

Shows the Power Up Bar when you collect a power up and shows the timer going down.
  

#### Power Up Handler

Activates the powerup when you collect it and removes the powerup effect after some time.
  

#### Scoreboard

Adds points to the scoreboard everytime you go through a pipe throughout the game.
  

#### Score Manager

Handles the scoring and best score calculating logic.
  

#### Scorer

Calls the scoring function from the score manager when the player passes through a pipe, adding 10 points.
  

#### X button

Closes the game when you press the Exit Button
 
## Future Enhancements
Some features we would like to add:
* You can sign in and out
* You can move 3 dimensionally
* Max score can be retained across different machines for a user
* A shop system where you can collect coins throughout the game and use them in the shop for different power ups, levels, and player skins.

## Some Problems We Encountered
* We decided that the pipes and ground should move while the player is only moving in a y direction, but making the ground move was hard. We decided that the ground will move at the same speed of the pipe and teleport back to the start once you reach the end of the ground. You can still see the flash from the teleportation
* When making the player, we had several models but they looked weird because the eyes were weird. So we removed the eyes and found the model that looked the best
* The powerups were a major challenge since we had errors in the generation, activation, and the deactivation but we got it eventually. :)

## Game Link:
https://play.unity.com/mg/other/floppy-bird-1
Hope you enjoy!!! :P
