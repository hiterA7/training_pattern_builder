﻿using System;

// Продукт
public class Car
{
    public string Type { get; set; }
    public string Engine { get; set; }
    public string Wheels { get; set; }
    public string Interior { get; set; }

    public override string ToString()
    {
        return $"Car Type: {Type}, Engine: {Engine}, Wheels: {Wheels}, Interior: {Interior}";
    }
}

// Строитель
public abstract class CarBuilder
{
    protected Car car = new Car();

    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildInterior();

    public Car GetResult()
    {
        return car;
    }
}

// Конкретный строитель для спортивного автомобиля
public class SportsCarBuilder : CarBuilder
{
    public override void BuildEngine()
    {
        car.Engine = "V8 Engine";
    }

    public override void BuildWheels()
    {
        car.Wheels = "Sport Wheels";
    }

    public override void BuildInterior()
    {
        car.Interior = "Leather Interior";
        car.Type = "Sports Car";
    }
}

// Директор
public class Director
{
    public void MakeSportsCar(CarBuilder builder)
    {
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildInterior();
    }
}

// Пример использования
class Program
{
    static void Main(string[] args)
    {
        CarBuilder carBuilder = new SportsCarBuilder();
        Director director = new Director();

        director.MakeSportsCar(carBuilder);
        Car car = carBuilder.GetResult();

        Console.WriteLine(car);
    }
}

