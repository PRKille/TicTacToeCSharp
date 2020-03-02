|Behavior|Input|Output|
|:-:|:-:|:-:|
|Create Game object|[program initializes]|new Game {PlayerXorO, Board, TurnCount}|
|Creates boardarray of arrays of chars|(start program)|arr[][] = {{ , , },{ , , },{ , , }}|
|Will print empty board to console|"begin program"|(prints board)|
|Changes user after each turn|TurnCount%2 = 0|"O's Turn"|
|Take user input for move Coordinates|11|boardArray[1][1] = X|
|Say which player wins if win condition is met|CheckWin(board)|"Player X Wins!"|
|If move counter hits 9 and no wins, print 'Tie'|*no one wins on turn 9*|"It's a tie!"|