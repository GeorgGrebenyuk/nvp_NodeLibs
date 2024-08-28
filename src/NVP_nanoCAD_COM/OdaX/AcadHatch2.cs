using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an area fill consisting of a pattern of lines
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadHatch2 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch2_Constructor : INode 
	{
		public OdaX.IAcadHatch2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHatch2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHatch2_ConstructorCast : INode 
	{
		public OdaX.IAcadHatch2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHatch2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the hatch background color.", 
		ViewType = "Data")]
	[NodeInput("AcadHatch2", typeof(object))]

	///<summary>
	///Returns the hatch background color.
	///</summary>
	public class BackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundColor);

		}
	}


	[NVP_Manifest(
		Text = "Returns the hatch background color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHatch2", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Returns the hatch background color.
	///</summary>
	public class Set_BackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundColor = inputs[1].Value;
			return null;
		}
	}
}
