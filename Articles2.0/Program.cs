﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        public class Article
        {
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public void Edit(string newContent)
            {
                this.Content = newContent;
            }

            public void ChangeAutrhor(string newAuthor)
            {
                this.Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ");

                Article article = new Article
                {
                    Title = articleData[0],
                    Content = articleData[1],
                    Author = articleData[2]
                };

                articles.Add(article);
            }

            string sortingCriteria = Console.ReadLine();
            List<Article> sorted = new List<Article>();
            if (sortingCriteria=="title")
            {
               sorted = articles.OrderBy(x => x.Title).ToList();
            }
            else if (sortingCriteria=="content")
            {
                sorted = articles.OrderBy(x => x.Content).ToList();
            }
            else
            {
               sorted = articles.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join("\n", sorted));
        }
    }
}