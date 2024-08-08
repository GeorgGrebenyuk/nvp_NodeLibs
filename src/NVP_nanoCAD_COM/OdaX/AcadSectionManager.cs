using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for controls which property is constrained when editing other property values
///</summary>
namespace OdaX.AcadSectionManager 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionManager_Constructor : INode 
	{
		public OdaX.IAcadSectionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionManager_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in the collection of sections.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the collection of sections.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of items in the collection of sections.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]

	///<summary>
	///Returns the number of items in the collection of sections.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "Returns the current live section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]

	///<summary>
	///Returns the current live section.
	///</summary>
	public class GetLiveSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLiveSection);

		}
	}


	[NVP_Manifest(
		Text = "Returns a unique section name.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionManager", typeof(object))]
	[NodeInput("pBaseName", typeof(System.String))]

	///<summary>
	///Returns a unique section name.
	///</summary>
	public class GetUniqueSectionName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUniqueSectionName(inputs[1].Value));

		}
	}
}
