using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using System.Collections;
using System.Linq;

///<summary>
/// Вспомогательные ноды
///</summary>
namespace NVP_Renga_COM._Renga.Utilities
{
    //public class BaseI_Renga
    //{
    //    public dynamic _i;
    //    public BaseI_Renga(dynamic i) { _i = i; }
    //}
    public class Utils
    {
        
        public static object GetPropertyValue(Renga.IProperty _property)
        {
            object prop_value = null;
            switch (_property.Type)
            {
                case Renga.PropertyType.PropertyType_Angle:
                    prop_value = _property.GetAngleValue(Renga.AngleUnit.AngleUnit_Degrees); break;
                case Renga.PropertyType.PropertyType_Area:
                    prop_value = _property.GetAreaValue(Renga.AreaUnit.AreaUnit_Meters2); break;
                case Renga.PropertyType.PropertyType_Boolean:
                    prop_value = _property.GetBooleanValue(); break;
                case Renga.PropertyType.PropertyType_Double:
                    prop_value = _property.GetDoubleValue(); break;
                case Renga.PropertyType.PropertyType_Enumeration:
                    prop_value = _property.GetEnumerationValue(); break;
                case Renga.PropertyType.PropertyType_Integer:
                    prop_value = _property.GetIntegerValue(); break;
                case Renga.PropertyType.PropertyType_Length:
                    prop_value = _property.GetLengthValue(Renga.LengthUnit.LengthUnit_Meters); break;
                case Renga.PropertyType.PropertyType_Logical:
                    prop_value = _property.GetLogicalValue(); break;
                case Renga.PropertyType.PropertyType_Mass:
                    prop_value = _property.GetMassValue(Renga.MassUnit.MassUnit_Kilograms); break;
                case Renga.PropertyType.PropertyType_String:
                    prop_value = _property.GetStringValue(); break;
                case Renga.PropertyType.PropertyType_Volume:
                    prop_value = _property.GetVolumeValue(Renga.VolumeUnit.VolumeUnit_Meters3); break;
            }
            return prop_value;
        }
        public static void SetPropertyValue(Renga.IProperty _property, object _value)
        {
            switch (_property.Type)
            {
                case Renga.PropertyType.PropertyType_Angle:
                    _property.SetAngleValue((double)_value, Renga.AngleUnit.AngleUnit_Degrees); break;
                case Renga.PropertyType.PropertyType_Area:
                    _property.SetAreaValue((double)_value, Renga.AreaUnit.AreaUnit_Meters2); break;
                case Renga.PropertyType.PropertyType_Boolean:
                    _property.SetBooleanValue((bool)_value); break;
                case Renga.PropertyType.PropertyType_Double:
                    _property.SetDoubleValue((double)_value); break;
                case Renga.PropertyType.PropertyType_Enumeration:
                    _property.SetEnumerationValue((string)_value); break;
                case Renga.PropertyType.PropertyType_Integer:
                    _property.SetIntegerValue((int)_value); break;
                case Renga.PropertyType.PropertyType_Length:
                    _property.SetLengthValue((double)_value, Renga.LengthUnit.LengthUnit_Meters); break;
                case Renga.PropertyType.PropertyType_Logical:
                    {
                        if ((bool)_value == true) _property.SetLogicalValue(Renga.Logical.Logical_True);
                        else if ((bool)_value == false) _property.SetLogicalValue(Renga.Logical.Logical_False);
                        else _property.SetLogicalValue(Renga.Logical.Logical_Indeterminate);
                        break;
                    }
                case Renga.PropertyType.PropertyType_Mass:
                    _property.SetMassValue((double)_value, Renga.MassUnit.MassUnit_Kilograms); break;
                case Renga.PropertyType.PropertyType_String:
                    _property.SetStringValue((string)_value); break;
                case Renga.PropertyType.PropertyType_Volume:
                    _property.SetVolumeValue((double)_value, Renga.VolumeUnit.VolumeUnit_Meters3); break;
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
                Renga.IProperty property = prop_defs.Get(id);
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
                Renga.IProperty property = prop_defs.Get(id);
                if (_prop_names.Contains(property.Name))
                {
                    int prop_index = _prop_names.IndexOf(property.Name);
                    object prop_value = _prop_values[prop_index];
                    Utils.SetPropertyValue(property, prop_value);

                }
            }
        }

        public static List<Renga.IModelObject> GetObjectsFromModelByTypes(Renga.IModel _model, Guid[] _ids)
        {
            var model_collection = _model.GetObjects();

            List<Renga.IModelObject> objects = new List<Renga.IModelObject>();

            for (int i = 0; i < model_collection.Count; i++)
            {
                var single_object = model_collection.GetByIndex(i);

                foreach (var id in _ids)
                {
                    if (single_object.ObjectType.Equals(id))
                    {
                        objects.Add(single_object);
                    }
                }
            }
            return objects;
        }
        public static Dictionary<string, List<Renga.IModelObject>> GetObjectsOnLevelsByTypes(Renga.IModel _model, Guid[] _ids)
        {
            var Levels = _Renga.Utilities.Utils.GetObjectsFromModelByTypes(_model, new Guid[] { _Renga.ObjectTypes.RengaObjectTypes.Level });
            Dictionary<int, Renga.ILevel> Level2Name = new Dictionary<int, Renga.ILevel>();
            foreach (var level in Levels)
            {
                Level2Name.Add(level.Id, level.GetInterfaceByName("ILevel"));
            }
            Dictionary<string, List<Renga.IModelObject>> objects = new Dictionary<string, List<Renga.IModelObject>>();
            var model_collection = _model.GetObjects();
            for (int i = 0; i < model_collection.Count; i++)
            {
                var single_object = model_collection.GetByIndex(i);

                foreach (var id in _ids)
                {
                    if (single_object.ObjectType.Equals(id))
                    {
                        Renga.ILevelObject single_object_in_Level = single_object.GetInterfaceByName("ILevelObject");
                        if (single_object_in_Level != null)
                        {
                            //BaseI_Renga inst = new BaseI_Renga(single_object);

                            var level = Level2Name[single_object_in_Level.LevelId];
                            if (!objects.ContainsKey(level.LevelName))
                            {

                                //List<BaseI_Renga> objects_one = new List<BaseI_Renga>() { inst };
                                List<Renga.IModelObject> objects_one = new List<Renga.IModelObject> { single_object };
                                objects.Add(level.LevelName, objects_one);
                            }
                            else objects[level.LevelName].Add(single_object); //inst
                        }
                    }
                }
            }
            return objects;
        }
        public static void CreateProperties(Renga.IProject _project, List<string> _names, List<int> _types, List<object> _guids, List<List<object>> _to_types)
        {
            Renga.IPropertyManager renga_props_manager = _project.PropertyManager;
            for (int prop_counter = 0; prop_counter < _names.Count; prop_counter++)
            {
                string prop_name = _names[prop_counter];
                Renga.PropertyType prop_type = (Renga.PropertyType)_types[prop_counter];
                List<object> prop_to_types = _to_types[prop_counter];
                Guid guid = Guid.NewGuid();
                if (_guids != null)
                {
                    var guid_raw = _guids[prop_counter];
                    if (guid_raw.GetType() == typeof(Guid)) guid = (Guid)guid_raw;
                    else Guid.TryParse((string)guid_raw, out guid);
                }

                if (!renga_props_manager.IsPropertyRegistered(guid))
                {
                    var prop_def = renga_props_manager.CreatePropertyDescription(prop_name, prop_type);
                    renga_props_manager.RegisterProperty2(guid, prop_def);
                    foreach (var obj_type in prop_to_types)
                    {
                        renga_props_manager.AssignPropertyToType(guid, (Guid)obj_type);
                    }
                }
                else
                {
                    string err = $"Свойство Name = {prop_name}; guid = {guid} уже существует";
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

    [NVP_Manifest(
        Text = "Создает определения свойств",
        ViewType = "Modifier")]
    [NodeInput("Renga.Project", typeof(object))]
    [NodeInput("Список имен свойств", typeof(object))]
    [NodeInput("Список enum_PropertyType", typeof(object))]
    [NodeInput("Список идентификаторов", typeof(object))]
    [NodeInput("Список списков ObjectTypes", typeof(object))]
    public class CreateProperties : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic renga_project_raw = inputs[0].Value;
            Renga.IProject proj = renga_project_raw._i as Renga.IProject;

            IList input_1_prop_Names = (IList)inputs[1].Value;
            IList input_2_prop_Types = (IList)inputs[2].Value;
            IList input_3_prop_Ids = (IList)inputs[3].Value;
            IList input_4_prop_Names = (IList)inputs[4].Value;

            List<string> prop_Names = input_1_prop_Names.Cast<string>().ToList();
            List<int> prop_Types = input_2_prop_Types.Cast<int>().ToList();
            List<object> prop_Ids = input_3_prop_Ids.Cast<object>().ToList();
            List<List<object>> prop_ToTypes = input_4_prop_Names.Cast<List<object>>().ToList();

            Utils.CreateProperties(proj, prop_Names, prop_Types, prop_Ids, prop_ToTypes);

            return new NodeResult(null);
        }
    }
}
