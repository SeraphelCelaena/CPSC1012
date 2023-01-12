using System;

class Artist
{
    // Fields or Data Members
    string firstName;
    string lastName;

    // Accessor Methods + Mutator Methods
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public Artist(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Artist Name = {FirstName}, {lastName}";
    }
}

class CD
{
    string title;
    int tracks;
    double price;
    Artist artist;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int Tracks
    {
        get { return tracks; }
        set { tracks = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Artist Artist
    {
        get { return artist; }
        set { artist = value; }
    }

    public CD(string title, int tracks, double price, Artist artist)
    {
        Title = title;
        Tracks = tracks;
        Price = price;
        Artist = artist;
    }

    public void CDinfo()
    {
        Console.WriteLine($"Title = {Title}");
        Console.WriteLine($"Number of Tracks = {Tracks}");
        Console.WriteLine($"Price = {Price}");
        Console.WriteLine(Artist.ToString());
    }
}

class Program
{
    public static void Main(string[] args)
    {
        CD c = new CD("CDEEZNUTS", 69, 420.69, new Artist("Cookie", "Doge"));

        c.CDinfo();
    }
}