using System;
using System.Collections.Generic;

namespace BaseVM.Mediator
{
    public static class Mediator
    {
        static IDictionary<string, List<Action<object>>> _dict = new Dictionary<string, List<Action<object>>>();

        static public void Register(string token, Action<object> callback)
        {
            if (!_dict.ContainsKey(token))
            {
                var list = new List<Action<object>>
                {
                    callback
                };
                _dict.Add(token, list);
            }
            else
            {
                bool found = false;
                foreach (var item in _dict[token])
                {
                    if (item.Method.ToString() == callback.Method.ToString())
                    {
                        found = true;
                    }
                    if (!found)
                    {
                        _dict[token].Add(callback);
                    }
                }
            }
        }
        static public void Unregister(string token, Action<object> callback)
        {
            if (_dict.ContainsKey(token))
            {
                _dict[token].Remove(callback);
            }
        }
        static public void NotifyCollegues(string token,params object[] args)
        {
            if (_dict.ContainsKey(token))
            {
                foreach (var item in _dict[token])
                {
                    item(args);
                }
            }
        }
    }
}
