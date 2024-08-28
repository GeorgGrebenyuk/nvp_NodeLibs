using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the plot settings and visual properties of a model space or paper space block
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadLayout 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayout_Constructor : INode 
	{
		public OdaX.IAcadLayout _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLayout;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayout_ConstructorCast : INode 
	{
		public OdaX.IAcadLayout _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLayout;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the block of a layout.", 
		ViewType = "Data")]
	[NodeInput("AcadLayout", typeof(object))]

	///<summary>
	///Returns the block of a layout.
	///</summary>
	public class Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Block);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the order of the specified layout.", 
		ViewType = "Data")]
	[NodeInput("AcadLayout", typeof(object))]

	///<summary>
	///Specifies or returns the order of the specified layout.
	///</summary>
	public class TabOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TabOrder);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the order of the specified layout.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayout", typeof(object))]
	[NodeInput("pOrder", typeof(System.Object))]

	///<summary>
	///Specifies or returns the order of the specified layout.
	///</summary>
	public class Set_TabOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TabOrder = inputs[1].Value;
			return null;
		}
	}
}
