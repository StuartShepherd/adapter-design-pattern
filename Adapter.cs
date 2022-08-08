﻿namespace AdapterDesignPattern;

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee) =>
        _adaptee = adaptee;

    public string DoRequest() =>
        $"Do '{_adaptee.DoAdapteeRequest()}'";
}
