﻿using System.Collections.Generic;
using System;

namespace ocp
{
  /*
  Open Close Principle states that a type is open for extension but closed for modification.
  We do not want to modify something that already works and is in production already, but nevertheless
  we need to add extensibility.
  */

  public enum Color
  {
    Red,
    Green,
    Blue
  }

  public enum Size
  {
    Small,
    Medium,
    Large,
    Yuge
  }

  public class Product
  {
    public string Name;
    public Color Color;
    public Size Size;
    public Product(string name, Color color, Size size)
    {
      Name = name;
      Color = color;
      Size = size;
    }
  }

  public class ProductFilter
  {
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
      foreach (var p in products)
      {
        if (p.Color == color)
        {
          yield return p;
        }
      }
    }
  }

  public interface ISpecification<T>
  {
    bool IsSatisfied(T item);
  }

  public interface IFilter<T>
  {
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
  }

  public class Filter : IFilter<Product>
  {
    IEnumerable<Product> IFilter<Product>.Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
      foreach (var i in items)
      {
          if(spec.IsSatisfied(i))
          {
              yield return i;
          }
      }
    }
  }

  public class ColorSpecification : ISpecification<Product>
  {
    private Color color;
    public ColorSpecification(Color color)
    {
        this.color = color;
    }
    public bool IsSatisfied(Product p)
    {
      return p.Color == color;
    }
  }

  public class AndSpecification<T> : ISpecification<T>
  {
    private readonly ISpecification<T> first, second;
    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        this.first = first;
        this.second = second;
    }
    public bool IsSatisfied(T t)
    {
      return first.IsSatisfied(t) && second.IsSatisfied(t);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var apple = new Product("Apple", Color.Green, Size.Small);
      var tree = new Product("Tree", Color.Green, Size.Large);
      var house = new Product("House", Color.Blue, Size.Large);

      Product[] products = {apple, tree, house};

      var pf = new ProductFilter();
      foreach(var p in pf.FilterByColor(products, Color.Green))
      {
        Console.WriteLine($"{p.Name}");
      }
    }
  }
}