using System;
using System.Collections.Generic;

public class Sewing: Project{
    private string _patternName;
    private double _totalNotionCost;
    private double _totalFabricCost;
    private int _totalSteps;
    private int _stepsCompleted;
    //                 name, price
    private Dictionary<string, double> _notions;
    //                 name, price
    private Dictionary<string, double> _fabric;

    public Sewing(){}

    public Sewing(string name, string description) : base(name, description){}

    public Sewing(string description, DateTime startDate, DateTime endDate) : base(description, startDate, endDate){}

    public Sewing(string name, string description, DateTime startDate, DateTime endDate) : base(name, description, startDate, endDate){}
}