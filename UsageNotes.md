
## Exercice 8

Make the candidate at ease. Give him/her a notebook, a pencil and a Visual Studio-equipped computer. Open the Exercices solution, hide all projects except `Exercice8`, make it the startup project.

<!-- language: c# -->

    static void Main(string[] args)
    {
        var marks = Mark.GetMarks();

        //
        // Exercice
        //
        // You have a collection of marks in the marks variable. All marks have a minimum and maximum value.
        //
        // Using this console application, compute the average mark for the entire collection, express it as a mark from 0/20 to 20/20.
        // You are free to build your solution the way you want.
        // Your goal is to display the value in a human-readable way.
        //
    }

Here the candidate is given a simple mathematical problem. The `Mark` class is a basic structure representing a mark. A mark has a minimum value, a maximum value and a value. The `Mark.GetMarks()` method returns a collection of marks.

The average mark is `0.57099999999999984`. Or ~11/20.

### What to expect?

#### Math stuff

There are two majors ways to proceed. The first is to use the basic average formula by aligning all marks to a 0-1 range.

    var result = Math.Round(
        marks.Average(
             f => (((double)f.Value) + (0 - f.Minimun))
                / (((double)f.Maximum) + (0 - f.Minimun))), 2) * 20;

The other uses less memory and consists of accumulating the average value in a loop. Loss of precision may occur :(

    double currentAverage = 0D;
    for(int i = 0; i < marks.Count; i++) {
        var mark = marks[i];
        double deltaLeft = mark.Value - mark.Minimun;
        double deltaRight = mark.Maximum - mark.Value;
        double deltaSum = deltaLeft + deltaRight;
        double percent = deltaLeft / deltaSum;
        currentAverage = (currentAverage * i + percent) / (i + 1);
    }

    Console.WriteLine(currentAverage * 20);

### Thinking

It's important to let the candidate think openly about the solution. There are many issues to handle: the min/max context, the negative values...

Be vigilant over:

* using doubles instead of ints
* showing a nice value (Math.Round)

### Execution

The candidate shall build a mathematical formula before jumping into code. Maybe asking a few extra questions.

A TDD approach would give a bonus point. The code shall be written in a domain class for clarity.

