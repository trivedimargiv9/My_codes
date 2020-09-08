# Guess between 1 to 10
import random
game_on = True

x = random.randint(1,10)
print(x)
guessed_num = 0

attempts = 0

    while game_on:

        while x != guessed_num and attempts != 5:

            guessed_num = int(input('Guess the number: '))

            if guessed_num == x:
                print('You are right!') 
                play = input('Want to play again? (y or n):')
                if play == 'y':
                    game_on = True
                    break
                else:
                    game_on =False
                    break
            else:
                print('Please try again\n')

            attempts += 1

            if attempts == 5:
                print('Sorry you lost!')
                game_on = False
                play = input('Want to play again? (y or n):')
                if play == 'y':
                    game_on = True
                    break
                else:
                    game_on =False
                    break
   
        # play = input('Want to play again? (y or n):')

        # if play == 'y':
        #     game_on = True

        # else:
        #     game_on = False
