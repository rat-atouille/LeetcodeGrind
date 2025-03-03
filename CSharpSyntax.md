## Conversion
```
Convert.ToString(var)        // var -> string
Convert.ToInt32(myDouble)    // double -> int
Convert.ToType(var)          // var -> typ

// string to char array
string str = "Hello";
char[] characters = str.ToCharArray();

// lowercase
myString.ToLower();

```

## Math
```
Math.Round(9.99);
Math.Min(5, 10);
```

## Array 
```
<Data Type>[ ] <Name_Array>;                                            // declare array
type [ ] < Name_Array > = new < datatype > [size];                     // array initialization 

<data_type>[] <arr_name> = new <data_type>[size];                      // Defining array with size, but not assigns values
<data_type>[] <arr_name> = new <data_type>[size]{ array_elements};    // Defining array with size and assigning the values at the same time
<data_type>[] <arr_name> = { array_elements };                        //The value of the array is directly initialized without taking its size

Initializing an Array after the declaration, it must be initialized with the new keyword. It can’t be initialized by only assigning values

Array.Sort(arrayName);    // sort
int max = arrayName.Max();
```

## List
```
List<int> numbers = new List<int>();      // declare and create empty
List<int> numbers = new List<int>() { init here };
List.Add();
List.Remove();
List.Count();
```

## LinkedList<T> (Doubly Linked List)
```
LinkedList<int> list = new LinkedList<int>();
list.AddLast(20);
list.AddFirst(20);
Console.WriteLine(list.First.Value);
```

## Stack
```
Stack<int> stack = new Stack<int>();
stack.Push();
stack.Pop();
```

## Queue
```
Queue<int> queue = new Queue<int>();
queue.Enqueue(10);
queue.Dequeue();
```

## Dictionary 
```
Dictionary<TKey, TValue> dictionaryName = new Dictionary<TKey, TValue>();
ageDict["Alice"] = 25;
d.Count	// count keys

Remove(TKey)
ToString()
```

## Hashset
```
HashSet<int> numbers = new HashSet<int>() { 1, 2, 3 };
numbers.Add(2);
numbers.Count();
```
