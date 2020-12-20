import os
from math import inf as infinity  # importing the infinity module from the math library under the alias 'infinity'
from os import system
from random import choice  # importing the choice module from the random library
import platform
import time  # importing the time library
import random  # re-importing the random library as a whole for AFK feature purposes (TO BE MADE REDUNDANT)

HUMAN = -1
COMP = +1
board = [
    [0, 0, 0],
    [0, 0, 0],
    [0, 0, 0],
]

# AFK mode
afk_switch = False  # Set to True for afk mode
afk_move = [1, 2, 3, 4, 5, 6, 7, 8, 9]
player_move = random.choice(afk_move)

"""
//AFK MODE//
A randomized array that selects random 
key value and uses it as a move on the board 
"""


def evaluate(state):
    # evaluates the heuristic value of current branch
    if wins(state, COMP):
        score = +1
    elif wins(state, HUMAN):
        score = -1
    else:
        score = 0

    return score


def wins(state, player):
    # A matrix of all the possible win states
    win_state = [
        [state[0][0], state[0][1], state[0][2]],
        [state[1][0], state[1][1], state[1][2]],
        [state[2][0], state[2][1], state[2][2]],
        [state[0][0], state[1][0], state[2][0]],
        [state[0][1], state[1][1], state[2][1]],
        [state[0][2], state[1][2], state[2][2]],
        [state[0][0], state[1][1], state[2][2]],
        [state[2][0], state[1][1], state[0][2]],
    ]
    if [player, player, player] in win_state:
        return True
    else:
        return False


def game_over(state):
    # The function checks the game state and returns if the game is over
    return wins(state, HUMAN) or wins(state, COMP)


def empty_cells(state):
    # Creates an array of empty cells and returns them
    cells = []

    for x, row in enumerate(state):
        for y, cell in enumerate(row):
            if cell == 0:
                cells.append([x, y])

    return cells


def valid_move(x, y):
    # Returns true or false depending on the
    if [x, y] in empty_cells(board):
        return True
    else:
        return False


def set_move(x, y, player):
    # redraw board with move if move is correct
    if valid_move(x, y):
        board[x][y] = player
        return True
    else:
        return False


def minimax(state, depth, player):
    # AI function that chooses the best best next move based on the current state of the board
    # Searches all the nodes in the tree and chooses the best outcome
    if player == COMP:
        best = [-1, -1, -infinity]
    else:
        best = [-1, -1, +infinity]

    if depth == 0 or game_over(state):
        score = evaluate(state)
        return [-1, -1, score]

    for cell in empty_cells(state):
        x, y = cell[0], cell[1]
        state[x][y] = player
        score = minimax(state, depth - 1, -player)
        state[x][y] = 0
        score[0], score[1] = x, y

        if player == COMP:
            if score[2] > best[2]:
                best = score  # max value
        else:
            if score[2] < best[2]:
                best = score  # min value

    return best


def clean():
    # Console clean function
    os_name = platform.system().lower()
    if 'windows' in os_name:
        system('cls')
    else:
        system('clear')


"""
//Clean Function//
Checks OS platform
Converts it to lowercase string
Compares if OS platform contains the keyword windows and uses windows CMD command
If other OS uses linux conventional command 'clear'
Clears console
"""


def render(state, c_choice, h_choice):
    # Generates the board

    chars = {
        -1: h_choice,
        +1: c_choice,
        0: ' '
    }
    str_line = '---------------'

    print('\n' + str_line)
    for row in state:
        for cell in row:
            symbol = chars[cell]
            print(f'| {symbol} |', end='')
        print('\n' + str_line)


def ai_turn(c_choice, h_choice):
    # Call minimax based function if unresolved chooses random move
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    clean()
    print(f'Computer turn [{c_choice}]')
    render(board, c_choice, h_choice)

    if depth == 9:
        x = choice([0, 1, 2])
        y = choice([0, 1, 2])
    else:
        move = minimax(board, depth, COMP)
        x, y = move[0], move[1]

    set_move(x, y, COMP)
    time.sleep(1)


def human_turn(c_choice, h_choice):
    # The Human plays choosing a valid move.
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    # Dictionary of valid moves
    move = -1
    moves = {
        1: [0, 0], 2: [0, 1], 3: [0, 2],
        4: [1, 0], 5: [1, 1], 6: [1, 2],
        7: [2, 0], 8: [2, 1], 9: [2, 2],
    }

    clean()
    print(f'Human turn [{h_choice}]')
    render(board, c_choice, h_choice)

    while move < 1 or move > 9:  # if the move is within the range of 1-9 proceed
        try:
            if not afk_switch:  # Checks if AFK is enabled
                move = int(input('Make your move (1..9): '))  # if AFK is disabled then get user input to play
            else:
                move = player_move  # Use randomized input from the array of 1-9
            coord = moves[move]
            can_move = set_move(coord[0], coord[1], HUMAN)

            if not can_move:  # If can't move then print response
                print('Bad move, try again')
                move = -1

        except (EOFError, KeyboardInterrupt):
            print('Bye, Play soon')  # response for terminating program unexpectedly
            exit(code=1)
        except (KeyError, ValueError):
            print('Bad choice')  # exception for an invalid value


"""
//Play again function//
Asks the player if they want to play again and reloads the main program file if the player wants to continue 
playing or terminates """


# play again loop
def play_again():
    play_again_choice = input("Do you want to play again? y/n: ")
    if play_again_choice == "y":
        clean()
        os.system("python main.py")
    else:
        print("Thanks for playing")
        exit(code=1)  # Terminates game on end


def main():
    # Main program
    clean()
    h_choice = ''  # X or O
    c_choice = ''  # X or O
    first = ''  # if human is the first

    # Human chooses X or O to play
    while h_choice != 'O' and h_choice != 'X':
        try:
            print('')
            h_choice = input('Choose X or O\nChosen: ').upper()
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit(code=1)
        except (KeyError, ValueError):
            print('Bad choice')

    # Setting computer's choice, if human chooses x choose O else choose x
    if h_choice == 'X':
        c_choice = 'O'
    else:
        c_choice = 'X'

    # Check if player wants to start first
    clean()
    while first != 'Y' and first != 'N':
        try:
            first = input('First to start?[y/n]: ').upper()
        except (EOFError, KeyboardInterrupt):
            print('Thanks for playing')
            exit(code=1)
        except (KeyError, ValueError):
            print('Please select y or n ')

    # Main loop of this game
    while len(empty_cells(board)) > 0 and not game_over(board):
        if first == 'N':
            ai_turn(c_choice, h_choice)
            first = ''

        human_turn(c_choice, h_choice)
        ai_turn(c_choice, h_choice)

    # Game over message
    if wins(board, HUMAN):
        clean()
        print(f'Human turn [{h_choice}]')
        render(board, c_choice, h_choice)
        print('YOU WIN!')  # winner msg
        play_again()
    elif wins(board, COMP):
        clean()
        print(f'Computer turn [{c_choice}]')
        render(board, c_choice, h_choice)
        print('YOU LOSE!')  # Looser msg
        play_again()
    else:
        clean()
        render(board, c_choice, h_choice)
        print('DRAW!')  # Draw msg
        play_again()


if __name__ == '__main__':
    main()
