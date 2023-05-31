using System;
using System.Collections.Generic;

namespace AssignmentCTraining
{
    internal class Program
    {
        static Dictionary<string, string> User = new Dictionary<string, string>();
        static Dictionary<string, string> Admin = new Dictionary<string, string>();
        static Dictionary<string, string> movies = new Dictionary<string, string>();
        static Dictionary<string, string> favorites = new Dictionary<string, string>();

        static bool isLoggedIn = false;
        static bool isAdmin = false;
        static bool isUser = false;

        static void Main(string[] args)
        {

            User.Add("rakhi", "rakhi123");
            Admin.Add("admin", "adminpass@1");
            Console.WriteLine("Welcome....to the Movie App!");

            string currentUser = "";

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Entered credentials are invalid. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();

                        if (Admin.ContainsKey(username) && Admin[username] == password)
                        {
                            isLoggedIn = true;
                            isAdmin = true;
                            currentUser = username;
                            Console.WriteLine("\nAdmin login successful!");
                        }
                        else if (User.ContainsKey(username) && User[username] == password)
                        {
                            isLoggedIn = true;
                            isUser = true;
                            currentUser = username;
                            Console.WriteLine("\nUser login successful!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid username or password. Please try again.");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Exiting.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (isLoggedIn)
                {
                    if (isAdmin)
                    {
                        AdminMenu();
                    }
                    else if (isUser)
                    {
                        UserMenu();
                    }
                }
            }
        }

        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu:");
                Console.WriteLine("1. Show movie list");
                Console.WriteLine("2. Add movie to collection");
                Console.WriteLine("3. Remove movie from collection");
                Console.WriteLine("4. Logout");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        foreach (KeyValuePair<string, string> i in movies)
                        {
                            Console.WriteLine(i.Key);
                        }
                        break;
                    case 2:
                        Console.Write("Enter the name of the movie to add: ");
                        string movie = Console.ReadLine();
                        Console.Write("Enter the description of the movie: ");
                        string description = Console.ReadLine();
                        movies.Add(movie, description);
                        Console.WriteLine($"Movie '{movie}' added to the collection.");
                        break;
                    case 3:
                        Console.WriteLine("Movies List");
                        foreach (KeyValuePair<string, string> i in movies)
                        {
                            Console.WriteLine(i.Key);
                        }

                        Console.Write("Enter the name of the movie to remove: ");
                        string movieToRemove = Console.ReadLine();
                        if (movies.ContainsKey(movieToRemove))
                        {
                            movies.Remove(movieToRemove);
                            Console.WriteLine($"Movie '{movieToRemove}' removed.");
                            RemoveMovieFromFavorites(movieToRemove);
                        }
                        else
                        {
                            Console.WriteLine($"Movie '{movieToRemove}' not found.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Logging out from admin account.");
                        isAdmin = false;
                        return;
                    default:
                        Console.WriteLine("Entered credentials are Invalid. Please try again.");
                        break;
                }
            }
        }

        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\nUser Menu:");
                Console.WriteLine("1. Show movie list");
                Console.WriteLine("2. Add movie to favorites");
                Console.WriteLine("3. Remove movie from favorites");
                Console.WriteLine("4. Logout");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        foreach (KeyValuePair<string, string> i in favorites)
                        {
                            Console.WriteLine(i.Key);
                        }
                        break;
                    case 2:
                        foreach (KeyValuePair<string, string> i in movies)
                        {
                            Console.WriteLine(i.Key);
                        }
                        Console.Write("Enter the name of the movie to add to favorites: ");
                        string movie = Console.ReadLine();
                        if (movies.ContainsKey(movie))
                        {
                            favorites.Add(movie, movies[movie]);
                            Console.WriteLine($"Movie '{movie}' added to favorites.");
                        }
                        else
                        {
                            Console.WriteLine($"Movie '{movie}' not found in the collection.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Favorites List");
                        foreach (KeyValuePair<string, string> i in favorites)
                        {
                            Console.WriteLine(i.Key);
                        }

                        Console.Write("Enter the name of the movie to remove from favorites: ");
                        string movieToRemove = Console.ReadLine();
                        if (favorites.ContainsKey(movieToRemove))
                        {
                            favorites.Remove(movieToRemove);
                            Console.WriteLine($"Movie '{movieToRemove}' removed from favorites.");
                        }
                        else
                        {
                            Console.WriteLine($"Movie '{movieToRemove}' not found in favorites.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Logging out from user account.");
                        isUser = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void RemoveMovieFromFavorites(string movieToRemove)
        {
            if (favorites.ContainsKey(movieToRemove))
            {
                favorites.Remove(movieToRemove);
                Console.WriteLine($"Movie '{movieToRemove}' removed.");
            }
        }

    }
}