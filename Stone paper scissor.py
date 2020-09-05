while True:

    import random
    choices = ['st','sc','p']

    print('Hello and Welcome!')
    attempt = 1
    game_on = True
    user_wins = 0
    computer_wins = 0

    def replay():
        
        replay_choice = input("Play again? (Y or N)")
        
        return replay_choice.upper() == 'Y'



    while game_on:

        for attempt in range(1,6):

            user_choice = input('Enter stone, paper or scissor: ')
            computer_choice = random.choice(choices)
            #print(computer_choice)

            if (user_choice == 'st' and computer_choice == 'sc') or (user_choice == 'sc' and computer_choice == 'p') or (user_choice == 'p' and computer_choice == 'st'):
                print('User wins!')
                user_wins += 1
                

            elif (user_choice == 'st' and computer_choice == 'p') or (user_choice == 'sc' and computer_choice == 'st') or (user_choice == 'p' and computer_choice == 'sc'):
                print('User lose!')
                computer_wins += 1
                

            else:
                print('Draw!')
                

            attempt += 1

        if user_wins > computer_wins:
            print('User finally wins!')
            break

        else:
            print('User finally loses!')
            break

        #break

    #play = input('Want to play again?')
    
    if not replay():
        break