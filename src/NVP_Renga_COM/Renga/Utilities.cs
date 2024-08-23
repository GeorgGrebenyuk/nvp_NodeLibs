using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using System.Collections;

///<summary>
/// Вспомогательные ноды
///</summary>
namespace Renga.Utilities
{
    public class Utils
    {
        public static object GetPropertyValue(Renga.IProperty _property)
        {
            object prop_value = null;
            switch (_property.Type)
            {
                case PropertyType.PropertyType_Angle:
                    prop_value = _property.GetAngleValue(AngleUnit.AngleUnit_Degrees); break;
                case PropertyType.PropertyType_Area:
                    prop_value = _property.GetAreaValue(AreaUnit.AreaUnit_Meters2); break;
                case PropertyType.PropertyType_Boolean:
                    prop_value = _property.GetBooleanValue(); break;
                case PropertyType.PropertyType_Double:
                    prop_value = _property.GetDoubleValue(); break;
                case PropertyType.PropertyType_Enumeration:
                    prop_value = _property.GetEnumerationValue(); break;
                case PropertyType.PropertyType_Integer:
                    prop_value = _property.GetIntegerValue(); break;
                case PropertyType.PropertyType_Length:
                    prop_value = _property.GetLengthValue(LengthUnit.LengthUnit_Meters); break;
                case PropertyType.PropertyType_Logical:
                    prop_value = _property.GetLogicalValue(); break;
                case PropertyType.PropertyType_Mass:
                    prop_value = _property.GetMassValue(MassUnit.MassUnit_Kilograms); break;
                case PropertyType.PropertyType_String:
                    prop_value = _property.GetStringValue(); break;
                case PropertyType.PropertyType_Volume:
                    prop_value = _property.GetVolumeValue(VolumeUnit.VolumeUnit_Meters3); break;
            }
            return prop_value;
        }
        public static void SetPropertyValue(Renga.IProperty _property, object _value)
        {
            switch (_property.Type)
            {
                case PropertyType.PropertyType_Angle:
                    _property.SetAngleValue((double)_value, AngleUnit.AngleUnit_Degrees); break;
                case PropertyType.PropertyType_Area:
                    _property.SetAreaValue((double)_value, AreaUnit.AreaUnit_Meters2); break;
                case PropertyType.PropertyType_Boolean:
                    _property.SetBooleanValue((bool)_value); break;
                case PropertyType.PropertyType_Double:
                    _property.SetDoubleValue((double)_value); break;
                case PropertyType.PropertyType_Enumeration:
                    _property.SetEnumerationValue((string)_value); break;
                case PropertyType.PropertyType_Integer:
                    _property.SetIntegerValue((int)_value); break;
                case PropertyType.PropertyType_Length:
                    _property.SetLengthValue((double)_value, LengthUnit.LengthUnit_Meters); break;
                case PropertyType.PropertyType_Logical:
                    {
                        if ((bool)_value == true) _property.SetLogicalValue(Logical.Logical_True);
                        else if ((bool)_value == false) _property.SetLogicalValue(Logical.Logical_False);
                        else _property.SetLogicalValue(Logical.Logical_Indeterminate);
                        break;
                    }
                case PropertyType.PropertyType_Mass:
                    _property.SetMassValue((double)_value, MassUnit.MassUnit_Kilograms); break;
                case PropertyType.PropertyType_String:
                    _property.SetStringValue((string)_value); break;
                case PropertyType.PropertyType_Volume:
                    _property.SetVolumeValue((double)_value, VolumeUnit.VolumeUnit_Meters3); break;
            }

            //object prop_value = Utils.GetPropertyValue(_property);
        }
        public static void SetPropertiesToObject(Renga.IModelObject _object, IList _prop_ids, IList _prop_values)
        {
            var prop_defs = _object.GetProperties();
            var guids = prop_defs.GetIds();

            List<Guid> _prop_ids2 = new List<Guid>();
            foreach (string guid_str in _prop_ids)
            {
                Guid id = Guid.Parse(guid_str);
                _prop_ids2.Add(id);
            }

            for (int item_counter = 0; item_counter < guids.Count; item_counter++)
            {
                Guid id = guids.Get(item_counter);
                IProperty property = prop_defs.Get(id);
                if (_prop_ids2.Contains(id))
                {
                    int prop_index = _prop_ids.IndexOf(property.IdS);
                    object prop_value = _prop_values[prop_index];
                    Utils.SetPropertyValue(property, prop_value);

                }
            }
        }

        public static void SetPropertiesToObject2(Renga.IModelObject _object, IList _prop_names, IList _prop_values)
        {
            var prop_defs = _object.GetProperties();
            var guids = prop_defs.GetIds();

            for (int item_counter = 0; item_counter < guids.Count; item_counter++)
            {
                Guid id = guids.Get(item_counter);
                IProperty property = prop_defs.Get(id);
                if (_prop_names.Contains(property.Name))
                {
                    int prop_index = _prop_names.IndexOf(property.Name);
                    object prop_value = _prop_values[prop_index];
                    Utils.SetPropertyValue(property, prop_value);

                }
            }
        }
    }

    [NVP_Manifest(
        Text = "Задает значения одному свойству для одного объекта. Если IsNames = true, то Свойство рассматривается как имя, если false - то как строковый идентификатор (guid)",
        ViewType = "Modifier")]
    [NodeInput("Renga.Project", typeof(object))]
    [NodeInput("ModelObject", typeof(object))]
    [NodeInput("Свойство", typeof(object))]
    [NodeInput("Значение свойства", typeof(object))]
    [NodeInput("IsNames", typeof(object))]
    public class SetPropertyToObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic renga_project_raw = inputs[0].Value;
            var _input0 = ((dynamic)inputs[1].Value)._i as Renga.IModelObject;
            string prop_name = (string)inputs[2].Value;
            object prop_value = inputs[3].Value;
            bool prop_mode = (bool)inputs[4].Value;

            Renga.IProject proj = renga_project_raw._i as Renga.IProject;
            var oper = proj.CreateOperation();
            oper.Start();

            List<string> prop_names = new List<string> { prop_name };
            List<object> prop_values = new List<object> { prop_value };

            if (prop_mode) Utils.SetPropertiesToObject2(_input0, prop_names, prop_values);
            else Utils.SetPropertiesToObject(_input0, prop_names, prop_values);

            oper.Apply();
            return new NodeResult(null);

        }
    }

    [NVP_Manifest(
        Text = "Задает значения группе свойств для одного объекта. Если IsNames = true, то СписокСвойств рассматривается как имена, если false - то как строковые идентификаторы (guid)",
        ViewType = "Modifier")]
    [NodeInput("Renga.Project", typeof(object))]
    [NodeInput("ModelObject", typeof(object))]
    [NodeInput("Список свойств", typeof(object))]
    [NodeInput("Список значений свойств", typeof(object))]
    [NodeInput("IsNames", typeof(object))]
    public class SetPropertiesToObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic renga_project_raw = inputs[0].Value;
            var _input0 = ((dynamic)inputs[1].Value)._i as Renga.IModelObject;
            IList prop_names = (IList)inputs[2].Value;
            IList prop_values = (IList)inputs[3].Value;
            bool prop_mode = (bool)inputs[4].Value;

            Renga.IProject proj = renga_project_raw._i as Renga.IProject;
            var oper = proj.CreateOperation();
            oper.Start();

            if (prop_mode) Utils.SetPropertiesToObject2(_input0, prop_names, prop_values);
            else Utils.SetPropertiesToObject(_input0, prop_names, prop_values);

            oper.Apply();
            return new NodeResult(null);

        }
    }

    [NVP_Manifest(
        Text = "Задает значения свойству для набора объектов. Если IsNames = true, то Свойство рассматривается как имя, если false - то как строковый идентификатор (guid)",
        ViewType = "Modifier")]
    [NodeInput("Renga.Project", typeof(object))]
    [NodeInput("Список ModelObject", typeof(object))]
    [NodeInput("Список наименований свойств", typeof(object))]
    [NodeInput("Список значений свойств", typeof(object))]
    [NodeInput("IsNames", typeof(object))]
    public class SetPropertiesToObjects : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic renga_project_raw = inputs[0].Value;
            IList objects_raw = (IList)inputs[1].Value;
            IList prop_names_raw = (IList)inputs[2].Value;
            IList prop_values_raw = (IList)inputs[3].Value;
            bool prop_mode = (bool)inputs[4].Value;


            Renga.IProject proj = renga_project_raw._i as Renga.IProject;
            var oper = proj.CreateOperation();
            oper.Start();

            for (int i = 0; i < objects_raw.Count; i++)
            {
                dynamic obj_raw = objects_raw[i];
                var obj = obj_raw._i as Renga.IModelObject;

                IList prop_names = (IList)prop_names_raw[i];
                IList prop_values = (IList)prop_values_raw[i];

                if (prop_mode) Utils.SetPropertiesToObject2(obj, prop_names, prop_values);
                else Utils.SetPropertiesToObject(obj, prop_names, prop_values);
            }
            oper.Apply();
            return new NodeResult(null);
        }
    }

    [NVP_Manifest(
        Text = "Задает значения группе свойств для набора объектов. Если IsNames = true, то СписокСвойств рассматривается как имена, если false - то как строковые идентификаторы",
        ViewType = "Modifier")]
    [NodeInput("Renga.Project", typeof(object))]
    [NodeInput("Список ModelObject", typeof(object))]
    [NodeInput("Свойство", typeof(object))]
    [NodeInput("Значение свойства", typeof(object))]
    [NodeInput("IsNames", typeof(object))]
    public class SetPropertyToObjects : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic renga_project_raw = inputs[0].Value;
            IList objects_raw = (IList)inputs[1].Value;

            string prop_name = (string)inputs[2].Value;
            object prop_value = inputs[3].Value;
            List<string> prop_names = new List<string> { prop_name };
            List<object> prop_values = new List<object> { prop_value };

            bool prop_mode = (bool)inputs[4].Value;

            Renga.IProject proj = renga_project_raw._i as Renga.IProject;
            var oper = proj.CreateOperation();
            oper.Start();

            for (int i = 0; i < objects_raw.Count; i++)
            {
                dynamic obj_raw = objects_raw[i];
                var obj = obj_raw._i as Renga.IModelObject;

                if (prop_mode) Utils.SetPropertiesToObject2(obj, prop_names, prop_values);
                else Utils.SetPropertiesToObject(obj, prop_names, prop_values);
            }
            oper.Apply();
            return new NodeResult(null);
        }
    }
}
