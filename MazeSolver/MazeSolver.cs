using System;

namespace Maze
{
    /// <summary>
    /// Class for finding exit out of a maze. It is assumed that the maze always has one entrance and only one exit (if any) and they are different.
    /// </summary>
    public class MazeSolver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MazeSolver"/> class.
        /// </summary>
        /// <param name="maze">Presents a maze as two-dimensional zero-based matrix.</param>
        /// <param name="rowStart">The zero-based index of row of the start.</param>
        /// <param name="columnStart">The zero-based index of column of the start.</param>
        /// <exception cref="ArgumentNullException">Thrown if passed maze is null.</exception>
        /// <exception cref="ArgumentException">Thrown if passed maze is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if rowStart or columnStart are not in mazeModel:
        /// less than zero or more then number of elements in the dimension.</exception>
        public MazeSolver(bool[,] maze, int rowStart, int columnStart) => throw new NotImplementedException();

        /// <summary>
        /// Starts an algorithm for finding shortest path.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the path does not exist.</exception>
        public void PassMaze() => throw new NotImplementedException();

        /// <summary>
        /// Gets the shortest path as a one-dimensional array of the pairs (row, column).
        /// </summary>
        /// <returns>
        /// The one-dimensional array of the pairs (row, column).
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if path finding algorithm wasn't started.
        /// </exception>
        public (int row, int column)[] GetPath() => throw new NotImplementedException();

        /// <summary>
        /// Gets the pairs (row, column) - indexes of row and columns of exit from maze.
        /// </summary>
        /// <returns>
        /// The indexes of row and columns of exit from maze.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if path finding algorithm wasn't started.
        /// </exception>
        public (int row, int column) GetExit() => throw new NotImplementedException();
    }
}
