using NVP.API.Nodes;
using System;
using System.Linq;
using System.Collections.Generic;
using NVP_Manifest_Creator;
using System.Collections;

namespace Dictionary
{
    [NVP_Manifest(
            Text = "Создает пустой словарь",
            ViewType = "Default")]
    public class Dictionary_CreateEmpty : INode
    {
        public IDictionary<string, object> _dict = new Dictionary<string, object>();
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _dict = new Dictionary<string, object>();

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
            Text = "Создает словарь по исходным данным",
            ViewType = "Default")]
    [NodeInput("Список ключей", typeof(object))]
    [NodeInput("Список значений", typeof(object))]
    public class Dictionary_CreateFromData : INode
    {
        public IDictionary<string, object> _dict = new Dictionary<string, object>();
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _dict = new Dictionary<string, object>();

            IList keys = (IList)inputs[0].Value;
            IList values = (IList)inputs[1].Value;

            for (int data_counter = 0; data_counter < keys.Count; data_counter++)
            {
                string key = (string)keys[data_counter];
                object value = values[data_counter];

                if (key != null && !_dict.ContainsKey(key)) _dict.Add(key, value);
            }
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
            Text = "Удаляет в заданном словаре значения по ключам и возвращает измененный словарь",
            ViewType = "Modifier")]
    [NodeInput("Словарь", typeof(object))]
    [NodeInput("Список ключей", typeof(object))]
    public class Dictionary_RemoveKeys : INode
    {
        public IDictionary<string, object> _dict = new Dictionary<string, object>();
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _dict = new Dictionary<string, object>();

            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;
            IList keys = (IList)inputs[1].Value;

            foreach (string key in keys) 
            {
                if (_dict0.ContainsKey(key))
                {
                    _dict0.Remove(key);
                }
            }

            this._dict = _dict0;
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
            Text = "Задает одиночное значение по ключу и возвращает измененный словарь",
            ViewType = "Modifier")]
    [NodeInput("Словарь", typeof(object))]
    [NodeInput("Ключ", typeof(string))]
    [NodeInput("Значение", typeof(object))]
    public class Dictionary_SetValueAtKey : INode
    {
        public IDictionary<string, object> _dict = new Dictionary<string, object>();
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _dict = new Dictionary<string, object>();

            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;

            string key = (string)inputs[1].Value;
            object value = inputs[2].Value;

            if (_dict0.ContainsKey(key)) _dict0[key] = value;
            else _dict0.Add(key, value);

            this._dict = _dict0;
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
            Text = "Задает значения по ключам и возвращает измененный словарь",
            ViewType = "Modifier")]
    [NodeInput("Словарь", typeof(object))]
    [NodeInput("Список ключей", typeof(string))]
    [NodeInput("Список значений", typeof(object))]
    public class Dictionary_SetValuesAtKeys : INode
    {
        public IDictionary<string, object> _dict = new Dictionary<string, object>();
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _dict = new Dictionary<string, object>();

            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;

            IList keys = (IList)inputs[0].Value;
            IList values = (IList)inputs[1].Value;

            for (int data_counter = 0; data_counter < keys.Count; data_counter++)
            {
                string key = (string)keys[data_counter];
                object value = values[data_counter];

                if (key != null) 
                {
                    if (_dict0.ContainsKey(key)) _dict0[key] = value;
                    else _dict0.Add(key, value);
                }
            }

            this._dict = _dict0;
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
            Text = "Возвращает значение по ключу",
            ViewType = "Data")]
    [NodeInput("Словарь", typeof(object))]
    [NodeInput("Ключ", typeof(string))]
    public class Dictionary_GetValueAtKey : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;
            string key = (string)inputs[1].Value;

            if (_dict0.ContainsKey(key)) return new NodeResult(_dict0[key]);
            else return new NodeResult(null);
        }
    }


    [NVP_Manifest(
            Text = "Возвращает значения по списку ключей",
            ViewType = "Data")]
    [NodeInput("Словарь", typeof(object))]
    [NodeInput("Список ключей", typeof(string))]
    public class Dictionary_GetValuesAtKeys : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;
            IList keys = (IList)inputs[0].Value;

            List<object> values = new List<object>();
            foreach (string key in keys)
            {
                if (_dict0.ContainsKey(key)) values.Add(_dict0[key]);
                else values.Add(null);
            }
            return new NodeResult(values);
        }
    }

    [NVP_Manifest(
            Text = "Возвращает все ключи словаря в виде списка строк",
            ViewType = "Data")]
    [NodeInput("Словарь", typeof(object))]
    public class Dictionary_GetKeys : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;
            return new NodeResult(_dict0.Keys.ToList());
        }
    }

    [NVP_Manifest(
            Text = "Возвращает все значения словаря в виде списка",
            ViewType = "Data")]
    [NodeInput("Словарь", typeof(object))]
    public class Dictionary_GetValues : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;
            return new NodeResult(_dict0.Values.ToList());
        }
    }

    [NVP_Manifest(
            Text = "Возвращает количество сущностей в словаре",
            ViewType = "Data")]
    [NodeInput("Словарь", typeof(object))]
    public class Dictionary_GetCount : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            IDictionary<string, object> _dict0 = (IDictionary<string, object>)inputs[0].Value;
            return new NodeResult(_dict0.Count);
        }
    }





}
