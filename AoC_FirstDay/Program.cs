string sample = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

int maxCalories = sample.Split("\n\n")
    .Select(elf => elf.Split("\n")
    .Select(int.Parse)
    .Sum()
    )
    .Max();
Console.WriteLine($"Part 1: {maxCalories}");
    