# TEAM HELL'S KITCHEN
This is the github repository for Team Hell's Kitchen (aka Team Galilei) for our final project in the CPSC 4820 - 3D Game Programming: Algorithms and Techniques at Clemson University (Spring 2020).

## The Goal
The goal of our game is a quick battle arena esque game themed around kitchen/cooking. The player is placed in a kitchen/arena with other AI players with the camera being in a static, 3rd person bird's eye view with a slight angle. The arena is filled with collectibles and objects/weapons the player/AI can pick up. These are various kitchen/food items that can be used to attack the other players with. The last player standing wins! We think this game will be a fun game that may possible be implemented with multiplayer (if time permits). It draws inspiration theme-wise from Overcooked.

## Theme and Conception
The idea for our game was concocted while contemplating what genre of game to develop while simultaneously looking through our personal game libraries. We haphazardly brought up the concept of attempting a battle royale game, but we more or less dismissed the idea as being beyond the scope of what would be achievable for this assignment. As a bit of a thought experiment, we briefly contemplated what changes would need to be made to fit the genre into this timescope, such as a smaller environment, fewer players, and more limited timeframes. We still browsed through our libraries during this contemplation, and we stumbled across the game of Overcooked, a game defined by its cute artstyle and hectic kitchen environment. Thus the idea was born to have a cramped battle royale/dodgeball game in the middle of a kitchen.

## Game Design
### Environment
Gameplay will take place in a roughly square environment. The player will control one of 8 characters on the battleground/kitchen. Elements within the environment include collectibles, weapons, and objects to maneuver around (such as stoves, shelves, tables, etc.).

### Win Condition
Players will fight each other using the collectibles and weapons in the arena until all other players have run out of HP.  

### User Interface
A simple UI design will display the current HP of the players (TBD from the following):

- Health bar above each player’s head
- Health bar with different colors representative of P1, P2, etc. aligned on the sides/bottom of the screen
- 1 hit KO

Another UI element is what item the player is currently holding next to their health bar, most likely as a symbol.

### Controls
This game will utilize a basic control scheme with WASD for player movement. Player actions keys will be made to pick up and use different weapons.

**WASD: Movement**

**SpaceBar: Shoot**

**F: Pick up Items**


## Minimum Viable Product
A game with a moveable player with basic controls and the ability to use weapons.

## Team Dynamic
- Meeting times
  - Our proposed meeting time Monday and Friday at noon.
- Script delagation
  - We’ve decided to delegate the following scripts to each team member. Subject to change based on project requirements and time restraints. 

  **Ethan**
    - Colliders
    - Environment/Visuals
    - Models

  **Brandon**
    - Player movement
    - Enemy AI movement
    - Game Logic UI

  **Josh**
    - Collectibles/Spawning
    - Weapons/Weapon Mechanics 
    - Player UI

## Project Timeline
1. April 9th - First Playable Version (prototype)
  - Movable character
  - Basic level (colliders and basic design)
  - Basic Collectibles 
  - Game Logic/UI

2. April 20th - Second Playable Version
  - Moveable Enemy AI
  - Outlined borders 
  - Battle System

3. April 27th - Final Product
  - AI Fights back
  - Reformed UI

## Blog
### Week 1
For this week, we have worked on pushing out a minimum viable product. This includes making basic player movement, basic environment, and basic UI. We've been working on a simple randomized spawning system for the weapons as well as being able to pick up said weapons. The basic UI implemented is a simple heatlh bar showing player health. We've also been working towards basic combat with primitive shapes for the players and weapons. 

### Week 2
Our first game build has been published, and we are working towards taking in the feedback we received and refining the mechanics. One thing we had brought to our attention was the fact that our player character begins floating at a certain point, so debuggin will have to go towards that. Another thing we will need to be working towards is refining the character models and environment. 

