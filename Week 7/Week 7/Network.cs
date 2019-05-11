using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    class Network
    {
        int[,] matrix;
        Random rand;
        int NRvertices;
        List<int> ConnectedNode;
        public Network(Random randseed, int nrofvertices)
        {
            matrix = new int[nrofvertices,nrofvertices];
            NRvertices = nrofvertices;
            rand = randseed;
            for (int i = 0; i < nrofvertices; i++)
            {
                for (int j = 0; j < nrofvertices; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        public void AddEdges(double prob)
        {
            for (int i = 0; i < NRvertices - 1; i++)
            {
                for (int j = i+1; j < NRvertices; j++)
                {
                    if (rand.NextDouble() < prob)
                    {
                        matrix[i, j] = 1;
                        matrix[j, i] = 1;
                    }
                }
            }
        }
        public string PrintGraph()
        {
            string str = "";
            for (int i = 0; i < NRvertices - 1; i++)
            {
                for (int j = i + 1; j < NRvertices; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        str += $"\n{i} -- {j}";
                    }
                    else
                    {
                        str += $"\n{i} {j}";
                    }
                }
            }
            return str;
        }
        public bool IsConnected()
        {
            ConnectedNode = new List<int>();
            ConnectedNode.Add(0);
            CheckConnected(0);        
            for (int i = 0; i < NRvertices; i++)
            {
                if (!ConnectedNode.Contains(i))
                {
                  return false;
                }
            }
            return true;
        }
        public void CheckConnected(int row)
        {
            int j = row;
            for (int i = 0; i < NRvertices; i++)
            {
                if (matrix[j,i] == 1)
                {
                    ConnectedNode.Add(i);
                    matrix[j, i] = 2;
                    matrix[i, j] = 2;
                    CheckConnected(i);
                }  
            }
        }
    }
}
