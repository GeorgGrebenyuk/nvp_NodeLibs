using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object containing the properties of a dynamic block
///</summary>
namespace OdaX.AcadDynamicBlockReferenceProperty 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDynamicBlockReferenceProperty_Constructor : INode 
	{
		public OdaX.IAcadDynamicBlockReferenceProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDynamicBlockReferenceProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDynamicBlockReferenceProperty_ConstructorCast : INode 
	{
		public OdaX.IAcadDynamicBlockReferenceProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDynamicBlockReferenceProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the name of the property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the name of the property.
	///</summary>
	public class PropertyName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PropertyName);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether a property is read-only.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns whether a property is read-only.
	///</summary>
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether a property is available in the application user interface.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns whether a property is available in the application user interface.
	///</summary>
	public class Show : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Show);

		}
	}


	[NVP_Manifest(
		Text = "Returns the description of the property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the description of the property.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Text = "Returns the values that are valid for a property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the values that are valid for a property.
	///</summary>
	public class AllowedValues : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowedValues);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the value of a property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Specifies or returns the value of a property.
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the value of a property.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]
	[NodeInput("Value", typeof(System.Object))]

	///<summary>
	///Specifies or returns the value of a property.
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the current units type for the display of a property.", 
		ViewType = "Data")]
	[NodeInput("AcadDynamicBlockReferenceProperty", typeof(object))]

	///<summary>
	///Returns the current units type for the display of a property.
	///</summary>
	public class UnitsType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitsType);

		}
	}
}
