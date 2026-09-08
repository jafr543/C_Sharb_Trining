using System;
using System.Collections;
using System.Collections.Generic;


namespace SimpleDictionaryDemo
{
    public class TreeNode<T>
    {
       public T Value { get; set; }

       public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
    }

    public class CompanyTree<T>
    {
        public TreeNode<T> Root { get; set; }

        public CompanyTree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CompanyTree<string> Company = new CompanyTree<string>("CEO");
            TreeNode<string> finance = new TreeNode<string>("CFE");
            TreeNode<string> tech = new TreeNode<string>("CHE");
            TreeNode<string> marketing = new TreeNode<string>("CIE");

            Company.Root.AddChild(finance);
            Company.Root.AddChild(tech);
            Company.Root.AddChild(marketing);

            finance.AddChild(new TreeNode<string>("Accountant"));
            tech.AddChild(new TreeNode<string>("Developer"));
            tech.AddChild(new TreeNode<string>("UX Designer"));
            marketing.AddChild(new TreeNode<string>("Social Media Manager"));


            PrintTree(Company.Root);
            Console.ReadKey();

        }

        public static void PrintTree<T>(TreeNode<T> node, string indent = "")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child , indent + "  ");
            }
        }
    }
}
