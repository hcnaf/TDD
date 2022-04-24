using System.Collections;

namespace GameOfLife
{
    public class GameOfLife
    {
        private BitArray[] _playGround;
        public GameOfLife(int rows, int columns, params (int row, int column)[] lifePositions) => throw new NotImplementedException();

        public void Next() => throw new NotImplementedException();

        public T[][] Render<T>(T lifeCell, T deadCell) => throw new NotImplementedException();
    }
}