# Star_Collect
 My first game made in Unity, made for a class. I initially named the game "Star Collect" when I was first working on it, but I eventually decided to change the name to "Star Bay." Below is a detailed review of my work from right after I completed the game.

 	One of the first things I did was implement falling platforms with my script FallingPlatform. I took the code used in the book's (The Ultimate Guide to 2D Games Development With Unity by Patrick Felicia) example on page 138, and edited it to make the platform fall after 2 seconds, instead of immediately after collision. In line 25, I created the function OnCollisionEnter2D, with the parameter type Collision2D and the name coll, where I added a conditional statement saying that if an object with the tag name “Player” collides with the object the script is assigned to, then the earlier established function “killIt” will be invoked after 2 seconds.  
 
	In my script FirstPlatFall I used the function OnCollisionExit2D, once again with the parameter type Collision2D and the name coll. I added a conditional statement where if an object, in this case the player, leaves the platform the script is attached to, then that platform will be destroyed.
 
	I added meteors falling from the sky to create an enemy of sorts that would cause the player to lose damage. In the spawner script, called MeteorSpawnScript, I first established the global variables: a public GameObject called enemy, a float called randX, a public float called spawnRate (the rate being 2 seconds), and a float called nextSpawn (set to 0). In the update function, I used a conditional if statement, where if the time was greater than the value of the variable nextSpawn then the following would happen: nextSpawn would equal time plus the time of the spawnRate, randX would be set to a coordinate anywhere between -18.2 and 14.0, whereToSpawn would be given a new Vector2 coordinate, with the value of randX being the X value, and Y being where the spawner (an empty game object) it, and finally the enemy would be spawned (or instantiated) in relation to the whereToSpawn coordinates. 
 
	In order to make it so the player lost lives from the falling meteors, I used the scripts PlayerHealth and HealthBarScript. In the HealthBarScript, I defined a public variable of Slider and named it slider. Then I created a public function SetMaxHealth with the parameters of an integer called health. I called on the slider and then maxValue (of the health bar) to be equal to the integer health. Then I called on the slider and then the value (of the health bar) to be equal to the integer health. In the public function SetHealth to make the value of the slider equal health. In my script PlayerHealth, I actually deal with the changing value of the player’s health and what it means. First I established the public integers maxHealth (set to 5) and currentHealth. I also called for the script HealthBarScript and renamed it healthBar. In the start function I set the currentHealth equal to maxHealth so that the player would start out with 5 lives. Then in the Update function I used an if statement to make it so if the currentHealth is equal to or less than 0, then the “Lose” screen would be loaded. In order to make the player take damage from meteors I used the function OnCollisionEnter2D, defined what the string tagName was, then used an if statement to say that if the tag name of an object was “meteor” then the player would take one damage (with the use of the function TakeDamage) and the object would be destroyed. In the function TakeDamage, the parameters of an integer named damage, the currentHealth loses life equal to the damage. The Healthbar would then be updated to reflect the damage.
 
	In order to make it so the player could only finish level 2 and beat the game if the player had collected a key item, I used the scripts KeyItemCollect and newLevel. In KeyItemCollect I defined the public global bool, named it isKeyCollected, and set it to false. I then used a private function OnTriggerEnter2D with the parameter Collider2D named collision. I defined the string tagName, then created a if statement where if the tagName of an object that is a trigger is “KeyItem” then the bool isKeyCollected is set to true, the object is destroyed, and a debug.log is also displayed saying that isKeyCollected = true. Then, in the script newLevel, I first called on the script KeyItemCollect and named it keyCollect. Then, in the start function, I find the script KeyItemCollect. I used a similar level progression as in the book’s platformer, with a OnCollisionEnter2D function. To end level2, I used an if statement to first check if the object’s tag name is "endOfLevelTwo". Then I used an if/else statement within that, so that if the bool isKeyCollected is true, the player can move onto the win screen. Else, a debug.log displays “Get Key”.
 
	In order to get a platform that moves up, I used the script PlatMoveUp. I first defined the public floats direction and timer, and the public bool names moving. In the start function the direction is set to 0.1. In the function OnCollisionEnter2D an if statement looks to find if the object it collided with is tagged with “Player” which then sets moving to false. In the function FixedUpdate an if statement is used to check if moving = true. When it is true, the timer begins working and the platform transforms up. Another if statement is used to check if the timer is greater than or equal to 1, and if it is then the direction and timer are both set to 0 and the platform stops moving. 
	I wanted to include some text on screen that would be able to appear or disappear at certain spots in the level. To do this I used the script NoticeCheck. In this I first defined 3 GameObject variables called UiObject, txt2, and txt3. In the start, I set whether they were active or not when first loading the game by setting them to true or false. Then, I used OnTriggerEnter2D with a parameter of Collider2D called other. I then used several if conditions for each GameObject variable, to decide when the text would activate or deactivate respectively.
 
	I wanted a bit of text to set up what was happening in the game after starting and before the first level, so I set up a string of dialogue with the scripts Dialogue, DialogueManager, and DialogueTrigger. I followed the video linked within the scripts, but I edited it so the function EndDialogue calls on the SceneManager and loads the scene “Level1.”
