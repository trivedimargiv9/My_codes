#from IPython.display import clear_output
board_list = [' '] * 10

def displsy_board(board_list):
  #  clear_output()
    print(board_list[7] + ' | ' + board_list[8] + ' | ' + board_list[9])
    print(board_list[4] + ' | ' + board_list[5] + ' | ' + board_list[6])
    print(board_list[1] + ' | ' + board_list[2] + ' | ' + board_list[3])

def player_output():
    marker =''
    while marker != 'X' and marker != 'O':
        
        marker = input("Enter your marker: (X or O)").upper()
        
    if marker == 'X':    
        return ('X','O')
    else:
        return ('O','X')



def place_marker(board,marker,position):
    board[position] = marker      


def win_check(board_list,mark):
    
    return ((board_list[1] == mark and board_list[2] == mark and board_list[3] == mark)
    or (board_list[1] == mark and board_list[4] == mark and board_list[7] == mark)
    or (board_list[1] == mark and board_list[5] == mark and board_list[9] == mark)
    or (board_list[2] == mark and board_list[5] == mark and board_list[8] == mark)
    or (board_list[3] == mark and board_list[5] == mark and board_list[7] == mark)
    or (board_list[3] == mark and board_list[6] == mark and board_list[9] == mark)
    or (board_list[4] == mark and board_list[5] == mark and board_list[6] == mark)
    or (board_list[7] == mark and board_list[8] == mark and board_list[9] == mark))


    import random

def choose_first():
    if random.randint(0,1) == 0:
        return 'Player 2'
    else:
        return 'Player 1'
    

def space_check(board, position):
    
    return board[position] == ' '



def full_board_check(board):
    for i in range(1,10):
        if space_check(board, i):
            return False
    return True



def player_choice(board):
    position = 0
    while (position not in range(1,10) or not space_check(board,position)):
        
        position = int(input('Enter your position: '))
        
    return position 


def replay():
    
    replay_choice = input("Play again? (Y or N)")
    
    return replay_choice.upper() == 'Y'




print("Welcome!")

while True:
    
    the_board = [' '] * 10
    #marker assignment
    player1_marker,player2_marker = player_output()
    
    turn = choose_first()
    print(turn + "will go first")
        
    ready = input("Are you ready? (Y or N)")
    
    
    if ready.upper() == 'Y':
        game_on = True
    else:
        game_on = False
        
    while game_on:
        
       
        # player 1
        if turn == 'Player 1':
            
            displsy_board(the_board)
            
            #position choice
            position = player_choice(the_board)
            
            #place marker and display board
            place_marker(the_board,player1_marker,position)
            
            #wincheck
            if win_check(the_board,player1_marker):
                displsy_board(the_board)
                print("Player 1 wins!")
                game_on = False
                
            else:
                if full_board_check(the_board):
                    displsy_board(the_board)
                    print("It's a Tie!")
                    break
                else:
                    turn = 'Player 2'
                    
        else:   #player 2
            
            displsy_board(the_board)
            #position choice
            position = player_choice(the_board)
            
            #place marker and display board
            place_marker(the_board,player2_marker,position)
            
            #wincheck
            if win_check(the_board,player2_marker):
                displsy_board(the_board)
                print("Player 2 wins!")
                game_on = False
                
            else:
                if full_board_check(the_board):
                    displsy_board(the_board)
                    print("It's a Tie!")
                    break
                else:
                    turn = 'Player 1'
            
    if not replay():
        break
            
            