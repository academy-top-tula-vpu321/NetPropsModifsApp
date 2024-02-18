
User user = new User()
{
    Name = "Bobby"
};

user.Name = "Bob";
user.Age = 26;

Console.WriteLine(user.Name);

User tom = new User("Tommy", 32) { Name = "Tommy" };
//tom.Type = "admin"; // ERROR
//Console.WriteLine(tom.Type);



class User
{
    string type;
    int age;

    public User()
    {
        //this.Name = name;
        //this.age = age;
        //this.type = type;
    }

    public User(string name, int age)
    {
        this.Name = name;
        this.age = age;
        //this.type = type;
    }

    public string Type
    {
        get => type;
        init
        {
            type = value;
        }
    }

    //public string Type
    //{
    //    get => type;
    //}



    public required string Name { set; get; } = "Anonim";
    //{
    //    get => name;
    //    set => name = value;
    //}

    public int Age
    {
        get => age;
        set 
        { 
            if(age > 0 && age < 100)
                age = value; 
        }
    }


    public void SetName(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return this.Name;
    }

    public void SetAge(int age)
    {
        if(age > 0 && age < 100)
            this.age = age;
    }
    public int GetAge()
    {
        return this.age;
    }

}


class Employee
{
    public string Name { set; get; }
    public int Age { set; get; }
}