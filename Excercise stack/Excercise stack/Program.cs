using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercise_stack
{
    public class Post
    {
        private int _id;
        private string _name;
        private string _description;
        private DateTime _creationTime;
        private int _numberOfVotes;

        /// <summary>
        ///   creates a new entry of type post.
        ///
        /// </summary>
        /// <pararm name="id">
        /// Param: (int) post ID
        /// </pararm>
        /// <pararm name="name">
        ///   Param: (string) post title</pararm>
        /// <pararm name="description">
        ///   Param: (string) post content</pararm>
        /// <pararm name="creationTime">
        ///   Param: (DateTime) creationTime
        /// </pararm>
        /// <pararm name="numberOfVotes">
        ///   Param: (int) the number of votes
        /// </pararm>
        public Post(
            int id, string name, string description,
            DateTime creationTime, int numberOfVotes)
        {
            _id = id;
            _name = name;
            _description = description;
            _creationTime = creationTime;
            _numberOfVotes = numberOfVotes;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime CreationTime
        {
            get { return _creationTime; }
            set { _creationTime = value; }
        }

        public int NumberOfVotes
        {
            get { return _numberOfVotes; }
            set { _numberOfVotes = value; }
        }
    }


    public class ManagePosts
    {
        /* Class features:
             * Create a post
             * Edit a post
             * Delete a post
             * Upvote/Downvote a post
             * Fetch all posts
        */

        List<Post> posts = new List<Post>();

        /// <summary>
        ///   takes a post title and post description as
        ///   input parameters and save the posts to the
        ///   custom posts list.
        ///
        /// </summary>
        /// <pararm name="title">
        ///   Param: (string) post title
        /// </pararm>
        /// <pararm name="description">
        ///   Param: (string) post description
        /// </pararm>

        // TODO: return a boolean value when the post is
        // created.
        public void CreatePost(string title,
            string description)
        {
            // To increment the post ID.
            var postID = posts.Count + 1;
            // To store post creation time.
            var currentDate = DateTime.Now;
            // Post always starts with zero votes
            posts.Add(
                new Post(postID, title,
                    description, currentDate, 0)
            );
        }

        /// <summary>
        ///   edit an existing post.
        ///
        /// </summary>
        /// <pararm name="postID">
        ///   (int) the post ID
        /// </pararm>
        /// <pararm name="title">
        ///   (string) new post title
        /// </pararm>
        /// <pararm name="description">
        ///   (string) new post description
        /// </pararm>
        /// <return>
        ///   (bool) Returns true if the post has been
        ///   edited, otherwise returns false.
        /// </return>
        public bool EditPost(int postID, string title, string description)
        {
            var postEdited = false;
            var currentDate = DateTime.Now;
            var listEntryID = postID - 1;

            if (CheckIfPostExists(postID))
            {
                // we extract the number of votes for the
                // current post before deleting it.
                var currentPostVotes = this.posts[listEntryID].NumberOfVotes;
                // we remove the current post before
                // inserting the new post at the same
                // index.
                this.posts.RemoveAt(listEntryID);

                this.posts.Insert(
                    listEntryID,
                    new Post(postID, title, description,
                        currentDate, currentPostVotes)
                );

                postEdited = true;
                return postEdited;
            }
            else
            {
                Console.WriteLine("Post ID not found.");
                return postEdited;
            }
        }

        /// <summary>
        ///   delete a post.
        ///
        /// </summary>
        /// <pararm name="postID"> (int) the post ID</pararm>
        /// <return>
        /// (bool) Returns true if the post has been removed, otherwise returns false.
        /// </return>
        public bool DeletePost(int postID)
        {
            var postDeleted = false;
            var listEntryID = postID - 1;

            if (CheckIfPostExists(postID))
            {
                // we remove the current post before insterting the new post
                // at the same index.
                // Notice that the listEntryID start the count at 0, postID
                // is listEntryID + 1
                this.posts.RemoveAt(listEntryID);

                postDeleted = true;
                return postDeleted;
            }
            else
                return postDeleted;
        }

        /// <summary>
        ///   upvote or downvote a post.
        ///
        /// </summary>
        /// <pararm name="postID"> (int) the post ID</pararm>
        /// <pararm name="vote"> (string) action</pararm>
        /// <return> (bool) returns true if the action succeeded, false otherwise</return>
        public bool SetPostVote(int postID, string vote)
        {
            var voteSet = false;
            var listEntryID = postID - 1;

            if (CheckIfPostExists(postID))
            {
                // We extract the current vote
                var currentPostVotes = this.posts[listEntryID].NumberOfVotes;
                switch (vote)
                {
                    case ("up"):
                        currentPostVotes += 1;
                        voteSet = true;
                        break;

                    case ("down"):
                        // Cannot downvote a post if it is already at 0;
                        if (currentPostVotes > 0)
                            currentPostVotes -= 1;
                        voteSet = true;
                        break;
                    default:
                        Console.WriteLine("  Not a valid action. Try again");
                        break;
                }
                if (voteSet)
                    this.posts[listEntryID].NumberOfVotes = currentPostVotes;
            }
            else
                Console.WriteLine("Post ID not found, please try again");

            return voteSet;
        }

        /// <summary>
        ///   used to look up a post before performing any action
        ///
        /// </summary>
        /// <pararm name="postID"> Param: (int) post ID</pararm>
        /// <return> (bool) Return true if post exists. False if not</return>
        public bool CheckIfPostExists(int postID)
        {
            bool postExists = true;

            if (this.posts.Count() < postID)
                postExists = false;
            else if (postID == 0)
                postExists = false;

            return postExists;
        }

        /// <summary>
        ///   fetch all available posts.
        ///
        /// </summary>
        /// <pararm name="Posts">Param: (list) posts object</pararm>
        public void FetchPosts()
        {
            Console.WriteLine("Available posts:");
            Console.WriteLine("");

            foreach (var post in this.posts)
            {
                Console.WriteLine("+ [{0}] {1} -- Content: {2} -- Creation Date: {3} -- Votes: {4}",
                    post.ID,
                    post.Name,
                    post.Description,
                    post.CreationTime,
                    post.NumberOfVotes
                );
            }
        }
    }

    class Program
    {
        /// <summary>
        ///   Used to determine the user actions and call the necessary
        ///   methods of the 'ManagePosts' class.
        ///
        /// </summary>
        static public void GetUserChoice()
        {
            var userPost = new ManagePosts();
            bool done = false;
            var postID = 0;
            var postTitle = "";
            var postDescription = "";

            Console.WriteLine("This program allows you to manage your posts.");

            while (!done)
            {
                Console.WriteLine(@"
- [c]reate a post.
- [e]dit a post.
- [de]lete a post.
- [li]st all posts.
- [up]pvote or downvote a post.
- [ex]it the program.
");
                System.Console.Write("Select an option from the menu: ");
                var userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    // Create a post
                    case ("c"):
                        Console.Clear();

                        Console.Write("* Enter a post title: ");
                        postTitle = Console.ReadLine();

                        Console.Write("* Enter a post description: ");
                        postDescription = Console.ReadLine();

                        // TODO: Convert to an if/else based on the return
                        // value of the function
                        userPost.CreatePost(postTitle, postDescription);

                        Console.Clear();
                        userPost.FetchPosts();
                        Console.WriteLine("  Post created!");
                        break;

                    // Edit a post
                    case ("e"):
                        Console.Clear();
                        userPost.FetchPosts();
                        Console.Write("* Enter the ID of the post to edit: ");
                        userInput = Console.ReadLine();

                        try
                        {
                            // We will bump to an int32 when this app becomes famous enough ;)
                            postID = Convert.ToInt16(userInput);

                            if (!userPost.CheckIfPostExists(postID))
                                Console.WriteLine("  Enter a valid ID.");
                            else
                            {
                                Console.Write("* Enter a new title: ");
                                postTitle = Console.ReadLine();

                                Console.Write("* Enter a new description: ");
                                postDescription = Console.ReadLine();

                                if (userPost.EditPost(postID, postTitle, postDescription))
                                    Console.Clear();
                                userPost.FetchPosts();
                                Console.WriteLine("  Post edited!");
                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Not a valid number");
                            userPost.FetchPosts();
                        }

                        break;

                    // Delete a post
                    case ("de"):
                        Console.Clear();
                        userPost.FetchPosts();

                        Console.Write("* Enter the ID of the post to delete: ");
                        // We will bump to an int32 when this app becomes famous enough ;)
                        userInput = Console.ReadLine();
                        try
                        {
                            // We will bump to an int32 when this app becomes famous enough ;)
                            postID = Convert.ToInt16(userInput);

                            if (!userPost.CheckIfPostExists(postID))
                                Console.WriteLine("  Enter a valid ID.");
                            else
                            {
                                Console.Clear();
                                if (userPost.DeletePost(postID))
                                {
                                    Console.Clear();
                                    userPost.FetchPosts();
                                    Console.WriteLine("  Post deleted!");
                                }
                                else
                                {
                                    Console.Clear();
                                    userPost.FetchPosts();
                                    Console.WriteLine("  Post not found, please try again");
                                }
                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Not a valid number");
                            userPost.FetchPosts();
                        }

                        break;

                    // List posts
                    case ("li"):
                        Console.Clear();
                        userPost.FetchPosts();
                        break;

                    // Upvote or downvote
                    case ("up"):
                        Console.Clear();
                        userPost.FetchPosts();
                        Console.Write("* Enter the ID of the post to upvote or downvote: ");
                        userInput = Console.ReadLine();

                        try
                        {
                            // We will bump to an int32 when this app becomes famous enough ;)
                            postID = Convert.ToInt16(userInput);

                            if (!userPost.CheckIfPostExists(postID))
                                Console.WriteLine("  Enter a valid ID.");
                            else
                            {
                                Console.Write("* (up)vote or (down)vote this post: ");
                                var postAction = Console.ReadLine();

                                if (userPost.SetPostVote(postID, postAction))
                                {
                                    Console.Clear();
                                    userPost.FetchPosts();
                                    Console.WriteLine("  Vote added to the post!");
                                }
                                else
                                {
                                    Console.Clear();
                                    userPost.FetchPosts();
                                    Console.WriteLine("  Enter a valid action.");
                                }
                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Not a valid number");
                            userPost.FetchPosts();
                        }

                        break;

                    // Exit the program
                    case ("ex"):
                        done = true;
                        break;

                    default:
                        Console.Clear();
                        userPost.FetchPosts();
                        Console.WriteLine("Unknown action. Please try again");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            GetUserChoice();
        }


    }
}
