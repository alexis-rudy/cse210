using System;

public class Reference
{
    private string _reference = "John 14:15 If you love me, keep my commandments.";
    private string _multipleScriptureReference = "Romans 13:8-10 \n8 Owe no man any thing, but to love one another: for he that loveth another hath fulfilled the law." +
    " \n9 For this, Thou shalt not commit adultery, Thou shalt not kill, Thou shalt not steal, Thou shalt not bear false witness, Thou shalt not covet; and if there" +
    " any other commandment, it is briefly comprehended in this saying, namely, Thou shalt love thy neighbor as thyself. \n10 Love worketh no ill to his neighbor: therefore love is the fulfilling of the law.";

    public string giveReference(bool type){
        if (type)
        {
            return _multipleScriptureReference;
        }
        return _reference;
    }
}