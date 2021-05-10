## AB Arcade

Author: Abhi Bastiany

Game Description:
	The ABArcade game is a simple arcade room with a couple arcade consoles in the corners that can be interacted with.  Each console allows the player to enter a different minigame.

Arcade Room Operation:

	Movement: The WASD keys or Directional arrows will move the player around the arcade, while the mouse will allow the player to "look around".
	Interaction: The F key controls all interactions (i.e. playing the game consoles and exiting the game)
	Menu: N/A
	Exiting the game: Walking up to the Exit door with the Glowing Red Light will throw a prompt for the player to choose if they want to exit the game, and pressing F here will quit the application altogether.

Tunnel Racer Operation:

	Movement: The A and D keys or the Left and Right arrow keys will move the player side to side, and upon hitting a wall, the player object will rotate and slide up the wall with the same keys.
		**Note:  The wall rotation function only works currently moving from the bottom to the sides, not the sides to the ceiling and not back down to the floor.**
	Interaction: N/A
	Gameplay: The player is a cube stuck to the walls of a tunnel and obstacles will spawn intermittently at random locations in relation to the tunnel and move towards the player.  The player needs to avoid the obstacles
		  and every obstacle that passes the player will increase the score.  If an obstacle hits the player, the game is over.
	Menu: Pressing the P key will pull up the minigame menu which gives you the option to play the game again (this will restart from the beginning), view controls for the game, or quit the game.
	Exiting the game: In the minigame menu mentioned above, the "Quit" button will bring the player out of the minigame and back to the arcade.

Shooting Gallery Operation:

	Movement: The WASD keys will move the player around the range, while the mouse will allow the player to "look around".
	Interaction: N/A
	Gameplay: Targets will spawn at the left of one of four target tracks in front of the player and begin to move left to right.  When a target reaches the right of the track it is deleted and logged as a target passed.
		  A target that gets hit by a bullet will register as a hit target and if 5 more targets pass than are hit in a given round, the game is over.  Each round advances after 10 hit targets and gradually the target speed
		  will increase, and the interval between spawns will decrease.
	Scoring: Shooting a target will increase the score
		**Note:  The increasing score function does not currently work.**
	Menu: Pressing the P key will pull up the minigame menu which gives you the option to play the game again (this will restart from the beginning), view controls for the game, or quit the game.
	Exiting the game: In the minigame menu mentioned above, the "Quit" button will bring the player out of the minigame and back to the arcade.



For the Teacher:

	Almost all of the assets in this game were of my own creation.  The FPS assets were largely pulled from a pack on the asset store (as well as the targets and accompanying scripts) 
	however all of the ones which I used, I made changes to the scripts and the prefabs such as omitting and adding sections, extra scripts, removing and adding HUD components, and removing and adding object components.
	All of the scripts in the greater "Scripts" folder are my own creation as are all other assets separate from the FPS pack folder.


Image Credits:

ShootingGallery Background Image: Image by <a href="https://pixabay.com/users/adege-4994132/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=2318966">adege</a> from <a href="https://pixabay.com/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=2318966">Pixabay</a>
**Note: the above image was never used.**
Concrete Wall Image: Image by <a href="https://pixabay.com/users/anaterate-2348028/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=3117245">Wolfgang Eckert</a> from <a href="https://pixabay.com/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=3117245">Pixabay</a>
Ground Image: Image by <a href="https://pixabay.com/users/sojanjanso-3537296/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=1807373">Sojan Janso</a> from <a href="https://pixabay.com/?utm_source=link-attribution&amp;utm_medium=referral&amp;utm_campaign=image&amp;utm_content=1807373">Pixabay</a>

Music License:

The music used in the arcade and the minigame menus is a legally purchased track from MachinimaSound.  See enclosed License file for more information.