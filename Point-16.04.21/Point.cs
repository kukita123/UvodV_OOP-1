﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Да се състави програма, описваща клас за точка в равнината с полета координати на точката. 
 * Да се създадат нужните компоненти на класа - конструктори, свойства. 
 * Да се разработи метод за изчисляване разстоянието между две точки А и B по формулата: ...... 
 * Да се създаде масив от 10 (или n на брой) точки и да се намери най-малкото разстояние между кои да е две от тях.
 */
namespace Point_16._04._21
{
    class Point
    {
        #region 9aClass
        private double x;
        private double y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { set; get; }

        public double Y { set; get; }

        #endregion
    
        #region 9bClass
        //private double _x;
        //private double _y;

        //public Point(double x, double y)
        //{
        //    this._x = x;
        //    this._y = y;
        //}
        //public Point()
        //{
        //    this._x = 0;
        //    this._y = 0;
        //}

        //public double X
        //{
        //    get { return this._x; }
        //    set { this._x = value; }
        //}        

        //public double Y
        //{
        //    get { return this._y; }
        //    set { this._y = value; }
        //}
        #endregion
    }
}
