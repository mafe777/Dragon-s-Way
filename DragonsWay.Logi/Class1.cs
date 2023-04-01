namespace DragonsWay.Logi
{
    public class DragonWay
    {
        private char[,] _way;

        public DragonWay(int n,string way)
        {
            Way = way;
            N = n;
            _way = new char[N,N*2];
            Game();
        }
        public int N { get; }
        public string Way { get; }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N ; i++)
            {
                for (int j = 0; j < N * 2 - 1; j++)
                {
                    output += $"{_way[i, j]}";
                }
                output += "\n";
            }
            return output;
        }


        private void FillBorders()
        {
            for (int i = 0; i < N*2 ; i++)
            {
                _way[0, i] = '█';
            }
            for (int i = 0; i < N*2  - 2; i++)
            {
                _way[1, i] = ' ';
            }

            _way[1, N * 2 - 2] = '█';
            for (int i = 2; i < N - 1; i++)
            {
                _way[i, 0] = '█';
                for (int j = 1; j < N*2; j++)
                {
                    _way[i, j] = ' ';
                }
                _way[i, N * 2 - 2] = '█';
            }
            _way[N - 2, 0] = '█';
            for (int i = 1; i < N*2; i++)
            {
                _way[N - 2, i] = ' ';
            }

            for (int i = 0; i < N*2-1; i++)
            {
                _way[N - 1, i] = '█';
            }
        }

        private void FindWayOut()//"→→→↓↓↓→→→↓↓↓→→→→→→→→→↓→→→→→→"
        {
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N * 2; j++)
                {
                    if (Way == "→") 
                    {
                        _way[i, j] = '→';
                    }
                }

            }
        }

        private void Game()
        {
            FillBorders();
            FindWayOut();
        }

    }
}


