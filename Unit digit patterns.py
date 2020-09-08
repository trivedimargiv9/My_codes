base_num = int(input('Input base number: '))
power = int(input('Input upto power: '))

numbers = []

for p in range(1,power+1):
    numbers.append(str(base_num**p))

# print(numbers)    
unit_digits = []

for nums in numbers:
    nums.split()
    unit_digits.append(int(nums[-1]))

print(unit_digits)