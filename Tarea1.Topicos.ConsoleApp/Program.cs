﻿using System;

namespace Tarea1.Topicos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Colsultas();
        }

        private static void Colsultas()
        {
            var llamado = new LogicaPrincipal();
            llamado.GenerarConsultas();
        }
    }
}
