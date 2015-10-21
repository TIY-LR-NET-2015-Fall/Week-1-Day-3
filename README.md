Week 1 Day 3 
=========

Assignment
=========

How To Submit?
--------------

1. Go to https://gist.github.com/ and copy the text below into the file. 
2. Name the file "day-3.cs"
3. Add the code you wrote to the gist
4. Press 'Create a public gist'
5. Copy that URL to the Gist, and submit the link as an [issue](https://github.com/TIY-LR-NET-2015-Fall/Week-1-Day-3/issues)
    * The issue name should be "YourName - Day 3"
    * The issue description text should be a link
 
Create a 'Pig Dice' game for the console
--------------------
Gameplay
=======
Each turn, a player repeatedly rolls a die until either a 1 is rolled or the player decides to "hold":

If the player rolls a 1, they score nothing and it becomes the next player's turn.
If the player rolls any other number, it is added to their turn total and the player's turn continues.
If a player chooses to "hold", their turn total is added to their score, and it becomes the next player's turn.
The first player to score 100 or more points wins.

For example, the first player, Ann, begins a turn with a roll of 5. Ann could hold and score 5 points, but chooses to roll again. Ann rolls a 2, and could hold with a turn total of 7 points, but chooses to roll again. Ann rolls a 1, and must end her turn without scoring. The next player, Bob, rolls the sequence 4-5-3-5-5, after which he chooses to hold, and adds his turn total of 22 points to his score.

Normal
=====
Submit your game design notes with the gist.
Submit a working game with only one player. I.e. one player rolls unitl he hits 100 or more.
Use Functions as necessary.

Hard
=====
Mutiple Players can play also construct classes with properties and methods representing the game (i.e. dice, player, etc class).

Nightmare
======
Construct an AI that plays based on 'optimal play' as defined here: [Pig Dice Game Wiki] (https://en.wikipedia.org/wiki/Pig_(dice_game)#Optimal_play)
