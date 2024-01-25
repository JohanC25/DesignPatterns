using System;
using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Models.Builder
{
    public class CarBuilder
    {
        private Vehicle _vehicle;

        private string _color = "Red";
        private string _brand = "Ford";
        private string _model = "Mustang";
        private int _year = DateTime.Now.Year;

        public CarBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        public CarBuilder SetBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _brand = model;
            return this;
        }
        
        public CarBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }

        public Vehicle Build()
        {
            return new Car(_color, _brand, _model, _year);
        }
    }
}
