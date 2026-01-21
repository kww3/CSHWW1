numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

remaining = set()
for i in numbers:
    if (i%2)==0:
        remaining.add(i)
for i in remaining:
    print("Remaining number:", i);

remaining.pop();
print("After popping an element:", remaining);
remaining.add(12);
print("After addig an element:", remaining);