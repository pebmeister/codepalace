﻿namespace WpfApplication1
{
    public interface ISolver
    {
        /// <summary>
        /// Solve the cube
        /// </summary>
        /// <returns>Solve sequence</returns>
        string Solve();

        /// <summary>
        /// Cube to solve
        /// </summary>
        ICube Cube { get; set; }
    }
}