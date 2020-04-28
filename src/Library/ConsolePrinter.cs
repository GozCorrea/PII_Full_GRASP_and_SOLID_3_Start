//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

// Experto ya que esta clase es la experta para imprimir por consola.
// Cumple el principio SRP ya que tiene una unica responsabilidad y es imprimir.

namespace Full_GRASP_And_SOLID.Library
{
    public class ConosolePrinter : IPrinter
    {
        public void Print (Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}

