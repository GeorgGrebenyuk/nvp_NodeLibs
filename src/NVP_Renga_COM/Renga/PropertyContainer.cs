using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Renga.Property;

///<summary>
///
///</summary>
namespace Renga.PropertyContainer 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertyContainer_Constructor : INode 
	{
		public Renga.IPropertyContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPropertyContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertyContainer_ConstructorCast : INode 
	{
		public Renga.IPropertyContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPropertyContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]
	[NodeInput("propertyId", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ContainsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContainsS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PropertyContainer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIds);

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все свойства в виде Renga.Property",
        ViewType = "Data")]
    [NodeInput("PropertyContainer", typeof(object))]

    public class GetAll_Properties : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IPropertyContainer;
			var guids = _input0.GetIds();
            List<Property_Constructor> items = new List<Property_Constructor>();
            for (int item_counter = 0; item_counter < guids.Count; item_counter++)
            {
				Guid id = guids.Get(item_counter);
				Property_Constructor item = new Property_Constructor();
				item._i = _input0.Get(id);
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }

    [NVP_Manifest(
        Text = "Возвращает все свойства в виде словаря",
        ViewType = "Data")]
    [NodeInput("PropertyContainer", typeof(object))]

    public class GetAll_Properties2 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IPropertyContainer;
            var guids = _input0.GetIds();
            Dictionary<string, object> properties = new Dictionary<string, object>();

            for (int item_counter = 0; item_counter < guids.Count; item_counter++)
            {
                Guid id = guids.Get(item_counter);
				var property = _input0.Get(id);
				object prop_value = null;
				switch (property.Type)
				{
                    case PropertyType.PropertyType_Angle:
                        prop_value = property.GetAngleValue(AngleUnit.AngleUnit_Degrees); break;
					case PropertyType.PropertyType_Area:
                        prop_value = property.GetAreaValue(AreaUnit.AreaUnit_Meters2); break;
                    case PropertyType.PropertyType_Boolean:
                        prop_value = property.GetBooleanValue(); break;
                    case PropertyType.PropertyType_Double:
                        prop_value = property.GetDoubleValue(); break;
                    case PropertyType.PropertyType_Enumeration:
                        prop_value = property.GetEnumerationValue(); break;
                    case PropertyType.PropertyType_Integer:
                        prop_value = property.GetIntegerValue(); break;
                    case PropertyType.PropertyType_Length:
                        prop_value = property.GetLengthValue(LengthUnit.LengthUnit_Meters); break;
                    case PropertyType.PropertyType_Logical:
                        prop_value = property.GetLogicalValue(); break;
                    case PropertyType.PropertyType_Mass:
                        prop_value = property.GetMassValue(MassUnit.MassUnit_Kilograms); break;
                    case PropertyType.PropertyType_String:
                        prop_value = property.GetStringValue(); break;
                    case PropertyType.PropertyType_Volume:
                        prop_value = property.GetVolumeValue(VolumeUnit.VolumeUnit_Meters3); break;                 
                }

				if (!properties.ContainsKey(property.Name)) properties.Add(property.Name, prop_value);
				else properties[property.Name] = prop_value;
            }
            return new NodeResult(properties);

        }
    }
}
