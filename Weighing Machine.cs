//https://exercism.org/tracks/csharp/exercises/weighing-machine/solutions/schraegstrich
using System;

class WeighingMachine
{
    private double weight;

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
    public int Precision {get ;}
    public double TareAdjustment{get; set;} = 5.0;
    public double Weight
    {
        get{return weight;}
        set{
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            return $"{Math.Round(Weight - TareAdjustment, Precision).ToString($"F{Precision}")} kg";
        }
        
    }
    
    
}


/*class WeighingMachine
{
    private double _weight;

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    public int Precision { get; }

    public double TareAdjustment { get; set; } = 5.0;

    public double Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            return $"{Math.Round(Weight - TareAdjustment, Precision).ToString($"F{Precision}")} kg";
        }
    } 
}*/