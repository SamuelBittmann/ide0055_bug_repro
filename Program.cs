// For this code a "warning IDE0055: Fix formatting" is reported
var result1 = new int[] { 1, 2 } switch
{
    [] => "empty",
    [1] => "one",
    _ => "unknown"
};

// For this code no warning is reported
var result2 = new int[] { 1, 2 } switch
{
    { Length: 0 } => "empty",
    [1] => "one",
    _ => "unknown"
};

Console.WriteLine(result1);
Console.WriteLine(result2);