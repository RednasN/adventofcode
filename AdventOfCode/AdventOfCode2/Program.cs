var directions = File.ReadAllLines("./Input.txt").ToList();

//Part1
var horizontal = 0;
var vertical = 0;


foreach (string direction in directions)
{
    var command = direction.Split(' ');

    var result = command[0] switch
    {
        "forward" => horizontal += int.Parse(command[1]),
        "backward" => horizontal -= int.Parse(command[1]),
        "up" => vertical -= int.Parse(command[1]),
        "down" => vertical += int.Parse(command[1]),        
        _ => throw new NotSupportedException()
    };
}

Console.WriteLine(horizontal * vertical);

//Part2
var aim = 0;
horizontal = 0;
vertical = 0;
foreach (string direction in directions)
{
    var command = direction.Split(' ');

    switch (command[0])
    {
        case "forward":
            horizontal += int.Parse(command[1]);
            vertical += aim * int.Parse(command[1]);
            break;
        case "backward":
            break;
        case "down":
            aim += int.Parse(command[1]);
            break;
        case "up":
            aim -= int.Parse(command[1]);
            break;

    }
}

Console.WriteLine(horizontal * vertical);