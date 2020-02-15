using System;
using TechTalk.SpecFlow;
using Shouldly;

[Binding]
public class Adder
{
    private int a;
    private int b;

    [When(@"passed (.*) and (.*)")]
    public void Add(int a, int b)
    {
        Console.WriteLine($"abc {a} {b}");
        this.a = a;
        this.b = b;
    }

    [Then(@"answer is (.*)")]
    public void CheckAddResult(int a)
    {
        Console.WriteLine($"abc {this.a} {this.b}");
        (this.a + this.b).ShouldBe(a);
    }
}