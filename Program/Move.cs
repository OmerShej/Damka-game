namespace Program
{
    class Move
    {
        private Player m_CurrentPlayer;
        private bool m_HaveAnotherPieceToEat = false;
        private bool m_HaveQuit = false;
        private int m_FromCol;
        private int m_FromRow;
        private int m_ToCol;
        private int m_ToRow;
        private string m_LastMove;

        public eMoveType m_MoveType;

        public bool HaveQuit
        {
            get
            {
                return m_HaveQuit;
            }
            set
            {
                m_HaveQuit = value;
            }
        }

        public string LastMove
        {
            get
            {
                return m_LastMove;
            }
            set
            {
                m_LastMove = value;
            }
        }

        public bool HaveAnotherPieceToEat
        {
            get
            {
                return m_HaveAnotherPieceToEat;
            }
            set
            {
                m_HaveAnotherPieceToEat = value;
            }
        }

        public Move(Player i_CurrentPlayer)
        {
            m_CurrentPlayer = i_CurrentPlayer;
        }

        public eMoveType  MoveType
        {
            get
            {
                return m_MoveType;
            }
            set
            {
                m_MoveType = value;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }
            set
            {
                m_CurrentPlayer = value;
            }
        }

        public int FromCol
        {
            get
            {
                return m_FromCol;
            }
            set
            {
                m_FromCol = value;
            }
        }

        public int FromRow
        {
            get
            {
                return m_FromRow;
            }
            set
            {
                m_FromRow = value;
            }
        }

        public int ToCol
        {
            get
            {
                return m_ToCol;
            }
            set
            {
                m_ToCol = value;
            }
        }

        public int ToRow
        {
            get
            {
                return m_ToRow;
            }
            set
            {
                m_ToRow = value;
            }
        }
    }
}
