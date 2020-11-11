using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.DecisionTreeClassifier
{
    class Node<T> where T : DatasetRow
    {
        private Query<T> query;
        private Node<T> yesNode;
        private Node<T> noNode;

        private Dictionary<string, Int32> labelCount;

        public Node(Query<T> query, Node<T> yes, Node<T> no )
        {
            this.query = query;
            this.yesNode = yes;
            this.noNode = no;
        }

        public Node(Dictionary<String, Int32> labelCount)
        {
            this.labelCount = labelCount;
        }

        public Query<T> GetQuery()
        {
            return this.query;
        }

        public Node<T> GetTrueNode()
        {
            return this.yesNode;
        }
        public Node<T> GetFalseNode()
        {
            return this.noNode;
        }

        public Dictionary<String, Int32> GetPredictions()
        {
            return this.labelCount;
        }
    }
}
