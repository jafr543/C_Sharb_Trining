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

        public TreeNode<T> Find(T value)
        {
            if (EqualityComparer<T>.Default.Equals(Value, value))
                return this;

            foreach(var child in Children)
            {
                var Found = child.Find(value);
                if(Found != null)
                    return Found;
            }

            return null;
        }
    }

    public class CompanyTree<T>
    {
        public TreeNode<T> Root { get; set; }

        public CompanyTree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }

        public void PrintTree()
        {
            PrintTree(Root);
        }

        public static void PrintTree<T>(TreeNode<T> node, string indent = "")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }

        public TreeNode<T> Find(T Value)
        {
           return Root?.Find(Value);
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


            Company.PrintTree();

            Console.WriteLine("\n\nTry to Find Developer:\n");

            if (Company.Find("Developer") != null)
                Console.WriteLine("Developer Found :-)");
            else
                Console.WriteLine("Developer Not Found :-(");


            Console.WriteLine("\n\nTry to Find DBA:\n");

            if (Company.Find("DBA") != null)
                Console.WriteLine("DBA Found :-)");
            else
                Console.WriteLine("DBA Not Found :-(");

            Console.ReadKey();

        }

        
    }
}
