# Zombie Game Project
## CONTROLS

```
W - Move forward
S - Move backward
A - Move left
D - Move right


Mouse input - Look around
Mouse left click - Shoot
Mouse right click - Aim down sight

```

## INTRODUCTION
As I was asked to make a zombie survival game for this project, I decided to take cues from the call of duty zombie mode. In said game you are faced with unending waves of a limitless horde zombies. With each wave that passes the zombies become more plentiful and can survive more damage until you are eventually overrun and can no longer survive.  
### GAME CONCEPT

## ASSETS USED
* [Standard Assets by Unity Technologies](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-32351) - Used for the First Person Controller 
* [Modern Guns: Handgun by Nokobot](https://assetstore.unity.com/packages/3d/props/guns/modern-guns-handgun-129821) - A simple hand gun with some animations
* [Zombie Animation Pack Free by Animus Digital](https://assetstore.unity.com/packages/3d/animations/zombie-animation-pack-free-150219) - A selection of different simple animations for the different states
* [Modular Abandoned Slaughterhouse: Lite by Mila Shalabai](https://assetstore.unity.com/packages/3d/environments/urban/modular-abandoned-slaughterhouse-lite-58082 ) - Assets for the level
* [Chainlink Fences by Kobra Game Studios](https://assetstore.unity.com/packages/3d/chainlink-fences-73107 ) - Assets for the level
* [Rubble Pieces Detailed Package by Nathanael Gazzard]( https://assetstore.unity.com/packages/3d/environments/rubble-pieces-detailed-package-74004) - Assets for the level
* [RPG/FPS Game Assets for PC/Mobile (Industrial Set v1.0) by Vdr0id](https://assetstore.unity.com/packages/3d/environments/industrial/rpg-fps-game-assets-for-pc-mobile-industrial-set-v1-0-87024) - Assets for the level
* [Old Building by Rusik3Dmodels](https://assetstore.unity.com/packages/3d/environments/industrial/old-building-70659) - Assets for the level
* [Makehuman by The MakeHuman team](http://www.makehumancommunity.org/) - Used to create the zombie model
* [Sound files by freesound.org](https://freesound.org/) - Used to find a collection of audio files used in the game
* [Grind And Death font by Knackpack Studio](https://www.dafont.com/grindanddeath.font) - Font found to add a little bit of style to the game

## SCRIPTS
Short descriptions of some of the scripts used.
Aim - Transitions the gun in front of the player so they can transition from using the crosshairs to the iron sights of the pistol for more accurate shooting.

Zombie Health - Checks if the zombie has been damaged and keeps track of the enemy’s health. If the zombie is hit it generates a particle effect showing the player that they have hit the zombie. If the zombie’s health is 0 then the animator of the object will be turned off and the zombie will ragdoll. This also deletes the dead zombie. 

Zombie spawner - randomly selects an area to spawn the zombie. Also controls the waves increasing the zombie count by 10 every wave. This script also initialises a 10 second cooldown between waves.

Ammo Text / Enemy Remaining /Player health / Score / Wave - these scripts update the UI so players receive the relevant information they need.

Remove bullet / Remove casings / Remove flash - These scripts came with the gun asset they had to be modified as the game objects they were generating were not being deleted cluttering the screen and hurting performance so i added a function to destroy each after a few seconds. I also added sound effects to the casings so they actually had an impact when they hit the ground.

Simple shoot - Same as a above this script came with the gun asset and was attached to it. I had to add a gunshot sound effect to the script and I also increased the animation speed of the gun because it was linked to the fire rate and I wanted to have a faster fire rate.

First Person Controller - I removed the jumping and sprinting mechanics from the first person controller as they were not needed for this game.

## STATE MACHINES
Idle behavior
ChaseBehaviour
AttackState

## CHALLENGES
Animations-state machines

## REFLECTION
Despite being relatively pleased with how the project turned out there were a few things that I didn’t get a chance to add that I wish I could have added. First and foremost, I wish I had added more guns than just the one in the demo. I had plans to add an assault rifle this would have been relatively simple as the bullet fire and casing eject script was already created all I would of had to do was get an assault rifle model and mark where the bullet was fired from and where the casings come out and have a constant fire rate from the gun. Another thing I wanted to add was limited ammo for the gun. This would have added a resource management element to the game. The zombies would have dropped ammo on the ground upon their death. Again, this would have had to have gone hand in hand with the multiple guns as if you ran out of ammo with the pistol you would have been completely defenceless. And the opposite if there was no resource management with the assault rifle then users would just constantly mow down zombies using the rifle and would never have a need for the pistol. 
I also would have liked to have added a selection of zombie types add some variety to the gameplay. Like a zombie that would like to stay at a distance and throw projectiles at the player. I also was planning an enemy that would buff the zombies around them so the player would have to focus their attention on them before battling the rest of the horde.
