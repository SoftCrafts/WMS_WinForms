using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;



/// <summary>
/// Summary description for WhereClause
/// </summary>
/// 
namespace WMS
{

    public class WhereClause : IDictionary<String, Object>
    {
        Dictionary<String, Object> whereCollection = new Dictionary<string, object>();
        public WhereClause()
        {

        }




        public void Add(string key, object value)
        {
            whereCollection.Add(key, value);
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

        public bool TryGetValue(string key, out object value)
        {
            return whereCollection.TryGetValue(key, out value);
        }

        public ICollection<object> Values
        {
            get { return whereCollection.Values; }
        }

        public object this[string key]
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

        public void Add(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            whereCollection.Clear();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
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

        public bool Remove(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return whereCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return whereCollection.GetEnumerator();
        }
    }
}