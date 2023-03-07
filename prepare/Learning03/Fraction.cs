using System;
// ASK ABOUT GETTERS AND SETTERS

// The purpose of the Fraction class is to hold information about a fraction.

public class Fraction{
    private int _topNum;
    private int _botNum;

    //Constructors
    public Fraction(){
        _topNum = 1;
        _botNum = 1;
    }
    public Fraction(int wholeNum){
        _topNum = wholeNum;
        _botNum = 1;
    }
    public Fraction(int top, int bottom){
        _topNum = top;
        _botNum = bottom;
    }

    // // Getters and Setters 
    // public int GetTopNumber(){
    //     return _topNum;
    // }
    // public int GetBotNumber(){
    //     return _botNum;
    // }
    // public void SetTopNumber(int topNum){
    //     _topNum = topNum;
    // }
    // public void SetBotNumber(int botNum){
    //     _botNum = botNum;
    // }

    // Methods
    public string GetFractionView(){
        string fraction = $"{_topNum}/{_botNum}";
        return fraction;
    }
    public double GetDecimalView(){
        return (double)_topNum/(double)_botNum;
    }
}