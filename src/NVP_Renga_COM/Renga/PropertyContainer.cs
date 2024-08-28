using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using NVP_Renga_COM._Renga.Property;
using System.Collections;
using NVP_Renga_COM._Renga.Utilities;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.PropertyContainer 
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
				object prop_value = Utils.GetPropertyValue(property);



                if (!properties.ContainsKey(property.Name)) properties.Add(property.Name, prop_value);
				else properties[property.Name] = prop_value;
            }
            return new NodeResult(properties);

        }
    }

    
}
