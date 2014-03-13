using System;

class CalculateAge
{
    private int _year;
    private int _month;
    private int _day;

    private DateTime _birthday { get; set; }
    private DateTime _now { get; set; }

    private const int EXCEPTION_FEBRUARY = 2;
    private const int EXCEPTION_FEB_DAYS = 29;

    private const int YEARS_AFTER = 10;

    private static CalculateAge self = new CalculateAge();

    static void Main(string[] args)
    {
        self.PromptUserBirthYear();
        self.PromptUserBirthMonth();
        self.PromptUserBirthDay();

        if (!self.checkConstraints())
        {
            throw new Exception("Constraint violation while trying to build the birthday stamp");
        }

        self.BuildBirthdayTimeStamp();
        self.BuildCurrentTimeStamp();

        Console.WriteLine("You are now " + self.CurrentAge() + " years old");
        Console.WriteLine("After " + YEARS_AFTER + " years, you will be " + self.AgeAfter() + " years old");
    }

    private void PromptUserBirthYear()
    {
        Console.WriteLine("Which year you were born?");
        this._year = Convert.ToInt32(Console.ReadLine());
    }

    private void PromptUserBirthMonth()
    {
        Console.WriteLine("Which month you were born?");
        this._month = Convert.ToInt32(Console.ReadLine());
    }

    private void PromptUserBirthDay()
    {
        Console.WriteLine("Which day you were born?");
        this._day = Convert.ToInt32(Console.ReadLine());
    }

    private Boolean checkConstraints()
    {
        if (this._day < 1 || this._day > 31)
        {
            return false;
        }

        if (this._month < 1 || this._month > 12)
        {
            return false;
        }

        if (this._year < 1 || this._year > DateTime.Now.Year)
        {
            return false;
        }

        if (this._month == EXCEPTION_FEBRUARY && this._day > EXCEPTION_FEB_DAYS)
        {
            return false;
        }
        return true;
    }

    private void BuildBirthdayTimeStamp()
    {
        this._birthday = new DateTime(this._year, this._month, this._day, 0, 00, 00);
    }

    private void BuildCurrentTimeStamp()
    {
        this._now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 00, 00);
    }

    private int CurrentAge()
    {
        return Convert.ToInt32(this._now.Year - this._birthday.Year);
    }

    private int AgeAfter()
    {
        int CurrentAge = this.CurrentAge();
        return CurrentAge + YEARS_AFTER;
    }


}

