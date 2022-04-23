using System;
using System.Collections.Generic;

#pragma warning disable CA1814
#pragma warning disable S2368

namespace Maze
{
    /// <summary>
    /// Class for finding exit out of a maze. It is assumed that the maze always has one entrance and only one exit (if any) and they are different.
    /// </summary>
    public class MazeSolver
    {
        private readonly bool[,] _maze;
        private readonly List<(int, int)> _moves = new List<(int, int)>();

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
        public MazeSolver(bool[,] maze, int rowStart, int columnStart)
        {
            if (maze is null)
                throw new ArgumentNullException(nameof(maze));

            if (maze.Length == 0)
                throw new ArgumentException("Maze is empty.");

            if (rowStart < 0 || rowStart >= Math.Sqrt(maze.Length))
                throw new ArgumentOutOfRangeException(nameof(rowStart));

            if (columnStart < 0 || columnStart >= Math.Sqrt(maze.Length))
                throw new ArgumentOutOfRangeException(nameof(columnStart));

            if (maze[rowStart, columnStart])
                throw new ArgumentException("Start position is in the wall.");

            _maze = (bool[,])maze.Clone();
            _moves.Add((rowStart, columnStart));
            _maze[rowStart, columnStart] = true;
        }

        /// <summary>
        /// Starts an algorithm for finding shortest path.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the path does not exist.</exception>
        public void PassMaze()
        {
            (int, int) firstStep = this.Directions(_moves[0].Item1, _moves[0].Item2)[0];
            _moves.Add(firstStep);
            _maze[firstStep.Item1, firstStep.Item2] = true;
            _moves.AddRange(this.GetMoves(firstStep.Item1, firstStep.Item2));
        }

        /// <summary>
        /// Gets the shortest path as a one-dimensional array of the pairs (row, column).
        /// </summary>
        /// <returns>
        /// The one-dimensional array of the pairs (row, column).
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if path finding algorithm wasn't started.
        /// </exception>
        public (int row, int column)[] GetPath()
        {
            if (_moves.Count == 1)
                throw new InvalidOperationException("Algorithm wasn't started. Please, use 'PassMaze()'.");

            return _moves.ToArray();
        }

        /// <summary>
        /// Gets the pairs (row, column) - indexes of row and columns of exit from maze.
        /// </summary>
        /// <returns>
        /// The indexes of row and columns of exit from maze.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if path finding algorithm wasn't started.
        /// </exception>
        public (int row, int column) GetExit()
        {
            if (_moves.Count == 1)
            {
                throw new InvalidOperationException("Algorithm wasn't started. Please, use 'PassMaze()'.");
            }

            return _moves[^1];
        }

        private List<(int, int)> GetMoves(int row, int column)
        {
            switch (row, column)
            {
                case (0, _):
                case (_, 0):
                case (_, _) when row == _maze.GetUpperBound(0) || column == (_maze.Length / (_maze.GetUpperBound(0) + 1) - 1):
                    return new List<(int, int)>();
            }

            if (this.Directions(row, column).Count == 0)
                throw new InvalidOperationException("Deadlock");

            List<(int, int)> supposedMoves = new List<(int, int)>();
            foreach ((int, int) direction in this.Directions(row, column))
            {
                List<(int, int)> movesInDirection = new List<(int, int)>();
                try
                {
                    _maze[direction.Item1, direction.Item2] = true;
                    movesInDirection.Add((direction.Item1, direction.Item2));
                    movesInDirection.AddRange(this.GetMoves(direction.Item1, direction.Item2));
                    _maze[direction.Item1, direction.Item2] = false;
                }
                catch (InvalidOperationException)
                {
                    _maze[direction.Item1, direction.Item2] = false;
                    continue;
                }

                if (supposedMoves.Count > movesInDirection.Count || supposedMoves.Count == 0)
                {
                    supposedMoves = movesInDirection;
                }
            }

            if (supposedMoves.Count == 0)
                throw new InvalidOperationException("There is no way");

            return supposedMoves;
        }

        private List<(int, int)> Directions(int row, int column)
        {
            var res = new List<(int, int)>();
            if (row > 0 && !_maze[row - 1, column])
                res.Add((row - 1, column));

            if (column > 0 && !_maze[row, column - 1])
                res.Add((row, column - 1));

            if (row < Math.Sqrt(_maze.Length) - 1 && !_maze[row + 1, column])
                res.Add((row + 1, column));

            if (column < Math.Sqrt(_maze.Length) - 1 && !_maze[row, column + 1])
                res.Add((row, column + 1));

            return res;
        }
    }
}
