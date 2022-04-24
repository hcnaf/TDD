using System.Collections;

namespace GameOfLife
{
    public class GameOfLife
    {
        private BitArray[] _playGround;
        public GameOfLife(int rows, int columns, params (int row, int column)[] lifePositions)
        {
            if (rows <= 0)
                throw new ArgumentOutOfRangeException(nameof(rows));
            if (columns <= 0)
                throw new ArgumentOutOfRangeException(nameof(columns));
            if (lifePositions is null)
                throw new ArgumentNullException(nameof(lifePositions));
            if (lifePositions.Any(x => x.row < 0 || x.row >= rows || x.column < 0 || x.column >= columns))
                throw new ArgumentOutOfRangeException(nameof(lifePositions));

            _playGround = new BitArray[rows];
            for (int i = 0; i < rows; i++)
                _playGround[i] = new BitArray(columns);

            foreach (var lifePosition in lifePositions)
                _playGround[lifePosition.row][lifePosition.column] = true;
        }

        public void Next()
        {
            var fieldsToReverse = new List<(int row, int column)>();
            for (int row = 0; row < _playGround.Length; ++row)
                for (int column = 0; column < _playGround[0].Length; ++column)
                {
                    switch(GetNeighborsCount(row, column))
                    {
                        case 2:
                            continue;
                        case 3:
                            if (!_playGround[row][column]) fieldsToReverse.Add((row, column));
                            continue;
                        default:
                            if (_playGround[row][column]) fieldsToReverse.Add((row, column));
                            continue;
                    }
                }

            foreach(var fieldToReverse in fieldsToReverse)
                _playGround[fieldToReverse.row][fieldToReverse.column] = !_playGround[fieldToReverse.row][fieldToReverse.column];
        }

        public T[][] Render<T>(T lifeCell, T deadCell) =>
            _playGround.Select(row =>
            {
                var res = new T[row.Length];
                for (int i = 0; i < row.Length; i++)
                    res[i] = row[i] ? lifeCell : deadCell;

                return res;
            }).ToArray();

        private int GetNeighborsCount(int row, int column)
        {
            var res = 0;

            if (row > 0 && column > 0 && _playGround[row - 1][column - 1])
                res++;
            if (row > 0 && _playGround[row - 1][column])
                res++;
            if (row > 0 && column < _playGround[0].Length - 1 && _playGround[row - 1][column + 1])
                res++;
            if (column < _playGround[0].Length - 1 && _playGround[row][column + 1])
                res++;
            if (row < _playGround.Length - 1 && column < _playGround[0].Length - 1 && _playGround[row + 1][column + 1])
                res++;
            if (row < _playGround.Length - 1 && _playGround[row + 1][column])
                res++;
            if (row < _playGround.Length - 1 && column > 0 && _playGround[row + 1][column - 1])
                res++;
            if (column > 0 && _playGround[row][column - 1])
                res++;

            return res;
        }
    }
}