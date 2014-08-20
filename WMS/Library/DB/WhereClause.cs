using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;


namespace WMS
{
    /// <summary>
    /// Summary description for WhereClause
    /// </summary>
    ///    
    public enum Operation
    {
        EQUAL,
        GREATER_THAN,
        GREATER_OR_EQUAL,
        LESS,
        LESS_OR_EQUAL
    }

    public class valueObject
    {
        internal object inValue;
        internal Operation operation;
        public string getOperationString()
        {
            switch (operation)
            {
                case Operation.EQUAL:
                    return "=";
                case Operation.GREATER_THAN:
                    return ">";
                case Operation.GREATER_OR_EQUAL:
                    return ">=";
                case Operation.LESS:
                    return "<";
                case Operation.LESS_OR_EQUAL:
                    return "<=";
                default:
                    return "=";
            }

        }
    }
    public class WhereClause : IDictionary<String, valueObject>
    {


        Dictionary<String, valueObject> whereCollection = new Dictionary<string, valueObject>();

        public void Add(string key, valueObject value)
        {
            Add(key, value.inValue, value.operation);
        }

        public void Add(string key, object value)
        {
            Add(key, value, Operation.EQUAL);
        }


        public void Add(string key, object value, Operation op = Operation.EQUAL)
        {

            whereCollection.Add(key, new valueObject() { inValue = value, operation = op });
        }

        public bool ContainsKey(string key)
        {
            return whereCollection.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { return whereCollection.Keys; }
        }

        public bool Remove(string key)
        {
            return whereCollection.Remove(key);
        }

        public bool TryGetValue(string key, out valueObject value)
        {

            return whereCollection.TryGetValue(key, out value);

        }

        public ICollection<valueObject> Values
        {
            get { return whereCollection.Values; }

        }

        public valueObject this[string key]
        {
            get
            {
                return whereCollection[key];
            }
            set
            {
                whereCollection[key] = value;
            }
        }

        public void Add(KeyValuePair<string, valueObject> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            whereCollection.Clear();
        }

        public bool Contains(KeyValuePair<string, valueObject> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, valueObject>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return whereCollection.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(KeyValuePair<string, valueObject> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, valueObject>> GetEnumerator()
        {

            return whereCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return whereCollection.GetEnumerator();
        }


    }
}