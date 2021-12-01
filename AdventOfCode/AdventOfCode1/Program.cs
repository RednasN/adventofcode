//Part1
var measurements = File.ReadAllLines("./Input.txt").Select(x => int.Parse(x)).ToList();
var result = Enumerable.Range(1, measurements.Count - 1).Where(i => measurements[i] > measurements[i - 1]).Count();
Console.WriteLine(result);

//Part2
var result3 = Enumerable.Range(0, measurements.Count).Where(i =>
measurements.Skip(i).Take(3).Sum() >
measurements.Skip(i - 1).Take(3).Sum()).Count();
Console.WriteLine(result3);