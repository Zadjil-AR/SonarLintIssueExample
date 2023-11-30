string? nullItem = null;
bool value = false;

Console.WriteLine(nullItem.ToUpper());

if (nullItem == null) Console.WriteLine(value);
if (nullItem != null) Console.WriteLine(value);

switch (nullItem)
{
	case "a":
		Console.WriteLine("yes");
		value = true;
		break;
	case "b":
		Console.WriteLine("no");
		value = false;
		break;
	default:
		Console.WriteLine("yes");
		value = true;
		break;
}

Console.WriteLine(value);
